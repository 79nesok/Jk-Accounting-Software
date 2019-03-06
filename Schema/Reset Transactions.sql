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
--PV
TRUNCATE TABLE tblPurchaseVouchers
TRUNCATE TABLE tblPurchaseVoucherDetails
--CDV
TRUNCATE TABLE tblCashDisbursementVouchers
TRUNCATE TABLE tblCashDisbursementVoucherDetails
TRUNCATE TABLE tblCashDisbursementVoucherBillsDetails
TRUNCATE TABLE tblCashDisbursementVoucherPaymentDistribution
--SV
TRUNCATE TABLE tblSalesVouchers
TRUNCATE TABLE tblSalesVoucherDetails
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