--MasterForm field questionable since Application is referencing on NewFormName and OpenFormName

--Maintenance
EXEC uspAddSystemSubCategory @Category = 'Maintenance', @Parent = NULL, @Name = 'Alphanumeric Tax Codes', @ListForm = 'EAlphanumericTaxCodesListForm', @MasterForm = NULL, @Index = 0

EXEC uspAddSystemSubCategory @Category = 'Maintenance', @Parent = NULL, @Name = 'Chart of Accounts', @ListForm = NULL, @MasterForm = NULL, @Index = 1
EXEC uspAddSystemSubCategory @Category = 'Maintenance', @Parent = 'Chart of Accounts', @Name = 'Assets', @ListForm = 'EAssetsListForm', @MasterForm = NULL, @Index = 2
EXEC uspAddSystemSubCategory @Category = 'Maintenance', @Parent = 'Chart of Accounts', @Name = 'Liabilities', @ListForm = 'ELiabilitiesListForm', @MasterForm = 'EAccountForm', @Index = 3
EXEC uspAddSystemSubCategory @Category = 'Maintenance', @Parent = 'Chart of Accounts', @Name = 'Equities', @ListForm = 'EEquitiesListForm', @MasterForm = 'EAccountForm', @Index = 4
EXEC uspAddSystemSubCategory @Category = 'Maintenance', @Parent = 'Chart of Accounts', @Name = 'Income', @ListForm = 'EIncomeListForm', @MasterForm = 'EAccountForm', @Index = 5
EXEC uspAddSystemSubCategory @Category = 'Maintenance', @Parent = 'Chart of Accounts', @Name = 'Expenses', @ListForm = 'EExpensesListForm', @MasterForm = 'EAccountForm', @Index = 6

EXEC uspAddSystemSubCategory @Category = 'Maintenance', @Parent = NULL, @Name = 'Items', @ListForm = 'EItemsListForm', @MasterForm = 'EItemForm', @Index = 7

EXEC uspAddSystemSubCategory @Category = 'Maintenance', @Parent = NULL, @Name = 'Payment Methods', @ListForm = 'EPaymentMethodsListForm', @MasterForm = 'EPaymentMethodForm', @Index = 8

EXEC uspAddSystemSubCategory @Category = 'Maintenance', @Parent = NULL, @Name = 'Subsidiaries', @ListForm = NULL, @MasterForm = NULL, @Index = 9
EXEC uspAddSystemSubCategory @Category = 'Maintenance', @Parent = 'Subsidiaries', @Name = 'Customers', @ListForm = 'ECustomersListForm', @MasterForm = 'ESubsidiaryForm', @Index = 10
EXEC uspAddSystemSubCategory @Category = 'Maintenance', @Parent = 'Subsidiaries', @Name = 'Suppliers', @ListForm = 'ESuppliersListForm', @MasterForm = 'ESubsidiaryForm', @Index = 11
EXEC uspAddSystemSubCategory @Category = 'Maintenance', @Parent = 'Subsidiaries', @Name = 'Employees', @ListForm = 'EEmployeesListForm', @MasterForm = 'ESubsidiaryForm', @Index = 12
EXEC uspAddSystemSubCategory @Category = 'Maintenance', @Parent = 'Subsidiaries', @Name = 'Others', @ListForm = 'EOthersListForm', @MasterForm = 'ESubsidiaryForm', @Index = 13

--Administration
EXEC uspAddSystemSubCategory @Category = 'Administration', @Parent = NULL, @Name = 'Company', @ListForm = 'ECompanyForm', @MasterForm = NULL, @Index = 0
EXEC uspAddSystemSubCategory @Category = 'Administration', @Parent = NULL, @Name = 'Security', @ListForm = NULL, @MasterForm = NULL, @Index = 1

--Accounting
EXEC uspAddSystemSubCategory @Category = 'Accounting', @Parent = NULL, @Name = 'Journal Vouchers', @ListForm = 'EJournalVouchersListForm', @MasterForm = 'EJournalVoucherForm', @Index = 0

EXEC uspAddSystemSubCategory @Category = 'Accounting', @Parent = NULL, @Name = 'Supplier', @ListForm = NULL, @MasterForm = NULL, @Index = 1
EXEC uspAddSystemSubCategory @Category = 'Accounting', @Parent = 'Supplier', @Name = 'Bills', @ListForm = 'EBillsListForm', @MasterForm = 'EBillsForm', @Index = 2
EXEC uspAddSystemSubCategory @Category = 'Accounting', @Parent = 'Supplier', @Name = 'Bills Payment', @ListForm = 'EBillsPaymentListForm', @MasterForm = 'EBillsPaymentForm', @Index = 3

EXEC uspAddSystemSubCategory @Category = 'Accounting', @Parent = NULL, @Name = 'Customer', @ListForm = NULL, @MasterForm = NULL, @Index = 4
EXEC uspAddSystemSubCategory @Category = 'Accounting', @Parent = 'Customer', @Name = 'Sales Invoices', @ListForm = 'ESalesInvoicesListForm', @MasterForm = 'ESalesInvoiceForm', @Index = 5
EXEC uspAddSystemSubCategory @Category = 'Accounting', @Parent = 'Customer', @Name = 'Customer Payments', @ListForm = 'ECashReceiptVouchersListForm', @MasterForm = 'ECashReceiptVoucherForm', @Index = 6
EXEC uspAddSystemSubCategory @Category = 'Accounting', @Parent = 'Customer', @Name = 'Customer Overpayment', @ListForm = 'ECustomerOverpaymentsListForm', @MasterForm = 'ECustomerOverpaymentForm', @Index = 7

--Report
EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = NULL, @Name = 'General Ledger', @ListForm = 'EGeneralLedgerReportForm', @MasterForm = NULL, @Index = 0
EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = NULL, @Name = 'Subsidiary Ledger', @ListForm = 'ESubsidiaryLedgerReportForm', @MasterForm = NULL, @Index = 1
EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = NULL, @Name = 'Trial Balance', @ListForm = 'ETrialBalanceReportForm', @MasterForm = NULL, @Index = 2

EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = NULL, @Name = 'Receivables and Payables', @ListForm = NULL, @MasterForm = NULL, @Index = 3
EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = 'Receivables and Payables', @Name = 'Aging of Receivables', @ListForm = 'EAgingOfReceivablesReportForm', @MasterForm = NULL, @Index = 4
EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = 'Receivables and Payables', @Name = 'Aging of Payables', @ListForm = 'EAgingOfPayablesReportForm', @MasterForm = NULL, @Index = 5
EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = 'Receivables and Payables', @Name = 'Collection Summary', @ListForm = 'ECollectionSummaryReportForm', @MasterForm = NULL, @Index = 6

EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = NULL, @Name = 'Financial Statement', @ListForm = NULL, @MasterForm = NULL, @Index = 7
EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = 'Financial Statement', @Name = 'Income Statement', @ListForm = 'EIncomeStatementReportForm', @MasterForm = NULL, @Index = 8
EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = 'Financial Statement', @Name = 'Balance Sheet', @ListForm = 'EBalanceSheetReportForm', @MasterForm = NULL, @Index = 9
EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = 'Financial Statement', @Name = 'Cash Flow', @ListForm = NULL, @MasterForm = NULL, @Index = 10

EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = NULL, @Name = 'Journals', @ListForm = NULL, @MasterForm = NULL, @Index = 11
EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = 'Journals', @Name = 'General', @ListForm = 'EGeneralJournalReportForm', @MasterForm = NULL, @Index = 12
EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = 'Journals', @Name = 'Purchase', @ListForm = 'EPurchaseJournalReportForm', @MasterForm = NULL, @Index = 13
EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = 'Journals', @Name = 'Cash Disbursement', @ListForm = 'ECashDisbursementJournalReportForm', @MasterForm = NULL, @Index = 14
EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = 'Journals', @Name = 'Sales', @ListForm = 'ESalesJournalReportForm', @MasterForm = NULL, @Index = 15
EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = 'Journals', @Name = 'Cash Receipt', @ListForm = 'ECashReceiptJournalReportForm', @MasterForm = NULL, @Index = 16
GO

