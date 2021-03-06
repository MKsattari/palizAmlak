/*
** 020_StoredProcedures_Select.sql
**
** Create the stored procedures used 
** to select rows from the database
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
** Table: divar_dakli_glb
*/
-- gp_divar_dakli_glb_SelectAll
IF NOT EXISTS (SELECT name FROM sysobjects WHERE id = object_id('gp_divar_dakli_glb_SelectAll'))
BEGIN
	EXEC sp_ExecuteSQL N'CREATE PROCEDURE gp_divar_dakli_glb_SelectAll AS PRINT ''ALTER PROC will update this'''
END	
GO

-- gp_divar_dakli_glb_SelectByszh_idAnddivar_dakli_glb_id
IF NOT EXISTS (SELECT name FROM sysobjects WHERE id = object_id('gp_divar_dakli_glb_SelectByszh_idAnddivar_dakli_glb_id'))
BEGIN
	EXEC sp_ExecuteSQL N'CREATE PROCEDURE gp_divar_dakli_glb_SelectByszh_idAnddivar_dakli_glb_id AS PRINT ''ALTER PROC will update this'''
END	
GO
	
-- 
IF NOT EXISTS (SELECT name FROM sysobjects WHERE id = object_id('gp_divar_dakli_glb_SelectBydivar_dakli_glb_id'))
BEGIN
	EXEC sp_ExecuteSQL N'CREATE PROCEDURE gp_divar_dakli_glb_SelectBydivar_dakli_glb_id AS PRINT ''ALTER PROC will update this'''
END	
GO

/*
** Table: memari
*/
-- gp_memari_SelectAll
IF NOT EXISTS (SELECT name FROM sysobjects WHERE id = object_id('gp_memari_SelectAll'))
BEGIN
	EXEC sp_ExecuteSQL N'CREATE PROCEDURE gp_memari_SelectAll AS PRINT ''ALTER PROC will update this'''
END	
GO

-- gp_memari_SelectByMemariID
IF NOT EXISTS (SELECT name FROM sysobjects WHERE id = object_id('gp_memari_SelectByMemariID'))
BEGIN
	EXEC sp_ExecuteSQL N'CREATE PROCEDURE gp_memari_SelectByMemariID AS PRINT ''ALTER PROC will update this'''
END	
GO
	
/*
** Table: noe
*/
-- gp_noe_SelectAll
IF NOT EXISTS (SELECT name FROM sysobjects WHERE id = object_id('gp_noe_SelectAll'))
BEGIN
	EXEC sp_ExecuteSQL N'CREATE PROCEDURE gp_noe_SelectAll AS PRINT ''ALTER PROC will update this'''
END	
GO

-- gp_noe_SelectBynoe_id
IF NOT EXISTS (SELECT name FROM sysobjects WHERE id = object_id('gp_noe_SelectBynoe_id'))
BEGIN
	EXEC sp_ExecuteSQL N'CREATE PROCEDURE gp_noe_SelectBynoe_id AS PRINT ''ALTER PROC will update this'''
END	
GO
	
/*
** Table: sazeh
*/
-- gp_sazeh_SelectAll
IF NOT EXISTS (SELECT name FROM sysobjects WHERE id = object_id('gp_sazeh_SelectAll'))
BEGIN
	EXEC sp_ExecuteSQL N'CREATE PROCEDURE gp_sazeh_SelectAll AS PRINT ''ALTER PROC will update this'''
END	
GO

-- gp_sazeh_SelectByszh_id
IF NOT EXISTS (SELECT name FROM sysobjects WHERE id = object_id('gp_sazeh_SelectByszh_id'))
BEGIN
	EXEC sp_ExecuteSQL N'CREATE PROCEDURE gp_sazeh_SelectByszh_id AS PRINT ''ALTER PROC will update this'''
END	
GO
	
-- 
IF NOT EXISTS (SELECT name FROM sysobjects WHERE id = object_id('gp_sazeh_SelectByfndsion_noe_id'))
BEGIN
	EXEC sp_ExecuteSQL N'CREATE PROCEDURE gp_sazeh_SelectByfndsion_noe_id AS PRINT ''ALTER PROC will update this'''
END	
GO

-- 
IF NOT EXISTS (SELECT name FROM sysobjects WHERE id = object_id('gp_sazeh_SelectBysgf_noe_id'))
BEGIN
	EXEC sp_ExecuteSQL N'CREATE PROCEDURE gp_sazeh_SelectBysgf_noe_id AS PRINT ''ALTER PROC will update this'''
END	
GO

-- 
IF NOT EXISTS (SELECT name FROM sysobjects WHERE id = object_id('gp_sazeh_SelectBysklt_noe_id'))
BEGIN
	EXEC sp_ExecuteSQL N'CREATE PROCEDURE gp_sazeh_SelectBysklt_noe_id AS PRINT ''ALTER PROC will update this'''
END	
GO

-- 
IF NOT EXISTS (SELECT name FROM sysobjects WHERE id = object_id('gp_sazeh_SelectBydivar_karji_glb_id'))
BEGIN
	EXEC sp_ExecuteSQL N'CREATE PROCEDURE gp_sazeh_SelectBydivar_karji_glb_id AS PRINT ''ALTER PROC will update this'''
END	
GO

/*
**
** Create the stored procedures used 
** when selecting rows from the database
**
**
*/

/*
** gp_divar_dakli_glb_SelectAll
*/
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
ALTER PROCEDURE gp_divar_dakli_glb_SelectAll
AS
/*
** Select all rows from the divar_dakli_glb table
*/

SELECT 
	gv_divar_dakli_glb.*
FROM
	gv_divar_dakli_glb
ORDER BY
	[szh_id],
	[divar_dakli_glb_id]	

GO
PRINT 'gp_divar_dakli_glb_SelectAll updated'
GO

GRANT EXECUTE ON [gp_divar_dakli_glb_SelectAll] TO public
GO

/*
** gp_divar_dakli_glb_SelectByszh_idAnddivar_dakli_glb_id
*/
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
ALTER PROCEDURE gp_divar_dakli_glb_SelectByszh_idAnddivar_dakli_glb_id
(
	@szh_id int,
	@divar_dakli_glb_id int
)
AS
/*
** Select a row from the divar_dakli_glb table by primary key
*/

SELECT 
	gv_divar_dakli_glb.*
FROM
	gv_divar_dakli_glb
WHERE
	[szh_id] = @szh_id
	AND [divar_dakli_glb_id] = @divar_dakli_glb_id

GO
PRINT 'gp_divar_dakli_glb_SelectByszh_idAnddivar_dakli_glb_id updated'
GO


GRANT EXECUTE ON [gp_divar_dakli_glb_SelectByszh_idAnddivar_dakli_glb_id] TO public
GO


/*
** divar_dakli_glb_SelectBydivar_dakli_glb_id
*/
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
ALTER PROCEDURE divar_dakli_glb_SelectBydivar_dakli_glb_id
(
	@divar_dakli_glb_id int
)
AS
/*
** Select rows from the divar_dakli_glb table by divar_dakli_glb_id
*/
SELECT 
	gv_divar_dakli_glb.*
FROM
	gv_divar_dakli_glb
WHERE
	[divar_dakli_glb_id] = @divar_dakli_glb_id
ORDER BY
	[szh_id],
	[divar_dakli_glb_id]

GO
PRINT 'divar_dakli_glb_SelectBydivar_dakli_glb_id updated'
GO


GRANT EXECUTE ON [divar_dakli_glb_SelectBydivar_dakli_glb_id] TO public
GO

/*
** gp_memari_SelectAll
*/
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
ALTER PROCEDURE gp_memari_SelectAll
AS
/*
** Select all rows from the memari table
*/

SELECT 
	gv_memari.*
FROM
	gv_memari
ORDER BY
	[MemariID]	

GO
PRINT 'gp_memari_SelectAll updated'
GO

GRANT EXECUTE ON [gp_memari_SelectAll] TO public
GO

/*
** gp_memari_SelectByMemariID
*/
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
ALTER PROCEDURE gp_memari_SelectByMemariID
(
	@MemariID int
)
AS
/*
** Select a row from the memari table by primary key
*/

SELECT 
	gv_memari.*
FROM
	gv_memari
WHERE
	[MemariID] = @MemariID

GO
PRINT 'gp_memari_SelectByMemariID updated'
GO


GRANT EXECUTE ON [gp_memari_SelectByMemariID] TO public
GO

/*
** gp_noe_SelectAll
*/
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
ALTER PROCEDURE gp_noe_SelectAll
AS
/*
** Select all rows from the noe table
*/

SELECT 
	gv_noe.*
FROM
	gv_noe
ORDER BY
	[noe_id]	

GO
PRINT 'gp_noe_SelectAll updated'
GO

GRANT EXECUTE ON [gp_noe_SelectAll] TO public
GO

/*
** gp_noe_SelectBynoe_id
*/
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
ALTER PROCEDURE gp_noe_SelectBynoe_id
(
	@noe_id int
)
AS
/*
** Select a row from the noe table by primary key
*/

SELECT 
	gv_noe.*
FROM
	gv_noe
WHERE
	[noe_id] = @noe_id

GO
PRINT 'gp_noe_SelectBynoe_id updated'
GO


GRANT EXECUTE ON [gp_noe_SelectBynoe_id] TO public
GO

/*
** gp_sazeh_SelectAll
*/
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
ALTER PROCEDURE gp_sazeh_SelectAll
AS
/*
** Select all rows from the sazeh table
*/

SELECT 
	gv_sazeh.*
FROM
	gv_sazeh
ORDER BY
	[szh_id]	

GO
PRINT 'gp_sazeh_SelectAll updated'
GO

GRANT EXECUTE ON [gp_sazeh_SelectAll] TO public
GO

/*
** gp_sazeh_SelectByszh_id
*/
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
ALTER PROCEDURE gp_sazeh_SelectByszh_id
(
	@szh_id int
)
AS
/*
** Select a row from the sazeh table by primary key
*/

SELECT 
	gv_sazeh.*
FROM
	gv_sazeh
WHERE
	[szh_id] = @szh_id

GO
PRINT 'gp_sazeh_SelectByszh_id updated'
GO


GRANT EXECUTE ON [gp_sazeh_SelectByszh_id] TO public
GO


/*
** sazeh_SelectByfndsion_noe_id
*/
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
ALTER PROCEDURE sazeh_SelectByfndsion_noe_id
(
	@fndsion_noe_id int
)
AS
/*
** Select rows from the sazeh table by fndsion_noe_id
*/
SELECT 
	gv_sazeh.*
FROM
	gv_sazeh
WHERE
	[fndsion_noe_id] = @fndsion_noe_id
ORDER BY
	[szh_id]

GO
PRINT 'sazeh_SelectByfndsion_noe_id updated'
GO


GRANT EXECUTE ON [sazeh_SelectByfndsion_noe_id] TO public
GO


/*
** sazeh_SelectBysgf_noe_id
*/
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
ALTER PROCEDURE sazeh_SelectBysgf_noe_id
(
	@sgf_noe_id int
)
AS
/*
** Select rows from the sazeh table by sgf_noe_id
*/
SELECT 
	gv_sazeh.*
FROM
	gv_sazeh
WHERE
	[sgf_noe_id] = @sgf_noe_id
ORDER BY
	[szh_id]

GO
PRINT 'sazeh_SelectBysgf_noe_id updated'
GO


GRANT EXECUTE ON [sazeh_SelectBysgf_noe_id] TO public
GO


/*
** sazeh_SelectBysklt_noe_id
*/
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
ALTER PROCEDURE sazeh_SelectBysklt_noe_id
(
	@sklt_noe_id int
)
AS
/*
** Select rows from the sazeh table by sklt_noe_id
*/
SELECT 
	gv_sazeh.*
FROM
	gv_sazeh
WHERE
	[sklt_noe_id] = @sklt_noe_id
ORDER BY
	[szh_id]

GO
PRINT 'sazeh_SelectBysklt_noe_id updated'
GO


GRANT EXECUTE ON [sazeh_SelectBysklt_noe_id] TO public
GO


/*
** sazeh_SelectBydivar_karji_glb_id
*/
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
ALTER PROCEDURE sazeh_SelectBydivar_karji_glb_id
(
	@divar_karji_glb_id int
)
AS
/*
** Select rows from the sazeh table by divar_karji_glb_id
*/
SELECT 
	gv_sazeh.*
FROM
	gv_sazeh
WHERE
	[divar_karji_glb_id] = @divar_karji_glb_id
ORDER BY
	[szh_id]

GO
PRINT 'sazeh_SelectBydivar_karji_glb_id updated'
GO


GRANT EXECUTE ON [sazeh_SelectBydivar_karji_glb_id] TO public
GO
