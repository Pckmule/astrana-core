IF DB_ID('{DATABASE_NAME}') IS NOT NULL
BEGIN
	USE [{DATABASE_NAME}]

	----------------------------------------------------------------------------------------------------
	-- Create Database Login and User
	----------------------------------------------------------------------------------------------------
	
	-- Database Login
	IF NOT EXISTS (SELECT 1 FROM [master].[sys].[server_principals] WHERE [Name] = '{DATABASE_USERNAME}')
	BEGIN
		
		CREATE LOGIN [{DATABASE_USERNAME}] WITH 
			PASSWORD = N'{DATABASE_PASSWORD}', 
			DEFAULT_DATABASE = [{DATABASE_NAME}], 
			CHECK_POLICY = ON, 
			CHECK_EXPIRATION = OFF;
		
		ALTER SERVER ROLE [dbcreator] 
			ADD MEMBER {DATABASE_USERNAME};
		
	END
	
	-- Database User
	IF NOT EXISTS (SELECT 1 FROM [master].[sys].[database_principals] WHERE [Name] = '{DATABASE_USERNAME}')
	BEGIN
	
		CREATE USER [{DATABASE_USERNAME}] 
			FOR LOGIN [{DATABASE_USERNAME}]
			WITH DEFAULT_SCHEMA=[dbo];
		
		ALTER ROLE [db_owner] 
			ADD MEMBER {DATABASE_USERNAME};
		
	END
	
	----------------------------------------------------------------------------------------------------
	-- Grant Necessary Database User Permissions
	----------------------------------------------------------------------------------------------------
	
	GRANT CONTROL ON DATABASE::[{DATABASE_NAME}] TO [{DATABASE_USERNAME}];
	GRANT CONTROL ON SCHEMA :: [maintenance] TO [{DATABASE_USERNAME}] WITH GRANT OPTION;
	GRANT CONTROL ON SCHEMA :: [config] TO [{DATABASE_USERNAME}] WITH GRANT OPTION;
	GRANT CONTROL ON SCHEMA :: [contact] TO [{DATABASE_USERNAME}] WITH GRANT OPTION;
	GRANT CONTROL ON SCHEMA :: [content] TO [{DATABASE_USERNAME}] WITH GRANT OPTION;
	GRANT CONTROL ON SCHEMA :: [dbo] TO [{DATABASE_USERNAME}] WITH GRANT OPTION;
	GRANT CONTROL ON SCHEMA :: [iam] TO [{DATABASE_USERNAME}] WITH GRANT OPTION;
	GRANT CONTROL ON SCHEMA :: [user] TO [{DATABASE_USERNAME}] WITH GRANT OPTION;
	
	-- GRANT CONTROL ON SCHEMA :: [logs] TO [{DATABASE_USERNAME}] WITH GRANT OPTION;
END