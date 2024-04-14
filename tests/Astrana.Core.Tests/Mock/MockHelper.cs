/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Enums;
using Microsoft.Extensions.Configuration;

namespace Astrana.Core.Tests.Mock
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