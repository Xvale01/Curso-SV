
USE DB_SISTEMA_VENTA
GO

INSERT INTO Rol (Descripcion)
VALUES ('ADMINISTRADOR')

INSERT INTO Rol (Descripcion)
VALUES ('EMPLEADO')

INSERT INTO Usuario (Documento,NombreCompleto,Correo,Clave,IdRol,Estado)
VALUES ('10','VALERIA','@GMAIL.COM','123',1,1)

INSERT INTO Usuario (Documento,NombreCompleto,Correo,Clave,IdRol,Estado)
VALUES ('20','BRYAN','@GMAIL.COM','123',2,1)

INSERT INTO Usuario (Documento,NombreCompleto,Correo,Clave,IdRol,Estado)
VALUES ('40','LILLIAM','@GMAIL.COM','123',1,1)

INSERT INTO Usuario (Documento,NombreCompleto,Correo,Clave,IdRol,Estado)
VALUES ('50','NUCITA','@GMAIL.COM','123',2,2)

INSERT INTO Permiso (IdRol,NombreMenu) VALUES 
(1,'menuUsuarios'),
(1,'menuMantenedor'),
(1,'menuVentas'),
(1,'menuCompras'),
(1,'menuClientes'),
(1,'menuProveedores'),
(1,'menuReportes'),
(1,'menuAcercaDe')

INSERT INTO Permiso (IdRol,NombreMenu) VALUES 
(2,'menuVentas'),
(2,'menuCompras'),
(2,'menuClientes'),
(2,'menuProveedores'),
(2,'menuAcercaDe')


INSERT INTO Producto (Codigo,Nombre,Descripcion,IdCategoria,Estado) VALUES ('10' , 'Leche' , '1 litro', 5 , 1)
INSERT INTO Negocio (IdNegocio,Nombre,RUC,Direccion) VALUES (1, 'Sistema de Venta' , '101010', 'av. codigo')