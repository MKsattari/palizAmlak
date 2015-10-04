USE [AmlakMaskan]
GO
/****** Object:  User [ruser]    Script Date: 10/4/2015 3:45:06 PM ******/
DROP USER [ruser]
GO
/****** Object:  User [amlak]    Script Date: 10/4/2015 3:45:06 PM ******/
DROP USER [amlak]
GO
/****** Object:  User [amlak]    Script Date: 10/4/2015 3:45:06 PM ******/
CREATE USER [amlak] FOR LOGIN [amlak] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [ruser]    Script Date: 10/4/2015 3:45:06 PM ******/
CREATE USER [ruser] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [amlak]
GO
ALTER ROLE [db_owner] ADD MEMBER [ruser]
GO
