SET IDENTITY_INSERT tblSubsidiaryTypes ON

INSERT INTO tblSubsidiaryTypes(Id, Name)
SELECT 1, 'Customers'
	UNION ALL
SELECT 2, 'Suppliers'
	UNION ALL
SELECT 3, 'Employees'
	UNION ALL
SELECT 4, 'Others'

SET IDENTITY_INSERT tblSubsidiaryTypes OFF
GO

