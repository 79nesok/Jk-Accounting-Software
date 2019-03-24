IF OBJECT_ID('uspPayablesAndPaymentChartReport') IS NOT NULL
	DROP PROCEDURE uspPayablesAndPaymentChartReport
GO

CREATE PROCEDURE uspPayablesAndPaymentChartReport(@CompanyId INT, @FromDate DATETIME, @ToDate DATETIME)
AS
SET NOCOUNT ON

SELECT x.[Month] + '-' + CAST(x.[Year] AS VARCHAR) AS [Month],
	SUM(x.Payables) AS Payables, SUM(x.Payment) AS Payment
FROM (
	SELECT m.Id, YEAR(b.[Date]) AS [Year],
		m.Name AS [Month], b.NetAmount AS Payables, 0 AS Payment
	FROM tblBills b
		INNER JOIN tblMonths m ON m.Id = MONTH(b.[Date])
	WHERE b.CompanyId = @CompanyId
		AND b.[Date] BETWEEN DATEADD(MONTH, -6, @FromDate) AND @ToDate
		AND b.Voided = 0

	UNION ALL

	SELECT m.Id, YEAR(bp.[Date]) AS [Year],
		m.Name AS [Month], 0 AS Payables, bppd.Amount AS Payment
	FROM tblBillsPayment bp
		INNER JOIN tblMonths m ON m.Id = MONTH(bp.[Date])
		INNER JOIN tblBillsPaymentPaymentDisbtribution bppd ON bppd.BillsPaymentId = bp.Id
	WHERE bp.CompanyId = @CompanyId
		AND bp.[Date] BETWEEN DATEADD(MONTH, -6, @FromDate) AND @ToDate
		AND bp.Voided = 0
) x
GROUP BY x.[Year], x.Id, x.[Month]
ORDER BY x.[Year], x.Id
GO

