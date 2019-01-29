SET IDENTITY_INSERT tblJournalTypes ON

INSERT INTO tblJournalTypes(Id, Code, Name)
SELECT 1, 'JV', 'Journal Voucher'
	UNION ALL
SELECT 2, 'PV', 'Purchase Voucher'
	UNION ALL
SELECT 3, 'SV', 'Sales Voucher'
	UNION ALL
SELECT 4, 'CRV', 'Cash Receipt Voucher'
	UNION ALL
SELECT 5, 'CDV', 'Cash Disbursement Voucher'

SET IDENTITY_INSERT tblJournalTypes OFF
GO

