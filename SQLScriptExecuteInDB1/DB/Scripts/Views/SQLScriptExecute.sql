

IF OBJECT_ID('dbo.UsersView', 'V') IS NOT NULL
BEGIN
	DROP VIEW dbo.UsersView
END
GO

IF OBJECT_ID('dbo.UsersView1', 'V') IS NOT NULL
BEGIN
	DROP VIEW dbo.UsersView1
END
GO

IF OBJECT_ID('dbo.UsersView2', 'V') IS NOT NULL
BEGIN
	DROP VIEW dbo.UsersView2
END
GO

IF OBJECT_ID('dbo.UserProc') IS NOT NULL
BEGIN
	DROP PROCEDURE dbo.UserProc
END
GO

:On Error exit

:r c:\View_Test.sql

GO

