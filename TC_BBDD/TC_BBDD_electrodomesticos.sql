USE [master]
GO
/****** Object:  Database [TC_Permisos]    Script Date: 28/04/2024 21:02:14 ******/
CREATE DATABASE [TC_Permisos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TC_Permisos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TC_Permisos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TC_Permisos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TC_Permisos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TC_Permisos] SET COMPATIBILITY_LEVEL = 150
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
/****** Object:  Table [dbo].[Administradores]    Script Date: 28/04/2024 21:02:14 ******/
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
/****** Object:  Table [dbo].[Almacen]    Script Date: 28/04/2024 21:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Almacen](
	[id] [int] NOT NULL,
	[nombre] [varchar](255) NULL,
	[ubicacion] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria_Producto]    Script Date: 28/04/2024 21:02:14 ******/
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
/****** Object:  Table [dbo].[clientes]    Script Date: 28/04/2024 21:02:14 ******/
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
/****** Object:  Table [dbo].[Factura]    Script Date: 28/04/2024 21:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[id] [int] NOT NULL,
	[clienteId] [int] NULL,
	[fecha] [date] NULL,
	[total] [decimal](10, 2) NULL,
	[vendedorId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[gestores_stock]    Script Date: 28/04/2024 21:02:14 ******/
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
/****** Object:  Table [dbo].[permisos]    Script Date: 28/04/2024 21:02:14 ******/
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
/****** Object:  Table [dbo].[Producto]    Script Date: 28/04/2024 21:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[id] [int] NOT NULL,
	[nombre] [varchar](255) NULL,
	[precio] [decimal](10, 2) NULL,
	[stockMinimo] [int] NULL,
	[stockActual] [int] NULL,
	[descripcion] [varchar](255) NULL,
	[categoriaId] [int] NULL,
	[proveedorId] [int] NULL,
	[almacenId] [int] NULL,
	[clienteId] [int] NULL,
	[gestorStockId] [int] NULL,
	[vendedorId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 28/04/2024 21:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[id] [int] NOT NULL,
	[nombre] [varchar](255) NULL,
	[direccion] [varchar](255) NULL,
	[telefono] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 28/04/2024 21:02:14 ******/
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
/****** Object:  Table [dbo].[roles_permisos]    Script Date: 28/04/2024 21:02:14 ******/
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
/****** Object:  Table [dbo].[roles_usuarios]    Script Date: 28/04/2024 21:02:14 ******/
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
/****** Object:  Table [dbo].[usuarios]    Script Date: 28/04/2024 21:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[email] [varchar](255) NOT NULL,
	[password] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vendedores]    Script Date: 28/04/2024 21:02:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vendedores](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombreVendedor] [varchar](255) NOT NULL,
	[cuilVendedor] [varchar](255) NOT NULL,
	[id_user_creador] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Administradores] ADD  CONSTRAINT [DF_Administradores_id_usuario_creador]  DEFAULT (NULL) FOR [id_usuario_creador]
GO
ALTER TABLE [dbo].[clientes] ADD  DEFAULT (NULL) FOR [id_usuario_creador]
GO
ALTER TABLE [dbo].[gestores_stock] ADD  DEFAULT (NULL) FOR [id_user_creador]
GO
ALTER TABLE [dbo].[vendedores] ADD  DEFAULT (NULL) FOR [id_user_creador]
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
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [fk_cliente] FOREIGN KEY([clienteId])
REFERENCES [dbo].[clientes] ([id])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [fk_cliente]
GO
ALTER TABLE [dbo].[gestores_stock]  WITH CHECK ADD  CONSTRAINT [FK_gestores_stock_creador] FOREIGN KEY([id_user_creador])
REFERENCES [dbo].[usuarios] ([id])
GO
ALTER TABLE [dbo].[gestores_stock] CHECK CONSTRAINT [FK_gestores_stock_creador]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [fk_almacen] FOREIGN KEY([almacenId])
REFERENCES [dbo].[Almacen] ([id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [fk_almacen]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [fk_categoria] FOREIGN KEY([categoriaId])
REFERENCES [dbo].[Categoria_Producto] ([id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [fk_categoria]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [fk_cliente_producto] FOREIGN KEY([clienteId])
REFERENCES [dbo].[clientes] ([id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [fk_cliente_producto]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [fk_gestorStock_producto] FOREIGN KEY([gestorStockId])
REFERENCES [dbo].[gestores_stock] ([id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [fk_gestorStock_producto]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [fk_proveedor] FOREIGN KEY([proveedorId])
REFERENCES [dbo].[Proveedor] ([id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [fk_proveedor]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [fk_vendedor_producto] FOREIGN KEY([vendedorId])
REFERENCES [dbo].[vendedores] ([id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [fk_vendedor_producto]
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
ALTER TABLE [dbo].[vendedores]  WITH CHECK ADD  CONSTRAINT [FK_vendedores_creador] FOREIGN KEY([id_user_creador])
REFERENCES [dbo].[usuarios] ([id])
GO
ALTER TABLE [dbo].[vendedores] CHECK CONSTRAINT [FK_vendedores_creador]
GO
USE [master]
GO
ALTER DATABASE [TC_Permisos] SET  READ_WRITE 
GO
