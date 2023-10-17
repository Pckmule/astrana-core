using System.Security.Cryptography;
using System.Text;

namespace Astrana.Core.Utilities
{
    public static class WindowsKeyStoreUtility
    {
        private const int RsaKeySize = 16384;
        private const string KeyStoreName = "AstranaKeyStore";

        public static void CreateKeys(bool useMachineKeyStore)
        {
            if (!OperatingSystem.IsWindows())
                return;

            var cspParameters = new CspParameters { KeyContainerName = KeyStoreName };

            if (useMachineKeyStore)
                cspParameters.Flags = CspProviderFlags.UseMachineKeyStore;

            new RSACryptoServiceProvider(cspParameters) 
            { 
                PersistKeyInCsp = true,
                KeySize = RsaKeySize
            };

            var containerName = new CspKeyContainerInfo(cspParameters).KeyContainerName;
        }

        public static string Encrypt(string message, string? keyContainerName = null)
        {
            if (!OperatingSystem.IsWindows())
                return string.Empty;

            var cspParameters = new CspParameters
            {
                KeyContainerName = keyContainerName ?? KeyStoreName
            };

            var rsa = new RSACryptoServiceProvider(cspParameters)
            {
                KeySize = RsaKeySize
            };

            return Convert.ToBase64String(rsa.Encrypt(Encoding.UTF8.GetBytes(message), true));
        }

        public static string Decrypt(byte[] encryptedBytes, string? keyStoreContainerName = null)
        {
            if (!OperatingSystem.IsWindows())
                return string.Empty;

            var cspParameters = new CspParameters
            {
                KeyContainerName = keyStoreContainerName ?? KeyStoreName
            };

            return BytesToString(new RSACryptoServiceProvider(cspParameters)
            {
                KeySize = RsaKeySize

            }.Decrypt(encryptedBytes, true));
        }

        public static byte[] StringToBytes(string text)
        {
            return Encoding.UTF8.GetBytes(text);
        }

        public static string BytesToString(byte[] bytes)
        {
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
