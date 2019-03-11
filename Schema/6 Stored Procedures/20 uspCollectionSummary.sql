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
		SELECT ''Total Receivables'' AS PaymentMethod, si.NetAmount AS Amount
		FROM tblSalesInvoices si
		WHERE si.CompanyId = ' + CAST(@CompanyId AS VARCHAR) + '
			AND si.[Date] <= ''' + CAST(@ToDate AS VARCHAR)  + '''
			AND si.Voided = 0

		UNION ALL

		SELECT ''Unpaid Receivables'' AS PaymentMethod, si.Balance AS Amount
		FROM tblSalesInvoices si
		WHERE si.CompanyId = ' + CAST(@CompanyId AS VARCHAR) + '
			AND si.[Date] <= ''' + CAST(@ToDate AS VARCHAR)  + '''
			AND si.Voided = 0

		UNION ALL

		SELECT pm.Name AS PaymentMethod, crpd.Amount
		FROM tblCashReceipts cr
			INNER JOIN tblCashReceiptDetails crd ON crd.CashReceiptId = cr.Id
			INNER JOIN tblCashReceiptPaymentDistribution crpd ON crpd.CashReceiptDetailId = crd.Id
			INNER JOIN tblPaymentMethods pm ON pm.Id = crd.PaymentMethodId
		WHERE cr.CompanyId = ' + CAST(@CompanyId AS VARCHAR) + '
			AND cr.[Date] BETWEEN ''' + CAST(@FromDate AS VARCHAR) + ''' AND ''' + CAST(@ToDate AS VARCHAR)  + '''
			AND cr.Voided = 0
	) tmp
	PIVOT(SUM(Amount) FOR PaymentMethod IN (' + @Columns + ')) AS pvt
	'

EXEC(@CommandText)
GO

