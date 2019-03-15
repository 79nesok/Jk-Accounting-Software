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
		@TableSource = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblJournalVouchers',
		@ColumnName = 'Date',
		@Caption = 'Date',
		@Index = 1,
		@Track = 1,
		@TableSource = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblJournalVouchers',
		@ColumnName = 'ReferenceNo',
		@Caption = 'Reference No',
		@Index = 2,
		@Track = 1,
		@TableSource = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblJournalVouchers',
		@ColumnName = 'ReferenceNo2',
		@Caption = 'Reference No 2',
		@Index = 3,
		@Track = 1,
		@TableSource = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblJournalVouchers',
		@ColumnName = 'Remarks',
		@Caption = 'Remarks',
		@Index = 4,
		@Track = 1,
		@TableSource = NULL

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
		@Caption = 'Account',
		@Index = 0,
		@Track = 1,
		@TableSource = 'tblAccounts'
	EXEC uspAddSystemLogColumn
		@TableName = 'tblJournalVoucherDetails',
		@ColumnName = 'SubsidiaryId',
		@Caption = 'Subsidiary',
		@Index = 1,
		@Track = 1,
		@TableSource = 'tblSubsidiaries'
	EXEC uspAddSystemLogColumn
		@TableName = 'tblJournalVoucherDetails',
		@ColumnName = 'Debit',
		@Caption = 'Debit',
		@Index = 2,
		@Track = 1,
		@TableSource = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblJournalVoucherDetails',
		@ColumnName = 'Credit',
		@Caption = 'Credit',
		@Index = 3,
		@Track = 1,
		@TableSource = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblJournalVoucherDetails',
		@ColumnName = 'Remarks',
		@Caption = 'Remarks',
		@Index = 4,
		@Track = 1,
		@TableSource = NULL

--tblBills
EXEC uspAddSystemLogTable
	@TableName = 'tblBills',
	@Caption = 'Bills',
	@IdentifierColumnName = 'TransactionNo',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = NULL,
	@SeparatorColumnId = NULL

--tblBillsPayment
EXEC uspAddSystemLogTable
	@TableName = 'tblBillsPayment',
	@Caption = 'Bills Payment',
	@IdentifierColumnName = 'TransactionNo',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = 'PaymentTypeId',
	@SeparatorColumnId = 1
EXEC uspAddSystemLogTable
	@TableName = 'tblBillsPayment',
	@Caption = 'Check Vouchers',
	@IdentifierColumnName = 'TransactionNo',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = 'PaymentTypeId',
	@SeparatorColumnId = 2

--tblSalesInvoices
EXEC uspAddSystemLogTable
	@TableName = 'tblSalesInvoices',
	@Caption = 'Sales Invoices',
	@IdentifierColumnName = 'TransactionNo',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = NULL,
	@SeparatorColumnId = NULL

--tblCashReceipts
EXEC uspAddSystemLogTable
	@TableName = 'tblCashReceipts',
	@Caption = 'Cash Receipts',
	@IdentifierColumnName = 'TransactionNo',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = 'PaymentTypeId',
	@SeparatorColumnId = 3
EXEC uspAddSystemLogTable
	@TableName = 'tblCashReceipts',
	@Caption = 'Cash Receipts Voucher',
	@IdentifierColumnName = 'TransactionNo',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = 'PaymentTypeId',
	@SeparatorColumnId = 4
GO

