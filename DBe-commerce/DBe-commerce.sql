-- Base de datos para un comercio de equipos de seguridad electr�nica B2C

-- Creaci�n de la base de datos
CREATE DATABASE ComercioSeguridad;
GO
USE ComercioSeguridad;
GO

-- Tabla de Categor�as de productos
CREATE TABLE Categorias (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    descripcion TEXT
);
GO

-- Tabla de Productos
CREATE TABLE Productos (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(150) NOT NULL,
    descripcion TEXT,
    precio DECIMAL(10, 2) NOT NULL,
    stock INT DEFAULT 0,
    id_categoria INT,
    imagen_url VARCHAR(255),
    fecha_agregado DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (id_categoria) REFERENCES Categorias(id) ON DELETE SET NULL
);
GO

-- Tabla de Clientes
CREATE TABLE Clientes (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    email VARCHAR(150) NOT NULL UNIQUE,
    telefono VARCHAR(20),
    direccion VARCHAR(255),
    ciudad VARCHAR(100),
    pais VARCHAR(50),
    fecha_registro DATETIME DEFAULT GETDATE()
);
GO

-- Tabla de Pedidos
CREATE TABLE Pedidos (
    id INT IDENTITY(1,1) PRIMARY KEY,
    id_cliente INT,
    fecha_pedido DATETIME DEFAULT GETDATE(),
    estado VARCHAR(20) CHECK (estado IN ('Pendiente', 'Procesado', 'Enviado', 'Entregado', 'Cancelado')) DEFAULT 'Pendiente',
    total DECIMAL(10, 2),
    FOREIGN KEY (id_cliente) REFERENCES Clientes(id) ON DELETE CASCADE
);
GO

-- Tabla de Detalles de Pedido
CREATE TABLE DetallesPedido (
    id INT IDENTITY(1,1) PRIMARY KEY,
    id_pedido INT,
    id_producto INT,
    cantidad INT NOT NULL,
    precio DECIMAL(10, 2) NOT NULL,
    subtotal AS (cantidad * precio) PERSISTED,
    FOREIGN KEY (id_pedido) REFERENCES Pedidos(id) ON DELETE CASCADE,
    FOREIGN KEY (id_producto) REFERENCES Productos(id) ON DELETE SET NULL
);
GO

-- Tabla de M�todos de Pago
CREATE TABLE MetodosPago (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    descripcion TEXT
);
GO

-- Tabla de Pagos
CREATE TABLE Pagos (
    id INT IDENTITY(1,1) PRIMARY KEY,
    id_pedido INT,
    id_metodo_pago INT,
    fecha_pago DATETIME DEFAULT GETDATE(),
    monto DECIMAL(10, 2) NOT NULL,
    estado VARCHAR(20) CHECK (estado IN ('Pendiente', 'Completado', 'Fallido')) DEFAULT 'Pendiente',
    FOREIGN KEY (id_pedido) REFERENCES Pedidos(id) ON DELETE CASCADE,
    FOREIGN KEY (id_metodo_pago) REFERENCES MetodosPago(id) ON DELETE SET NULL
);
GO



-- Tabla de Roles para definir los tipos de usuario (Cliente, Administrador, etc.)
CREATE TABLE Roles (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL UNIQUE,
    descripcion TEXT
);
GO

-- Tabla de Usuarios para el sistema de autenticaci�n
CREATE TABLE Usuarios (
    id INT IDENTITY(1,1) PRIMARY KEY,
    id_cliente INT,
    username VARCHAR(50) NOT NULL UNIQUE,
    password_hash VARCHAR(255) NOT NULL, -- Se almacena el hash de la contrase�a
    email VARCHAR(150) NOT NULL UNIQUE,
    id_rol INT,
    estado VARCHAR(10) CHECK (estado IN ('Activo', 'Inactivo')) DEFAULT 'Activo',
    fecha_registro DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (id_cliente) REFERENCES Clientes(id) ON DELETE CASCADE,
    FOREIGN KEY (id_rol) REFERENCES Roles(id) ON DELETE SET NULL
);
GO

-- Tabla para registrar cada intento de acceso (login)
CREATE TABLE HistorialAcceso (
    id INT IDENTITY(1,1) PRIMARY KEY,
    id_usuario INT,
    fecha_acceso DATETIME DEFAULT GETDATE(),
    direccion_ip VARCHAR(45), -- Direcci�n IP del usuario
    exito BIT, -- Indica si el acceso fue exitoso o no (0 = No, 1 = S�)
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id) ON DELETE CASCADE
);
GO

