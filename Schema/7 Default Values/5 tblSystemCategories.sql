SET IDENTITY_INSERT tblSystemCategories ON

INSERT INTO tblSystemCategories(Id, Name, [Index])
SELECT 1, 'Maintenance', 0
	UNION ALL
SELECT 2, 'Administration', 1
	UNION ALL
SELECT 3, 'Accounting', 2
	UNION ALL
SELECT 4, 'Report', 3

SET IDENTITY_INSERT tblSystemCategories OFF
GO

