TRUNCATE TABLE tblSystemLogTableConfig
TRUNCATE TABLE tblSystemLogColumnConfig

--Maintenance
EXEC uspAddSystemLogTable
	@TableName = 'tblAccounts',
	@Caption = 'Assets',
	@IdentifierColumnName = 'Code',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = 'AccountTypeId',
	@SeparatorColumnId = 1
EXEC uspAddSystemLogTable
	@TableName = 'tblAccounts',
	@Caption = 'Liabilities',
	@IdentifierColumnName = 'Code',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = 'AccountTypeId',
	@SeparatorColumnId = 2
EXEC uspAddSystemLogTable
	@TableName = 'tblAccounts',
	@Caption = 'Equities',
	@IdentifierColumnName = 'Code',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = 'AccountTypeId',
	@SeparatorColumnId = 3
EXEC uspAddSystemLogTable
	@TableName = 'tblAccounts',
	@Caption = 'Income',
	@IdentifierColumnName = 'Code',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = 'AccountTypeId',
	@SeparatorColumnId = 4
EXEC uspAddSystemLogTable
	@TableName = 'tblAccounts',
	@Caption = 'Expenses',
	@IdentifierColumnName = 'Code',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = 'AccountTypeId',
	@SeparatorColumnId = 5

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
	@IdentifierColumnName = 'Code',
	@Track = 1,
	@Enable = 0

	EXEC uspAddSystemLogColumn
		@TableName = 'tblItems',
		@ColumnName = 'Code',
		@Caption = 'Code',
		@Index = 0,
		@Track = 1,
		@TableSource = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblItems',
		@ColumnName = 'Name',
		@Caption = 'Name',
		@Index = 1,
		@Track = 1,
		@TableSource = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblItems',
		@ColumnName = 'TypeId',
		@Caption = 'Type',
		@Index = 2,
		@Track = 1,
		@TableSource = 'tblItemTypes'
	EXEC uspAddSystemLogColumn
		@TableName = 'tblItems',
		@ColumnName = 'Remarks',
		@Caption = 'Remarks',
		@Index = 3,
		@Track = 1,
		@TableSource = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblItems',
		@ColumnName = 'Active',
		@Caption = 'Active',
		@Index = 4,
		@Track = 1,
		@TableSource = NULL

EXEC uspAddSystemLogTable
	@TableName = 'tblPaymentMethods',
	@Caption = 'Payment Methods',
	@IdentifierColumnName = 'Code',
	@Track = 1,
	@Enable = 0

EXEC uspAddSystemLogTable
	@TableName = 'tblSubsidiaries',
	@Caption = 'Customers',
	@IdentifierColumnName = 'Code',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = 'SubsidiaryTypeId',
	@SeparatorColumnId = 1
EXEC uspAddSystemLogTable
	@TableName = 'tblSubsidiaries',
	@Caption = 'Suppliers',
	@IdentifierColumnName = 'Code',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = 'SubsidiaryTypeId',
	@SeparatorColumnId = 2
EXEC uspAddSystemLogTable
	@TableName = 'tblSubsidiaries',
	@Caption = 'Employees',
	@IdentifierColumnName = 'Code',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = 'SubsidiaryTypeId',
	@SeparatorColumnId = 3
EXEC uspAddSystemLogTable
	@TableName = 'tblSubsidiaries',
	@Caption = 'Others',
	@IdentifierColumnName = 'Code',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = 'SubsidiaryTypeId',
	@SeparatorColumnId = 4

--Administration
EXEC uspAddSystemLogTable
	@TableName = 'tblCompanies',
	@Caption = 'Company',
	@IdentifierColumnName = 'Code',
	@Track = 1,
	@Enable = 0
EXEC uspAddSystemLogTable
	@TableName = 'tblSystemUsers',
	@Caption = 'Users',
	@IdentifierColumnName = 'FormalName',
	@Track = 1,
	@Enable = 0

--Accounting
EXEC uspAddSystemLogTable
	@TableName = 'tblJournalVouchers',
	@Caption = 'Journal Vouchers',
	@IdentifierColumnName = 'TransactionNo',
	@Track = 1,
	@Enable = 0

EXEC uspAddSystemLogTable
	@TableName = 'tblBills',
	@Caption = 'Bills',
	@IdentifierColumnName = 'TransactionNo',
	@Track = 1,
	@Enable = 0
EXEC uspAddSystemLogTable
	@TableName = 'tblBillsPayment',
	@Caption = 'Bills Payment',
	@IdentifierColumnName = 'TransactionNo',
	@Track = 1,
	@Enable = 0

EXEC uspAddSystemLogTable
	@TableName = 'tblSalesInvoices',
	@Caption = 'Sales Invoices',
	@IdentifierColumnName = 'TransactionNo',
	@Track = 1,
	@Enable = 0
EXEC uspAddSystemLogTable
	@TableName = 'tblCashReceipts',
	@Caption = 'Cash Receipts',
	@IdentifierColumnName = 'TransactionNo',
	@Track = 1,
	@Enable = 0

--Insert System Log Items
DECLARE @tmp TABLE(Id INT IDENTITY(1, 1), Caption VARCHAR(100) PRIMARY KEY(Id))
DECLARE @Id INT
DECLARE @Caption VARCHAR(100)
DECLARE @LastIndex INT

INSERT INTO @tmp(Caption)
SELECT Caption
FROM tblSystemLogTableConfig
WHERE Track = 1
ORDER BY Caption

SELECT @LastIndex = [Index]
FROM tblSystemSubCategories
WHERE Name = 'System Logs'

WHILE 1 = 1
BEGIN
	SELECT TOP 1
		@Id = Id,
		@Caption = Caption
	FROM @tmp

	SET @LastIndex = @LastIndex + 1

	EXEC uspAddSystemSubCategory @Category = 'Report', @Parent = 'System Logs', @Name = @Caption, @ListForm = 'ESystemLogsReportForm', @MasterForm = NULL, @Index = @LastIndex

	DELETE
	FROM @tmp
	WHERE Id = @Id

	IF NOT EXISTS(SELECT * FROM @tmp)
		BREAK
END

--Create all triggers
DECLARE @table TABLE(TableId INT)
DECLARE @TableId INT

INSERT INTO @table(TableId)
SELECT Id
FROM tblSystemLogTableConfig
WHERE Track = 1

WHILE 1 = 1
BEGIN
	SELECT TOP 1
		@TableId = TableId
	FROM @table

	EXEC uspCreateTrigger @TableId

	UPDATE tblSystemLogTableConfig
	SET [Enable] = 1
	WHERE Id = @TableId

	DELETE
	FROM @table
	WHERE TableId = @TableId

	IF NOT EXISTS(SELECT * FROM @table)
		BREAK
END
GO

