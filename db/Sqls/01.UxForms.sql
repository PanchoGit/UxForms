USE master
GO

IF (NOT EXISTS (SELECT 1 FROM master.dbo.sysdatabases WHERE name = 'UxForms' ))
BEGIN
     CREATE DATABASE UxForms
END
GO

USE UxForms
GO

-- UxForms App

IF (NOT EXISTS (SELECT 1 FROM sys.syslogins where name = 'UxFormsApp'))
BEGIN
     CREATE LOGIN UxFormsApp WITH 
            PASSWORD = 'formspawn!01',
            DEFAULT_DATABASE = UxForms, 
            CHECK_EXPIRATION = OFF, 
            CHECK_POLICY = OFF;
END

IF (NOT EXISTS (SELECT 1 FROM UxForms.sys.database_principals where name = 'UxFormsApp' ))
BEGIN
     CREATE USER UxFormsApp FOR LOGIN UxFormsApp WITH DEFAULT_SCHEMA = app;
END

IF NOT EXISTS ( SELECT 1 FROM sys.schemas WHERE name = 'app')
BEGIN
     EXEC('CREATE SCHEMA app');
END

GRANT SELECT ON SCHEMA ::app TO UxFormsApp
GRANT INSERT ON SCHEMA ::app TO UxFormsApp
GRANT UPDATE ON SCHEMA ::app TO UxFormsApp
GRANT DELETE ON SCHEMA ::app TO UxFormsApp
