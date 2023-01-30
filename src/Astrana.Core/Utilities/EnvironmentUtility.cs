/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Utilities
{
    public static class EnvironmentUtility
    {
        public const string ProductionEnvironmentName = "Production";
        public const string TestingEnvironmentName = "Testing";
        public const string StagingEnvironmentName = "Staging";
        public const string DevelopmentEnvironmentName = "Development";

        public const string TestingEnvironmentShortName = "test";
        public const string StagingEnvironmentShortName = "stg";
        public const string DevelopmentEnvironmentShortName = "dev";

        public static string GetEnvironment()
        {
            return Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? ProductionEnvironmentName;
        }

        public static bool IsProductionEnvironment()
        {
            return string.Equals(GetEnvironment(), ProductionEnvironmentName, StringComparison.CurrentCultureIgnoreCase);
        }

        public static bool IsStagingEnvironment()
        {
            return string.Equals(GetEnvironment(), StagingEnvironmentName, StringComparison.CurrentCultureIgnoreCase);
        }

        public static bool IsTestingEnvironment()
        {
            return string.Equals(GetEnvironment(), TestingEnvironmentName, StringComparison.CurrentCultureIgnoreCase);
        }

        public static bool IsDevelopmentEnvironment()
        {
            return string.Equals(GetEnvironment(), DevelopmentEnvironmentName, StringComparison.CurrentCultureIgnoreCase);
        }

        public static string GetEnvironmentShortName(bool uppercase = false)
        {
            var prefix = string.Empty;

            if (IsDevelopmentEnvironment())
                prefix = DevelopmentEnvironmentShortName;

            else if (IsTestingEnvironment())
                prefix = TestingEnvironmentShortName;

            else if (IsStagingEnvironment())
                prefix = StagingEnvironmentShortName;

            return uppercase ? prefix.ToUpper() : prefix;
        }
    }
}
