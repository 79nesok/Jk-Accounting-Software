IF OBJECT_ID('uspGetCheckDetails') IS NOT NULL
	DROP PROCEDURE uspGetCheckDetails
GO

CREATE PROCEDURE uspGetCheckDetails(@Id INT, @HasCheck BIT OUTPUT)
AS
SET NOCOUNT ON

SELECT '**' + s.Name + '**' AS Payee,
	bpd.CheckDate,
	bpd.CheckNo,
	'**' + CONVERT(VARCHAR, FORMAT(bpd.Amount,'#,###.00')) + '**' AS Amount,
	'**' + dbo.fnNumberToWords(bpd.Amount) + dbo.fnGetCenvato(bpd.Amount) + '**' AS AmountInWords
FROM tblBillsPayment bp
	INNER JOIN tblBillsPaymentDetails bpd ON bpd.BillsPaymentId = bp.Id
	INNER JOIN tblPaymentMethods pm ON pm.Id = bpd.PaymentMethodId
		AND pm.ForClearing = 1
	INNER JOIN tblSubsidiaries s ON s.Id = bp.SubsidiaryId
WHERE bp.Id = @Id

IF @@ROWCOUNT > 0
	SET @HasCheck = 1
ELSE
	SET @HasCheck = 0
GO

