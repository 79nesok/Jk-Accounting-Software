--JV
EXEC uspAddSystemPrintout
	@FormCaption = 'Journal Voucher',
	@Report = 'Journal Voucher',
	@PrintoutFormName = 'EJournalPrintoutForm',
	@Index = 0

--B
EXEC uspAddSystemPrintout
	@FormCaption = 'Bill',
	@Report = 'Bill',
	@PrintoutFormName = 'EBillPrintoutForm',
	@Index = 0
EXEC uspAddSystemPrintout
	@FormCaption = 'Bill',
	@Report = 'Puchase Journal',
	@PrintoutFormName = 'EJournalPrintoutForm',
	@Index = 1

--BP
EXEC uspAddSystemPrintout
	@FormCaption = 'Bills Payment',
	@Report = 'Cash Disbursement Journal',
	@PrintoutFormName = 'EJournalPrintoutForm',
	@Index = 0
EXEC uspAddSystemPrintout
	@FormCaption = 'Bills Payment',
	@Report = 'Check',
	@PrintoutFormName = 'ECheckPrintoutForm',
	@Index = 1
EXEC uspAddSystemPrintout
	@FormCaption = 'Bills Payment',
	@Report = 'BIR Form 2307',
	@PrintoutFormName = 'EBIRForm2307PrintoutForm',
	@Index = 2

--CV
EXEC uspAddSystemPrintout
	@FormCaption = 'Check Voucher',
	@Report = 'Check Voucher',
	@PrintoutFormName = 'EJournalPrintoutForm',
	@Index = 0
EXEC uspAddSystemPrintout
	@FormCaption = 'Check Voucher',
	@Report = 'Check',
	@PrintoutFormName = 'ECheckPrintoutForm',
	@Index = 1

--SI
EXEC uspAddSystemPrintout
	@FormCaption = 'Sales Invoice',
	@Report = 'Sales Invoice',
	@PrintoutFormName = 'ESalesInvoicePrintoutForm',
	@Index = 0
EXEC uspAddSystemPrintout
	@FormCaption = 'Sales Invoice',
	@Report = 'Sales Journal',
	@PrintoutFormName = 'EJournalPrintoutForm',
	@Index = 1

--CR
EXEC uspAddSystemPrintout
	@FormCaption = 'Cash Receipt',
	@Report = 'Cash Receipt Journal',
	@PrintoutFormName = 'EJournalPrintoutForm',
	@Index = 0

--CRV
EXEC uspAddSystemPrintout
	@FormCaption = 'Cash Receipt Voucher',
	@Report = 'Cash Receipt Voucher',
	@PrintoutFormName = 'EJournalPrintoutForm',
	@Index = 0
GO

