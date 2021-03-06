/*
** 010_ViewsForStoredProcedures.sql
**
** Create the views that are used by
** the select stored procedures 
**
** This script was automatically generated by
** Rad Software NextGeneration
**
** http://www.radsoftware.com.au/
**
*/

/*
** Connect to the AmlakMaskan database
*/
USE [AmlakMaskan]
GO

	
/*
** Create gv_divar_dakli_glb
*/
IF NOT EXISTS (SELECT name FROM sysobjects WHERE id = object_id('gv_divar_dakli_glb'))
BEGIN
	EXEC sp_ExecuteSQL N'CREATE VIEW gv_divar_dakli_glb AS SELECT ''ALTER VIEW will update this'' AS col'
END	
GO

	
/*
** Create gv_memari
*/
IF NOT EXISTS (SELECT name FROM sysobjects WHERE id = object_id('gv_memari'))
BEGIN
	EXEC sp_ExecuteSQL N'CREATE VIEW gv_memari AS SELECT ''ALTER VIEW will update this'' AS col'
END	
GO

	
/*
** Create gv_noe
*/
IF NOT EXISTS (SELECT name FROM sysobjects WHERE id = object_id('gv_noe'))
BEGIN
	EXEC sp_ExecuteSQL N'CREATE VIEW gv_noe AS SELECT ''ALTER VIEW will update this'' AS col'
END	
GO

	
/*
** Create gv_sazeh
*/
IF NOT EXISTS (SELECT name FROM sysobjects WHERE id = object_id('gv_sazeh'))
BEGIN
	EXEC sp_ExecuteSQL N'CREATE VIEW gv_sazeh AS SELECT ''ALTER VIEW will update this'' AS col'
END	
GO

	
/*
**
** Create the views used by the 
** select stored procedures 
**
**
*/

/*
** gv_divar_dakli_glb
*/
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
ALTER VIEW gv_divar_dakli_glb
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
PRINT 'gv_divar_dakli_glb updated'
GO

GRANT SELECT ON [gv_divar_dakli_glb] TO public
GO


/*
** gv_memari
*/
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
ALTER VIEW gv_memari
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
PRINT 'gv_memari updated'
GO

GRANT SELECT ON [gv_memari] TO public
GO


/*
** gv_noe
*/
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
ALTER VIEW gv_noe
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
PRINT 'gv_noe updated'
GO

GRANT SELECT ON [gv_noe] TO public
GO


/*
** gv_sazeh
*/
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
ALTER VIEW gv_sazeh
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
PRINT 'gv_sazeh updated'
GO

GRANT SELECT ON [gv_sazeh] TO public
GO
