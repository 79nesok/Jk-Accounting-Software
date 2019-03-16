TRUNCATE TABLE tblSystemLogTableLinks

DECLARE @tmp TABLE(Id INT IDENTITY,
	Caption VARCHAR(100), ChildTableName VARCHAR(100),
	TableId INT, ChildTableId INT PRIMARY KEY(Id))

INSERT INTO @tmp(Caption, ChildTableName)
VALUES
	--JV
	('Journal Vouchers', 'tblJournalVoucherDetails'),

	--B
	('Bills', 'tblBillDetails'),

	--BP
	('Bills Payment', 'tblBillsPaymentDetails'),
	('Bills Payment', 'tblBillsPaymentBillDetails'),

	--CV
	('Check Vouchers', 'tblBillsPaymentAccountDetails'),

	--SI
	('Sales Invoices', 'tblSalesInvoiceDetails'),

	--CR
	('Cash Receipts', 'tblCashReceiptDetails'),
	('Cash Receipts', 'tblCashReceiptInvoiceDetails'),

	--CRV
	('Cash Receipts Voucher', 'tblCashReceiptAccountDetails')

UPDATE tmp
SET tmp.TableId = t.Id,
	tmp.ChildTableId = ct.Id
FROM @tmp tmp
	INNER JOIN tblSystemLogTableConfig t ON t.Caption = tmp.Caption
	INNER JOIN tblSystemLogTableConfig ct ON ct.TableName = tmp.ChildTableName

INSERT INTO tblSystemLogTableLinks(TableId, ChildTableId)
SELECT TableId, ChildTableId
FROM @tmp
WHERE TableId IS NOT NULL
GO

