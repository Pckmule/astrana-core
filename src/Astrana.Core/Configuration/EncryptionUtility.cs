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
        private const string EncryptionKeyVariableName = "PCEK";
        private const string InitializationVectorVariableName = "PCIV";

        public static string EncryptString(string plainText, string? key = null, string? iv = null)
        {
            if(plainText == null)
                throw new ArgumentNullException(nameof(plainText));

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
                var key = Registry.CurrentUser.OpenSubKey(WindowsRegistryKeys.BaseSubKey)?.GetValue(EncryptionKeyVariableName);

                if (key == null)
                    throw new EncryptionKeyNotFoundException("No encryption key was set in the Windows Registry.");

                return key.ToString() ?? "";
            }
            else
            {
                var key = Environment.GetEnvironmentVariable($"{EnvironmentVariableKeys.BuildKey(EncryptionKeyVariableName)}", EnvironmentVariableTarget.User) ?? "";

                if (string.IsNullOrWhiteSpace(key))
                    throw new EncryptionKeyNotFoundException("No encryption key was set in the Environment Variables.");

                return key;
            }
        }

        public static void StoreEncryptionKey()
        {
            if (OperatingSystem.IsWindows())
            {
                var key = Registry.CurrentUser.CreateSubKey(WindowsRegistryKeys.BaseSubKey);

                key.SetValue(EncryptionKeyVariableName, GenerateEncryptionKey(), RegistryValueKind.String);
                key.Close();
            }
            else
            {
                Environment.SetEnvironmentVariable($"{EnvironmentVariableKeys.BuildKey(EncryptionKeyVariableName)}", GenerateEncryptionKey(), EnvironmentVariableTarget.User);
            }
        }

        public static string GenerateEncryptionKey()
        {
            return Convert.ToBase64String(Aes.Create().Key);
        }

        public static string GetInitializationVector()
        {
            if (OperatingSystem.IsWindows())
            {
                var key = Registry.CurrentUser.OpenSubKey(WindowsRegistryKeys.BaseSubKey)?.GetValue(InitializationVectorVariableName);

                if (key == null)
                    throw new InitializationVectorNotFoundException("No initialization vector set in the Windows Registry.");

                return key.ToString() ?? "";
            }
            else
            {
                var key = Environment.GetEnvironmentVariable($"{EnvironmentVariableKeys.BuildKey(InitializationVectorVariableName)}", EnvironmentVariableTarget.User) ?? "";

                if (string.IsNullOrWhiteSpace(key))
                    throw new InitializationVectorNotFoundException("No initialization vector set in the Environment Variables.");

                return key;
            }
        }

        public static void StoreInitializationVector()
        {
            if (OperatingSystem.IsWindows())
            {
                var key = Registry.CurrentUser.CreateSubKey(WindowsRegistryKeys.BaseSubKey);

                key.SetValue(InitializationVectorVariableName, GenerateEncryptionIV(), RegistryValueKind.String);
                key.Close();
            }
            else
            {
                Environment.SetEnvironmentVariable($"{EnvironmentVariableKeys.BuildKey(InitializationVectorVariableName)}", GenerateEncryptionKey(), EnvironmentVariableTarget.User);
            }
        }

        // ReSharper disable once InconsistentNaming
        public static string GenerateEncryptionIV()
        {
            return Convert.ToBase64String(Aes.Create().IV);
        }
    }
}