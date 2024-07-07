
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
SELECT * FROM Negocio

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

SELECT IdProveedor, Documento, RazonSocial, Correo, Telefono, Estado FROM Proveedor

SELECT IdNegocio, Nombre, RUC, Direccion, Logo FROM Negocio WHERE IdNegocio = 1


select count(*) + 1 from COMPRA


select * from COMPRA where NumeroDocumento = '00002'
select * from DETALLECOMPRA where IdCompra = 12


SELECT 
 c.IdCompra, c.TipoDocumento, c.NumeroDocumento, c.MontoTotal, convert(char(10),c.FechaRegistro,103) 'FechaRegistro',
 p.Documento, p.RazonSocial, 
 u.NombreCompleto
FROM Compra c 
INNER JOIN Usuario u ON u.IdUsuario = c.IdUsuario
INNER JOIN Proveedor p ON p.IdProveedor = c.IdProveedor
WHERE c.NumeroDocumento = '00001'



SELECT 
 p.Nombre, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal
FROM DetalleCompra dc
INNER JOIN Producto p ON p.IdProducto = dc.IdProducto
WHERE dc.IdCompra = 12


update producto set stock = stock - @idProducto where idproducto = @idProducto

SELECT * FROM Producto





SELECT * FROM VENTA
SELECT * FROM compra
SELECT * FROM DetalleCompra
SELECT * FROM DetalleVenta
SELECT * FROM Producto

SELECT v.IdVenta,
 v.DocumentoCliente, v.NombreCliente,
 v.TipoDocumento, v.NumeroDocumento,
 v.MontoTotal, v.MontoCambio, v.MontoPago,
 convert(char(10),v.FechaRegistro,103) 'FechaRegistro',
 u.NombreCompleto
FROM Venta v 
INNER JOIN Usuario u ON u.IdUsuario = v.IdUsuario
WHERE v.NumeroDocumento = '00001'

SELECT p.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal
FROM DetalleVenta dv
INNER JOIN Producto p ON p.IdProducto = dv.IdProducto
WHERE dv.IdVenta = 12



SELECT
    CONVERT(char(10), c.FechaRegistro, 103) AS FechaRegistro,
    c.TipoDocumento,
    c.NumeroDocumento,
    c.MontoTotal,
    u.NombreCompleto AS UsuarioRegistro,
    pr.Documento AS DocumentoProveedor,
    pr.RazonSocial,
    p.Codigo AS CodigoProducto,
    p.Nombre AS NombreProducto,
    ca.Descripcion AS Categoria,
    dc.PrecioCompra,
    dc.PrecioVenta,
    dc.Cantidad,
    dc.MontoTotal AS SubTotal
FROM COMPRA c
INNER JOIN USUARIO u ON u.IdUsuario = c.IdUsuario
INNER JOIN PROVEEDOR pr ON pr.IdProveedor = c.IdProveedor
INNER JOIN DETALLECOMPRA dc ON dc.IdCompra = c.IdCompra
INNER JOIN PRODUCTO p ON p.IdProducto = dc.IdProducto
INNER JOIN CATEGORIA ca ON ca.IdCategoria = p.IdCategoria
WHERE CONVERT(DATE, c.FechaRegistro) BETWEEN '2024-06-30' AND '2024-07-30';


