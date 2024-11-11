USE ComercioSeguridad;
GO

-- Insertar datos en Categorías
INSERT INTO Categorias (nombre, descripcion) VALUES 
('Cámaras de Seguridad', 'Cámaras de vigilancia para uso residencial y comercial'),
('Sistemas de Alarmas', 'Alarmas contra robos e incendios'),
('Control de Acceso', 'Dispositivos de control de acceso y biometría'),
('Grabadores DVR/NVR', 'Dispositivos de grabación de video para sistemas de cámaras'),
('Sensores de Movimiento', 'Sensores para detectar movimiento'),
('Kits de Seguridad', 'Kits completos de seguridad para hogares'),
('Intercomunicadores', 'Sistemas de intercomunicación para empresas y residencias'),
('Accesorios', 'Accesorios adicionales para sistemas de seguridad'),
('Monitores', 'Monitores para visualizar cámaras de seguridad'),
('Fuentes de Poder', 'Fuentes de poder para dispositivos de seguridad');
GO

-- Insertar datos en Productos
INSERT INTO Productos (nombre, descripcion, precio, stock, id_categoria, imagen_url) VALUES 
('Cámara IP', 'Cámara IP para vigilancia', 120.50, 50, 1, 'url_imagen_1'),
('Alarma Antirrobo', 'Alarma contra robos', 200.00, 30, 2, 'url_imagen_2'),
('Lector de Huellas', 'Control de acceso con huella digital', 150.75, 20, 3, 'url_imagen_3'),
('DVR 4 Canales', 'Grabador de video digital para 4 cámaras', 100.00, 15, 4, 'url_imagen_4'),
('Sensor de Movimiento', 'Sensor de movimiento PIR', 25.00, 100, 5, 'url_imagen_5'),
('Kit de Seguridad', 'Kit completo con cámara y DVR', 300.00, 10, 6, 'url_imagen_6'),
('Intercomunicador', 'Intercomunicador de video', 80.00, 40, 7, 'url_imagen_7'),
('Cable HDMI', 'Cable HDMI de 10 metros', 15.00, 200, 8, 'url_imagen_8'),
('Monitor 19 Pulgadas', 'Monitor para sistemas de seguridad', 180.00, 12, 9, 'url_imagen_9'),
('Fuente de Poder 12V', 'Fuente de poder para cámaras', 20.00, 100, 10, 'url_imagen_10');
GO

-- Insertar datos en Clientes
INSERT INTO Clientes (nombre, apellido, email, telefono, direccion, ciudad, pais) VALUES 
('Juan', 'Pérez', 'juan.perez@example.com', '5551234567', 'Calle Falsa 123', 'Lima', 'Perú'),
('María', 'López', 'maria.lopez@example.com', '5552345678', 'Av. Principal 456', 'Cusco', 'Perú'),
('Carlos', 'Sánchez', 'carlos.sanchez@example.com', '5553456789', 'Jr. Secundario 789', 'Arequipa', 'Perú'),
('Ana', 'García', 'ana.garcia@example.com', '5554567890', 'Av. Secundaria 321', 'Trujillo', 'Perú'),
('Luis', 'Ramírez', 'luis.ramirez@example.com', '5555678901', 'Calle Tercera 654', 'Chiclayo', 'Perú'),
('Claudia', 'Torres', 'claudia.torres@example.com', '5556789012', 'Av. Cuarta 987', 'Piura', 'Perú'),
('Miguel', 'Vargas', 'miguel.vargas@example.com', '5557890123', 'Jr. Quinta 210', 'Tacna', 'Perú'),
('Rosa', 'Castro', 'rosa.castro@example.com', '5558901234', 'Av. Sexta 543', 'Iquitos', 'Perú'),
('Alberto', 'Rojas', 'alberto.rojas@example.com', '5559012345', 'Calle Séptima 876', 'Puno', 'Perú'),
('Patricia', 'Flores', 'patricia.flores@example.com', '5550123456', 'Jr. Octava 109', 'Huancayo', 'Perú');
GO

-- Insertar datos en Roles
INSERT INTO Roles (nombre, descripcion) VALUES 
('Cliente', 'Usuario con permisos para realizar compras en el comercio electrónico'),
('Administrador', 'Usuario con permisos para gestionar el inventario, usuarios y pedidos');
GO

-- Insertar datos en Usuarios
INSERT INTO Usuarios (id_cliente, username, password_hash, email, id_rol, estado) VALUES 
(1, 'jperez', 'hashed_password_example1', 'jperez@example.com', 1, 'Activo'),
(2, 'mlopez', 'hashed_password_example2', 'mlopez@example.com', 1, 'Activo'),
(3, 'csanchez', 'hashed_password_example3', 'csanchez@example.com', 1, 'Activo'),
(4, 'agarcia', 'hashed_password_example4', 'agarcia@example.com', 1, 'Activo'),
(5, 'admin', 'hashed_password_admin', 'admin@example.com', 2, 'Activo');
GO