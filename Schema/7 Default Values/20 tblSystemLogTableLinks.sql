TRUNCATE TABLE tblSystemLogTableLinks

DECLARE @tmp TABLE(Id INT IDENTITY,
	TableName VARCHAR(100), ChildTableName VARCHAR(100),
	TableId INT, ChildTableId INT PRIMARY KEY(Id))

INSERT INTO @tmp(TableName, ChildTableName)
VALUES
	--JV
	('tblJournalVouchers', 'tblJournalVoucherDetails'),

	--B
	('tblBills', 'tblBillDetails'),

	--BP
	('tblBillsPayment', 'tblBillsPaymentDetails'),
	('tblBillsPayment', 'tblBillsPaymentBillDetails'),

	--CV
	('tblBillsPayment', 'tblBillsPaymentAccountDetails'),

	--SI
	('tblSalesInvoices', 'tblSalesInvoiceDetails'),

	--CR
	('tblCashReceipts', 'tblCashReceiptDetails'),
	('tblCashReceipts', 'tblCashReceiptInvoiceDetails'),

	--CRV
	('tblCashReceipts', 'tblCashReceiptAccountDetails')

UPDATE tmp
SET tmp.TableId = t.Id,
	tmp.ChildTableId = ct.Id
FROM @tmp tmp
	INNER JOIN tblSystemLogTableConfig t ON t.TableName = tmp.TableName
	INNER JOIN tblSystemLogTableConfig ct ON ct.TableName = tmp.ChildTableName

INSERT INTO tblSystemLogTableLinks(TableId, ChildTableId)
SELECT TableId, ChildTableId
FROM @tmp
WHERE TableId IS NOT NULL
GO

