--MasterForm field questionable since Application is referencing on NewFormName and OpenFormName

--Maintenance
EXEC uspAddSystemSubCategory @Category = 'Maintenance', @Parent = NULL, @Name = 'Subsidiaries', @ListForm = NULL, @MasterForm = NULL, @Index = 0
EXEC uspAddSystemSubCategory @Category = 'Maintenance', @Parent = 'Subsidiaries', @Name = 'Customers', @ListForm = 'ECustomersListForm', @MasterForm = 'ESubsidiaryForm', @Index = 1
EXEC uspAddSystemSubCategory @Category = 'Maintenance', @Parent = 'Subsidiaries', @Name = 'Suppliers', @ListForm = 'ESuppliersListForm', @MasterForm = 'ESubsidiaryForm', @Index = 2
EXEC uspAddSystemSubCategory @Category = 'Maintenance', @Parent = 'Subsidiaries', @Name = 'Employees', @ListForm = 'EEmployeesListForm', @MasterForm = 'ESubsidiaryForm', @Index = 3
EXEC uspAddSystemSubCategory @Category = 'Maintenance', @Parent = 'Subsidiaries', @Name = 'Others', @ListForm = 'EOthersListForm', @MasterForm = 'ESubsidiaryForm', @Index = 4

--Administration
EXEC uspAddSystemSubCategory @Category = 'Administration', @Parent = NULL, @Name = 'Company', @ListForm = 'ECompanyForm', @MasterForm = NULL, @Index = 0
EXEC uspAddSystemSubCategory @Category = 'Administration', @Parent = NULL, @Name = 'Security', @ListForm = NULL, @MasterForm = NULL, @Index = 1

--Accounting
EXEC uspAddSystemSubCategory @Category = 'Accounting', @Parent = NULL, @Name = 'Chart of Accounts', @ListForm = NULL, @MasterForm = NULL, @Index = 0
EXEC uspAddSystemSubCategory @Category = 'Accounting', @Parent = 'Chart of Accounts', @Name = 'Assets', @ListForm = 'EAssetsListForm', @MasterForm = NULL, @Index = 1
EXEC uspAddSystemSubCategory @Category = 'Accounting', @Parent = 'Chart of Accounts', @Name = 'Liabilities', @ListForm = 'ELiabilitiesListForm', @MasterForm = 'EAccountForm', @Index = 2
EXEC uspAddSystemSubCategory @Category = 'Accounting', @Parent = 'Chart of Accounts', @Name = 'Equities', @ListForm = 'EEquitiesListForm', @MasterForm = 'EAccountForm', @Index = 3
EXEC uspAddSystemSubCategory @Category = 'Accounting', @Parent = 'Chart of Accounts', @Name = 'Income', @ListForm = 'EIncomeListForm', @MasterForm = 'EAccountForm', @Index = 4
EXEC uspAddSystemSubCategory @Category = 'Accounting', @Parent = 'Chart of Accounts', @Name = 'Expenses', @ListForm = 'EExpensesListForm', @MasterForm = 'EAccountForm', @Index = 5
EXEC uspAddSystemSubCategory @Category = 'Accounting', @Parent = NULL, @Name = 'Journal Vouchers', @ListForm = 'EJournalVouchersListForm', @MasterForm = 'EJournalVoucherForm', @Index = 6
EXEC uspAddSystemSubCategory @Category = 'Accounting', @Parent = NULL, @Name = 'Purchase Vouchers', @ListForm = 'EPurchaseVouchersListForm', @MasterForm = NULL, @Index = 7
EXEC uspAddSystemSubCategory @Category = 'Accounting', @Parent = NULL, @Name = 'Cash Disbursement Vouchers', @ListForm = 'ECashDisbursementVouchersListForm', @MasterForm = NULL, @Index = 8
EXEC uspAddSystemSubCategory @Category = 'Accounting', @Parent = NULL, @Name = 'Sales Vouchers', @ListForm = 'ESalesVouchersListForm', @MasterForm = NULL, @Index = 9
EXEC uspAddSystemSubCategory @Category = 'Accounting', @Parent = NULL, @Name = 'Cash Receipt Vouchers', @ListForm = 'ECashReceiptVouchersListForm', @MasterForm = NULL, @Index = 10

--Report
EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = NULL, @Name = 'General Ledger', @ListForm = 'EGeneralLedgerReportForm', @MasterForm = NULL, @Index = 0
EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = NULL, @Name = 'Subsidiary Ledger', @ListForm = 'ESubsidiaryLedgerReportForm', @MasterForm = NULL, @Index = 1
EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = NULL, @Name = 'Trial Balance', @ListForm = 'ETrialBalanceReportForm', @MasterForm = NULL, @Index = 2
EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = NULL, @Name = 'Income Statement', @ListForm = 'EIncomeStatementReportForm', @MasterForm = NULL, @Index = 3
EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = NULL, @Name = 'Balance Sheet', @ListForm = 'EBalanceSheetReportForm', @MasterForm = NULL, @Index = 4
EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = NULL, @Name = 'Cash Flow', @ListForm = NULL, @MasterForm = NULL, @Index = 5
GO

