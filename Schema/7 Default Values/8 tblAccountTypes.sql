SET IDENTITY_INSERT tblAccountTypes ON

INSERT INTO tblAccountTypes(Id, Code, Name)
SELECT 1, 'Asset', 'Asset'
	UNION ALL
SELECT 2, 'Liability', 'Liability'
	UNION ALL
SELECT 3, 'Equity', 'Equity'
	UNION ALL
SELECT 4, 'Income', 'Income'
	UNION ALL
SELECT 5, 'Expense', 'Expense'

SET IDENTITY_INSERT tblAccountTypes OFF
GO

