CREATE ROLE {Database_Username} WITH CREATEDB LOGIN ENCRYPTED PASSWORD '{Database_Password}';

IF NOT EXISTS(SELECT 1 FROM pg_catalog.pg_database WHERE LOWER(datname) = LOWER('{Database_Name}')) THEN

	CREATE DATABASE {Database_Name} WITH OWNER '{Database_Username}' ENCODING 'UTF8';

END IF