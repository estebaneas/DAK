USE [DAK_TRACKING]
GO
/****** Object:  Table [dbo].[DetalleTracking]    Script Date: 03/12/2021 12:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleTracking](
	[Numero] [int] NOT NULL,
	[Detalle] [varchar](200) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[NumeroTrackign] [varchar](50) NOT NULL,
 CONSTRAINT [PK_DetalleTracking] PRIMARY KEY CLUSTERED 
(
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tracking]    Script Date: 03/12/2021 12:04:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tracking](
	[NumeroTracking] [varchar](50) NOT NULL,
	[UlrimaActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_Tracking] PRIMARY KEY CLUSTERED 
(
	[NumeroTracking] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DetalleTracking]  WITH CHECK ADD  CONSTRAINT [FK_DetalleTracking_Tracking] FOREIGN KEY([NumeroTrackign])
REFERENCES [dbo].[Tracking] ([NumeroTracking])
GO
ALTER TABLE [dbo].[DetalleTracking] CHECK CONSTRAINT [FK_DetalleTracking_Tracking]
GO
