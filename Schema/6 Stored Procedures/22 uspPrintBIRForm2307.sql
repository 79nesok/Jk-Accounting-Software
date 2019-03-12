IF OBJECT_ID('uspPrintBIRForm2307') IS NOT NULL
	DROP PROCEDURE uspPrintBIRForm2307
GO

CREATE PROCEDURE uspPrintBIRForm2307(@Id INT, @Result BIT OUTPUT)
AS
SET NOCOUNT ON

IF EXISTS(
	SELECT *
	FROM tblBillsPaymentDetails bpd
		INNER JOIN tblPaymentMethods pm ON pm.Id = bpd.PaymentMethodId
		INNER JOIN tblAccounts a ON a.Id = pm.AccountId
		INNER JOIN tblSystemAccountCodes sac ON sac.Id = a.SystemAccountCodeId
	WHERE bpd.BillsPaymentId = @Id
		AND a.Name = 'WITHHOLDING TAX PAYABLE'
)
	SET @Result = 1
ELSE
	SET @Result = 0
GO

