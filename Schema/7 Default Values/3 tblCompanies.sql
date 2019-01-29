SET IDENTITY_INSERT tblCompanies ON

INSERT INTO tblCompanies(Id, Code, Name,
	CreatedById, DateCreated, ModifiedById, DateModified)
SELECT 1, 'Company 001', 'Company 001',
	1, GETDATE(), 1, GETDATE()

SET IDENTITY_INSERT tblCompanies OFF
GO

