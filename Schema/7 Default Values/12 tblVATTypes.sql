SET IDENTITY_INSERT tblVATTypes ON

INSERT INTO tblVATTypes(Id, Code, Name, Rate, Active)
SELECT 1, 'VAT Inclusive', 'VAT Inclusive', 12, 1
	UNION ALL
SELECT 2, 'VAT Exclusive', 'VAT Exclusive', 12, 1
	UNION ALL
SELECT 3, 'Non VATable', 'Not VATable', 0, 1
	UNION ALL
SELECT 4, 'Zero Rated', 'Zero Rated', 0, 1

SET IDENTITY_INSERT tblVATTypes OFF
GO

