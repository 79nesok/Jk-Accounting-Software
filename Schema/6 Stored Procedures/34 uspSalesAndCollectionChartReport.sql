IF OBJECT_ID('uspSalesAndCollectionChartReport') IS NOT NULL
	DROP PROCEDURE uspSalesAndCollectionChartReport
GO

CREATE PROCEDURE uspSalesAndCollectionChartReport(@CompanyId INT, @FromDate DATETIME, @ToDate DATETIME)
AS
SET NOCOUNT ON

SELECT x.[Month] + '-' + CAST(x.[Year] AS VARCHAR) AS [Month],
	SUM(x.Sales) AS Sales, SUM(x.[Collection]) AS [Collection]
FROM (
	SELECT m.Id, YEAR(si.[Date]) AS [Year],
		m.Name AS [Month], si.NetAmount AS Sales, 0 AS [Collection]
	FROM tblSalesInvoices si
		INNER JOIN tblMonths m ON m.Id = MONTH(si.[Date])
	WHERE si.CompanyId = @CompanyId
		AND si.[Date] BETWEEN DATEADD(MONTH, -6, @FromDate) AND @ToDate
		AND si.Voided = 0

	UNION ALL

	SELECT m.Id, YEAR(cr.[Date]) AS [Year],
		m.Name AS [Month], 0 AS Sales, crpd.Amount AS [Collection]
	FROM tblCashReceipts cr
		INNER JOIN tblMonths m ON m.Id = MONTH(cr.[Date])
		INNER JOIN tblCashReceiptPaymentDistribution crpd ON crpd.CashReceiptId = cr.Id
	WHERE cr.CompanyId = @CompanyId
		AND cr.[Date] BETWEEN DATEADD(MONTH, -6, @FromDate) AND @ToDate
		AND cr.Voided = 0
) x
GROUP BY x.[Year], x.Id, x.[Month]
ORDER BY x.[Year], x.Id
GO

