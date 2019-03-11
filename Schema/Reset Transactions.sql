--Reset transactions
BEGIN TRAN
--Ledgers
TRUNCATE TABLE tblSubsidiaryLedger
TRUNCATE TABLE tblGeneralLedger

--Journals
TRUNCATE TABLE tblJournals
TRUNCATE TABLE tblJournalDetails

--JV
TRUNCATE TABLE tblJournalVouchers
TRUNCATE TABLE tblJournalVoucherDetails
--B
TRUNCATE TABLE tblBills
TRUNCATE TABLE tblBillDetails
--BP
TRUNCATE TABLE tblBillsPayment
TRUNCATE TABLE tblBillsPaymentDetails
TRUNCATE TABLE tblBillsPaymentBillDetails
TRUNCATE TABLE tblBillsPaymentPaymentDisbtribution
--SI
TRUNCATE TABLE tblSalesInvoices
TRUNCATE TABLE tblSalesInvoiceDetails
--CR
TRUNCATE TABLE tblCashReceipts
TRUNCATE TABLE tblCashReceiptDetails
TRUNCATE TABLE tblCashReceiptInvoiceDetails
TRUNCATE TABLE tblCashReceiptPaymentDistribution
--COP
TRUNCATE TABLE tblCustomerOverpayments

--Series
UPDATE tblSystemSeries
SET NextNumber = 1

ROLLBACK