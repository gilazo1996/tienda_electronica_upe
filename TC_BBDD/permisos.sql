-- Crear la tabla clientes con columna id como identidad
CREATE TABLE clientes (
  id INT PRIMARY KEY IDENTITY(1,1),
  nombre VARCHAR(255) NOT NULL,
  cuil VARCHAR(255) NOT NULL,
  id_usuario_creador INT DEFAULT NULL
);

-- Crear la tabla permisos con columna id como identidad
CREATE TABLE permisos (
  id INT PRIMARY KEY IDENTITY(1,1),
  nombre VARCHAR(255) NOT NULL
);

-- Crear la tabla roles con columna id como identidad
CREATE TABLE roles (
  id INT PRIMARY KEY IDENTITY(1,1),
  nombre VARCHAR(255) NOT NULL
);

-- Crear la tabla roles_permisos con columna id como identidad
CREATE TABLE roles_permisos (
  id INT PRIMARY KEY IDENTITY(1,1),
  id_rol INT NOT NULL,
  id_permiso INT NOT NULL,
  CONSTRAINT FK_roles_permisos_rol FOREIGN KEY (id_rol) REFERENCES roles(id),
  CONSTRAINT FK_roles_permisos_permiso FOREIGN KEY (id_permiso) REFERENCES permisos(id)
);

-- Crear la tabla usuarios con columna id como identidad
CREATE TABLE usuarios (
  id INT PRIMARY KEY IDENTITY(1,1),
  nombre VARCHAR(255) NOT NULL,
  email VARCHAR(255) NOT NULL,
  password VARCHAR(255) NOT NULL
);
-- Crear la tabla roles_usuarios con columna id como identidad
CREATE TABLE roles_usuarios (
  id INT PRIMARY KEY IDENTITY(1,1),
  id_rol INT NOT NULL,
  id_usuario INT NOT NULL,
  CONSTRAINT FK_roles_usuarios_rol FOREIGN KEY (id_rol) REFERENCES roles(id),
  CONSTRAINT FK_roles_usuarios_usuario FOREIGN KEY (id_usuario) REFERENCES usuarios(id)
);

