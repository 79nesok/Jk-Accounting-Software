USE master
GO

IF DB_ID('FreeAccountingSoftware') IS NULL
BEGIN
	CREATE DATABASE [FreeAccountingSoftware]
		ON PRIMARY(NAME = N'FreeAccountingSoftware', FILENAME = N'E:\Projects\Database\2014\FreeAccountingSoftware.mdf')
		LOG ON (NAME = N'FreeAccountingSoftware_log', FILENAME = N'E:\Projects\Database\2014\FreeAccountingSoftware.ldf')
END
GO

ALTER DATABASE [FreeAccountingSoftware] SET COMPATIBILITY_LEVEL = 100
GO
