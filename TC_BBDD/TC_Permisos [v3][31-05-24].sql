USE [master]
GO
/****** Object:  Database [TC_Permisos]    Script Date: 31/5/2024 22:56:58 ******/
CREATE DATABASE [TC_Permisos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TC_Permisos', FILENAME = N'D:\Archivos de programa 2\SQL Server Express 17\MSSQL14.SQLEXPRESS\MSSQL\DATA\TC_Permisos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TC_Permisos_log', FILENAME = N'D:\Archivos de programa 2\SQL Server Express 17\MSSQL14.SQLEXPRESS\MSSQL\DATA\TC_Permisos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [TC_Permisos] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TC_Permisos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TC_Permisos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TC_Permisos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TC_Permisos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TC_Permisos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TC_Permisos] SET ARITHABORT OFF 
GO
ALTER DATABASE [TC_Permisos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TC_Permisos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TC_Permisos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TC_Permisos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TC_Permisos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TC_Permisos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TC_Permisos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TC_Permisos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TC_Permisos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TC_Permisos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TC_Permisos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TC_Permisos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TC_Permisos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TC_Permisos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TC_Permisos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TC_Permisos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TC_Permisos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TC_Permisos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TC_Permisos] SET  MULTI_USER 
GO
ALTER DATABASE [TC_Permisos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TC_Permisos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TC_Permisos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TC_Permisos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TC_Permisos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TC_Permisos] SET QUERY_STORE = OFF
GO
USE [TC_Permisos]
GO
/****** Object:  Table [dbo].[Administradores]    Script Date: 31/5/2024 22:56:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administradores](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombreAdmin] [varchar](50) NOT NULL,
	[cuilAdmin] [varchar](50) NOT NULL,
	[id_usuario_creador] [int] NULL,
 CONSTRAINT [PK_Administradores] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria_Producto]    Script Date: 31/5/2024 22:56:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria_Producto](
	[id] [int] NOT NULL,
	[nombre] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 31/5/2024 22:56:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[cuil] [varchar](255) NOT NULL,
	[id_usuario_creador] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_factura]    Script Date: 31/5/2024 22:56:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_factura](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_factura] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[cantidad_producto] [int] NOT NULL,
 CONSTRAINT [PK_detalle_factura] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 31/5/2024 22:56:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[id_factura] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NULL,
	[fecha_compra] [date] NULL,
	[total] [decimal](10, 2) NULL,
	[id_producto_comprado] [int] NULL,
	[cantidad] [int] NULL,
 CONSTRAINT [PK__Factura__6C08ED536456B819] PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[gestores_stock]    Script Date: 31/5/2024 22:56:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gestores_stock](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombreGestor] [varchar](255) NOT NULL,
	[cuilGestor] [varchar](255) NOT NULL,
	[id_user_creador] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permisos]    Script Date: 31/5/2024 22:56:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permisos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 31/5/2024 22:56:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NULL,
	[precio] [decimal](10, 2) NULL,
	[stockMinimo] [int] NULL,
	[stockActual] [int] NULL,
	[descripcion] [varchar](255) NULL,
	[categoriaId] [int] NULL,
 CONSTRAINT [PK__Producto__3213E83FE605759D] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 31/5/2024 22:56:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles_permisos]    Script Date: 31/5/2024 22:56:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles_permisos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_rol] [int] NOT NULL,
	[id_permiso] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles_usuarios]    Script Date: 31/5/2024 22:56:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles_usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_rol] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 31/5/2024 22:56:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[email] [varchar](255) NOT NULL,
	[password] [varchar](255) NOT NULL,
	[estado] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Administradores] ON 

INSERT [dbo].[Administradores] ([id], [nombreAdmin], [cuilAdmin], [id_usuario_creador]) VALUES (1, N'Econtrera', N'2042045544', 1)
SET IDENTITY_INSERT [dbo].[Administradores] OFF
INSERT [dbo].[Categoria_Producto] ([id], [nombre]) VALUES (1, N'Accesorios')
INSERT [dbo].[Categoria_Producto] ([id], [nombre]) VALUES (2, N'Hardware PC')
SET IDENTITY_INSERT [dbo].[clientes] ON 

INSERT [dbo].[clientes] ([id], [nombre], [cuil], [id_usuario_creador]) VALUES (1, N'Gerardo Ibarra', N'20-12345678-9', 2)
INSERT [dbo].[clientes] ([id], [nombre], [cuil], [id_usuario_creador]) VALUES (2, N'Nicolas Garrido', N'20-87654321-9', 2)
INSERT [dbo].[clientes] ([id], [nombre], [cuil], [id_usuario_creador]) VALUES (3, N'Cosme Fulanito', N'20-76543219-8', 3)
INSERT [dbo].[clientes] ([id], [nombre], [cuil], [id_usuario_creador]) VALUES (4, N'Elias Contrera', N'20432399452', 13)
INSERT [dbo].[clientes] ([id], [nombre], [cuil], [id_usuario_creador]) VALUES (8, N'Elias Florencio Contrera', N'21432399452', 14)
INSERT [dbo].[clientes] ([id], [nombre], [cuil], [id_usuario_creador]) VALUES (9, N'Elias Contrera Fabian', N'20-13123123-1', 15)
INSERT [dbo].[clientes] ([id], [nombre], [cuil], [id_usuario_creador]) VALUES (10, N'Elias Contrera Programacion', N'20421231232', 16)
INSERT [dbo].[clientes] ([id], [nombre], [cuil], [id_usuario_creador]) VALUES (11, N'Chamo Century', N'321231243123', 17)
INSERT [dbo].[clientes] ([id], [nombre], [cuil], [id_usuario_creador]) VALUES (12, N'asdasd', N'12312313', 17)
INSERT [dbo].[clientes] ([id], [nombre], [cuil], [id_usuario_creador]) VALUES (13, N'Elias Contreras', N'20-13123123-1', 15)
INSERT [dbo].[clientes] ([id], [nombre], [cuil], [id_usuario_creador]) VALUES (14, N'Elias', N'20-13123123-1', 15)
INSERT [dbo].[clientes] ([id], [nombre], [cuil], [id_usuario_creador]) VALUES (15, N'Matias gomez', N'20-40398231-2', 19)
INSERT [dbo].[clientes] ([id], [nombre], [cuil], [id_usuario_creador]) VALUES (16, N'Matias gomez', N'20-40398231-2', 19)
INSERT [dbo].[clientes] ([id], [nombre], [cuil], [id_usuario_creador]) VALUES (17, N'Brian Toledo', N'22-45231156-2', 20)
INSERT [dbo].[clientes] ([id], [nombre], [cuil], [id_usuario_creador]) VALUES (18, N'Brian Toledo', N'22-45231156-2', 20)
SET IDENTITY_INSERT [dbo].[clientes] OFF
SET IDENTITY_INSERT [dbo].[Factura] ON 

INSERT [dbo].[Factura] ([id_factura], [id_usuario], [fecha_compra], [total], [id_producto_comprado], [cantidad]) VALUES (3, 17, CAST(N'2024-05-21' AS Date), CAST(100.00 AS Decimal(10, 2)), 1, NULL)
INSERT [dbo].[Factura] ([id_factura], [id_usuario], [fecha_compra], [total], [id_producto_comprado], [cantidad]) VALUES (4, 15, CAST(N'2024-05-31' AS Date), CAST(9500.00 AS Decimal(10, 2)), 3, NULL)
INSERT [dbo].[Factura] ([id_factura], [id_usuario], [fecha_compra], [total], [id_producto_comprado], [cantidad]) VALUES (5, 15, CAST(N'2024-05-31' AS Date), CAST(5658.00 AS Decimal(10, 2)), 1, NULL)
INSERT [dbo].[Factura] ([id_factura], [id_usuario], [fecha_compra], [total], [id_producto_comprado], [cantidad]) VALUES (6, 19, CAST(N'2024-05-31' AS Date), CAST(15990.00 AS Decimal(10, 2)), 4, NULL)
INSERT [dbo].[Factura] ([id_factura], [id_usuario], [fecha_compra], [total], [id_producto_comprado], [cantidad]) VALUES (7, 19, CAST(N'2024-05-31' AS Date), CAST(15990.00 AS Decimal(10, 2)), 4, NULL)
INSERT [dbo].[Factura] ([id_factura], [id_usuario], [fecha_compra], [total], [id_producto_comprado], [cantidad]) VALUES (8, 20, CAST(N'2024-05-31' AS Date), CAST(5658.00 AS Decimal(10, 2)), 1, NULL)
INSERT [dbo].[Factura] ([id_factura], [id_usuario], [fecha_compra], [total], [id_producto_comprado], [cantidad]) VALUES (9, 20, CAST(N'2024-05-31' AS Date), CAST(5658.00 AS Decimal(10, 2)), 1, NULL)
SET IDENTITY_INSERT [dbo].[Factura] OFF
SET IDENTITY_INSERT [dbo].[gestores_stock] ON 

INSERT [dbo].[gestores_stock] ([id], [nombreGestor], [cuilGestor], [id_user_creador]) VALUES (1, N'GestorElias', N'20432399452', 3)
SET IDENTITY_INSERT [dbo].[gestores_stock] OFF
SET IDENTITY_INSERT [dbo].[permisos] ON 

INSERT [dbo].[permisos] ([id], [nombre]) VALUES (1, N'crear cliente')
INSERT [dbo].[permisos] ([id], [nombre]) VALUES (2, N'editar cliente propio')
INSERT [dbo].[permisos] ([id], [nombre]) VALUES (3, N'editar cualquier cliente')
INSERT [dbo].[permisos] ([id], [nombre]) VALUES (4, N'eliminar cliente')
INSERT [dbo].[permisos] ([id], [nombre]) VALUES (5, N'modificar usuario')
INSERT [dbo].[permisos] ([id], [nombre]) VALUES (6, N'eliminar usuario')
INSERT [dbo].[permisos] ([id], [nombre]) VALUES (7, N'alta usuario')
SET IDENTITY_INSERT [dbo].[permisos] OFF
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([id], [nombre], [precio], [stockMinimo], [stockActual], [descripcion], [categoriaId]) VALUES (1, N'Auriculares', CAST(5658.00 AS Decimal(10, 2)), 7, 35, N'JBL High Fidelity Cableado Red', 1)
INSERT [dbo].[Producto] ([id], [nombre], [precio], [stockMinimo], [stockActual], [descripcion], [categoriaId]) VALUES (2, N'Mouse', CAST(10600.00 AS Decimal(10, 2)), 7, 33, N'Razor Inhalambrico', 1)
INSERT [dbo].[Producto] ([id], [nombre], [precio], [stockMinimo], [stockActual], [descripcion], [categoriaId]) VALUES (3, N'Teclado', CAST(9500.00 AS Decimal(10, 2)), 7, 24, N'Genius', 1)
INSERT [dbo].[Producto] ([id], [nombre], [precio], [stockMinimo], [stockActual], [descripcion], [categoriaId]) VALUES (4, N'Webcam', CAST(15990.00 AS Decimal(10, 2)), 7, 7, N'Logitech HD', 1)
INSERT [dbo].[Producto] ([id], [nombre], [precio], [stockMinimo], [stockActual], [descripcion], [categoriaId]) VALUES (5, N'Televisor', CAST(260333.00 AS Decimal(10, 2)), 7, 8, N'LG 4K 30 In', 1)
SET IDENTITY_INSERT [dbo].[Producto] OFF
SET IDENTITY_INSERT [dbo].[roles] ON 

INSERT [dbo].[roles] ([id], [nombre]) VALUES (1, N'administrador')
INSERT [dbo].[roles] ([id], [nombre]) VALUES (2, N'gerente')
INSERT [dbo].[roles] ([id], [nombre]) VALUES (3, N'usuario')
INSERT [dbo].[roles] ([id], [nombre]) VALUES (5, N'gestorStock')
SET IDENTITY_INSERT [dbo].[roles] OFF
SET IDENTITY_INSERT [dbo].[roles_permisos] ON 

INSERT [dbo].[roles_permisos] ([id], [id_rol], [id_permiso]) VALUES (1, 1, 1)
INSERT [dbo].[roles_permisos] ([id], [id_rol], [id_permiso]) VALUES (2, 1, 2)
INSERT [dbo].[roles_permisos] ([id], [id_rol], [id_permiso]) VALUES (3, 1, 3)
INSERT [dbo].[roles_permisos] ([id], [id_rol], [id_permiso]) VALUES (4, 1, 4)
INSERT [dbo].[roles_permisos] ([id], [id_rol], [id_permiso]) VALUES (5, 1, 5)
INSERT [dbo].[roles_permisos] ([id], [id_rol], [id_permiso]) VALUES (6, 2, 1)
INSERT [dbo].[roles_permisos] ([id], [id_rol], [id_permiso]) VALUES (7, 2, 2)
INSERT [dbo].[roles_permisos] ([id], [id_rol], [id_permiso]) VALUES (8, 2, 3)
INSERT [dbo].[roles_permisos] ([id], [id_rol], [id_permiso]) VALUES (9, 3, 1)
INSERT [dbo].[roles_permisos] ([id], [id_rol], [id_permiso]) VALUES (13, 5, 7)
INSERT [dbo].[roles_permisos] ([id], [id_rol], [id_permiso]) VALUES (14, 1, 6)
INSERT [dbo].[roles_permisos] ([id], [id_rol], [id_permiso]) VALUES (15, 1, 7)
SET IDENTITY_INSERT [dbo].[roles_permisos] OFF
SET IDENTITY_INSERT [dbo].[roles_usuarios] ON 

INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (2, 1, 1)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (3, 2, 2)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (4, 2, 3)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (5, 3, 4)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (6, 3, 5)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (7, 3, 6)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (8, 3, 7)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (9, 3, 8)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (10, 3, 9)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (11, 3, 10)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (12, 3, 11)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (13, 3, 12)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (14, 3, 13)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (15, 3, 14)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (16, 3, 15)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (17, 3, 16)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (18, 3, 17)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (19, 5, 18)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (20, 3, 19)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (21, 3, 20)
SET IDENTITY_INSERT [dbo].[roles_usuarios] OFF
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (1, N'Administrador', N'admin@example.com', N'123', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (2, N'Empleado 1', N'empleado1@example.com', N'123', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (3, N'Empleado 2', N'empleado2@example.com', N'123', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (4, N'Usuario 1', N'usuario1@example.com', N'123', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (5, N'Usuario 2', N'usuario2@example.com', N'123', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (6, N'Elias', N'asd@mail.com.ar', N'1234', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (7, N'', N'asd@mail.com.ar', N'123', N'inactivo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (8, N'', N'asd@mail.com', N'123', N'inactivo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (9, N'', N'asd@asm.com', N'', N'inactivo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (10, N'xd123', N'asd@mail.com', N'123', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (11, N'AVECES', N'aveces@mail.com', N'432', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (12, N'xd', N'xxdd', N'123', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (13, N'eliasxde', N'elias@mail.com', N'123', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (14, N'Elias1', N'eli@gmail.com.ar', N'123', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (15, N'elias543', N'elias123@gmail.com', N'123', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (16, N'Eliasxd', N'elieli@mail.com.ar', N'123', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (17, N'Chamo', N'chamo@mail.com', N'123', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (18, N'Gaston', N'gaston_roa@live.com', N'12345', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (19, N'matias gomez', N'gomez@gmail.com', N'hello', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (20, N'Brian', N'brian@gmail.com', N'1234', N'activo')
SET IDENTITY_INSERT [dbo].[usuarios] OFF
ALTER TABLE [dbo].[Administradores] ADD  CONSTRAINT [DF_Administradores_id_usuario_creador]  DEFAULT (NULL) FOR [id_usuario_creador]
GO
ALTER TABLE [dbo].[clientes] ADD  DEFAULT (NULL) FOR [id_usuario_creador]
GO
ALTER TABLE [dbo].[gestores_stock] ADD  DEFAULT (NULL) FOR [id_user_creador]
GO
ALTER TABLE [dbo].[usuarios] ADD  DEFAULT ('activo') FOR [estado]
GO
ALTER TABLE [dbo].[Administradores]  WITH CHECK ADD  CONSTRAINT [FK_Administradores_usuarios] FOREIGN KEY([id_usuario_creador])
REFERENCES [dbo].[usuarios] ([id])
GO
ALTER TABLE [dbo].[Administradores] CHECK CONSTRAINT [FK_Administradores_usuarios]
GO
ALTER TABLE [dbo].[clientes]  WITH CHECK ADD  CONSTRAINT [FK_clientes_usuarios] FOREIGN KEY([id_usuario_creador])
REFERENCES [dbo].[usuarios] ([id])
GO
ALTER TABLE [dbo].[clientes] CHECK CONSTRAINT [FK_clientes_usuarios]
GO
ALTER TABLE [dbo].[detalle_factura]  WITH CHECK ADD  CONSTRAINT [FK__detalle_f__id_fa__6FE99F9F] FOREIGN KEY([id_factura])
REFERENCES [dbo].[Factura] ([id_factura])
GO
ALTER TABLE [dbo].[detalle_factura] CHECK CONSTRAINT [FK__detalle_f__id_fa__6FE99F9F]
GO
ALTER TABLE [dbo].[detalle_factura]  WITH CHECK ADD  CONSTRAINT [FK__detalle_f__id_pr__70DDC3D8] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Producto] ([id])
GO
ALTER TABLE [dbo].[detalle_factura] CHECK CONSTRAINT [FK__detalle_f__id_pr__70DDC3D8]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK__Factura__id_prod__1332DBDC] FOREIGN KEY([id_producto_comprado])
REFERENCES [dbo].[Producto] ([id])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK__Factura__id_prod__1332DBDC]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuarios] ([id])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_usuarios]
GO
ALTER TABLE [dbo].[gestores_stock]  WITH CHECK ADD  CONSTRAINT [FK_gestores_stock_creador] FOREIGN KEY([id_user_creador])
REFERENCES [dbo].[usuarios] ([id])
GO
ALTER TABLE [dbo].[gestores_stock] CHECK CONSTRAINT [FK_gestores_stock_creador]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [fk_categoria] FOREIGN KEY([categoriaId])
REFERENCES [dbo].[Categoria_Producto] ([id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [fk_categoria]
GO
ALTER TABLE [dbo].[roles_permisos]  WITH CHECK ADD  CONSTRAINT [FK_roles_permisos_permiso] FOREIGN KEY([id_permiso])
REFERENCES [dbo].[permisos] ([id])
GO
ALTER TABLE [dbo].[roles_permisos] CHECK CONSTRAINT [FK_roles_permisos_permiso]
GO
ALTER TABLE [dbo].[roles_permisos]  WITH CHECK ADD  CONSTRAINT [FK_roles_permisos_rol] FOREIGN KEY([id_rol])
REFERENCES [dbo].[roles] ([id])
GO
ALTER TABLE [dbo].[roles_permisos] CHECK CONSTRAINT [FK_roles_permisos_rol]
GO
ALTER TABLE [dbo].[roles_usuarios]  WITH CHECK ADD  CONSTRAINT [FK_roles_usuarios_rol] FOREIGN KEY([id_rol])
REFERENCES [dbo].[roles] ([id])
GO
ALTER TABLE [dbo].[roles_usuarios] CHECK CONSTRAINT [FK_roles_usuarios_rol]
GO
ALTER TABLE [dbo].[roles_usuarios]  WITH CHECK ADD  CONSTRAINT [FK_roles_usuarios_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuarios] ([id])
GO
ALTER TABLE [dbo].[roles_usuarios] CHECK CONSTRAINT [FK_roles_usuarios_usuario]
GO
USE [master]
GO
ALTER DATABASE [TC_Permisos] SET  READ_WRITE 
GO
