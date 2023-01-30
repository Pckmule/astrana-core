namespace Astrana.Core.Domain.Models.Database.Constants
{
    public static class ConnectionStringParts
    {
        public static class PostgreSql
        {
            public const string Host = "Host";
            public const string Port = "Port";
            public const string Database = "Database";
            public const string UserId = "User Id";
            public const string Password = "Password";
        }

        public static class MySql
        {
            public const string Server = "Server";
            public const string Port = "Port";
            public const string Database = "Database";
            public const string Uid = "Uid";
            public const string Password = "Pwd";
        }

        public static class MsSqlServer
        {
            public const string Server = "Server";
            public const string Database = "Database";
            public const string UserId = "User Id";
            public const string Password = "Password";
            public const string Encrypt = "Encrypt";
            public const string TrustServerCertificate = "TrustServerCertificate";
        }
    }
}
