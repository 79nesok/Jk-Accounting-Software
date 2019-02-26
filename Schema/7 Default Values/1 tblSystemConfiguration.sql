IF NOT EXISTS(SELECT * FROM tblSystemConfiguration)
	INSERT INTO tblSystemConfiguration(ProductName, ProductVersion)
	SELECT 'Jk Accounting Software', '1.0.0.0'
GO

