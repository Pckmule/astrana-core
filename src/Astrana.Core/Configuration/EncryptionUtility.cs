/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Configuration.Constants;
using Astrana.Core.Configuration.Exceptions;
using Microsoft.Win32;
using System.Security.Cryptography;

namespace Astrana.Core.Configuration
{
    public static class EncryptionUtility
    {
        private const string SettingsFileKeyValueSeparator = ":=";

        private const string EncryptionKeyVariableName = "PCEK";
        private const string InitializationVectorVariableName = "PCIV";

        public static string EncryptString(string plainText, string? key = null, string? iv = null)
        {
            if(plainText == null)
                throw new ArgumentNullException(nameof(plainText));

            if (OperatingSystem.IsWindows())
            {
                //return WindowsKeyStoreUtility.Encrypt(plainText);
            }

            if (string.IsNullOrWhiteSpace(key))
                key = GetEncryptionKey();

            if (string.IsNullOrWhiteSpace(iv))
                iv = GetInitializationVector();

            byte[] array;

            using (var aes = Aes.Create())
            {
                aes.Key = Convert.FromBase64String(key);
                aes.IV = Convert.FromBase64String(iv);

                using var memoryStream = new MemoryStream();
                using var cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(aes.Key, aes.IV), CryptoStreamMode.Write);
                using (var streamWriter = new StreamWriter(cryptoStream))
                {
                    streamWriter.Write(plainText);
                }

                array = memoryStream.ToArray();
            }

            return Convert.ToBase64String(array);
        }

        public static string DecryptString(string cipherText, string? key = null, string? iv = null)
        {
            if (cipherText == null)
                throw new ArgumentNullException(nameof(cipherText));

            if (OperatingSystem.IsWindows())
            {
                //return WindowsKeyStoreUtility.Decrypt(WindowsKeyStoreUtility.StringToBytes(cipherText));
            }

            if (string.IsNullOrWhiteSpace(key))
                key = GetEncryptionKey();

            if (string.IsNullOrWhiteSpace(iv))
                iv = GetInitializationVector();

            using (var aes = Aes.Create())
            {
                aes.Key = Convert.FromBase64String(key);
                aes.IV = Convert.FromBase64String(iv);

                using var memoryStream = new MemoryStream(Convert.FromBase64String(cipherText));
                using var cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(aes.Key, aes.IV), CryptoStreamMode.Read);
                using var streamReader = new StreamReader(cryptoStream);
                return streamReader.ReadToEnd();
            }
        }

        public static string GetEncryptionKey()
        {
            if (OperatingSystem.IsWindows())
            {
                return GetEncryptionKeyOnWindowsOS();
            }

            if (OperatingSystem.IsMacOS())
            {
                return GetEncryptionKeyOnMacOS();
            }

            if (OperatingSystem.IsLinux())
            {
                return GetEncryptionKeyOnLinuxOS();
            }

            return GetEncryptionKeyOnGenericOS();
        }

        private static string GetEncryptionKeyOnWindowsOS()
        {
            if (!OperatingSystem.IsWindows())
                return string.Empty;

            var key = Registry.LocalMachine.OpenSubKey(WindowsRegistryKeys.BaseSubKey)?.GetValue(EncryptionKeyVariableName);

            if (key == null)
                throw new EncryptionKeyNotFoundException("Windows: No encryption key was set in the Windows Registry.");

            return key.ToString() ?? "";
        }

        private static string GetEncryptionKeyOnMacOS()
        {
            if (!OperatingSystem.IsMacOS())
                return string.Empty;

            return GetEncryptionKeyOnGenericOS();
        }

        private static string GetEncryptionKeyOnLinuxOS()
        {
            if (!OperatingSystem.IsLinux())
                return string.Empty;
            
            var key = GetSettingValue(EncryptionKeyVariableName, ReadSettingsFileAsync(GetSecureSettingsFilePath()).Result);

            if (string.IsNullOrWhiteSpace(key))
                throw new EncryptionKeyNotFoundException("Linux: No encryption key was set in the Secure Configuration File.\n " + FileSystemUtility.SystemHomeDirectoryPath);

            return key;
        }

        private static string GetEncryptionKeyOnGenericOS()
        {
            var key = Environment.GetEnvironmentVariable($"{EnvironmentVariableKeys.BuildKey(EncryptionKeyVariableName)}", EnvironmentVariableTarget.User) ?? "";
            
            if (string.IsNullOrWhiteSpace(key))
                throw new EncryptionKeyNotFoundException("No encryption key was set in the Environment Variables.");

            return key;
        }

        public static void StoreEncryptionKey()
        {
            if (OperatingSystem.IsWindows())
            {
                StoreEncryptionKeyOnWindowsOS();
            }
            else if (OperatingSystem.IsMacOS())
            {
                StoreEncryptionKeyOnMacOS();
            }
            else if (OperatingSystem.IsLinux())
            {
                StoreEncryptionKeyOnLinuxOS();
            }
            else
            {
                StoreEncryptionKeyOnGenericOS();
            }
        }

        private static void StoreEncryptionKeyOnWindowsOS()
        {
            if (!OperatingSystem.IsWindows())
                return;

            var key = Registry.LocalMachine.CreateSubKey(WindowsRegistryKeys.BaseSubKey);

            key.SetValue(EncryptionKeyVariableName, GenerateEncryptionKey(), RegistryValueKind.String);
            key.Close();
        }

        private static void StoreEncryptionKeyOnMacOS()
        {
            if (!OperatingSystem.IsMacOS())
                return;

            StoreEncryptionKeyOnGenericOS();
        }

        private static void StoreEncryptionKeyOnLinuxOS()
        {
            if (!OperatingSystem.IsLinux())
                return;

            var settingsFilePath = GetSecureSettingsFilePath();

            var settings = ReadSettingsFileAsync(settingsFilePath).Result;

            UpsertSetting(EncryptionKeyVariableName, GenerateEncryptionKey(), settings);

            SaveSettingsFileAsync(settingsFilePath, settings).RunSynchronously();
        }

        private static void StoreEncryptionKeyOnGenericOS()
        {
            Environment.SetEnvironmentVariable($"{EnvironmentVariableKeys.BuildKey(EncryptionKeyVariableName)}", GenerateEncryptionKey(), EnvironmentVariableTarget.User);
        }

        public static string GenerateEncryptionKey()
        {
            return Convert.ToBase64String(Aes.Create().Key);
        }

        public static string GetInitializationVector()
        {
            if (OperatingSystem.IsWindows())
            {
                return GetInitializationVectorOnWindowsOS();
            }

            if (OperatingSystem.IsMacOS())
            {
                return GetInitializationVectorOnMacOS();
            }

            if (OperatingSystem.IsLinux())
            {
                return GetInitializationVectorOnLinuxOS();
            }

            return GetInitializationVectorOnGenericOS();
        }

        public static string GetInitializationVectorOnWindowsOS()
        {
            if (!OperatingSystem.IsWindows())
                return string.Empty;

            var key = Registry.LocalMachine.OpenSubKey(WindowsRegistryKeys.BaseSubKey)?.GetValue(InitializationVectorVariableName);

            if (key == null)
                throw new InitializationVectorNotFoundException("No initialization vector set in the Windows Registry.");

            return key.ToString() ?? "";
        }

        public static string GetInitializationVectorOnMacOS()
        {
            if (!OperatingSystem.IsMacOS())
                return string.Empty;

            return GetInitializationVectorOnGenericOS();
        }

        public static string GetInitializationVectorOnLinuxOS()
        {
            if (!OperatingSystem.IsLinux())
                return string.Empty;

            var key = GetSettingValue(InitializationVectorVariableName, ReadSettingsFileAsync(GetSecureSettingsFilePath()).Result);

            if (string.IsNullOrWhiteSpace(key))
                throw new EncryptionKeyNotFoundException("Linux: No initialization vector set in the Secure Configuration File.");

            return key;
        }

        public static string GetInitializationVectorOnGenericOS()
        {
            var key = Environment.GetEnvironmentVariable($"{EnvironmentVariableKeys.BuildKey(InitializationVectorVariableName)}", EnvironmentVariableTarget.User) ?? "";

            if (string.IsNullOrWhiteSpace(key))
                throw new InitializationVectorNotFoundException("No initialization vector set in the Environment Variables.");

            return key;
        }

        public static void StoreInitializationVector()
        {
            if (OperatingSystem.IsWindows())
            {
                StoreInitializationVectorOnWindowsOS();
            }
            else if (OperatingSystem.IsMacOS())
            {
                StoreInitializationVectorOnMacOS();
            }
            else if (OperatingSystem.IsLinux())
            {
                StoreInitializationVectorOnLinuxOS();
            }
            else
            {
                StoreInitializationVectorOnGenericOS();
            }
        }

        private static void StoreInitializationVectorOnWindowsOS()
        {
            if (!OperatingSystem.IsWindows())
                return;

            var key = Registry.LocalMachine.CreateSubKey(WindowsRegistryKeys.BaseSubKey);

            key.SetValue(InitializationVectorVariableName, GenerateEncryptionIV(), RegistryValueKind.String);
            key.Close();
        }

        private static void StoreInitializationVectorOnMacOS()
        {
            if (!OperatingSystem.IsMacOS())
                return;

            StoreInitializationVectorOnGenericOS();
        }

        private static void StoreInitializationVectorOnLinuxOS()
        {
            if (!OperatingSystem.IsLinux())
                return;

            var settingsFilePath = GetSecureSettingsFilePath();

            var settings = ReadSettingsFileAsync(settingsFilePath).Result;

            UpsertSetting(InitializationVectorVariableName, GenerateEncryptionKey(), settings);

            SaveSettingsFileAsync(settingsFilePath, settings).RunSynchronously();

            StoreInitializationVectorOnGenericOS();
        }

        private static void StoreInitializationVectorOnGenericOS()
        {
            Environment.SetEnvironmentVariable($"{EnvironmentVariableKeys.BuildKey(InitializationVectorVariableName)}", GenerateEncryptionKey(), EnvironmentVariableTarget.User);
        }

        // ReSharper disable once InconsistentNaming
        public static string GenerateEncryptionIV()
        {
            return Convert.ToBase64String(Aes.Create().IV);
        }

        private static string GetSecureSettingsFilePath()
        {
            var secureSettingsDirectory = FileSystemUtility.GetSecureSettingsDirectoryPath;

            if (!Directory.Exists(secureSettingsDirectory))
                Directory.CreateDirectory(secureSettingsDirectory);

            return Path.Join(secureSettingsDirectory, ".astrana");
        }

        private static async Task<List<string>> ReadSettingsFileAsync(string settingsFilePath)
        {
            if (!File.Exists(settingsFilePath))
                File.CreateText(settingsFilePath);

            return (await File.ReadAllLinesAsync(settingsFilePath)).ToList();
        }

        private static string GetSetting(string settingKey, IEnumerable<string> settings)
        {
            return settings.FirstOrDefault(s => s.StartsWith($"{EnvironmentVariableKeys.BuildKey(settingKey)}{SettingsFileKeyValueSeparator}")) ?? "";
        }

        private static string GetSettingValue(string settingKey, IEnumerable<string> settings)
        {
            var setting = GetSetting(settingKey, settings);

            if (string.IsNullOrEmpty(setting) || setting.IndexOf(SettingsFileKeyValueSeparator, StringComparison.Ordinal) < 0)
                return string.Empty;

            return setting.Split(SettingsFileKeyValueSeparator)[1];
        }

        private static void UpsertSetting(string settingKey, string settingValue, IList<string> settings)
        {
            var settingKeyAndSeparator = $"{EnvironmentVariableKeys.BuildKey(settingKey)}{SettingsFileKeyValueSeparator}";

            if (settings.Any(s => s.StartsWith(settingKeyAndSeparator)))
            {
                for (var i = 0; i < settings.Count; i++)
                {
                    if (settings[i].StartsWith(settingKeyAndSeparator))
                    {
                        settings[i] = $"{settingKeyAndSeparator}{settingValue}";
                    }
                }
            }
            else
            {
                settings.Add($"{settingKeyAndSeparator}{settingValue}");
            }
        }

        private static async Task SaveSettingsFileAsync(string settingsFilePath, IEnumerable<string> settings)
        {
            if (!File.Exists(settingsFilePath))
                File.CreateText(settingsFilePath);
            
            await File.WriteAllLinesAsync(settingsFilePath, settings);
        }

    }
}