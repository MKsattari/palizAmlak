/*
** 030_StoredProcedures_Insert.sql
**
** Create the stored procedures used 
** when adding new rows to the database
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
** Create gp_divar_dakli_glb_Insert
*/
IF NOT EXISTS (SELECT name FROM sysobjects WHERE id = object_id('gp_divar_dakli_glb_Insert'))
BEGIN
	EXEC sp_ExecuteSQL N'CREATE PROCEDURE gp_divar_dakli_glb_Insert AS PRINT ''ALTER PROC will update this'''
END	
GO
	
/*
** Create gp_memari_Insert
*/
IF NOT EXISTS (SELECT name FROM sysobjects WHERE id = object_id('gp_memari_Insert'))
BEGIN
	EXEC sp_ExecuteSQL N'CREATE PROCEDURE gp_memari_Insert AS PRINT ''ALTER PROC will update this'''
END	
GO
	
/*
** Create gp_noe_Insert
*/
IF NOT EXISTS (SELECT name FROM sysobjects WHERE id = object_id('gp_noe_Insert'))
BEGIN
	EXEC sp_ExecuteSQL N'CREATE PROCEDURE gp_noe_Insert AS PRINT ''ALTER PROC will update this'''
END	
GO
	
/*
** Create gp_sazeh_Insert
*/
IF NOT EXISTS (SELECT name FROM sysobjects WHERE id = object_id('gp_sazeh_Insert'))
BEGIN
	EXEC sp_ExecuteSQL N'CREATE PROCEDURE gp_sazeh_Insert AS PRINT ''ALTER PROC will update this'''
END	
GO
	
/*
**
** Create the stored procedures used 
** when adding new rows to the database
**
**
*/

/*
** gp_divar_dakli_glb_Insert
*/
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
ALTER PROCEDURE gp_divar_dakli_glb_Insert
(
	@szh_id int,
	@divar_dakli_glb_id int
)
AS
/*
** Add a row to the divar_dakli_glb table
*/

INSERT INTO [divar_dakli_glb]
(
	 [szh_id]
	,[divar_dakli_glb_id]
)
VALUES
(
	 @szh_id
	,@divar_dakli_glb_id
)

/*
** Select the new row
*/
SELECT
	gv_divar_dakli_glb.*
FROM
	gv_divar_dakli_glb
WHERE
	[szh_id] = @szh_id
	AND [divar_dakli_glb_id] = @divar_dakli_glb_id

GO
PRINT 'gp_divar_dakli_glb_Insert updated'
GO


GRANT EXECUTE ON [gp_divar_dakli_glb_Insert] TO public
GO

/*
** gp_memari_Insert
*/
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
ALTER PROCEDURE gp_memari_Insert
(
	@MemariID int OUTPUT, -- the automatically generated value will be returned as an output parameter
	@ReshtehID int,
	@ModiriatID int,
	@ShahrestanID int
)
AS
/*
** Add a row to the memari table
*/

INSERT INTO [memari]
(
	 [ReshtehID]
	,[ModiriatID]
	,[ShahrestanID]
)
VALUES
(
	 @ReshtehID
	,@ModiriatID
	,@ShahrestanID
)

SET @MemariID = (SELECT SCOPE_IDENTITY())

/*
** Select the new row
*/
SELECT
	gv_memari.*
FROM
	gv_memari
WHERE
	[MemariID] = @MemariID

GO
PRINT 'gp_memari_Insert updated'
GO


GRANT EXECUTE ON [gp_memari_Insert] TO public
GO

/*
** gp_noe_Insert
*/
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
ALTER PROCEDURE gp_noe_Insert
(
	@noe_id int,
	@noe_nam nvarchar(200),
	@noe_cls nvarchar(50),
	@noe_tozi nvarchar(200)
)
AS
/*
** Add a row to the noe table
*/

INSERT INTO [noe]
(
	 [noe_id]
	,[noe_nam]
	,[noe_cls]
	,[noe_tozi]
)
VALUES
(
	 @noe_id
	,@noe_nam
	,@noe_cls
	,@noe_tozi
)

/*
** Select the new row
*/
SELECT
	gv_noe.*
FROM
	gv_noe
WHERE
	[noe_id] = @noe_id

GO
PRINT 'gp_noe_Insert updated'
GO


GRANT EXECUTE ON [gp_noe_Insert] TO public
GO

/*
** gp_sazeh_Insert
*/
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
ALTER PROCEDURE gp_sazeh_Insert
(
	@szh_id int OUTPUT, -- the automatically generated value will be returned as an output parameter
	@mlk_id int,
	@rsht_id int,
	@modirt_id int,
	@shrstan_id int,
	@shobh_id nchar(10),
	@fndsion_noe_id int,
	@fndsion_tozi varchar(max),
	@sgf_noe_id int,
	@sgf_sayr varchar(200),
	@sgf_tozi varchar(max),
	@sklt_noe_id int,
	@sklt_tozi varchar(200),
	@sklt_sayr varchar(max),
	@divar_karji_glb_id int,
	@divar_dakli_glb_partition bit,
	@divar_dakli_glb_simani bit,
	@divar_dakli_glb_lika bit,
	@divar_dakli_glb_hblx bit,
	@divar_dakli_glb_sofali bit,
	@divar_dakli_glb_poma bit,
	@divar_dakli_glb_ajor bit,
	@divar_dakli_glb_drywall bit,
	@divar_dakli_glb_sayer bit,
	@divar_dakli_glb_sayer_val nvarchar(200),
	@divar_dakli_glb_tozi int,
	@thvil_tarikh char(10),
	@thvil_krshnas int
)
AS
/*
** Add a row to the sazeh table
*/

INSERT INTO [sazeh]
(
	 [mlk_id]
	,[rsht_id]
	,[modirt_id]
	,[shrstan_id]
	,[shobh_id]
	,[fndsion_noe_id]
	,[fndsion_tozi]
	,[sgf_noe_id]
	,[sgf_sayr]
	,[sgf_tozi]
	,[sklt_noe_id]
	,[sklt_tozi]
	,[sklt_sayr]
	,[divar_karji_glb_id]
	,[divar_dakli_glb_partition]
	,[divar_dakli_glb_simani]
	,[divar_dakli_glb_lika]
	,[divar_dakli_glb_hblx]
	,[divar_dakli_glb_sofali]
	,[divar_dakli_glb_poma]
	,[divar_dakli_glb_ajor]
	,[divar_dakli_glb_drywall]
	,[divar_dakli_glb_sayer]
	,[divar_dakli_glb_sayer_val]
	,[divar_dakli_glb_tozi]
	,[thvil_tarikh]
	,[thvil_krshnas]
)
VALUES
(
	 @mlk_id
	,@rsht_id
	,@modirt_id
	,@shrstan_id
	,@shobh_id
	,@fndsion_noe_id
	,@fndsion_tozi
	,@sgf_noe_id
	,@sgf_sayr
	,@sgf_tozi
	,@sklt_noe_id
	,@sklt_tozi
	,@sklt_sayr
	,@divar_karji_glb_id
	,@divar_dakli_glb_partition
	,@divar_dakli_glb_simani
	,@divar_dakli_glb_lika
	,@divar_dakli_glb_hblx
	,@divar_dakli_glb_sofali
	,@divar_dakli_glb_poma
	,@divar_dakli_glb_ajor
	,@divar_dakli_glb_drywall
	,@divar_dakli_glb_sayer
	,@divar_dakli_glb_sayer_val
	,@divar_dakli_glb_tozi
	,@thvil_tarikh
	,@thvil_krshnas
)

SET @szh_id = (SELECT SCOPE_IDENTITY())

/*
** Select the new row
*/
SELECT
	gv_sazeh.*
FROM
	gv_sazeh
WHERE
	[szh_id] = @szh_id

GO
PRINT 'gp_sazeh_Insert updated'
GO


GRANT EXECUTE ON [gp_sazeh_Insert] TO public
GO
