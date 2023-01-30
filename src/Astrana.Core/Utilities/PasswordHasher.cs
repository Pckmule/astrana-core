using System.Security.Cryptography;

namespace Astrana.Core.Utilities
{
    public sealed class PasswordHasher
    {
        private const int SaltSize = 16;
        private const int HashSize = 20;
        private const int HashIterations = 10000;

        private readonly byte[] _salt;
        private readonly byte[] _hash;

        public PasswordHasher(string plainTextPassword, string? salt = null)
        {
            if (string.IsNullOrWhiteSpace(salt))
            {
                _salt = new byte[SaltSize];
                new RNGCryptoServiceProvider().GetBytes(_salt);
            }
            else
            {
                _salt = Convert.FromBase64String(salt);
            }

            _hash = new Rfc2898DeriveBytes(plainTextPassword, _salt, HashIterations).GetBytes(HashSize);
        }

        public PasswordHasher(byte[] hashBytes)
        {
            _salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, _salt, 0, SaltSize);

            _hash = new byte[HashSize];
            Array.Copy(hashBytes, SaltSize, _hash, 0, HashSize);
        }

        public PasswordHasher(byte[] salt, byte[] hash)
        {
            _salt = new byte[SaltSize];
            Array.Copy(salt, 0, _salt, 0, SaltSize);

            _hash = new byte[HashSize];
            Array.Copy(hash, 0, _hash, 0, HashSize);
        }

        public byte[] ToArray()
        {
            var hashBytes = new byte[SaltSize + HashSize];

            Array.Copy(_salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(_hash, 0, hashBytes, SaltSize, HashSize);
            
            return hashBytes;
        }

        public byte[] Salt => (byte[])_salt.Clone();

        public string SaltString => Convert.ToBase64String(Salt);

        public byte[] Hash => (byte[])_hash.Clone();

        public string HashString => Convert.ToBase64String(Hash);

        public bool Verify(string plainTextPassword)
        {
            var test = new Rfc2898DeriveBytes(plainTextPassword, _salt, HashIterations).GetBytes(HashSize);

            for (var i = 0; i < HashSize; i++)
                if (test[i] != _hash[i]) return false;

            return true;
        }
    }
}