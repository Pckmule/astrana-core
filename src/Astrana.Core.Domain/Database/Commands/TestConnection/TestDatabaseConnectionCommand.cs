/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Domain.Models.Database;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.SystemSetup;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using MySqlConnector;
using Npgsql;
using System.Net.Sockets;

namespace Astrana.Core.Domain.Database.Commands.TestConnection
{
    public class TestDatabaseConnectionCommand : ITestDatabaseConnectionCommand
    {
        private readonly ILogger<TestDatabaseConnectionCommand> _logger;

        public TestDatabaseConnectionCommand(ILogger<TestDatabaseConnectionCommand> logger)
        {
            _logger = logger;
        }

        public async Task<ExecutionResult> ExecuteAsync(TestDatabaseConnectionRequest request, Guid actioningUserId)
        {
            if (!request.IsValid)
                return new ExecutionFailResult("Database Connection details are invalid.");
                        
            try
            {
                switch (request.DatabaseProvider)
                {
                    case Enums.DatabaseProvider.PostgreSQL:
                        await using (var conn = new NpgsqlConnection(new PostgreSqlConnectionString(request.DatabaseHost, request.DatabaseHostPort, request.DatabaseName, request.DatabaseUsername, request.DatabasePassword).GetString()))
                        {
                            await conn.OpenAsync();
                            await conn.CloseAsync();

                            return new ExecutionSuccessResult("Database Connection Successful");
                        }

                    case Enums.DatabaseProvider.MySQL:

                        await using (var connection = new MySqlConnection(new MySqlConnectionString(request.DatabaseHost, request.DatabaseHostPort, request.DatabaseName, request.DatabaseUsername, request.DatabasePassword).GetString()))
                        {
                            await connection.OpenAsync();
                            await connection.CloseAsync();

                            return new ExecutionSuccessResult("Database Connection Successful");
                        }

                    case Enums.DatabaseProvider.MSSqlServer:
                    case Enums.DatabaseProvider.Default:

                        await using (var connection = new SqlConnection(new MsSqlServerConnectionString(request.DatabaseHost, request.DatabaseHostPort, request.DatabaseName, request.DatabaseUsername, request.DatabasePassword).GetString()))
                        {
                            await connection.OpenAsync();
                            await connection.CloseAsync();

                            return new ExecutionSuccessResult("Database Connection Successful");
                        }
                }

                return new ExecutionFailResult("Unsupported Database Provider", ErrorCodes.CannotConnect);
            }
            catch (PostgresException ex)
            {
                var errorCode = ErrorCodes.CannotConnect;

                if (ex.SqlState == PostgresErrorCodes.InvalidPassword)
                    errorCode = ErrorCodes.CannotConnect_AuthenticationFailed;

                return new ExecutionFailResult("Database Connection Failed", errorCode);
            }
            catch (MySqlException ex)
            {
                var errorCode = ErrorCodes.CannotConnect;

                if (ex.ErrorCode == MySqlErrorCode.UnableToConnectToHost)
                    errorCode = ErrorCodes.CannotConnect_NetworkError;

                return new ExecutionFailResult("Database Connection Failed", errorCode);
            }
            catch (SqlException ex)
            {
                var errorCode = ErrorCodes.CannotConnect;

                if (ex.Number == 3)
                    errorCode = ErrorCodes.CannotConnect_NetworkError;

                if (ex.Number == 18456)
                    errorCode = ErrorCodes.CannotConnect_AuthenticationFailed;

                return new ExecutionFailResult("Database Connection Failed", errorCode);
            }
            catch (SocketException)
            {
                return new ExecutionFailResult("Database Connection Failed", ErrorCodes.CannotConnect_NetworkError);
            }
            catch (Exception)
            {
                return new ExecutionFailResult("Database Connection Failed", ErrorCodes.CannotConnect);
            }
        }
    }
}
