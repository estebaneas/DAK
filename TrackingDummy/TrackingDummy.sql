USE [TrackingDePaquetes]
GO
/****** Object:  Table [dbo].[Detalle]    Script Date: 03/12/2021 12:05:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle](
	[numero] [int] IDENTITY(1,1) NOT NULL,
	[TrackingId] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[detalle] [varchar](50) NULL,
 CONSTRAINT [PK_Detalle] PRIMARY KEY CLUSTERED 
(
	[numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tracking]    Script Date: 03/12/2021 12:05:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tracking](
	[numero] [varchar](50) NOT NULL,
	[latitud] [float] NULL,
	[longitud] [float] NULL,
	[IDTrack] [int] IDENTITY(1,1) NOT NULL,
	[estado] [int] NOT NULL,
 CONSTRAINT [PK_Tracking] PRIMARY KEY CLUSTERED 
(
	[IDTrack] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Detalle]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Tracking] FOREIGN KEY([TrackingId])
REFERENCES [dbo].[Tracking] ([IDTrack])
GO
ALTER TABLE [dbo].[Detalle] CHECK CONSTRAINT [FK_Detalle_Tracking]
GO
