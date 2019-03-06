IF OBJECT_ID('uspCollectionSummary') IS NOT NULL
	DROP PROCEDURE uspCollectionSummary
GO

CREATE PROCEDURE uspCollectionSummary(@CompanyId INT, @FromDate DATETIME, @ToDate DATETIME)
AS
SET NOCOUNT ON

DECLARE @Columns VARCHAR(1024)
DECLARE @CommandText VARCHAR(8000)

SET @Columns = '[Total Receivables],[Unpaid Receivables],'

SELECT @Columns = ISNULL(@Columns, '') + '[' + Name + '],'
FROM tblPaymentMethods
WHERE CompanyId = @CompanyId

SET @Columns = LEFT(@Columns, LEN(@Columns) - 1)

SET @CommandText = '
	SELECT *
	FROM (
		SELECT ''Total Receivables'' AS PaymentMethod, sv.NetAmount AS Amount
		FROM tblSalesVouchers sv
		WHERE sv.CompanyId = ' + CAST(@CompanyId AS VARCHAR) + '
			AND sv.[Date] <= ''' + CAST(@ToDate AS VARCHAR)  + '''
			AND sv.Voided = 0

		UNION ALL

		SELECT ''Unpaid Receivables'' AS PaymentMethod, sv.Balance AS Amount
		FROM tblSalesVouchers sv
		WHERE sv.CompanyId = ' + CAST(@CompanyId AS VARCHAR) + '
			AND sv.[Date] <= ''' + CAST(@ToDate AS VARCHAR)  + '''
			AND sv.Voided = 0

		UNION ALL

		SELECT pm.Name AS PaymentMethod, cpd.Amount
		FROM tblCashReceiptVouchers cv
			INNER JOIN tblCashReceiptVoucherDetails cvd ON cvd.CashReceiptVoucherId = cv.Id
			INNER JOIN tblCashReceiptVoucherPaymentDistribution cpd ON cpd.CashReceiptVoucherDetailId = cvd.Id
			INNER JOIN tblPaymentMethods pm ON pm.Id = cvd.PaymentMethodId
		WHERE cv.CompanyId = ' + CAST(@CompanyId AS VARCHAR) + '
			AND cv.[Date] BETWEEN ''' + CAST(@FromDate AS VARCHAR) + ''' AND ''' + CAST(@ToDate AS VARCHAR)  + '''
			AND cv.Voided = 0
	) tmp
	PIVOT(SUM(Amount) FOR PaymentMethod IN (' + @Columns + ')) AS pvt
	'

EXEC(@CommandText)
GO

