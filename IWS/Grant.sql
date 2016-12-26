USE [master]
GO

/****** Object:  Login [IIS APPPOOL\DefaultAppPool]    Script Date: 10/22/2016 3:03:12 AM ******/
CREATE LOGIN [IIS APPPOOL\DefaultAppPool] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO

ALTER SERVER ROLE [sysadmin] ADD MEMBER [IIS APPPOOL\DefaultAppPool]
GO
