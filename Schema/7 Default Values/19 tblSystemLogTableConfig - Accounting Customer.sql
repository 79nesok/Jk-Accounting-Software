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

