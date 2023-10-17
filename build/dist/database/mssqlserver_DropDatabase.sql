USE tempdb;

DECLARE @SQL nvarchar(1000);

IF EXISTS (SELECT 1 FROM sys.databases WHERE [name] = N'{DATABASE_NAME}')
BEGIN
    SET @SQL = N'USE [{DATABASE_NAME}];

                 ALTER DATABASE {DATABASE_NAME} SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                 USE [tempdb];

                 DROP DATABASE {DATABASE_NAME};';
    EXEC (@SQL);
END;