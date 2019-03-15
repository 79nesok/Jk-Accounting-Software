--tblBills
EXEC uspAddSystemLogTable
	@TableName = 'tblBills',
	@Caption = 'Bills',
	@IdentifierColumnName = 'TransactionNo',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = NULL,
	@SeparatorColumnId = NULL

	--tblBills Column
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBills',
		@ColumnName = 'TransactionNo',
		@Caption = 'Transaction No',
		@Index = 0,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBills',
		@ColumnName = 'Date',
		@Caption = 'Date',
		@Index = 1,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBills',
		@ColumnName = 'ReferenceNo',
		@Caption = 'Reference No',
		@Index = 2,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBills',
		@ColumnName = 'ReferenceNo2',
		@Caption = 'Reference No 2',
		@Index = 3,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBills',
		@ColumnName = 'SubsidiaryId',
		@Caption = 'Subsidiary',
		@Index = 4,
		@Track = 1,
		@TableSource = 'tblSubsidiaries',
		@TableSourceResult = 'Name'
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBills',
		@ColumnName = 'Remarks',
		@Caption = 'Remarks',
		@Index = 5,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBills',
		@ColumnName = 'GrossAmount',
		@Caption = 'Gross Amount',
		@Index = 6,
		@Track = 0,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBills',
		@ColumnName = 'WithholdingTax',
		@Caption = 'Withholding Tax',
		@Index = 7,
		@Track = 0,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBills',
		@ColumnName = 'VATAmount',
		@Caption = 'VAT Amount',
		@Index = 8,
		@Track = 0,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBills',
		@ColumnName = 'DiscountAmount',
		@Caption = 'Discount Amount',
		@Index = 9,
		@Track = 0,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBills',
		@ColumnName = 'NetAmount',
		@Caption = 'Net Amount',
		@Index = 10,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL

--tblBillDetails
EXEC uspAddSystemLogTable
	@TableName = 'tblBillDetails',
	@Caption = 'Bill Details',
	@IdentifierColumnName = 'BillId',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = NULL,
	@SeparatorColumnId = NULL

	--tblBillDetails Column
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBillDetails',
		@ColumnName = 'ItemId',
		@Caption = 'Detail - Item',
		@Index = 0,
		@Track = 1,
		@TableSource = 'tblItems',
		@TableSourceResult = 'Name'
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBillDetails',
		@ColumnName = 'AccountId',
		@Caption = 'Detail - Account',
		@Index = 1,
		@Track = 1,
		@TableSource = 'tblAccounts',
		@TableSourceResult = 'Name'
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBillDetails',
		@ColumnName = 'Amount',
		@Caption = 'Detail - Amount',
		@Index = 2,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBillDetails',
		@ColumnName = 'VATTypeId',
		@Caption = 'Detail - VAT Type',
		@Index = 3,
		@Track = 1,
		@TableSource = 'tblVATTypes',
		@TableSourceResult = 'Name'
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBillDetails',
		@ColumnName = 'ATCId',
		@Caption = 'Detail - ATC',
		@Index = 4,
		@Track = 1,
		@TableSource = 'tblAlphaNumericTaxCodes',
		@TableSourceResult = 'Name'
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBillDetails',
		@ColumnName = 'DiscountAmount',
		@Caption = 'Detail - Discount Amount',
		@Index = 5,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBillDetails',
		@ColumnName = 'Remarks',
		@Caption = 'Detail - Remarks',
		@Index = 6,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL

--tblBillsPayment
EXEC uspAddSystemLogTable
	@TableName = 'tblBillsPayment',
	@Caption = 'Bills Payment',
	@IdentifierColumnName = 'TransactionNo',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = 'PaymentTypeId',
	@SeparatorColumnId = 1
--Check Voucher
EXEC uspAddSystemLogTable
	@TableName = 'tblBillsPayment',
	@Caption = 'Check Vouchers',
	@IdentifierColumnName = 'TransactionNo',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = 'PaymentTypeId',
	@SeparatorColumnId = 2

	--tblBillsPayment Column
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBillsPayment',
		@ColumnName = 'TransactionNo',
		@Caption = 'Transaction No',
		@Index = 0,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBillsPayment',
		@ColumnName = 'Date',
		@Caption = 'Date',
		@Index = 1,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBillsPayment',
		@ColumnName = 'ReferenceNo',
		@Caption = 'Reference No',
		@Index = 2,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBillsPayment',
		@ColumnName = 'ReferenceNo2',
		@Caption = 'Reference No 2',
		@Index = 3,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBillsPayment',
		@ColumnName = 'SubsidiaryId',
		@Caption = 'Subsidiary',
		@Index = 4,
		@Track = 1,
		@TableSource = 'tblSubsidiaries',
		@TableSourceResult = 'Name'
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBillsPayment',
		@ColumnName = 'Remarks',
		@Caption = 'Remarks',
		@Index = 5,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL

--tblBillsPaymentDetails
EXEC uspAddSystemLogTable
	@TableName = 'tblBillsPaymentDetails',
	@Caption = 'Payment Details',
	@IdentifierColumnName = 'BillsPaymentId',
	@Track = 1,
	@Enable = 0,
	@SeparatorColumnName = NULL,
	@SeparatorColumnId = NULL

	--tblBillsPaymentDetails Column
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBillsPaymentDetails',
		@ColumnName = 'PaymentMethodId',
		@Caption = 'Payment Detail - Payment Method',
		@Index = 0,
		@Track = 1,
		@TableSource = 'tblPaymentMethods',
		@TableSourceResult = 'Name'
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBillsPaymentDetails',
		@ColumnName = 'Amount',
		@Caption = 'Payment Detail - Amount',
		@Index = 1,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBillsPaymentDetails',
		@ColumnName = 'CheckNo',
		@Caption = 'Payment Detail - Check No',
		@Index = 1,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBillsPaymentDetails',
		@ColumnName = 'CheckDate',
		@Caption = 'Payment Detail - Check Date',
		@Index = 1,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
	EXEC uspAddSystemLogColumn
		@TableName = 'tblBillsPaymentDetails',
		@ColumnName = 'Remarks',
		@Caption = 'Payment Detail - Remarks',
		@Index = 1,
		@Track = 1,
		@TableSource = NULL,
		@TableSourceResult = NULL
GO

