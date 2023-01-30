IF DB_ID('{Database_Name}') IS NOT NULL
BEGIN
	USE [{Database_Name}]

	IF NOT EXISTS (SELECT 1 FROM master.sys.server_principals WHERE [Name] = '{Database_Username}')
	BEGIN
		CREATE LOGIN [{Database_Username}] WITH PASSWORD = N'{Database_Password}', DEFAULT_DATABASE = {Database_Name}, CHECK_POLICY = ON, CHECK_EXPIRATION = ON;
		ALTER SERVER ROLE [dbcreator] ADD MEMBER {Database_Username};
	END
	
	IF NOT EXISTS (SELECT 1 FROM master.sys.database_principals WHERE [Name] = '{Database_Username}')
	BEGIN
		CREATE USER [{Database_Username}] FOR LOGIN [{Database_Username}] WITH DEFAULT_SCHEMA=[dbo];
		ALTER ROLE [db_owner] ADD MEMBER {Database_Username};
	END
END