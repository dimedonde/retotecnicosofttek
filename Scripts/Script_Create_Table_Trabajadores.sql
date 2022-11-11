/****** Object:  Table [dbo].[Trabajadores]    Script Date: 2022-11-08 14:29:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Trabajadores](
	[Id] [int] NOT NULL,
	[Fecha] [char](8) NOT NULL,
	[NombreApellido] [varchar](50) NOT NULL,
	[Modalidad] [varchar](20) NOT NULL,
	[Horas] [int] NOT NULL,
	[TipoCambio] [decimal](10, 2) NOT NULL,
	[PagoSoles] [decimal](10, 2) NOT NULL,
	[PagoDolares] [decimal](10, 2) NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
