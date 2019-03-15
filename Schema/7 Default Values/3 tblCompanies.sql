SET IDENTITY_INSERT tblCompanies ON

INSERT INTO tblCompanies(Id, Code, Name, [Address],
	CreatedById, DateCreated, ModifiedById, DateModified)
SELECT 1, 'Company 001', 'Company 001', 'J.P. Ramoy Street, Brgy. Addition Hills, Quezon City',
	1, GETDATE(), 1, GETDATE()

SET IDENTITY_INSERT tblCompanies OFF
GO

