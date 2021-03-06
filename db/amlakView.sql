USE [AmlakMaskan]
GO
/****** Object:  View [dbo].[gv_sazeh]    Script Date: 10/4/2015 3:46:30 PM ******/
DROP VIEW [dbo].[gv_sazeh]
GO
/****** Object:  View [dbo].[gv_noe]    Script Date: 10/4/2015 3:46:30 PM ******/
DROP VIEW [dbo].[gv_noe]
GO
/****** Object:  View [dbo].[gv_memari]    Script Date: 10/4/2015 3:46:30 PM ******/
DROP VIEW [dbo].[gv_memari]
GO
/****** Object:  View [dbo].[gv_divar_dakli_glb]    Script Date: 10/4/2015 3:46:30 PM ******/
DROP VIEW [dbo].[gv_divar_dakli_glb]
GO
/****** Object:  View [dbo].[gv_divar_dakli_glb]    Script Date: 10/4/2015 3:46:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[gv_divar_dakli_glb]
AS
/*
** Select all rows from the divar_dakli_glb table
** and the lookup expressions defined for associated tables
*/

SELECT 
	[divar_dakli_glb].*
FROM
	[divar_dakli_glb]



GO
/****** Object:  View [dbo].[gv_memari]    Script Date: 10/4/2015 3:46:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[gv_memari]
AS
/*
** Select all rows from the memari table
** and the lookup expressions defined for associated tables
*/

SELECT 
	[memari].*
FROM
	[memari]



GO
/****** Object:  View [dbo].[gv_noe]    Script Date: 10/4/2015 3:46:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[gv_noe]
AS
/*
** Select all rows from the noe table
** and the lookup expressions defined for associated tables
*/

SELECT 
	[noe].*
FROM
	[noe]



GO
/****** Object:  View [dbo].[gv_sazeh]    Script Date: 10/4/2015 3:46:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[gv_sazeh]
AS
/*
** Select all rows from the sazeh table
** and the lookup expressions defined for associated tables
*/

SELECT 
	[sazeh].*
FROM
	[sazeh]



GO
