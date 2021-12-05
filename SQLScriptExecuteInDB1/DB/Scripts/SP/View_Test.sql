PRINT 'CREATING Views'
GO

CREATE VIEW UsersView
AS
SELECT * FROM [UserRegistrations].[Users]
GO

PRINT 'CREATING UsersView'
GO

CREATE VIEW UsersView1
AS
SELECT * FROM [UserRegistrations].[Users]
GO

PRINT 'CREATING UsersView1'
GO

CREATE VIEW UsersView2
AS
SELECT * FROM [UserRegistrations].[Users]
GO

PRINT 'CREATING UsersView2'
GO

CREATE PROCEDURE UserProc
AS
SELECT * FROM [UserRegistrations].[Users]
GO

PRINT 'CREATING UserProc'
GO
