--tblCompanies
EXEC uspAddSystemLogTable
	@TableName = 'tblCompanies',
	@Caption = 'Company',
	@IdentifierColumnName = 'Code',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = NULL,
	@SeparatorColumnId = NULL

	--tblCompanies Column
	EXEC uspAddSystemLogColumn
		@TableName = 'tblCompanies',
		@ColumnName = 'Code',
		@Caption = 'Code',
		@Index = 0,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblCompanies',
		@ColumnName = 'Name',
		@Caption = 'Name',
		@Index = 1,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblCompanies',
		@ColumnName = 'Address',
		@Caption = 'Address',
		@Index = 2,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblCompanies',
		@ColumnName = 'Remarks',
		@Caption = 'Remarks',
		@Index = 3,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblCompanies',
		@ColumnName = 'TIN',
		@Caption = 'TIN',
		@Index = 4,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblCompanies',
		@ColumnName = 'ZIPCode',
		@Caption = 'ZIP Code',
		@Index = 5,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblCompanies',
		@ColumnName = 'ATCId',
		@Caption = 'ATC',
		@Index = 6,
		@Track = 1,
		@TableSource = 'tblAlphaNumericTaxCodes',
		@TableSourceResult = 'Name'

--No CompanyId, trigger will error
----tblSystemUsers
--EXEC uspAddSystemLogTable
--	@TableName = 'tblSystemUsers',
--	@Caption = 'Users',
--	@IdentifierColumnName = 'FormalName',
--	@Track = 1,
--	@Enable = 0,
--	@SeparatorColumnName = NULL,
--	@SeparatorColumnId = NULL

--	--tblSystemUsers Column
--	EXEC uspAddSystemLogColumn
--		@TableName = 'tblCompanies',
--		@ColumnName = 'Code',
--		@Caption = 'Code',
--		@Index = 0,
--		@Track = 1,
--		@TableSource = NULL
GO

