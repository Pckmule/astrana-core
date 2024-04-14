/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.Configuration
{
    public sealed class DataProtectionEncryptionUtility: IDataProtectionEncryptionUtility
    {
        private readonly IDataProtector _dataProtector;

        public DataProtectionEncryptionUtility(IDataProtectionProvider provider)
        {
            _dataProtector = provider.CreateProtector("Astrana.EncryptionUtility.v1");
        }

        public string EncryptString(string plainText)
        {
            if (plainText == null)
                throw new ArgumentNullException(nameof(plainText));

            var cipherText = _dataProtector.Protect(plainText);
            
            return cipherText;
        }

        public string DecryptString(string cipherText)
        {
            if (cipherText == null)
                throw new ArgumentNullException(nameof(cipherText));

            var plainText = _dataProtector.Unprotect(cipherText);

            return plainText;
        }
    }
    
    public static class DataProtectionEncryptionUtilityExtensions
    {
        public static IServiceCollection AddDataEncryption(this IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));
            
            services.AddSingleton<IDataProtectionEncryptionUtility, DataProtectionEncryptionUtility>();

            return services;
        }
    }
}