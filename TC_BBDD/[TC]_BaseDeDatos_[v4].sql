USE [master]
GO
/****** Object:  Database [TC_Permisos]    Script Date: 12/06/2024 15:11:50 ******/
CREATE DATABASE [TC_Permisos]
 CONTAINMENT = NONE
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
ALTER DATABASE [TC_Permisos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TC_Permisos] SET QUERY_STORE = OFF
GO
USE [TC_Permisos]
GO
/****** Object:  Table [dbo].[Administradores]    Script Date: 12/06/2024 15:11:50 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria_Producto]    Script Date: 12/06/2024 15:11:50 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 12/06/2024 15:11:50 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_factura]    Script Date: 12/06/2024 15:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_factura](
	[id_detalle] [int] IDENTITY(1,1) NOT NULL,
	[id_factura] [int] NOT NULL,
	[producto_comprado] [varchar](150) NULL,
	[cantidad] [int] NULL,
	[subtotal] [decimal](15, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 12/06/2024 15:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NULL,
	[fecha_compra] [date] NULL,
	[total] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[gestores_stock]    Script Date: 12/06/2024 15:11:50 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permisos]    Script Date: 12/06/2024 15:11:50 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 12/06/2024 15:11:50 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 12/06/2024 15:11:50 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles_permisos]    Script Date: 12/06/2024 15:11:50 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles_usuarios]    Script Date: 12/06/2024 15:11:50 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 12/06/2024 15:11:50 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Administradores] ON 

INSERT [dbo].[Administradores] ([id], [nombreAdmin], [cuilAdmin], [id_usuario_creador]) VALUES (1, N'Econtrera', N'2042045544', 1)
SET IDENTITY_INSERT [dbo].[Administradores] OFF
GO
INSERT [dbo].[Categoria_Producto] ([id], [nombre]) VALUES (1, N'Accesorios Oficina')
INSERT [dbo].[Categoria_Producto] ([id], [nombre]) VALUES (2, N'Hardware PC')
INSERT [dbo].[Categoria_Producto] ([id], [nombre]) VALUES (3, N'Electronica de Ocio')
INSERT [dbo].[Categoria_Producto] ([id], [nombre]) VALUES (4, N'Electrodomesticos')
INSERT [dbo].[Categoria_Producto] ([id], [nombre]) VALUES (5, N'Informatica y Telecomunicaciones')
INSERT [dbo].[Categoria_Producto] ([id], [nombre]) VALUES (6, N'Herramientas Electronicas')
INSERT [dbo].[Categoria_Producto] ([id], [nombre]) VALUES (7, N'Aparatos Medicos')
INSERT [dbo].[Categoria_Producto] ([id], [nombre]) VALUES (8, N'Instrumento Vigilancia')
GO
SET IDENTITY_INSERT [dbo].[clientes] ON 

INSERT [dbo].[clientes] ([id], [nombre], [cuil], [id_usuario_creador]) VALUES (1, N'Cliente', N'20-12341234-1', 4)
INSERT [dbo].[clientes] ([id], [nombre], [cuil], [id_usuario_creador]) VALUES (2, N'Elias Contrera', N'2043341212', 10)
INSERT [dbo].[clientes] ([id], [nombre], [cuil], [id_usuario_creador]) VALUES (3, N'Fede', N'fede', 11)
SET IDENTITY_INSERT [dbo].[clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[detalle_factura] ON 

INSERT [dbo].[detalle_factura] ([id_detalle], [id_factura], [producto_comprado], [cantidad], [subtotal]) VALUES (1, 1, N'Mouse', 7, CAST(74200.00 AS Decimal(15, 2)))
INSERT [dbo].[detalle_factura] ([id_detalle], [id_factura], [producto_comprado], [cantidad], [subtotal]) VALUES (2, 1, N'Auriculares', 1, CAST(5658.00 AS Decimal(15, 2)))
INSERT [dbo].[detalle_factura] ([id_detalle], [id_factura], [producto_comprado], [cantidad], [subtotal]) VALUES (3, 2, N'Teclado', 9, CAST(85500.00 AS Decimal(15, 2)))
INSERT [dbo].[detalle_factura] ([id_detalle], [id_factura], [producto_comprado], [cantidad], [subtotal]) VALUES (4, 2, N'Mouse', 2, CAST(21200.00 AS Decimal(15, 2)))
INSERT [dbo].[detalle_factura] ([id_detalle], [id_factura], [producto_comprado], [cantidad], [subtotal]) VALUES (5, 3, N'Teclado', 1, CAST(9500.00 AS Decimal(15, 2)))
INSERT [dbo].[detalle_factura] ([id_detalle], [id_factura], [producto_comprado], [cantidad], [subtotal]) VALUES (6, 3, N'Auriculares', 1, CAST(5658.00 AS Decimal(15, 2)))
SET IDENTITY_INSERT [dbo].[detalle_factura] OFF
GO
SET IDENTITY_INSERT [dbo].[Factura] ON 

INSERT [dbo].[Factura] ([id], [id_usuario], [fecha_compra], [total]) VALUES (1, 10, CAST(N'2024-06-07' AS Date), CAST(79858.00 AS Decimal(10, 2)))
INSERT [dbo].[Factura] ([id], [id_usuario], [fecha_compra], [total]) VALUES (2, 11, CAST(N'2024-06-07' AS Date), CAST(106700.00 AS Decimal(10, 2)))
INSERT [dbo].[Factura] ([id], [id_usuario], [fecha_compra], [total]) VALUES (3, 11, CAST(N'2024-06-07' AS Date), CAST(15158.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Factura] OFF
GO
SET IDENTITY_INSERT [dbo].[gestores_stock] ON 

INSERT [dbo].[gestores_stock] ([id], [nombreGestor], [cuilGestor], [id_user_creador]) VALUES (1, N'GestorElias', N'20432399452', 3)
SET IDENTITY_INSERT [dbo].[gestores_stock] OFF
GO
SET IDENTITY_INSERT [dbo].[permisos] ON 

INSERT [dbo].[permisos] ([id], [nombre]) VALUES (1, N'crear cliente')
INSERT [dbo].[permisos] ([id], [nombre]) VALUES (2, N'editar cliente propio')
INSERT [dbo].[permisos] ([id], [nombre]) VALUES (3, N'editar cualquier cliente')
INSERT [dbo].[permisos] ([id], [nombre]) VALUES (4, N'eliminar cliente')
INSERT [dbo].[permisos] ([id], [nombre]) VALUES (5, N'modificar usuario')
INSERT [dbo].[permisos] ([id], [nombre]) VALUES (6, N'eliminar usuario')
INSERT [dbo].[permisos] ([id], [nombre]) VALUES (7, N'alta usuario')
INSERT [dbo].[permisos] ([id], [nombre]) VALUES (8, N'ver clientes')
INSERT [dbo].[permisos] ([id], [nombre]) VALUES (9, N'ver facturas')
SET IDENTITY_INSERT [dbo].[permisos] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([id], [nombre], [precio], [stockMinimo], [stockActual], [descripcion], [categoriaId]) VALUES (1, N'Auriculares', CAST(5658.00 AS Decimal(10, 2)), 7, 31, N'JBL High Fidelity Cableado Red', 1)
INSERT [dbo].[Producto] ([id], [nombre], [precio], [stockMinimo], [stockActual], [descripcion], [categoriaId]) VALUES (2, N'Mouse', CAST(10600.00 AS Decimal(10, 2)), 7, 20, N'Razor Inhalambrico', 1)
INSERT [dbo].[Producto] ([id], [nombre], [precio], [stockMinimo], [stockActual], [descripcion], [categoriaId]) VALUES (3, N'Teclado', CAST(9500.00 AS Decimal(10, 2)), 7, 9, N'Genius', 1)
INSERT [dbo].[Producto] ([id], [nombre], [precio], [stockMinimo], [stockActual], [descripcion], [categoriaId]) VALUES (4, N'Webcam', CAST(15990.00 AS Decimal(10, 2)), 7, 1, N'Logitech HD', 1)
INSERT [dbo].[Producto] ([id], [nombre], [precio], [stockMinimo], [stockActual], [descripcion], [categoriaId]) VALUES (5, N'Televisor', CAST(260333.00 AS Decimal(10, 2)), 7, 4, N'LG 4K 30 In', 1)
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[roles] ON 

INSERT [dbo].[roles] ([id], [nombre]) VALUES (1, N'administrador')
INSERT [dbo].[roles] ([id], [nombre]) VALUES (2, N'gerente')
INSERT [dbo].[roles] ([id], [nombre]) VALUES (3, N'usuario')
INSERT [dbo].[roles] ([id], [nombre]) VALUES (5, N'gestorStock')
SET IDENTITY_INSERT [dbo].[roles] OFF
GO
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
GO
SET IDENTITY_INSERT [dbo].[roles_usuarios] ON 

INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (2, 1, 1)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (3, 2, 2)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (4, 2, 3)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (5, 3, 4)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (6, 3, 5)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (28, 5, 6)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (29, 3, 7)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (30, 3, 8)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (31, 1, 9)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (32, 3, 10)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (33, 3, 11)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (34, 2, 12)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (35, 1, 13)
INSERT [dbo].[roles_usuarios] ([id], [id_rol], [id_usuario]) VALUES (36, 3, 14)
SET IDENTITY_INSERT [dbo].[roles_usuarios] OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (1, N'Administrador', N'elias@mail.com', N'123', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (2, N'Empleado 1', N'gerente@mail.com', N'123', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (3, N'Matias', N'gerente@gmail.com', N'123', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (4, N'Usuario 1', N'usuario@mail.com', N'123', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (5, N'Usuario 2', N'usuario@gmail.com', N'123', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (6, N'Eliasxde', N'gestor@mail.com.ar', N'1234', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (7, N'hola buenas', N'elias@mail.com.ar', N'123', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (8, N'Hola', N'elias@mail.edu', N'123', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (9, N'Gaston', N'gaston@mail.com.ar', N'123', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (10, N'eliasxd', N'asd', N'123', N'inactivo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (11, N'Fede', N'fede@mail.com.ar', N'123', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (12, N'Matias', N'matimail.com', N'123', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (13, N'holawenas', N'wenasmail.com', N'123', N'activo')
INSERT [dbo].[usuarios] ([id], [nombre], [email], [password], [estado]) VALUES (14, N'asd', N'eliasmail.com', N'123', N'activo')
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
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
ALTER TABLE [dbo].[detalle_factura]  WITH CHECK ADD FOREIGN KEY([id_factura])
REFERENCES [dbo].[Factura] ([id])
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
