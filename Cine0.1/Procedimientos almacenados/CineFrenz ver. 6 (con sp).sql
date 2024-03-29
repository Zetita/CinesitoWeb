USE [master]
GO
/****** Object:  Database [CineFrenz]    Script Date: 06/24/2019 01:35:57 ******/
CREATE DATABASE [CineFrenz] ON  PRIMARY 
( NAME = N'CineFrenz', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\CineFrenz.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CineFrenz_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\CineFrenz_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CineFrenz] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CineFrenz].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CineFrenz] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [CineFrenz] SET ANSI_NULLS OFF
GO
ALTER DATABASE [CineFrenz] SET ANSI_PADDING OFF
GO
ALTER DATABASE [CineFrenz] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [CineFrenz] SET ARITHABORT OFF
GO
ALTER DATABASE [CineFrenz] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [CineFrenz] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [CineFrenz] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [CineFrenz] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [CineFrenz] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [CineFrenz] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [CineFrenz] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [CineFrenz] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [CineFrenz] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [CineFrenz] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [CineFrenz] SET  DISABLE_BROKER
GO
ALTER DATABASE [CineFrenz] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [CineFrenz] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [CineFrenz] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [CineFrenz] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [CineFrenz] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [CineFrenz] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [CineFrenz] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [CineFrenz] SET  READ_WRITE
GO
ALTER DATABASE [CineFrenz] SET RECOVERY SIMPLE
GO
ALTER DATABASE [CineFrenz] SET  MULTI_USER
GO
ALTER DATABASE [CineFrenz] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [CineFrenz] SET DB_CHAINING OFF
GO
USE [CineFrenz]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [char](40) NOT NULL,
	[Contrasenia] [char](16) NOT NULL,
	[Email_Usuario] [char](40) NOT NULL,
	[Apellidos_Usuario] [char](40) NOT NULL,
	[Nombres_Usuario] [char](40) NOT NULL,
	[DNI_Usuario] [char](8) NOT NULL,
	[Telefono_Usuario] [char](15) NOT NULL,
	[FechaNac_Usuario] [date] NOT NULL,
	[Administrador] [bit] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[ID_Usuario] ASC,
	[Usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UC_Usuarios] UNIQUE NONCLUSTERED 
(
	[Usuario] ASC,
	[Email_Usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sucursales]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sucursales](
	[ID_Sucursal] [char](10) NOT NULL,
	[Nombre_Sucursal] [char](20) NOT NULL,
	[Direccion_Sucursal] [char](60) NOT NULL,
	[Localidad_Sucursal] [char](40) NOT NULL,
	[Provincia_Sucursal] [char](40) NOT NULL,
	[DireccionURL] [text] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Sucursal] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Nombre_Sucursal] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Sucursales] ([ID_Sucursal], [Nombre_Sucursal], [Direccion_Sucursal], [Localidad_Sucursal], [Provincia_Sucursal], [DireccionURL]) VALUES (N'1         ', N'CineFrenz Palermo   ', N'Medrano 1500                                                ', N'Capital Federal                         ', N'Buenos Aires                            ', N'ff')
INSERT [dbo].[Sucursales] ([ID_Sucursal], [Nombre_Sucursal], [Direccion_Sucursal], [Localidad_Sucursal], [Provincia_Sucursal], [DireccionURL]) VALUES (N'2         ', N'CineFrenz Martinez  ', N'Parana 3745                                                 ', N'Martinez                                ', N'Buenos Aires                            ', N'https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d13151.137403543751!2d-58.524169!3d-34.508351!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xf720852d6dd69bcb!2sHoyts+Unicenter+%7C+Cinemark+Hoyts!5e0!3m2!1ses-419!2sar!4v1561342513488!5m2!1ses-419!2sar')
/****** Object:  Table [dbo].[Formatos]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Formatos](
	[ID_Formato] [char](10) NOT NULL,
	[Nombre_Formato] [char](20) NOT NULL,
	[Idioma_Formato] [char](40) NOT NULL,
	[Subtitulos_Formato] [bit] NOT NULL,
	[Precio_Formato] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Formato] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Formatos] ([ID_Formato], [Nombre_Formato], [Idioma_Formato], [Subtitulos_Formato], [Precio_Formato]) VALUES (N'1         ', N'2D                  ', N'ESPANOL                                 ', 0, 100)
INSERT [dbo].[Formatos] ([ID_Formato], [Nombre_Formato], [Idioma_Formato], [Subtitulos_Formato], [Precio_Formato]) VALUES (N'2         ', N'3D                  ', N'ESPANOL                                 ', 0, 150)
INSERT [dbo].[Formatos] ([ID_Formato], [Nombre_Formato], [Idioma_Formato], [Subtitulos_Formato], [Precio_Formato]) VALUES (N'3         ', N'2D                  ', N'INGLES                                  ', 1, 90)
/****** Object:  Table [dbo].[Peliculas]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Peliculas](
	[ID_Pelicula] [char](10) NOT NULL,
	[Titulo_Pelicula] [char](40) NOT NULL,
	[Genero_Pelicula] [text] NOT NULL,
	[Clasificacion_Pelicula] [char](10) NOT NULL,
	[FechaEstreno_Pelicula] [date] NOT NULL,
	[Director_Pelicula] [char](40) NOT NULL,
	[Sinopsis_Pelicula] [text] NOT NULL,
	[ImagenURL] [text] NOT NULL,
	[Duracion] [time](7) NOT NULL,
	[TrailerUrl] [text] NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Pelicula] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Peliculas] ([ID_Pelicula], [Titulo_Pelicula], [Genero_Pelicula], [Clasificacion_Pelicula], [FechaEstreno_Pelicula], [Director_Pelicula], [Sinopsis_Pelicula], [ImagenURL], [Duracion], [TrailerUrl], [Estado]) VALUES (N'1         ', N'John Wick                               ', N'Accion', N'+18       ', CAST(0xC43F0B00 AS Date), N'Chad Stahelski                          ', N'Keanu Reeves protagoniza a John Wick quien ya debería haber sido ejecutado, pero el gerente del Continental, Winston (McShane), le ha dado un período de gracia de una hora antes de ser excomulgado', N'~/Recursos/Portadas/1.jpg', CAST(0x070014E85D0F0000 AS Time), N'https://www.youtube.com/embed/pU8-7BX9uxs', 1)
INSERT [dbo].[Peliculas] ([ID_Pelicula], [Titulo_Pelicula], [Genero_Pelicula], [Clasificacion_Pelicula], [FechaEstreno_Pelicula], [Director_Pelicula], [Sinopsis_Pelicula], [ImagenURL], [Duracion], [TrailerUrl], [Estado]) VALUES (N'2         ', N'Detetive Pikachu                        ', N'Fantasia', N'ATP       ', CAST(0xA43F0B00 AS Date), N'Rob Letterman                           ', N'Un día, un chico llamado Tim Goodman se encuentra con un Pikachu bastante inteligente que dice ser un gran detective y descubre que puede entenderlo', N'~/Recursos/Portadas/2.jpg', CAST(0x07005847F80D0000 AS Time), N'https://www.youtube.com/embed/XzCj0lGfveU', 1)
INSERT [dbo].[Peliculas] ([ID_Pelicula], [Titulo_Pelicula], [Genero_Pelicula], [Clasificacion_Pelicula], [FechaEstreno_Pelicula], [Director_Pelicula], [Sinopsis_Pelicula], [ImagenURL], [Duracion], [TrailerUrl], [Estado]) VALUES (N'3         ', N'4X4                                     ', N'Accion', N'+16       ', CAST(0x623F0B00 AS Date), N'Mariano Cohn                            ', N'Un ladrón (Peter Lanzani) se introduce en una camioneta 4 x 4 que en apariencia no tiene alarma. Roba el equipo de audio y realiza desmanes dentro de la misma, pero cuando pretende salir se da cuenta que está encerrado', N'~/Recursos/Portada/3.jpg', CAST(0x07009CA6920C0000 AS Time), N'https://www.youtube.com/embed/2ZAxzP4cfCI', 1)
/****** Object:  Table [dbo].[Snacks]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Snacks](
	[ID_Snack] [char](10) NOT NULL,
	[Nombre_Snack] [char](30) NOT NULL,
	[Tipo_Snack] [char](20) NOT NULL,
	[Precio_Snack] [smallmoney] NOT NULL,
	[URLImagen_Snack] [text] NOT NULL,
	[Estado_Snack] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Snack] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Snacks] ([ID_Snack], [Nombre_Snack], [Tipo_Snack], [Precio_Snack], [URLImagen_Snack], [Estado_Snack]) VALUES (N'SN001     ', N'Balde de pochoclos grande     ', N'Pochoclos           ', 150.0000, N'~/img/snacks/balde_pochoclos_grande.jpg', 1)
/****** Object:  StoredProcedure [dbo].[spInsertarFormato]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertarFormato]
(
@ID_FORMATO char(10),
@NOMBRE char(20),
@IDIOMA char(40),
@SUBTITULOS bit,
@PRECIO float

)
AS
INSERT INTO Formatos
(
ID_Formato,
Nombre_Formato,
Idioma_Formato,
Subtitulos_Formato,
Precio_Formato
)
VALUES
(
@ID_FORMATO,
@NOMBRE,
@IDIOMA,
@SUBTITULOS,
@PRECIO
)
RETURN
GO
/****** Object:  StoredProcedure [dbo].[spInsertarPelicula]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertarPelicula]
(
@ID_PELICULA CHAR(20),
@TITULO CHAR(40),
@GENERO TEXT,
@CLASIFICACION CHAR(10),
@FECHAESTRENO DATE,
@DIRECTOR CHAR(40),
@SINOPSIS TEXT,
@IMAGENURL TEXT,
@DURACION TIME(7),
@TRAILERURL TEXT,
@ESTADO bit
)
AS
INSERT INTO Peliculas
(
Titulo_Pelicula,
Genero_Pelicula,
Clasificacion_Pelicula,
FechaEstreno_Pelicula,
Director_Pelicula,
Sinopsis_Pelicula,
ImagenURL,
Duracion,
TrailerURL,
Estado
)
VALUES
(
@TITULO,
@GENERO,
@CLASIFICACION,
@FECHAESTRENO,
@DIRECTOR,
@SINOPSIS,
@IMAGENURL,
@DURACION,
@TRAILERURL,
@ESTADO

)RETURN
GO
/****** Object:  StoredProcedure [dbo].[spInsertarSnack]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertarSnack]
(
@ID_SNACK char(10),
@NOMBRE char(30),
@TIPO char(20),
@PRECIO smallmoney,
@IMAGENURL text,
@ESTADO bit
)
AS
INSERT INTO Snacks
(
ID_Snack,
Nombre_Snack,
Tipo_Snack,
Precio_Snack,
URLImagen_Snack,
Estado_Snack
)
VALUES
(
@ID_SNACK,
@NOMBRE,
@TIPO,
@PRECIO,
@IMAGENURL,
@ESTADO
)
RETURN
GO
/****** Object:  StoredProcedure [dbo].[spEliminarUsuario]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEliminarUsuario]
(
@USUARIO char(40),
@ACTIVO bit
)
AS 
UPDATE Usuarios
SET Activo=@ACTIVO
WHERE Usuario=@USUARIO

RETURN
GO
/****** Object:  StoredProcedure [dbo].[spEliminarSnack]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEliminarSnack]
(
@ID_SNACK char(10),
@ESTADO bit
)
AS 
UPDATE Snacks
SET Estado_Snack=@ESTADO
WHERE ID_Snack=@ID_SNACK

RETURN
GO
/****** Object:  StoredProcedure [dbo].[spActualizarUsuario]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spActualizarUsuario]
(
@USUARIO CHAR(40),
@CONTRASENIA CHAR(16),
@EMAIL CHAR(40),
@APELLIDOS CHAR(40),
@NOMBRES CHAR(40),
@DNI CHAR(8),
@TELEFONO CHAR(15),
@FECHANAC DATE,
@ADMINISTRADOR BIT,
@ACTIVO BIT
)
AS
UPDATE Usuarios
SET
Contrasenia=@CONTRASENIA,
Email_Usuario=@EMAIL,
Apellidos_Usuario=@APELLIDOS,
Nombres_Usuario=@NOMBRES,
DNI_Usuario=@DNI,
Telefono_Usuario=@TELEFONO,
FechaNac_Usuario=@FECHANAC,
Administrador=@ADMINISTRADOR
WHERE Usuario=@USUARIO
RETURN
GO
/****** Object:  StoredProcedure [dbo].[spActualizarSnack]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spActualizarSnack]
(
@ID_SNACK char(10),
@NOMBRE char(30),
@TIPO char(20),
@PRECIO smallmoney,
@IMAGENURL text,
@ESTADO bit

)
AS

UPDATE Snacks
SET
Nombre_Snack=@NOMBRE,
Tipo_Snack=@TIPO,
Precio_Snack=@PRECIO,
Estado_Snack=@ESTADO
WHERE ID_Snack=@ID_SNACK

RETURN
GO
/****** Object:  StoredProcedure [dbo].[spActualizarPelicula]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spActualizarPelicula]
(
@ID_PELICULA CHAR(20),
@TITULO CHAR(40),
@GENERO TEXT,
@CLASIFICACION CHAR(10),
@FECHAESTRENO DATE,
@DIRECTOR CHAR(40),
@SINOPSIS TEXT,
@IMAGENURL TEXT,
@DURACION TIME(7),
@TRAILERURL TEXT,
@ESTADO bit

)
AS
UPDATE Peliculas
SET
Titulo_Pelicula=@TITULO,
Genero_Pelicula=@GENERO,
Clasificacion_Pelicula=@CLASIFICACION,
FechaEstreno_Pelicula=@FECHAESTRENO,
Director_Pelicula=@DIRECTOR,
Sinopsis_Pelicula=@SINOPSIS,
ImagenURL=@IMAGENURL,
Duracion=@DURACION,
TrailerUrl=@TRAILERURL,
Estado=@ESTADO
WHERE ID_Pelicula=@ID_PELICULA

RETURN
GO
/****** Object:  StoredProcedure [dbo].[spActualizarFormato]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spActualizarFormato]
(
@ID_FORMATO char(10),
@NOMBRE char(20),
@IDIOMA char(40),
@SUBTITULOS bit,
@PRECIO float

)
AS
UPDATE Formatos
SET
Nombre_Formato=@NOMBRE,
Idioma_Formato=@IDIOMA,
Subtitulos_Formato=@SUBTITULOS,
Precio_Formato=@PRECIO
WHERE ID_Formato=@ID_FORMATO

RETURN
GO
/****** Object:  Table [dbo].[Salas]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Salas](
	[ID_Sala] [char](10) NOT NULL,
	[ID_Sucursal] [char](10) NOT NULL,
	[Sala] [char](20) NOT NULL,
	[Butacas_Sala] [int] NOT NULL,
 CONSTRAINT [PK_Salas] PRIMARY KEY CLUSTERED 
(
	[ID_Sala] ASC,
	[ID_Sucursal] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Salas] ([ID_Sala], [ID_Sucursal], [Sala], [Butacas_Sala]) VALUES (N'1         ', N'1         ', N'SALA 1              ', 44)
INSERT [dbo].[Salas] ([ID_Sala], [ID_Sucursal], [Sala], [Butacas_Sala]) VALUES (N'1         ', N'2         ', N'SALA 1              ', 44)
INSERT [dbo].[Salas] ([ID_Sala], [ID_Sucursal], [Sala], [Butacas_Sala]) VALUES (N'2         ', N'2         ', N'SALA 2              ', 44)
INSERT [dbo].[Salas] ([ID_Sala], [ID_Sucursal], [Sala], [Butacas_Sala]) VALUES (N'3         ', N'2         ', N'SALA 3              ', 44)
/****** Object:  Table [dbo].[PeliculasXFormatos]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PeliculasXFormatos](
	[ID_PxF] [char](10) NOT NULL,
	[ID_Pelicula] [char](10) NOT NULL,
	[ID_Formato] [char](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_PxF] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[PeliculasXFormatos] ([ID_PxF], [ID_Pelicula], [ID_Formato]) VALUES (N'1         ', N'1         ', N'1         ')
INSERT [dbo].[PeliculasXFormatos] ([ID_PxF], [ID_Pelicula], [ID_Formato]) VALUES (N'2         ', N'1         ', N'2         ')
INSERT [dbo].[PeliculasXFormatos] ([ID_PxF], [ID_Pelicula], [ID_Formato]) VALUES (N'3         ', N'2         ', N'1         ')
/****** Object:  Table [dbo].[Ventas]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ventas](
	[ID_Venta] [char](10) NOT NULL,
	[IDUsuario_Venta] [int] NOT NULL,
	[Usuario_Venta] [char](40) NOT NULL,
	[FechaHora_Venta] [datetime] NOT NULL,
	[CantEntradas_Venta] [int] NOT NULL,
	[PrecioFinal_Venta] [smallmoney] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Venta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[spInsertarUsuario]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertarUsuario]
(
@USUARIO CHAR(40),
@CONTRASENIA CHAR(16),
@EMAIL CHAR(40),
@APELLIDOS CHAR(40),
@NOMBRES CHAR(40),
@DNI CHAR(8),
@TELEFONO CHAR(15),
@FECHANAC DATE,
@ADMINISTRADOR BIT,
@ACTIVO BIT
)
AS
INSERT INTO Usuarios
(
Usuario,
Contrasenia,
Email_Usuario,
Apellidos_Usuario,
Nombres_Usuario,
DNI_Usuario,
Telefono_Usuario,
FechaNac_Usuario,
Administrador,
Activo
)
VALUES
(
@USUARIO,
@CONTRASENIA,
@EMAIL,
@APELLIDOS,
@NOMBRES,
@DNI,
@TELEFONO,
@FECHANAC,
@ADMINISTRADOR,
@ACTIVO

)
RETURN
GO
/****** Object:  StoredProcedure [dbo].[spInsertarSucursales]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertarSucursales]
(
@ID_SUCURSAL char(10),
@NOMBRE char(20),
@DIRECCION char(60),
@LOCALIDAD char(40),
@PROVINCIA char(40),
@DIRECCIONURL text
)
AS
INSERT INTO Sucursales
(
ID_Sucursal,
Nombre_Sucursal,
Direccion_Sucursal,
Localidad_Sucursal,
Provincia_Sucursal,
DireccionURL
)
VALUES
(
@ID_SUCURSAL,
@NOMBRE,
@DIRECCION,
@LOCALIDAD,
@PROVINCIA,
@DIRECCIONURL
)
RETURN
GO
/****** Object:  StoredProcedure [dbo].[spInsertarVenta]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertarVenta]
(
@IDVENTA char(10),
@IDUSUARIO int,
@USUARIO char(40),
@FECHA_HORA datetime,
@CANT_ENTRADAS int, 
@PRECIO_FINAL smallmoney
)
AS
INSERT INTO Ventas
(
ID_Venta,
IDUsuario_Venta,
Usuario_Venta,
FechaHora_Venta,
CantEntradas_Venta,
PrecioFinal_Venta
)
VALUES
(
@IDVENTA,
@IDUSUARIO,
@USUARIO,
@FECHA_HORA,
@CANT_ENTRADAS,
@PRECIO_FINAL
)
RETURN
GO
/****** Object:  Table [dbo].[Funciones]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Funciones](
	[ID_Funcion] [char](10) NOT NULL,
	[ID_PxF] [char](10) NOT NULL,
	[ID_Sucursal] [char](10) NOT NULL,
	[ID_Sala] [char](10) NOT NULL,
	[FechaHora_Funcion] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Funcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Funciones] ([ID_Funcion], [ID_PxF], [ID_Sucursal], [ID_Sala], [FechaHora_Funcion]) VALUES (N'1         ', N'1         ', N'1         ', N'1         ', CAST(0x0000AA74014159A0 AS DateTime))
INSERT [dbo].[Funciones] ([ID_Funcion], [ID_PxF], [ID_Sucursal], [ID_Sala], [FechaHora_Funcion]) VALUES (N'2         ', N'2         ', N'1         ', N'1         ', CAST(0x0000AA74017B0740 AS DateTime))
INSERT [dbo].[Funciones] ([ID_Funcion], [ID_PxF], [ID_Sucursal], [ID_Sala], [FechaHora_Funcion]) VALUES (N'3         ', N'1         ', N'1         ', N'1         ', CAST(0x0000AA7401499700 AS DateTime))
INSERT [dbo].[Funciones] ([ID_Funcion], [ID_PxF], [ID_Sucursal], [ID_Sala], [FechaHora_Funcion]) VALUES (N'4         ', N'2         ', N'1         ', N'1         ', CAST(0x0000AA7401499700 AS DateTime))
INSERT [dbo].[Funciones] ([ID_Funcion], [ID_PxF], [ID_Sucursal], [ID_Sala], [FechaHora_Funcion]) VALUES (N'FN005     ', N'3         ', N'2         ', N'1         ', CAST(0x0000AA7F00A4CB80 AS DateTime))
/****** Object:  Table [dbo].[SnacksXVentas]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SnacksXVentas](
	[ID_Venta] [char](10) NOT NULL,
	[ID_Snack] [char](10) NOT NULL,
	[Nombre_Snack] [char](30) NOT NULL,
	[Precio_Snack] [smallmoney] NOT NULL,
	[Cantidad_Snack] [int] NOT NULL,
 CONSTRAINT [PK_VentasXSnacks] PRIMARY KEY CLUSTERED 
(
	[ID_Venta] ASC,
	[ID_Snack] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[spInsertarSala]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertarSala]
(
@ID_SALA char(10),
@ID_SUCURSAL char(10),
@SALA char(20),
@BUTACAS Int
)
AS
INSERT INTO Salas
(
ID_Sala,
ID_Sucursal,
Sala,
Butacas_Sala
)
VALUES
(
@ID_SALA,
@ID_SUCURSAL,
@SALA,
@BUTACAS
)
RETURN
GO
/****** Object:  StoredProcedure [dbo].[spInsertarPXF]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertarPXF]
(
@ID_PXF char(10),
@ID_PELICULA char(10),
@ID_FORMATO char(10)

)
AS
INSERT INTO PeliculasXFormatos
(
ID_PxF,
ID_Pelicula,
ID_Formato
)
VALUES
(
@ID_PXF,
@ID_PELICULA,
@ID_FORMATO
)
RETURN
GO
/****** Object:  StoredProcedure [dbo].[spInsertarFuncion]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertarFuncion]
(
@ID_FUNCION char(10),
@ID_PXF char(10),
@ID_SALA char(10),
@ID_SUCURSAL char(10),
@FECHA_HORA datetime
)
AS
INSERT INTO Funciones
(
ID_Funcion,
ID_PxF,
ID_Sala,
ID_Sucursal,
FechaHora_Funcion
)
VALUES
(
@ID_FUNCION,
@ID_PXF,
@ID_SALA,
@ID_SUCURSAL,
@FECHA_HORA
)

RETURN
GO
/****** Object:  Table [dbo].[ButacaXFunciones]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ButacaXFunciones](
	[ID_Butaca] [char](10) NOT NULL,
	[ID_Funcion] [char](10) NOT NULL,
	[Fila_Butaca] [char](20) NOT NULL,
	[Butaca] [char](20) NOT NULL,
 CONSTRAINT [PK_ButacaXFunciones] PRIMARY KEY CLUSTERED 
(
	[ID_Butaca] ASC,
	[ID_Funcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[spInsertarSnacksxVenta]    Script Date: 06/24/2019 01:35:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertarSnacksxVenta]
(
@ID_VENTA char(10),
@ID_SNACK char(10),
@NOMBRE char(30),
@PRECIO smallmoney,
@CANTIDAD int
)
AS
INSERT INTO SnacksXVentas
(
ID_Venta,
ID_Snack,
Nombre_Snack,
Precio_Snack,
Cantidad_Snack
)
VALUES
(
@ID_VENTA,
@ID_SNACK,
@NOMBRE,
@PRECIO,
@CANTIDAD
)
RETURN
GO
/****** Object:  StoredProcedure [dbo].[spInsertarBxF]    Script Date: 06/24/2019 01:35:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertarBxF]
(
@ID_BUTACA char(10),
@ID_FUNCION char(10),
@FILA char(20),
@BUTACA char(20)
)
AS
INSERT INTO ButacaXFunciones
(
ID_Butaca,
ID_Funcion,
Fila_Butaca,
Butaca
)
VALUES
(
@ID_BUTACA,
@ID_FUNCION,
@FILA,
@BUTACA
)
RETURN
GO
/****** Object:  Table [dbo].[DetalleVentas]    Script Date: 06/24/2019 01:35:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetalleVentas](
	[ID_Venta] [char](10) NOT NULL,
	[ID_Funcion] [char](10) NOT NULL,
	[ID_Butaca] [char](10) NOT NULL,
	[Fila_Butaca] [char](20) NOT NULL,
	[Butaca] [char](20) NOT NULL,
	[Ben_MenorOMayor] [bit] NOT NULL,
	[PrecioEntrada] [smallmoney] NOT NULL,
 CONSTRAINT [PK_DetalleVentas] PRIMARY KEY CLUSTERED 
(
	[ID_Venta] ASC,
	[ID_Funcion] ASC,
	[ID_Butaca] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[spInsertarDetalleVenta]    Script Date: 06/24/2019 01:35:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertarDetalleVenta]
(
@ID_VENTA char(10),
@ID_FUNCION char(10),
@ID_BUTACA char(10),
@FILA_BUTACA char(20),
@BUTACA char(20),
@BEN_MENOROMAYOR bit,
@PRECIO smallmoney
)
AS
INSERT INTO DetalleVentas
(
ID_Venta,
ID_Funcion,
ID_Butaca,
Fila_Butaca,
Butaca,
Ben_MenorOMayor,
PrecioEntrada
)
VALUES
(
@ID_VENTA,
@ID_FUNCION,
@ID_BUTACA,
@FILA_BUTACA,
@BUTACA,
@BEN_MENOROMAYOR,
@PRECIO
)
RETURN
GO
/****** Object:  ForeignKey [FK__Salas__ID_Sucurs__300424B4]    Script Date: 06/24/2019 01:35:58 ******/
ALTER TABLE [dbo].[Salas]  WITH CHECK ADD FOREIGN KEY([ID_Sucursal])
REFERENCES [dbo].[Sucursales] ([ID_Sucursal])
GO
/****** Object:  ForeignKey [FK__Peliculas__ID_Fo__30F848ED]    Script Date: 06/24/2019 01:35:58 ******/
ALTER TABLE [dbo].[PeliculasXFormatos]  WITH CHECK ADD FOREIGN KEY([ID_Formato])
REFERENCES [dbo].[Formatos] ([ID_Formato])
GO
/****** Object:  ForeignKey [FK__Peliculas__ID_Pe__31EC6D26]    Script Date: 06/24/2019 01:35:58 ******/
ALTER TABLE [dbo].[PeliculasXFormatos]  WITH CHECK ADD FOREIGN KEY([ID_Pelicula])
REFERENCES [dbo].[Peliculas] ([ID_Pelicula])
GO
/****** Object:  ForeignKey [FK_Ventas]    Script Date: 06/24/2019 01:35:58 ******/
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas] FOREIGN KEY([IDUsuario_Venta], [Usuario_Venta])
REFERENCES [dbo].[Usuarios] ([ID_Usuario], [Usuario])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas]
GO
/****** Object:  ForeignKey [FK__Funciones__ID_Px__32E0915F]    Script Date: 06/24/2019 01:35:58 ******/
ALTER TABLE [dbo].[Funciones]  WITH CHECK ADD FOREIGN KEY([ID_PxF])
REFERENCES [dbo].[PeliculasXFormatos] ([ID_PxF])
GO
/****** Object:  ForeignKey [FK_Funciones]    Script Date: 06/24/2019 01:35:58 ******/
ALTER TABLE [dbo].[Funciones]  WITH CHECK ADD  CONSTRAINT [FK_Funciones] FOREIGN KEY([ID_Sala], [ID_Sucursal])
REFERENCES [dbo].[Salas] ([ID_Sala], [ID_Sucursal])
GO
ALTER TABLE [dbo].[Funciones] CHECK CONSTRAINT [FK_Funciones]
GO
/****** Object:  ForeignKey [FK__SnacksXVe__ID_Ve__34C8D9D1]    Script Date: 06/24/2019 01:35:58 ******/
ALTER TABLE [dbo].[SnacksXVentas]  WITH CHECK ADD FOREIGN KEY([ID_Venta])
REFERENCES [dbo].[Ventas] ([ID_Venta])
GO
/****** Object:  ForeignKey [FK_VentasXSnacks]    Script Date: 06/24/2019 01:35:58 ******/
ALTER TABLE [dbo].[SnacksXVentas]  WITH CHECK ADD  CONSTRAINT [FK_VentasXSnacks] FOREIGN KEY([ID_Snack])
REFERENCES [dbo].[Snacks] ([ID_Snack])
GO
ALTER TABLE [dbo].[SnacksXVentas] CHECK CONSTRAINT [FK_VentasXSnacks]
GO
/****** Object:  ForeignKey [FK__ButacaXFu__ID_Fu__36B12243]    Script Date: 06/24/2019 01:35:58 ******/
ALTER TABLE [dbo].[ButacaXFunciones]  WITH CHECK ADD FOREIGN KEY([ID_Funcion])
REFERENCES [dbo].[Funciones] ([ID_Funcion])
GO
/****** Object:  ForeignKey [FK__DetalleVe__ID_Ve__37A5467C]    Script Date: 06/24/2019 01:35:59 ******/
ALTER TABLE [dbo].[DetalleVentas]  WITH CHECK ADD FOREIGN KEY([ID_Venta])
REFERENCES [dbo].[Ventas] ([ID_Venta])
GO
/****** Object:  ForeignKey [FK_DetalleVentas]    Script Date: 06/24/2019 01:35:59 ******/
ALTER TABLE [dbo].[DetalleVentas]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVentas] FOREIGN KEY([ID_Funcion], [ID_Butaca])
REFERENCES [dbo].[ButacaXFunciones] ([ID_Butaca], [ID_Funcion])
GO
ALTER TABLE [dbo].[DetalleVentas] CHECK CONSTRAINT [FK_DetalleVentas]
GO
