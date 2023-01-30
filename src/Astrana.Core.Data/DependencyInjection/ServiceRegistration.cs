/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Configuration.Extensions;
using Astrana.Core.Data.Constants;
using Astrana.Core.Data.Exceptions;
using Astrana.Core.Data.Repositories;
using Astrana.Core.Data.Utilities;
using Astrana.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace Astrana.Core.Data.DependencyInjection
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration? configuration = null)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            var databaseProvider = configuration.GetDatabaseProvider();

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                var connectionString = configuration.GetConnectionString(databaseProvider.ToString());

                switch (databaseProvider)
                {
                    case DatabaseProvider.PostgreSQL:
                        options.UseNpgsql(connectionString, o => { 
                            o.MigrationsAssembly(MigrationsAssemblyNames.PostgreSQL); 
                            o.MigrationsHistoryTable(TableNames.MigrationsHistory, SchemaNames.Maintenance); 
                        });
                        break;

                    case DatabaseProvider.MySQL:
                        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), o => { 
                            o.MigrationsAssembly(MigrationsAssemblyNames.MySQL); 
                            o.MigrationsHistoryTable(TableNames.MigrationsHistory, SchemaNames.Maintenance);
                            o.SchemaBehavior(MySqlSchemaBehavior.Translate, (schema, entity) => $"{schema ?? "dbo"}_{entity}");
                        });
                        break;

                    case DatabaseProvider.MSSqlServer:
                        options.UseSqlServer(connectionString, o => { 
                            o.MigrationsAssembly(MigrationsAssemblyNames.MSSqlServer);
                            o.MigrationsHistoryTable(TableNames.MigrationsHistory, SchemaNames.Maintenance); 
                        });
                        break;

                    default:
                        throw new UnsupportedDatabaseProviderException(databaseProvider.ToString());
                }
            });

            services.AddRepositories();
            services.AddUtilities();

            return services;
        }
    }
}
