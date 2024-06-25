
USE DB_SISTEMA_VENTA
GO

SELECT * FROM Rol
SELECT * FROM Usuario
SELECT * FROM Permiso
SELECT * FROM Categoria
SELECT * FROM Producto
SELECT * FROM Venta
SELECT * FROM DetalleVenta
SELECT * FROM Compra
SELECT * FROM DetalleCompra
SELECT * FROM Cliente
SELECT * FROM Proveedor

select p.IdRol, NombreMenu from Permiso p  
inner join Rol r on r.IdRol = p.IdRol
inner join Usuario u on u.IdRol = r.IdRol
where u.IdUsuario = 2


SELECT u.IdUsuario, u.Documento, u.NombreCompleto, u.Correo, u.Clave, u.Estado, r.IdRol, r.Descripcion FROM Usuario u
INNER JOIN Rol r on r.IdRol = u.IdRol



SELECT IdCategoria, Descripcion, Estado FROM Categoria


SELECT IdProducto,Codigo,Nombre, p.Descripcion, c.IdCategoria, c.Descripcion 'DescripcionCategoria', Stock, PrecioCompra,PrecioVenta,p.Estado FROM Producto p
INNER JOIN Categoria c ON c.IdCategoria = p.IdCategoria

SELECT IdCliente, Documento, NombreCompleto, Correo, Telefono, Estado FROM Cliente