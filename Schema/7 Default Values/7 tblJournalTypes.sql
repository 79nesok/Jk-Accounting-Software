SET IDENTITY_INSERT tblJournalTypes ON

INSERT INTO tblJournalTypes(Id, Code, Name)
SELECT 1, 'GJ', 'General Journal'
	UNION ALL
SELECT 2, 'PJ', 'Purchase Journal'
	UNION ALL
SELECT 3, 'SJ', 'Sales Journal'
	UNION ALL
SELECT 4, 'CRJ', 'Cash Receipt Journal'
	UNION ALL
SELECT 5, 'CDJ', 'Cash Disbursement Journal'

SET IDENTITY_INSERT tblJournalTypes OFF
GO

