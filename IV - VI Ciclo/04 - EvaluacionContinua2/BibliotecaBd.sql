USE [master]
GO
/****** Object:  Database [BibliotecaBd]    Script Date: 10/02/2023 23:09:14 ******/
CREATE DATABASE [BibliotecaBd]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BibliotecaBd', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BibliotecaBd.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BibliotecaBd_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BibliotecaBd_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BibliotecaBd] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BibliotecaBd].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BibliotecaBd] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BibliotecaBd] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BibliotecaBd] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BibliotecaBd] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BibliotecaBd] SET ARITHABORT OFF 
GO
ALTER DATABASE [BibliotecaBd] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BibliotecaBd] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BibliotecaBd] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BibliotecaBd] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BibliotecaBd] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BibliotecaBd] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BibliotecaBd] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BibliotecaBd] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BibliotecaBd] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BibliotecaBd] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BibliotecaBd] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BibliotecaBd] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BibliotecaBd] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BibliotecaBd] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BibliotecaBd] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BibliotecaBd] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BibliotecaBd] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BibliotecaBd] SET RECOVERY FULL 
GO
ALTER DATABASE [BibliotecaBd] SET  MULTI_USER 
GO
ALTER DATABASE [BibliotecaBd] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BibliotecaBd] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BibliotecaBd] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BibliotecaBd] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BibliotecaBd] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BibliotecaBd] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BibliotecaBd', N'ON'
GO
ALTER DATABASE [BibliotecaBd] SET QUERY_STORE = OFF
GO
USE [BibliotecaBd]
GO
/****** Object:  Table [dbo].[EDITORIAL]    Script Date: 10/02/2023 23:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EDITORIAL](
	[IDEDITORIAL] [int] IDENTITY(1,1) NOT NULL,
	[EDITORIAL] [nvarchar](50) NULL,
	[NOMBRECONTACTO] [nvarchar](50) NULL,
	[DIRECCION] [nvarchar](50) NULL,
	[CIUDAD] [nvarchar](50) NULL,
	[TELEFONO] [nvarchar](50) NULL,
	[EMAIL] [nvarchar](50) NULL,
	[COMENTARIO] [nvarchar](50) NULL,
	[ACTIVO] [bit] NULL,
 CONSTRAINT [PK_EDITORIAL] PRIMARY KEY CLUSTERED 
(
	[IDEDITORIAL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVENTARIO]    Script Date: 10/02/2023 23:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVENTARIO](
	[IDINVENTARIO] [int] IDENTITY(1,1) NOT NULL,
	[IDLIBRO] [int] NULL,
	[IDSUCURSAL] [int] NULL,
	[EXISTENCIA] [nvarchar](50) NULL,
	[COMENTARIOS] [nvarchar](50) NULL,
	[ACTIVO] [bit] NULL,
 CONSTRAINT [PK_INVENTARIO] PRIMARY KEY CLUSTERED 
(
	[IDINVENTARIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LIBRO]    Script Date: 10/02/2023 23:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LIBRO](
	[IDLIBRO] [int] IDENTITY(1,1) NOT NULL,
	[TITULOLIBRO] [nvarchar](50) NULL,
	[AUTOR] [nvarchar](50) NULL,
	[ANIO] [nvarchar](50) NULL,
	[PRECIO] [nvarchar](50) NULL,
	[COMENTARIOS] [nvarchar](50) NULL,
	[NUMPAGE] [nvarchar](50) NULL,
	[IDEDITORIAL] [int] NULL,
	[ACTIVO] [bit] NULL,
 CONSTRAINT [PK_LIBRO] PRIMARY KEY CLUSTERED 
(
	[IDLIBRO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SUCURSAL]    Script Date: 10/02/2023 23:09:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUCURSAL](
	[IDSUCURSAL] [int] IDENTITY(1,1) NOT NULL,
	[SUCURSAL] [nvarchar](50) NULL,
	[NOMBREENCARGADO] [nvarchar](50) NULL,
	[DIRECCION] [nvarchar](50) NULL,
	[CIUDAD] [nvarchar](50) NULL,
	[TELEFONO] [nvarchar](50) NULL,
	[EMAIL] [nvarchar](50) NULL,
	[COMENTARIO] [nvarchar](50) NULL,
	[ACTIVO] [bit] NULL,
 CONSTRAINT [PK_SUCURSAL] PRIMARY KEY CLUSTERED 
(
	[IDSUCURSAL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[EDITORIAL] ON 

INSERT [dbo].[EDITORIAL] ([IDEDITORIAL], [EDITORIAL], [NOMBRECONTACTO], [DIRECCION], [CIUDAD], [TELEFONO], [EMAIL], [COMENTARIO], [ACTIVO]) VALUES (1, N'Asteca', N'Juan', N'nose', N'lima', N'987936272', N'lasdkjasd@gmail.com', N'nose', 1)
SET IDENTITY_INSERT [dbo].[EDITORIAL] OFF
GO
SET IDENTITY_INSERT [dbo].[INVENTARIO] ON 

INSERT [dbo].[INVENTARIO] ([IDINVENTARIO], [IDLIBRO], [IDSUCURSAL], [EXISTENCIA], [COMENTARIOS], [ACTIVO]) VALUES (1, 1, 1, N'si', N'fino', 1)
SET IDENTITY_INSERT [dbo].[INVENTARIO] OFF
GO
SET IDENTITY_INSERT [dbo].[LIBRO] ON 

INSERT [dbo].[LIBRO] ([IDLIBRO], [TITULOLIBRO], [AUTOR], [ANIO], [PRECIO], [COMENTARIOS], [NUMPAGE], [IDEDITORIAL], [ACTIVO]) VALUES (1, N'Harry Potte', N'SD', N'2012', N'50', N'fino', N'500', NULL, 1)
SET IDENTITY_INSERT [dbo].[LIBRO] OFF
GO
SET IDENTITY_INSERT [dbo].[SUCURSAL] ON 

INSERT [dbo].[SUCURSAL] ([IDSUCURSAL], [SUCURSAL], [NOMBREENCARGADO], [DIRECCION], [CIUDAD], [TELEFONO], [EMAIL], [COMENTARIO], [ACTIVO]) VALUES (1, N'1', N'Carlos', N'LiMA', N'SJL', N'987456321', N'AKSJDAS@gmail.com', N'nose', 1)
SET IDENTITY_INSERT [dbo].[SUCURSAL] OFF
GO
ALTER TABLE [dbo].[INVENTARIO]  WITH CHECK ADD  CONSTRAINT [FK_INVENTARIO_LIBRO] FOREIGN KEY([IDLIBRO])
REFERENCES [dbo].[LIBRO] ([IDLIBRO])
GO
ALTER TABLE [dbo].[INVENTARIO] CHECK CONSTRAINT [FK_INVENTARIO_LIBRO]
GO
ALTER TABLE [dbo].[INVENTARIO]  WITH CHECK ADD  CONSTRAINT [FK_INVENTARIO_SUCURSAL] FOREIGN KEY([IDSUCURSAL])
REFERENCES [dbo].[SUCURSAL] ([IDSUCURSAL])
GO
ALTER TABLE [dbo].[INVENTARIO] CHECK CONSTRAINT [FK_INVENTARIO_SUCURSAL]
GO
ALTER TABLE [dbo].[LIBRO]  WITH CHECK ADD  CONSTRAINT [FK_EDITORIAL_LIBRO] FOREIGN KEY([IDEDITORIAL])
REFERENCES [dbo].[EDITORIAL] ([IDEDITORIAL])
GO
ALTER TABLE [dbo].[LIBRO] CHECK CONSTRAINT [FK_EDITORIAL_LIBRO]
GO
USE [master]
GO
ALTER DATABASE [BibliotecaBd] SET  READ_WRITE 
GO
