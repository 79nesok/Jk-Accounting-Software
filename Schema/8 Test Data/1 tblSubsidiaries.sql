DECLARE @tmp TABLE(Id INT)

WHILE((SELECT COUNT(*) FROM @tmp) < 100)
BEGIN
	INSERT INTO @tmp(Id)
	SELECT ISNULL(MAX(Id), 0) + 1
	FROM @tmp
END

INSERT INTO tblSubsidiaries(CompanyId, SubsidiaryTypeId,
	Code, Name,
	Active, CreatedById, DateCreated, ModifiedById, DateModified)
SELECT 1, st.Id,
	CASE WHEN RIGHT(st.Name, 1) = 's' THEN LEFT(st.Name, LEN(st.Name) - 1) ELSE st.Name END + ' ' + RIGHT('00' + CAST(t.Id AS VARCHAR), 3),
	CASE WHEN RIGHT(st.Name, 1) = 's' THEN LEFT(st.Name, LEN(st.Name) - 1) ELSE st.Name END + ' ' + RIGHT('00' + CAST(t.Id AS VARCHAR), 3),
	CASE WHEN CHECKSUM(NEWID()) % 2 = 1 THEN 1 ELSE 0 END, 1, GETDATE(), 1, GETDATE()
FROM tblSubsidiaryTypes st
	CROSS JOIN @tmp t
GO

