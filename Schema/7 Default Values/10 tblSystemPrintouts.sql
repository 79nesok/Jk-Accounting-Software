DECLARE @tmp TABLE(FormCaption VARCHAR(100), Report VARCHAR(100), PrintoutFormName VARCHAR(100))

INSERT INTO @tmp(FormCaption, Report, PrintoutFormName)
VALUES
	--JV
	('Journal Voucher', 'Journal Voucher', 'EJournalPrintoutForm'),

	--B
	('Bill', 'Bill', 'EBillPrintoutForm'),	--done
	('Bill', 'Puchase Journal', 'EJournalPrintoutForm'),

	--BP
	('Bills Payment', 'BIR Form 2307', 'EBIRForm2307PrintoutForm'),--done
	('Bills Payment', 'Cash Disbursement Journal', 'EJournalPrintoutForm'),

	--CV
	('Check Voucher', 'Check Voucher', 'EJournalPrintoutForm'),

	--SI
	('Sales Invoice', 'Sales Invoice', 'ESalesInvoicePrintoutForm'), --done
	('Sales Invoice', 'Sales Journal', 'EJournalPrintoutForm'),

	--CR
	('Cash Receipt', 'Cash Receipt Journal', 'EJournalPrintoutForm'),

	--CRV
	('Cash Receipt Voucher', 'Cash Receipt Voucher', 'EJournalPrintoutForm')


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

