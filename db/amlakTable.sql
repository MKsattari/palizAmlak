USE [AmlakMaskan]
GO
/****** Object:  Table [dbo].[divar_dakli_glb]    Script Date: 10/4/2015 3:35:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[divar_dakli_glb](
	[szh_id] [int] NOT NULL,
	[divar_dakli_glb_id] [int] NOT NULL,
 CONSTRAINT [PK_divar_dakli_glb] PRIMARY KEY CLUSTERED 
(
	[szh_id] ASC,
	[divar_dakli_glb_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[memari]    Script Date: 10/4/2015 3:35:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[memari](
	[memari_id] [int] IDENTITY(1,1) NOT NULL,
	[mlk_id] [int] NOT NULL,
	[krbri_edari] [bit] NULL,
	[krbri_shobh] [bit] NULL,
	[krbri_mhman_sara] [bit] NULL,
	[krbri_maskoni] [bit] NULL,
	[krbri_amozshi] [bit] NULL,
	[krbri_parking] [bit] NULL,
	[krbri_vrzshi] [bit] NULL,
	[krbri_rstoran] [bit] NULL,
	[krbri_sayer] [bit] NULL,
	[krbri_sayer_val] [nvarchar](200) NULL,
	[msaht_kol_ayani] [int] NOT NULL,
	[mshat_zmin_arse] [int] NOT NULL,
	[mshat_karbri_shobh] [int] NOT NULL,
	[mshat_karbri_mskoni] [int] NOT NULL,
	[mshat_karbri_mhman_sara] [int] NOT NULL,
	[mshat_karbri_amozshi] [int] NOT NULL,
	[mshat_karbri_edari] [int] NOT NULL,
	[mshat_karbri_khzanh] [int] NOT NULL,
	[mshat_karbri_sndogh] [int] NOT NULL,
	[mshat_karbri_khzanh2] [int] NOT NULL,
	[mshat_karbri_baygani] [int] NOT NULL,
	[mshat_karbri_anbar] [int] NOT NULL,
	[mshat_karbri_motor_khanh] [int] NOT NULL,
	[mshat_karbri_edari22] [int] NOT NULL,
	[mshat_karbri_varzshi] [int] NOT NULL,
	[mshat_karbri_rstoran] [int] NOT NULL,
	[mshat_karbri_parking] [int] NOT NULL,
	[mshat_karbri_abdar_khanh] [int] NOT NULL,
	[mshat_karbri_nmaz_khanh] [int] NOT NULL,
	[mshat_karbri_tel_khanh] [int] NOT NULL,
	[mshat_karbri_tablo_brgh] [int] NOT NULL,
	[mshat_karbri_otagh_dizl] [int] NOT NULL,
	[mshat_karbri_mshaat] [int] NOT NULL,
	[mshat_karbri_tozi] [nvarchar](max) NULL,
	[tol_sakhtman_bar] [int] NOT NULL,
	[arz_sakhtman] [int] NOT NULL,
	[tdad_kol_tbghat] [int] NULL,
	[tdad_tbghat_ekhtiar_bank] [int] NULL,
 CONSTRAINT [PK_memari_1] PRIMARY KEY CLUSTERED 
(
	[memari_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[noe]    Script Date: 10/4/2015 3:35:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[noe](
	[noe_id] [int] NOT NULL,
	[noe_nam] [nvarchar](200) NOT NULL,
	[noe_cls] [nvarchar](50) NOT NULL,
	[noe_tozi] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_noe] PRIMARY KEY CLUSTERED 
(
	[noe_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sazeh]    Script Date: 10/4/2015 3:35:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sazeh](
	[szh_id] [int] IDENTITY(1,1) NOT NULL,
	[mlk_id] [int] NULL,
	[rsht_id] [int] NOT NULL,
	[modirt_id] [int] NOT NULL,
	[shrstan_id] [int] NOT NULL,
	[shobh_id] [nchar](10) NULL,
	[fndsion_noe_id] [int] NOT NULL,
	[fndsion_tozi] [varchar](max) NULL,
	[sgf_noe_id] [int] NOT NULL,
	[sgf_sayr] [varchar](200) NULL,
	[sgf_tozi] [varchar](max) NULL,
	[sklt_noe_id] [int] NOT NULL,
	[sklt_tozi] [varchar](200) NULL,
	[sklt_sayr] [varchar](max) NULL,
	[divar_karji_glb_id] [int] NOT NULL,
	[divar_dakli_glb_partition] [bit] NULL,
	[divar_dakli_glb_simani] [bit] NULL,
	[divar_dakli_glb_lika] [bit] NULL,
	[divar_dakli_glb_hblx] [bit] NULL,
	[divar_dakli_glb_sofali] [bit] NULL,
	[divar_dakli_glb_poma] [bit] NULL,
	[divar_dakli_glb_ajor] [bit] NULL,
	[divar_dakli_glb_drywall] [bit] NULL,
	[divar_dakli_glb_sayer] [bit] NULL,
	[divar_dakli_glb_sayer_val] [nvarchar](200) NULL,
	[divar_dakli_glb_tozi] [int] NULL,
	[thvil_tarikh] [char](10) NOT NULL,
	[thvil_krshnas] [int] NOT NULL,
 CONSTRAINT [PK_sazeh] PRIMARY KEY CLUSTERED 
(
	[szh_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[divar_dakli_glb]  WITH CHECK ADD  CONSTRAINT [FK_divar_dakli_glb_noe] FOREIGN KEY([divar_dakli_glb_id])
REFERENCES [dbo].[noe] ([noe_id])
GO
ALTER TABLE [dbo].[divar_dakli_glb] CHECK CONSTRAINT [FK_divar_dakli_glb_noe]
GO
ALTER TABLE [dbo].[sazeh]  WITH CHECK ADD  CONSTRAINT [FK_sazeh_noe] FOREIGN KEY([fndsion_noe_id])
REFERENCES [dbo].[noe] ([noe_id])
GO
ALTER TABLE [dbo].[sazeh] CHECK CONSTRAINT [FK_sazeh_noe]
GO
ALTER TABLE [dbo].[sazeh]  WITH CHECK ADD  CONSTRAINT [FK_sazeh_noe1] FOREIGN KEY([sgf_noe_id])
REFERENCES [dbo].[noe] ([noe_id])
GO
ALTER TABLE [dbo].[sazeh] CHECK CONSTRAINT [FK_sazeh_noe1]
GO
ALTER TABLE [dbo].[sazeh]  WITH CHECK ADD  CONSTRAINT [FK_sazeh_noe2] FOREIGN KEY([sklt_noe_id])
REFERENCES [dbo].[noe] ([noe_id])
GO
ALTER TABLE [dbo].[sazeh] CHECK CONSTRAINT [FK_sazeh_noe2]
GO
ALTER TABLE [dbo].[sazeh]  WITH CHECK ADD  CONSTRAINT [FK_sazeh_noe3] FOREIGN KEY([divar_karji_glb_id])
REFERENCES [dbo].[noe] ([noe_id])
GO
ALTER TABLE [dbo].[sazeh] CHECK CONSTRAINT [FK_sazeh_noe3]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'شناسه سیستمی سازه ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sazeh', @level2type=N'COLUMN',@level2name=N'szh_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'شناسه ملک' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sazeh', @level2type=N'COLUMN',@level2name=N'mlk_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'شناسه رشته ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sazeh', @level2type=N'COLUMN',@level2name=N'rsht_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'کد مدیریت استان -منطقه' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sazeh', @level2type=N'COLUMN',@level2name=N'modirt_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'کدشهرستان' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sazeh', @level2type=N'COLUMN',@level2name=N'shrstan_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'کدشعبه /ساختمان' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sazeh', @level2type=N'COLUMN',@level2name=N'shobh_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'نوع فونداسیون' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sazeh', @level2type=N'COLUMN',@level2name=N'fndsion_noe_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'توضیحات ضروری فونداسیون' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sazeh', @level2type=N'COLUMN',@level2name=N'fndsion_tozi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'نوع سقف سازه ای ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sazeh', @level2type=N'COLUMN',@level2name=N'sgf_noe_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'سقف سایر' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sazeh', @level2type=N'COLUMN',@level2name=N'sgf_sayr'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'توضیحات ضروری سقف' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sazeh', @level2type=N'COLUMN',@level2name=N'sgf_tozi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'نوع اسکلت' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sazeh', @level2type=N'COLUMN',@level2name=N'sklt_noe_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'اسکلت -توضیحات ضروری' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sazeh', @level2type=N'COLUMN',@level2name=N'sklt_tozi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'اسکلت سایر' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sazeh', @level2type=N'COLUMN',@level2name=N'sklt_sayr'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'دیوار خارجی غالب ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sazeh', @level2type=N'COLUMN',@level2name=N'divar_karji_glb_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'توضیحات دیوار داخلی غالب ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sazeh', @level2type=N'COLUMN',@level2name=N'divar_dakli_glb_tozi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'تاریخ تهیه' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sazeh', @level2type=N'COLUMN',@level2name=N'thvil_tarikh'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'کارشناس تحویل' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sazeh', @level2type=N'COLUMN',@level2name=N'thvil_krshnas'
GO
