--tblSalesInvoices
EXEC uspAddSystemLogTable
	@TableName = 'tblSalesInvoices',
	@Caption = 'Sales Invoices',
	@IdentifierColumnName = 'TransactionNo',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = NULL,
	@SeparatorColumnId = NULL

	--tblSalesInvoices Column
	EXEC uspAddSystemLogColumn
		@TableName = 'tblSalesInvoices',
		@ColumnName = 'TransactionNo',
		@Caption = 'Transaction No',
		@Index = 0,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblSalesInvoices',
		@ColumnName = 'Date',
		@Caption = 'Date',
		@Index = 1,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblSalesInvoices',
		@ColumnName = 'ReferenceNo',
		@Caption = 'Reference No',
		@Index = 2,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblSalesInvoices',
		@ColumnName = 'ReferenceNo2',
		@Caption = 'Reference No 2',
		@Index = 3,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblSalesInvoices',
		@ColumnName = 'SubsidiaryId',
		@Caption = 'Subsidiary',
		@Index = 4,
		@Track = 1,
		@TableSource = 'tblSubsidiaries',
		@TableSourceResult = 'Name'
	EXEC uspAddSystemLogColumn
		@TableName = 'tblSalesInvoices',
		@ColumnName = 'Remarks',
		@Caption = 'Remarks',
		@Index = 5,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblSalesInvoices',
		@ColumnName = 'GrossAmount',
		@Caption = 'Gross Amount',
		@Index = 6,
		@Track = 0,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblSalesInvoices',
		@ColumnName = 'VATAmount',
		@Caption = 'VAT Amount',
		@Index = 7,
		@Track = 0,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblSalesInvoices',
		@ColumnName = 'DiscountAmount',
		@Caption = 'Discount Amount',
		@Index = 8,
		@Track = 0,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblSalesInvoices',
		@ColumnName = 'NetAmount',
		@Caption = 'Net Amount',
		@Index = 9,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL

--tblSalesInvoiceDetails
EXEC uspAddSystemLogTable
	@TableName = 'tblSalesInvoiceDetails',
	@Caption = 'Sales Invoice Details',
	@IdentifierColumnName = 'SalesInvoiceId',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = NULL,
	@SeparatorColumnId = NULL

	--tblSalesInvoiceDetails Column
	EXEC uspAddSystemLogColumn
		@TableName = 'tblSalesInvoiceDetails',
		@ColumnName = 'ItemId',
		@Caption = 'Detail - Item',
		@Index = 0,
		@Track = 1,
		@TableSource = 'tblItems',
		@TableSourceResult = 'Name'
	EXEC uspAddSystemLogColumn
		@TableName = 'tblSalesInvoiceDetails',
		@ColumnName = 'AccountId',
		@Caption = 'Detail - Account',
		@Index = 1,
		@Track = 1,
		@TableSource = 'tblAccounts',
		@TableSourceResult = 'Name'
	EXEC uspAddSystemLogColumn
		@TableName = 'tblSalesInvoiceDetails',
		@ColumnName = 'Amount',
		@Caption = 'Detail - Amount',
		@Index = 2,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblSalesInvoiceDetails',
		@ColumnName = 'VATTypeId',
		@Caption = 'Detail - VAT Type',
		@Index = 3,
		@Track = 1,
		@TableSource = 'tblVATTypes',
		@TableSourceResult = 'Name'
	EXEC uspAddSystemLogColumn
		@TableName = 'tblSalesInvoiceDetails',
		@ColumnName = 'DiscountAmount',
		@Caption = 'Detail - Discount Amount',
		@Index = 4,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblSalesInvoiceDetails',
		@ColumnName = 'Remarks',
		@Caption = 'Detail - Remarks',
		@Index = 5,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL

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

	--tblCashReceipts Column
	EXEC uspAddSystemLogColumn
		@TableName = 'tblCashReceipts',
		@ColumnName = 'TransactionNo',
		@Caption = 'Transaction No',
		@Index = 0,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblCashReceipts',
		@ColumnName = 'Date',
		@Caption = 'Date',
		@Index = 1,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblCashReceipts',
		@ColumnName = 'ReferenceNo',
		@Caption = 'Reference No',
		@Index = 2,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblCashReceipts',
		@ColumnName = 'ReferenceNo2',
		@Caption = 'Reference No 2',
		@Index = 3,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblCashReceipts',
		@ColumnName = 'SubsidiaryId',
		@Caption = 'Subsidiary',
		@Index = 4,
		@Track = 1,
		@TableSource = 'tblSubsidiaries',
		@TableSourceResult = 'Name'
	EXEC uspAddSystemLogColumn
		@TableName = 'tblCashReceipts',
		@ColumnName = 'Remarks',
		@Caption = 'Remarks',
		@Index = 5,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL

--tblCashReceiptDetails
EXEC uspAddSystemLogTable
	@TableName = 'tblCashReceiptDetails',
	@Caption = 'Cash Receipt Payment Details',
	@IdentifierColumnName = 'CashReceiptId',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = NULL,
	@SeparatorColumnId = NULL

	--tblCashReceiptDetails Column
	EXEC uspAddSystemLogColumn
		@TableName = 'tblCashReceiptDetails',
		@ColumnName = 'PaymentMethodId',
		@Caption = 'Payment Detail - Payment Method',
		@Index = 0,
		@Track = 1,
		@TableSource = 'tblPaymentMethods',
		@TableSourceResult = 'Name'
	EXEC uspAddSystemLogColumn
		@TableName = 'tblCashReceiptDetails',
		@ColumnName = 'Amount',
		@Caption = 'Payment Detail - Amount',
		@Index = 1,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblCashReceiptDetails',
		@ColumnName = 'CheckNo',
		@Caption = 'Payment Detail - Check No',
		@Index = 2,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblCashReceiptDetails',
		@ColumnName = 'CheckDate',
		@Caption = 'Payment Detail - Check Date',
		@Index = 3,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblCashReceiptDetails',
		@ColumnName = 'Remarks',
		@Caption = 'Payment Detail - Remarks',
		@Index = 4,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL

--tblCashReceiptInvoiceDetails
EXEC uspAddSystemLogTable
	@TableName = 'tblCashReceiptInvoiceDetails',
	@Caption = 'Cash Receipt Details',
	@IdentifierColumnName = 'CashReceiptId',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = NULL,
	@SeparatorColumnId = NULL

	--tblCashReceiptInvoiceDetails Column
	EXEC uspAddSystemLogColumn
		@TableName = 'tblCashReceiptInvoiceDetails',
		@ColumnName = 'SourceId',
		@Caption = 'Detail - Transaction No',
		@Index = 0,
		@Track = 1,
		@TableSource = 'tblSalesInvoices',
		@TableSourceResult = 'TransactionNo'

	EXEC uspAddSystemLogColumn
		@TableName = 'tblCashReceiptInvoiceDetails',
		@ColumnName = 'AppliedAmount',
		@Caption = 'Detail - Applied Amount',
		@Index = 1,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL

--tblCashReceiptAccountDetails
EXEC uspAddSystemLogTable
	@TableName = 'tblCashReceiptAccountDetails',
	@Caption = 'Cash Receipt Voucher Details',
	@IdentifierColumnName = 'CashReceiptId',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = NULL,
	@SeparatorColumnId = NULL

	--tblCashReceiptAccountDetails Column
	EXEC uspAddSystemLogColumn
		@TableName = 'tblCashReceiptAccountDetails',
		@ColumnName = 'AccountId',
		@Caption = 'Detail - Account',
		@Index = 0,
		@Track = 1,
		@TableSource = 'tblAccounts',
		@TableSourceResult = 'Name'
	EXEC uspAddSystemLogColumn
		@TableName = 'tblCashReceiptAccountDetails',
		@ColumnName = 'SubsidiaryId',
		@Caption = 'Detail - Subsidiary',
		@Index = 1,
		@Track = 1,
		@TableSource = 'tblSubsidiaries',
		@TableSourceResult = 'Name'
	EXEC uspAddSystemLogColumn
		@TableName = 'tblCashReceiptAccountDetails',
		@ColumnName = 'Debit',
		@Caption = 'Detail - Debit',
		@Index = 2,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblCashReceiptAccountDetails',
		@ColumnName = 'Credit',
		@Caption = 'Detail - Credit',
		@Index = 3,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblCashReceiptAccountDetails',
		@ColumnName = 'Remarks',
		@Caption = 'Detail - Remarks',
		@Index = 4,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
GO

