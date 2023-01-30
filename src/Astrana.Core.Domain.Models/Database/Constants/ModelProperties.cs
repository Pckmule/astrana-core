/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Utilities;

namespace Astrana.Core.Domain.Models.Database.Constants
{
    public static class ModelProperties
    {
        public static class ConnectionString
        {
            public static readonly string NameUnique = nameof(ConnectionString).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(ConnectionString).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(ConnectionString)}s".SplitOnUpperCase();

            public const int MinimumHostAddressLength = 1;
            public const int MaximumHostAddressLength = 100;

            public const int MinimumHostAddressPortLength = 1;
            public const int MaximumHostAddressPortLength = 100;

            public const int MinimumDatabaseNameLength = 1;
            public const int MaximumDatabaseNameLength = 100;

            public const int MinimumUsernameLength = 1;
            public const int MaximumUsernameLength = 100;

            public const int MinimumPasswordLength = 1;
            public const int MaximumPasswordLength = 100;
        }

        public static class PostgreSqlConnectionString
        {
            public static readonly string NameUnique = nameof(PostgreSqlConnectionString).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(PostgreSqlConnectionString).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(PostgreSqlConnectionString)}s".SplitOnUpperCase();

            public const int MinimumHostAddressLength = ConnectionString.MinimumHostAddressLength;
            public const int MaximumHostAddressLength = ConnectionString.MaximumHostAddressLength;

            public const int MinimumHostAddressPortLength = ConnectionString.MinimumHostAddressPortLength;
            public const int MaximumHostAddressPortLength = ConnectionString.MaximumHostAddressPortLength;

            public const int MinimumDatabaseNameLength = ConnectionString.MinimumDatabaseNameLength;
            public const int MaximumDatabaseNameLength = ConnectionString.MaximumDatabaseNameLength;

            public const int MinimumUsernameLength = ConnectionString.MinimumUsernameLength;
            public const int MaximumUsernameLength = ConnectionString.MaximumUsernameLength;

            public const int MinimumPasswordLength = ConnectionString.MinimumPasswordLength;
            public const int MaximumPasswordLength = ConnectionString.MaximumPasswordLength;
        }

        public static class MySqlConnectionString
        {
            public static readonly string NameUnique = nameof(MySqlConnectionString).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(MySqlConnectionString).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(MySqlConnectionString)}s".SplitOnUpperCase();

            public const int MinimumHostAddressLength = ConnectionString.MinimumHostAddressLength;
            public const int MaximumHostAddressLength = ConnectionString.MaximumHostAddressLength;

            public const int MinimumHostAddressPortLength = ConnectionString.MinimumHostAddressPortLength;
            public const int MaximumHostAddressPortLength = ConnectionString.MaximumHostAddressPortLength;

            public const int MinimumDatabaseNameLength = ConnectionString.MinimumDatabaseNameLength;
            public const int MaximumDatabaseNameLength = ConnectionString.MaximumDatabaseNameLength;

            public const int MinimumUsernameLength = ConnectionString.MinimumUsernameLength;
            public const int MaximumUsernameLength = ConnectionString.MaximumUsernameLength;

            public const int MinimumPasswordLength = ConnectionString.MinimumPasswordLength;
            public const int MaximumPasswordLength = ConnectionString.MaximumPasswordLength;
        }

        public static class MsSqlServerConnectionString
        {
            public static readonly string NameUnique = nameof(MsSqlServerConnectionString).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(MsSqlServerConnectionString).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(MsSqlServerConnectionString)}s".SplitOnUpperCase();

            public const int MinimumHostAddressLength = ConnectionString.MinimumHostAddressLength;
            public const int MaximumHostAddressLength = ConnectionString.MaximumHostAddressLength;

            public const int MinimumHostAddressPortLength = ConnectionString.MinimumHostAddressPortLength;
            public const int MaximumHostAddressPortLength = ConnectionString.MaximumHostAddressPortLength;

            public const int MinimumDatabaseNameLength = ConnectionString.MinimumDatabaseNameLength;
            public const int MaximumDatabaseNameLength = ConnectionString.MaximumDatabaseNameLength;

            public const int MinimumUsernameLength = ConnectionString.MinimumUsernameLength;
            public const int MaximumUsernameLength = ConnectionString.MaximumUsernameLength;

            public const int MinimumPasswordLength = ConnectionString.MinimumPasswordLength;
            public const int MaximumPasswordLength = ConnectionString.MaximumPasswordLength;
        }

        public static class DatabaseConfiguration
        {
            public static readonly string NameUnique = nameof(DatabaseConfiguration).SplitOnUpperCase();
            public static readonly string NameSingularForm = nameof(DatabaseConfiguration).SplitOnUpperCase();
            public static readonly string NamePluralForm = $"{nameof(DatabaseConfiguration)}s".SplitOnUpperCase();
        }

    }
}
