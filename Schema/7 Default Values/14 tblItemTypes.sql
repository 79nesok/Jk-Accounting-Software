SET IDENTITY_INSERT tblItemTypes ON

INSERT INTO tblItemTypes(Id, Code, Name, Active)
SELECT 1, 'Goods', 'Goods', 1
	UNION ALL
SELECT 2, 'Service', 'Service', 1

SET IDENTITY_INSERT tblItemTypes OFF
GO

