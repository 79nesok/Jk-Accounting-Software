DECLARE @tmp TABLE(FormCaption VARCHAR(100), Report VARCHAR(100), PrintoutFormName VARCHAR(100))

INSERT INTO @tmp(FormCaption, Report, PrintoutFormName)
VALUES
	('Journal Voucher', 'Journal Voucher', 'EJournalVoucherPrintoutForm'),
	('Sales Voucher', 'Sales Invoice', 'ESalesInvoicePrintoutForm')

INSERT INTO tblSystemPrintouts(FormCaption, Report, PrintoutFormName)
SELECT t.FormCaption, t.Report, t.PrintoutFormName
FROM @tmp t
WHERE NOT EXISTS(
	SELECT *
	FROM tblSystemPrintouts sp
	WHERE sp.FormCaption = t.FormCaption
		AND sp.Report = t.Report
		AND sp.PrintoutFormName = t.PrintoutFormName
)
GO

