IF OBJECT_ID('uspBIRForm2307Details') IS NOT NULL
	DROP PROCEDURE uspBIRForm2307Details
GO

CREATE PROCEDURE uspBIRForm2307Details(@Id INT)
AS
SET NOCOUNT ON

SELECT DISTINCT bd.Id, i.Name AS IncomePaymentsSubjToWTAX,
	atc.Code AS ATC,
	CASE WHEN MONTH(bp.[Date]) % 3 = 1 THEN bd.GrossAmount ELSE 0 END AS FirstMonth,
	CASE WHEN MONTH(bp.[Date]) % 3 = 2 THEN bd.GrossAmount ELSE 0 END AS SecondMonth,
	CASE WHEN MONTH(bp.[Date]) % 3 = 0 THEN bd.GrossAmount ELSE 0 END AS ThirdMonth,
	bd.GrossAmount AS Total,
	bd.WithholdingTax AS TaxWithheld
FROM tblBillsPayment bp
	INNER JOIN tblBillsPaymentDetails bpd ON bpd.BillsPaymentId = bp.Id
	INNER JOIN tblPaymentMethods pm ON pm.Id = bpd.PaymentMethodId
	INNER JOIN tblAccounts a ON a.Id = pm.AccountId
	--INNER JOIN tblSystemAccountCodes sac ON sac.Id = a.SystemAccountCodeId
		--AND sac.Code = 'WITHHOLDING TAX PAYABLE'
	INNER JOIN tblBillsPaymentBillDetails bpbd ON bpbd.BillsPaymentId = bp.Id
	INNER JOIN tblBillDetails bd ON bd.BillId = bpbd.SourceId
		AND bd.WithholdingTax > 0
	INNER JOIN tblItems i ON i.Id = bd.ItemId
	INNER JOIN tblAlphaNumericTaxCodes atc ON atc.Id = bd.ATCId
WHERE bp.Id = @Id
GO

