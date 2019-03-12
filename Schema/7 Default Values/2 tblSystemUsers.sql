SET IDENTITY_INSERT tblSystemUsers ON

INSERT INTO tblSystemUsers(Id, UserName, [Password], FirstName, LastName,
	CreatedById, DateCreated, ModifiedById, DateModified)
SELECT 1, 'Systems Developer', '0', 'Systems', 'Developer',
	1, GETDATE(), 1, GETDATE()

SET IDENTITY_INSERT tblSystemUsers OFF
GO

