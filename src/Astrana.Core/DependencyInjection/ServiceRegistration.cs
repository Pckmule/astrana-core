/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Legal;
using Astrana.Core.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Astrana.Core.DependencyInjection
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services, IConfiguration? configuration = null)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            services.AddScoped<ILegalService, LegalService>();
            services.AddTransient<ILegalService, LegalService>();

            services.AddScoped<ITranslator, Translator>();
            services.AddTransient<ITranslator, Translator>();

            return services;
        }
    }
}
