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
--CRV
TRUNCATE TABLE tblCashReceiptVouchers
TRUNCATE TABLE tblCashReceiptVoucherDetails
TRUNCATE TABLE tblCashReceiptVoucherInvoiceDetails
TRUNCATE TABLE tblCashReceiptVoucherPaymentDistribution
--COP
TRUNCATE TABLE tblCustomerOverpayments

--Series
UPDATE tblSystemSeries
SET NextNumber = 1

ROLLBACK