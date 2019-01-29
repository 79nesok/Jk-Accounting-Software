SET IDENTITY_INSERT tblSecurityUsers ON

INSERT INTO tblSecurityUsers(Id, UserName, [Password], FirstName, LastName,
	CreatedById, DateCreated, ModifiedById, DateModified)
SELECT 1, 'Systems Developer', '0', 'Systems', 'Developer',
	1, GETDATE(), 1, GETDATE()

SET IDENTITY_INSERT tblSecurityUsers OFF
GO

