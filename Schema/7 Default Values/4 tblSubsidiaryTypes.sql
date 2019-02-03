SET IDENTITY_INSERT tblSubsidiaryTypes ON

INSERT INTO tblSubsidiaryTypes(Id, Name)
SELECT 1, 'Customer'
	UNION ALL
SELECT 2, 'Supplier'
	UNION ALL
SELECT 3, 'Employee'
	UNION ALL
SELECT 4, 'Others'

SET IDENTITY_INSERT tblSubsidiaryTypes OFF
GO

