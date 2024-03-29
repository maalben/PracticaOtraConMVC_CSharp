USE [master]
GO
CREATE DATABASE [bdolimpiadas] ON  PRIMARY 
( NAME = N'bdolimpiadas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\bdolimpiadas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'bdolimpiadas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\bdolimpiadas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bdolimpiadas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bdolimpiadas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bdolimpiadas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bdolimpiadas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bdolimpiadas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bdolimpiadas] SET ARITHABORT OFF 
GO
ALTER DATABASE [bdolimpiadas] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [bdolimpiadas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bdolimpiadas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bdolimpiadas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bdolimpiadas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bdolimpiadas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bdolimpiadas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bdolimpiadas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bdolimpiadas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bdolimpiadas] SET  ENABLE_BROKER 
GO
ALTER DATABASE [bdolimpiadas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bdolimpiadas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bdolimpiadas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bdolimpiadas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bdolimpiadas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bdolimpiadas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bdolimpiadas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bdolimpiadas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [bdolimpiadas] SET  MULTI_USER 
GO
ALTER DATABASE [bdolimpiadas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bdolimpiadas] SET DB_CHAINING OFF 
GO
USE [bdolimpiadas]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tblmarcaciones](
	[idmodalidad] [int] NOT NULL,
	[idpais] [int] NOT NULL,
	[idposicion] [int] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tblmodalidades](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tblpaises](
	[idpais] [int] IDENTITY(1,1) NOT NULL,
	[nombrepais] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idpais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tblposicion](
	[idposicion] [tinyint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](10) NOT NULL,
 CONSTRAINT [PK_tblposicion] PRIMARY KEY CLUSTERED 
(
	[idposicion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [tblmodalidades] ON 

INSERT [tblmodalidades] ([id], [nombre]) VALUES (2, N'Voleyball')
INSERT [tblmodalidades] ([id], [nombre]) VALUES (3, N'Fútbol')
INSERT [tblmodalidades] ([id], [nombre]) VALUES (4, N'Basketball')
INSERT [tblmodalidades] ([id], [nombre]) VALUES (5, N'Natación')
SET IDENTITY_INSERT [tblmodalidades] OFF
SET IDENTITY_INSERT [tblpaises] ON 

INSERT [tblpaises] ([idpais], [nombrepais]) VALUES (1, N'Checoslovaquia')
INSERT [tblpaises] ([idpais], [nombrepais]) VALUES (2, N'Colombia')
SET IDENTITY_INSERT [tblpaises] OFF
SET IDENTITY_INSERT [tblposicion] ON 

INSERT [tblposicion] ([idposicion], [nombre]) VALUES (1, N'Primero')
INSERT [tblposicion] ([idposicion], [nombre]) VALUES (2, N'Segundo')
INSERT [tblposicion] ([idposicion], [nombre]) VALUES (3, N'Tercero')
SET IDENTITY_INSERT [tblposicion] OFF
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [spAccionesPaises]
@opcion INT = null,
@nombrepais VARCHAR(50)  = null
AS
IF @opcion = 1
BEGIN
	INSERT INTO dbo.tblpaises
	(nombrepais) VALUES (@nombrepais)	
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [spConsultaMarcaciones]
AS
SELECT 
moda.nombre AS "Modalidad", 
pais.nombrepais AS "País", 
mar.idposicion AS "Posición" 
FROM dbo.tblmarcaciones mar
INNER JOIN dbo.tblmodalidades moda
ON mar.idmodalidad = moda.id
INNER JOIN dbo.tblpaises pais
ON mar.idpais = pais.idpais
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [spConsultaModalidades]
@opcion INT = null
AS
SELECT * FROM dbo.tblmodalidades ORDER BY id ASC




GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [spConsultaPaises]
@opcion INT = null
AS
SELECT p.idpais AS 'Código', p.nombrepais AS 'Nombre' FROM dbo.tblpaises p


GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [spConsultarPosiciones]
AS
SELECT * FROM dbo.tblposicion ORDER BY idposicion ASC
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [spGuardarMarcacion]
@idmodalidad int,
@idpais int,
@idposicion int
AS
INSERT INTO dbo.tblmarcaciones (idmodalidad, idpais, idposicion)
VALUES (@idmodalidad, @idpais, @idposicion)
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [SPGuardarModalidades]
@nombre VARCHAR(50) = NULL
AS
INSERT INTO dbo.tblmodalidades
(nombre) VALUES (@nombre)




GO
USE [master]
GO
ALTER DATABASE [bdolimpiadas] SET  READ_WRITE 
GO
