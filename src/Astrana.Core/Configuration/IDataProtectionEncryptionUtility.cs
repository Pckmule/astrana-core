namespace Astrana.Core.Configuration
{
    public interface IDataProtectionEncryptionUtility
    {
        string EncryptString(string plainText);

        string DecryptString(string cipherText);
    }
}
