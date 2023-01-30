/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Attributes;
using Astrana.Core.Localization.Attributes;
using System.ComponentModel;

namespace Astrana.Core.Enums
{
    [Description("Database Provider")]
    [TranslationCode("database_provider")]
    public enum DatabaseProvider
    {
        [Description("Default")]
        [TranslationCode("default")]
        Default,

        [Description("PostgreSQL")]
        [TranslationCode("database_provider_name_postgresql")]
        [IconAddress("images/logos/databases/postgresql.png")]
        PostgreSQL,

        [Description("MySQL")]
        [TranslationCode("database_provider_name_mysql")]
        [IconAddress("images/logos/databases/mysql.png")]
        MySQL,

        [Description("MSSqlServer")]
        [TranslationCode("database_provider_name_mssql")]
        [IconAddress("images/logos/databases/mssql.png")]
        MSSqlServer
    }
}
