--tblJournalVouchers
EXEC uspAddSystemLogTable
	@TableName = 'tblJournalVouchers',
	@Caption = 'Journal Vouchers',
	@IdentifierColumnName = 'TransactionNo',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = NULL,
	@SeparatorColumnId = NULL

	--tblJournalVouchers Column
	EXEC uspAddSystemLogColumn
		@TableName = 'tblJournalVouchers',
		@ColumnName = 'TransactionNo',
		@Caption = 'Transaction No',
		@Index = 0,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblJournalVouchers',
		@ColumnName = 'Date',
		@Caption = 'Date',
		@Index = 1,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblJournalVouchers',
		@ColumnName = 'ReferenceNo',
		@Caption = 'Reference No',
		@Index = 2,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblJournalVouchers',
		@ColumnName = 'ReferenceNo2',
		@Caption = 'Reference No 2',
		@Index = 3,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblJournalVouchers',
		@ColumnName = 'Remarks',
		@Caption = 'Remarks',
		@Index = 4,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL

--tblJournalVoucherDetails
EXEC uspAddSystemLogTable
	@TableName = 'tblJournalVoucherDetails',
	@Caption = 'Journal Voucher Details',
	@IdentifierColumnName = 'JournalVoucherId',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = NULL,
	@SeparatorColumnId = NULL

	--tblJournalVoucherDetails Column
	EXEC uspAddSystemLogColumn
		@TableName = 'tblJournalVoucherDetails',
		@ColumnName = 'AccountId',
		@Caption = 'Detail - Account',
		@Index = 0,
		@Track = 1,
		@TableSource = 'tblAccounts',
		@TableSourceResult = 'Name'
	EXEC uspAddSystemLogColumn
		@TableName = 'tblJournalVoucherDetails',
		@ColumnName = 'SubsidiaryId',
		@Caption = 'Detail - Subsidiary',
		@Index = 1,
		@Track = 1,
		@TableSource = 'tblSubsidiaries',
		@TableSourceResult = 'Name'
	EXEC uspAddSystemLogColumn
		@TableName = 'tblJournalVoucherDetails',
		@ColumnName = 'Debit',
		@Caption = 'Detail - Debit',
		@Index = 2,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblJournalVoucherDetails',
		@ColumnName = 'Credit',
		@Caption = 'Detail - Credit',
		@Index = 3,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblJournalVoucherDetails',
		@ColumnName = 'Remarks',
		@Caption = 'Detail - Remarks',
		@Index = 4,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
GO

