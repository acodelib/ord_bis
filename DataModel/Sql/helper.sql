USE BISystem
GO


SELECT
	c.*
FROM
	sys.tables t
	join sys.columns c on t.object_id = c.object_id
where t.name = 'accessrequests'




/*
IF NOT EXISTS (SELECT 1 FROM dbo.Users)
	IF EXISTS (SELECT 1 FROM sys.tables t join sys.columns c on t.object_id=c.object_id and t.name = 'users' and c.name = 'email')
	    INSERT INTO dbo.Users (name,surname,username,email,manager_id)
		VALUES
		('andrei','gurguta','agurguta','andrei.gurguat@company.ie',null),
		('john','depp','jdepp','john.dep@company.ie',null);
*/