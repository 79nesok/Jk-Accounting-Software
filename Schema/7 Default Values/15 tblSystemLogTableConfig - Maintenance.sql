--tblAccounts
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

	--tblAccounts Column
	EXEC uspAddSystemLogColumn
		@TableName = 'tblAccounts',
		@ColumnName = 'Code',
		@Caption = 'Code',
		@Index = 0,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblAccounts',
		@ColumnName = 'Name',
		@Caption = 'Name',
		@Index = 1,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblAccounts',
		@ColumnName = 'SystemAccountCodeId',
		@Caption = 'System Account Code',
		@Index = 2,
		@Track = 1,
		@TableSource = 'tblSystemAccountCodes',
		@TableSourceResult = 'Name'
	EXEC uspAddSystemLogColumn
		@TableName = 'tblAccounts',
		@ColumnName = 'Remarks',
		@Caption = 'Remarks',
		@Index = 3,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblAccounts',
		@ColumnName = 'Active',
		@Caption = 'Active',
		@Index = 4,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL

--tblItems
EXEC uspAddSystemLogTable
	@TableName = 'tblItems',
	@Caption = 'Items',
	@IdentifierColumnName = 'Code',
	@Track = 1,
	@Enable = 0

	--tblItems Column
	EXEC uspAddSystemLogColumn
		@TableName = 'tblItems',
		@ColumnName = 'Code',
		@Caption = 'Code',
		@Index = 0,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblItems',
		@ColumnName = 'Name',
		@Caption = 'Name',
		@Index = 1,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblItems',
		@ColumnName = 'TypeId',
		@Caption = 'Type',
		@Index = 2,
		@Track = 1,
		@TableSource = 'tblItemTypes',
		@TableSourceResult = 'Name'
	EXEC uspAddSystemLogColumn
		@TableName = 'tblItems',
		@ColumnName = 'Remarks',
		@Caption = 'Remarks',
		@Index = 3,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblItems',
		@ColumnName = 'Active',
		@Caption = 'Active',
		@Index = 4,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL

--tblPaymentMethods
EXEC uspAddSystemLogTable
	@TableName = 'tblPaymentMethods',
	@Caption = 'Payment Methods',
	@IdentifierColumnName = 'Code',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = NULL,
	@SeparatorColumnId = NULL

	--tblPaymentMethods Column
	EXEC uspAddSystemLogColumn
		@TableName = 'tblPaymentMethods',
		@ColumnName = 'Code',
		@Caption = 'Code',
		@Index = 0,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblPaymentMethods',
		@ColumnName = 'Name',
		@Caption = 'Name',
		@Index = 1,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblPaymentMethods',
		@ColumnName = 'AccountId',
		@Caption = 'Account',
		@Index = 2,
		@Track = 1,
		@TableSource = 'tblAccounts',
		@TableSourceResult = 'Name'
	EXEC uspAddSystemLogColumn
		@TableName = 'tblPaymentMethods',
		@ColumnName = 'Remarks',
		@Caption = 'Remarks',
		@Index = 3,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblPaymentMethods',
		@ColumnName = 'ForClearing',
		@Caption = 'For Clearing',
		@Index = 4,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblPaymentMethods',
		@ColumnName = 'Active',
		@Caption = 'Active',
		@Index = 4,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL

--tblSubsidiaries
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

	--tblSubsidiaries Column
	EXEC uspAddSystemLogColumn
		@TableName = 'tblSubsidiaries',
		@ColumnName = 'Code',
		@Caption = 'Code',
		@Index = 0,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblSubsidiaries',
		@ColumnName = 'Name',
		@Caption = 'Name',
		@Index = 1,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblSubsidiaries',
		@ColumnName = 'Address',
		@Caption = 'Address',
		@Index = 2,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblSubsidiaries',
		@ColumnName = 'Remarks',
		@Caption = 'Remarks',
		@Index = 3,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblSubsidiaries',
		@ColumnName = 'Active',
		@Caption = 'Active',
		@Index = 4,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblSubsidiaries',
		@ColumnName = 'TIN',
		@Caption = 'TIN',
		@Index = 5,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblSubsidiaries',
		@ColumnName = 'ZIPCode',
		@Caption = 'ZIP Code',
		@Index = 6,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblSubsidiaries',
		@ColumnName = 'ATCId',
		@Caption = 'ATC',
		@Index = 7,
		@Track = 1,
		@TableSource = 'tblAlphaNumericTaxCodes',
		@TableSourceResult = 'Name'
GO

