/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Diagnostics.CodeAnalysis;

namespace Astrana.Core.Configuration.Constants
{
    [ExcludeFromCodeCoverage]
    public static class ApplicationConfigurationKeys
    {
        public const string DatabaseProvider = "DatabaseProvider";

        public const string ConnectionStringsMsSqlServer = "ConnectionStrings:MSSqlServer";
        public const string ConnectionStringsMySql = "ConnectionStrings:MySQL";
        public const string ConnectionStringsPostgreSql = "ConnectionStrings:PostgreSQL";

        public const string SerilogSinkFileName = "File";

        public const string SerilogSinkMsSqlServerName = "MSSqlServer";
        public const string SerilogSinkMsSqlServerArgConnectionString = "connectionString";

        public const string SerilogSinkMySqlName = "MySQL";
        public const string SerilogSinkMySqlArgConnectionString = "connectionString";

        public const string SerilogSinkPostgreSqlName = "PostgreSQL";
        public const string SerilogSinkPostgreSqlArgConnectionString = "connectionString";

        public const string SerilogWriteTo = "Serilog:WriteTo";
        public const string SerilogWriteToName = SerilogWriteTo + ":{0}:Name";
        public const string SerilogWriteToMsSqlServerArgsConnectionString = SerilogWriteTo + ":{0}:Args:" + SerilogSinkMsSqlServerArgConnectionString;
        public const string SerilogWriteToMySqlArgsConnectionString = SerilogWriteTo + ":{0}:Args:" + SerilogSinkMsSqlServerArgConnectionString;
        public const string SerilogWriteToPostgreSqlArgsConnectionString = SerilogWriteTo + ":{0}:Args:" + SerilogSinkMsSqlServerArgConnectionString;

        public const string Authentication = "Authentication";

    }
}
