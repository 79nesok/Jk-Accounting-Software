SET IDENTITY_INSERT tblPaymentTypes ON

INSERT INTO tblPaymentTypes(Id, Code, Name, HasSourceTransaction)
SELECT 1, 'BP', 'Bills Payment', 1
	UNION ALL
SELECT 2, 'CV', 'Check Voucher', 0
	UNION ALL
SELECT 3, 'CR', 'Cash Receipt', 1
	UNION ALL
SELECT 4, 'CRV', 'Cash Receipt Voucher', 0

SET IDENTITY_INSERT tblPaymentTypes OFF
GO

