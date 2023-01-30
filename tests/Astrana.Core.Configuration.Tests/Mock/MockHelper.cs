using Astrana.Core.Enums;
using Microsoft.Extensions.Configuration;

namespace Astrana.Core.Configuration.Tests.Mock
{
    public static class MockHelper
    {
        public static IConfiguration MockApplicationConfiguration(string configurationFileName = "appsettings.json", DatabaseProvider databaseProvider = DatabaseProvider.MSSqlServer)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(configurationFileName, optional: false, reloadOnChange: false);
            
            return builder.Build() as IConfiguration;
        }
    }
}