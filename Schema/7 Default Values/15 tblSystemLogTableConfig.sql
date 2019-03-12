TRUNCATE TABLE tblSystemLogTableConfig

--Maintenance
EXEC uspAddSystemLogTable
	@TableName = 'tblAccounts',
	@Caption = 'Assets',
	@Track = 1,
	@Enable = 0
EXEC uspAddSystemLogTable
	@TableName = 'tblAccounts',
	@Caption = 'Liabilities',
	@Track = 1, @Enable = 0
EXEC uspAddSystemLogTable
	@TableName = 'tblAccounts',
	@Caption = 'Equities',
	@Track = 1,
	@Enable = 0
EXEC uspAddSystemLogTable
	@TableName = 'tblAccounts',
	@Caption = 'Income',
	@Track = 1,
	@Enable = 0
EXEC uspAddSystemLogTable
	@TableName = 'tblAccounts',
	@Caption = 'Expenses',
	@Track = 1,
	@Enable = 0

	EXEC uspAddSystemLogColumn
		@TableName = 'tblAccounts',
		@ColumnName = 'Code',
		@Caption = 'Code',
		@Index = 0,
		@Track = 1,
		@TableSource = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblAccounts',
		@ColumnName = 'Name',
		@Caption = 'Name',
		@Index = 1,
		@Track = 1,
		@TableSource = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblAccounts',
		@ColumnName = 'SystemAccountCodeId',
		@Caption = 'System Account Code',
		@Index = 2,
		@Track = 1,
		@TableSource = 'tblSystemAccountCodes'
	EXEC uspAddSystemLogColumn
		@TableName = 'tblAccounts',
		@ColumnName = 'Remarks',
		@Caption = 'Remarks',
		@Index = 3,
		@Track = 1,
		@TableSource = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblAccounts',
		@ColumnName = 'Active',
		@Caption = 'Active',
		@Index = 4,
		@Track = 1,
		@TableSource = NULL

EXEC uspAddSystemLogTable
	@TableName = 'tblItems',
	@Caption = 'Items',
	@Track = 1,
	@Enable = 0

EXEC uspAddSystemLogTable
	@TableName = 'tblPaymentMethods',
	@Caption = 'Payment Methods',
	@Track = 1,
	@Enable = 0

EXEC uspAddSystemLogTable
	@TableName = 'tblSubsidiaries',
	@Caption = 'Customers',
	@Track = 1,
	@Enable = 0
EXEC uspAddSystemLogTable
	@TableName = 'tblSubsidiaries',
	@Caption = 'Suppliers',
	@Track = 1,
	@Enable = 0
EXEC uspAddSystemLogTable
	@TableName = 'tblSubsidiaries',
	@Caption = 'Employees',
	@Track = 1,
	@Enable = 0
EXEC uspAddSystemLogTable
	@TableName = 'tblSubsidiaries',
	@Caption = 'Others',
	@Track = 1,
	@Enable = 0

--Administration
EXEC uspAddSystemLogTable
	@TableName = 'tblCompanies',
	@Caption = 'Company',
	@Track = 1,
	@Enable = 0
EXEC uspAddSystemLogTable
	@TableName = 'tblSystemUsers',
	@Caption = 'Users',
	@Track = 1,
	@Enable = 0

--Accounting
EXEC uspAddSystemLogTable
	@TableName = 'tblJournalVouchers',
	@Caption = 'Journal Vouchers',
	@Track = 1,
	@Enable = 0

EXEC uspAddSystemLogTable
	@TableName = 'tblBills',
	@Caption = 'Bills',
	@Track = 1,
	@Enable = 0
EXEC uspAddSystemLogTable
	@TableName = 'tblBillsPayment',
	@Caption = 'Bills Payment',
	@Track = 1,
	@Enable = 0

EXEC uspAddSystemLogTable
	@TableName = 'tblSalesInvoices',
	@Caption = 'Sales Invoices',
	@Track = 1,
	@Enable = 0
EXEC uspAddSystemLogTable
	@TableName = 'tblCashReceipts',
	@Caption = 'Cash Receipts',
	@Track = 1,
	@Enable = 0
GO

