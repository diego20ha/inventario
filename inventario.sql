USE [master]
GO
/****** Object:  Database [inventario]    Script Date: 28/11/2016 02:47:29 p.m. ******/
CREATE DATABASE [inventario]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'inventario', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.INVENTARIO\MSSQL\DATA\inventario.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'inventario_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.INVENTARIO\MSSQL\DATA\inventario_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [inventario] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [inventario].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [inventario] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [inventario] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [inventario] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [inventario] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [inventario] SET ARITHABORT OFF 
GO
ALTER DATABASE [inventario] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [inventario] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [inventario] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [inventario] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [inventario] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [inventario] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [inventario] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [inventario] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [inventario] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [inventario] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [inventario] SET  ENABLE_BROKER 
GO
ALTER DATABASE [inventario] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [inventario] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [inventario] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [inventario] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [inventario] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [inventario] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [inventario] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [inventario] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [inventario] SET  MULTI_USER 
GO
ALTER DATABASE [inventario] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [inventario] SET DB_CHAINING OFF 
GO
ALTER DATABASE [inventario] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [inventario] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [inventario]
GO
/****** Object:  StoredProcedure [dbo].[getLastReciboEntradaID]    Script Date: 28/11/2016 02:47:34 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getLastReciboEntradaID]
AS   
BEGIN
	SELECT idreciboentrada FROM reciboEntrada WHERE idreciboentrada=(SELECT MAX(idreciboentrada) FROM reciboEntrada);
		
	if @@rowcount = 0
		return 1;
END

GO
/****** Object:  StoredProcedure [dbo].[getLastReciboSalidaID]    Script Date: 28/11/2016 02:47:34 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getLastReciboSalidaID]
AS   
BEGIN
	SELECT idrecibosalida FROM reciboSalida WHERE idrecibosalida=(SELECT MAX(idrecibosalida) FROM reciboSalida);
		
	if @@rowcount = 0
		return 1;
END

GO
/****** Object:  Table [dbo].[cliente]    Script Date: 28/11/2016 02:47:34 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cliente](
	[idcliente] [int] NOT NULL,
	[idusuario] [int] NOT NULL,
	[nombrecliente] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[entradaTarima]    Script Date: 28/11/2016 02:47:34 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[entradaTarima](
	[idtarimaentrada] [int] NOT NULL,
	[idreciboentrada] [int] NOT NULL,
	[peso] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idtarimaentrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[inventario]    Script Date: 28/11/2016 02:47:34 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[inventario](
	[idinventario] [int] NOT NULL,
	[idcliente] [int] NOT NULL,
	[nombreinventario] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idinventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ordenOrigen]    Script Date: 28/11/2016 02:47:34 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ordenOrigen](
	[idordenorigen] [int] NOT NULL,
	[tipoelemento] [varchar](45) NOT NULL,
	[idordentrabajo] [int] NOT NULL,
	[calidad] [varchar](45) NOT NULL,
	[cantidadsacos] [int] NULL,
	[pesoneto] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[idordenorigen] ASC,
	[tipoelemento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ordenResultado]    Script Date: 28/11/2016 02:47:34 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ordenResultado](
	[idordenresultados] [int] NOT NULL,
	[tipoelemento] [varchar](45) NOT NULL,
	[idordentrabajo] [int] NOT NULL,
	[calidad] [varchar](45) NOT NULL,
	[cantidadsacos] [int] NULL,
	[pesoneto] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[idordenresultados] ASC,
	[tipoelemento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ordenTrabajo]    Script Date: 28/11/2016 02:47:34 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ordenTrabajo](
	[idordentrabajo] [int] NOT NULL,
	[idinventario] [int] NOT NULL,
	[cliente] [varchar](45) NOT NULL,
	[fecha] [date] NOT NULL,
	[cantidadsacos] [int] NULL,
	[pesototal] [float] NULL,
	[observaciones] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[idordentrabajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[proceso]    Script Date: 28/11/2016 02:47:34 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proceso](
	[idproceso] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idproceso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[reciboEntrada]    Script Date: 28/11/2016 02:47:34 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[reciboEntrada](
	[idreciboentrada] [int] NOT NULL,
	[idinventario] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[calidad] [varchar](45) NOT NULL,
	[cantidadsacos] [int] NULL,
	[cliente] [varchar](25) NULL,
	[pesototalsacos] [float] NULL,
	[contrato] [varchar](45) NULL,
	[guia] [varchar](45) NULL,
	[placa] [varchar](45) NULL,
	[ubicacion] [int] NULL,
	[pesotarimasvacias] [float] NULL,
	[pesobruto] [float] NULL,
	[pesoneto] [float] NULL,
	[observaciones] [varchar](300) NULL,
	[pesototaltarimas] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[idreciboentrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[reciboEntradaSacos]    Script Date: 28/11/2016 02:47:34 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[reciboEntradaSacos](
	[idreciboentradasacos] [int] NOT NULL,
	[idreciboentrada] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[tipo] [varchar](45) NOT NULL,
	[tara] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idreciboentradasacos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[reciboSalida]    Script Date: 28/11/2016 02:47:34 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[reciboSalida](
	[idrecibosalida] [int] NOT NULL,
	[idinventario] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[cliente] [varchar](45) NOT NULL,
	[calidad] [varchar](45) NOT NULL,
	[cantidadsacos] [int] NULL,
	[contrato] [varchar](45) NULL,
	[guia] [varchar](45) NULL,
	[placa] [varchar](45) NULL,
	[ubicacion] [varchar](45) NULL,
	[pesototaltarimas] [float] NULL,
	[pesotarimasvacias] [float] NULL,
	[pesobruto] [float] NULL,
	[tarasacos] [float] NULL,
	[pesoneto] [float] NULL,
	[tiposaco] [varchar](45) NULL,
	[observaciones] [varchar](45) NULL,
	[pesototalsacos] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[idrecibosalida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[reciboSalidaOrigen]    Script Date: 28/11/2016 02:47:34 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[reciboSalidaOrigen](
	[idrecibosalidaorigin] [int] NOT NULL,
	[tipoelemento] [int] NOT NULL,
	[idrecibosalida] [int] NOT NULL,
	[calidad] [varchar](45) NOT NULL,
	[cantidadsacos] [int] NULL,
	[pesoneto] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[idrecibosalidaorigin] ASC,
	[tipoelemento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[reciboSalidaSacos]    Script Date: 28/11/2016 02:47:34 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[reciboSalidaSacos](
	[idrecibosalidasacos] [int] NOT NULL,
	[idrecibosalida] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[tipo] [varchar](45) NOT NULL,
	[tara] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idrecibosalidasacos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[rol]    Script Date: 28/11/2016 02:47:34 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[rol](
	[idrol] [int] NOT NULL,
	[nombre] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idrol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[salidaTarima]    Script Date: 28/11/2016 02:47:34 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[salidaTarima](
	[idtarimaSalida] [int] NOT NULL,
	[idrecibosalida] [int] NOT NULL,
	[peso] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idtarimaSalida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[usuario]    Script Date: 28/11/2016 02:47:34 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[idusuario] [int] NOT NULL,
	[idrol] [int] NOT NULL,
	[nombreusuario] [varchar](45) NOT NULL,
	[contrasena] [varchar](12) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD  CONSTRAINT [idusuario] FOREIGN KEY([idusuario])
REFERENCES [dbo].[usuario] ([idusuario])
GO
ALTER TABLE [dbo].[cliente] CHECK CONSTRAINT [idusuario]
GO
ALTER TABLE [dbo].[entradaTarima]  WITH CHECK ADD  CONSTRAINT [idreciboentradatarima] FOREIGN KEY([idreciboentrada])
REFERENCES [dbo].[reciboEntrada] ([idreciboentrada])
GO
ALTER TABLE [dbo].[entradaTarima] CHECK CONSTRAINT [idreciboentradatarima]
GO
ALTER TABLE [dbo].[inventario]  WITH CHECK ADD  CONSTRAINT [idcliente] FOREIGN KEY([idcliente])
REFERENCES [dbo].[cliente] ([idcliente])
GO
ALTER TABLE [dbo].[inventario] CHECK CONSTRAINT [idcliente]
GO
ALTER TABLE [dbo].[ordenOrigen]  WITH CHECK ADD  CONSTRAINT [idordentrabajo] FOREIGN KEY([idordentrabajo])
REFERENCES [dbo].[ordenTrabajo] ([idordentrabajo])
GO
ALTER TABLE [dbo].[ordenOrigen] CHECK CONSTRAINT [idordentrabajo]
GO
ALTER TABLE [dbo].[ordenResultado]  WITH CHECK ADD  CONSTRAINT [idordentrabajoresultado] FOREIGN KEY([idordentrabajo])
REFERENCES [dbo].[ordenTrabajo] ([idordentrabajo])
GO
ALTER TABLE [dbo].[ordenResultado] CHECK CONSTRAINT [idordentrabajoresultado]
GO
ALTER TABLE [dbo].[ordenTrabajo]  WITH CHECK ADD  CONSTRAINT [idinventarioorden] FOREIGN KEY([idinventario])
REFERENCES [dbo].[inventario] ([idinventario])
GO
ALTER TABLE [dbo].[ordenTrabajo] CHECK CONSTRAINT [idinventarioorden]
GO
ALTER TABLE [dbo].[reciboEntrada]  WITH CHECK ADD  CONSTRAINT [idinventarioentrada] FOREIGN KEY([idinventario])
REFERENCES [dbo].[inventario] ([idinventario])
GO
ALTER TABLE [dbo].[reciboEntrada] CHECK CONSTRAINT [idinventarioentrada]
GO
ALTER TABLE [dbo].[reciboEntradaSacos]  WITH CHECK ADD  CONSTRAINT [idreciboentradasacos] FOREIGN KEY([idreciboentrada])
REFERENCES [dbo].[reciboEntrada] ([idreciboentrada])
GO
ALTER TABLE [dbo].[reciboEntradaSacos] CHECK CONSTRAINT [idreciboentradasacos]
GO
ALTER TABLE [dbo].[reciboSalida]  WITH CHECK ADD  CONSTRAINT [idinventariosalida] FOREIGN KEY([idinventario])
REFERENCES [dbo].[inventario] ([idinventario])
GO
ALTER TABLE [dbo].[reciboSalida] CHECK CONSTRAINT [idinventariosalida]
GO
ALTER TABLE [dbo].[reciboSalidaOrigen]  WITH CHECK ADD  CONSTRAINT [idrecibosalida] FOREIGN KEY([idrecibosalidaorigin])
REFERENCES [dbo].[reciboSalida] ([idrecibosalida])
GO
ALTER TABLE [dbo].[reciboSalidaOrigen] CHECK CONSTRAINT [idrecibosalida]
GO
ALTER TABLE [dbo].[reciboSalidaSacos]  WITH CHECK ADD  CONSTRAINT [idrecibosalidasacos] FOREIGN KEY([idrecibosalida])
REFERENCES [dbo].[reciboSalida] ([idrecibosalida])
GO
ALTER TABLE [dbo].[reciboSalidaSacos] CHECK CONSTRAINT [idrecibosalidasacos]
GO
ALTER TABLE [dbo].[salidaTarima]  WITH CHECK ADD  CONSTRAINT [idrecibosalidatarima] FOREIGN KEY([idrecibosalida])
REFERENCES [dbo].[reciboSalida] ([idrecibosalida])
GO
ALTER TABLE [dbo].[salidaTarima] CHECK CONSTRAINT [idrecibosalidatarima]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [idrol] FOREIGN KEY([idrol])
REFERENCES [dbo].[rol] ([idrol])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [idrol]
GO
USE [master]
GO
ALTER DATABASE [inventario] SET  READ_WRITE 
GO
