USE BISystem
GO



SELECT
	c.*
FROM
	sys.tables t
	join sys.columns c on t.object_id = c.object_id
where t.name = 'webpages_UsersInRoles'



ALTER TABLE BISystem.dbo.webpages_Roles ADD role_description VARCHAR(1000);
ALTER TABLE BISystem.dbo.webpages_UsersInRoles ADD activated_by INT;
ALTER TABLE BISystem.dbo.webpages_UsersInRoles ADD date_Active DATETIME;
ALTER TABLE BISystem.dbo.webpages_UsersInRoles ADD deactivated_by INT;
ALTER TABLE BISystem.dbo.webpages_UsersInRoles ADD date_deactivated DATETIME;





/*
IF NOT EXISTS (SELECT 1 FROM dbo.Users)
	IF EXISTS (SELECT 1 FROM sys.tables t join sys.columns c on t.object_id=c.object_id and t.name = 'users' and c.name = 'email')
	    INSERT INTO dbo.Users (name,surname,username,email,manager_id)
		VALUES
		('andrei','gurguta','agurguta','andrei.gurguat@company.ie',null),
		('john','depp','jdepp','john.dep@company.ie',null);
*/