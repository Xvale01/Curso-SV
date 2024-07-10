
USE DB_SISTEMA_VENTA
GO



/* ----------------- USUARIOS ----------------- */



CREATE PROCEDURE SP_RegistrarUsuario (
@Documento VARCHAR(50),
@NombreCompleto VARCHAR(100),
@Correo VARCHAR(100),
@Clave VARCHAR(100),
@IdRol INT,
@Estado BIT,
@IdUsuarioResultado INT OUTPUT,
@Mensaje VARCHAR(500) OUTPUT
)
AS BEGIN
	SET @IdUsuarioResultado = 0;
	SET @Mensaje = ''
	IF NOT EXISTS (SELECT * FROM USUARIO WHERE Documento = @Documento)
	BEGIN 
		INSERT INTO Usuario(Documento, NombreCompleto, Correo, Clave, IdRol, Estado)
		VALUES (@Documento,@NombreCompleto,@Correo,@Clave,@IdRol,@Estado)
		SET @IdUsuarioResultado = SCOPE_IDENTITY()
	END
	ELSE
		SET @Mensaje = 'No se puede repetir el documento para más de un usuario'
END



CREATE PROCEDURE SP_EditarUsuario (
@IdUsuario int,
@Documento VARCHAR(50),
@NombreCompleto VARCHAR(100),
@Correo VARCHAR(100),
@Clave VARCHAR(100),
@IdRol INT,
@Estado BIT,
@Respuesta BIT OUTPUT,
@Mensaje VARCHAR(500) OUTPUT
)
AS BEGIN
	SET @Respuesta = 0;
	SET @Mensaje = ''

	IF NOT EXISTS (SELECT * FROM USUARIO WHERE Documento = @Documento AND idusuario != @IdUsuario)
	BEGIN 
		UPDATE Usuario SET
		Documento = @Documento,
		NombreCompleto = @NombreCompleto,
		Correo = @Correo,
		Clave = @Clave,
		IdRol = @IdRol,
		Estado = @Estado
		WHERE IdUsuario = @IdUsuario

		SET @Respuesta = 1
	END
	ELSE
		SET @Mensaje = 'No se puede repetir el documento para más de un usuario'
END


CREATE PROCEDURE SP_EliminarUsuario (
@IdUsuario int,
@Respuesta BIT OUTPUT,
@Mensaje VARCHAR(500) OUTPUT
)
AS BEGIN
	SET @Respuesta = 0;
	SET @Mensaje = ''
	DECLARE @PasoReglas bit = 1



	IF  EXISTS 
	(
		SELECT * FROM COMPRA C
		INNER JOIN USUARIO U ON U.IdUsuario = C.IdUsuario
		WHERE U.IdUsuario = @IdUsuario
	)
	BEGIN 
		SET @PasoReglas = 0
		SET @Respuesta = 0
		SET @Mensaje = @Mensaje + 'No se puede eliminar porque el usuario se encuentra relacionado a una COMPRA\n'
	END


	IF  EXISTS 
	(
		SELECT * FROM VENTA V
		INNER JOIN USUARIO U ON U.IdUsuario = V.IdUsuario
		WHERE U.IdUsuario = @IdUsuario
	)
	BEGIN 
		SET @PasoReglas = 0
		SET @Respuesta = 0;
		SET @Mensaje = @Mensaje + 'No se puede eliminar porque el usuario se encuentra relacionado a una VENTA\n'
	END


	IF(@PasoReglas = 1)
	BEGIN
		DELETE FROM Usuario	WHERE IdUsuario = @IdUsuario
		SET @Respuesta = 1;
	END
END




/* ----------------- CATEGORIAS ----------------- */




CREATE  PROCEDURE SP_RegistrarCategoria (
@Descripcion VARCHAR(50),
@Estado BIT,
@Respuesta INT OUTPUT,
@Mensaje VARCHAR(500) OUTPUT
)
AS BEGIN
	SET @Respuesta = 0;
	IF NOT EXISTS (SELECT * FROM Categoria WHERE Descripcion = @Descripcion)
	BEGIN 
		INSERT INTO Categoria(Descripcion,Estado)
		VALUES (@Descripcion,@Estado)
		SET @Respuesta = SCOPE_IDENTITY()
	END
	ELSE
		SET @Mensaje = 'No se puede repetir la descripcion de una categoría'
END


CREATE  PROCEDURE SP_EditarCategoria (
@IdCategoria int,
@Descripcion VARCHAR(50),
@Estado BIT,
@Respuesta BIT OUTPUT,
@Mensaje VARCHAR(500) OUTPUT
)
AS BEGIN
	SET @Respuesta = 1;
	SET @Mensaje = ''

	IF NOT EXISTS (SELECT * FROM Categoria WHERE Descripcion = @Descripcion AND IdCategoria != @IdCategoria)
	BEGIN 
		UPDATE Categoria SET
		Descripcion = @Descripcion,
		Estado = @Estado
		WHERE IdCategoria = @IdCategoria

		SET @Respuesta = 0
	END
	ELSE
		SET @Mensaje = 'No se puede repetir la descripcion de una categoría'
END


CREATE PROCEDURE SP_EliminarCategoria (
@IdCategoria int,
@Respuesta BIT OUTPUT,
@Mensaje VARCHAR(500) OUTPUT
)
AS BEGIN
	SET @Respuesta = 1;

	IF NOT EXISTS (	SELECT * FROM Categoria C 
	INNER JOIN PRODUCTO P ON P.IdCategoria = C.IdCategoria
	WHERE C.IdCategoria = @IdCategoria	)

	BEGIN 
		DELETE top(1) FROM Categoria WHERE IdCategoria = @IdCategoria
	END
	ELSE
		SET @Respuesta = 0;
		SET @Mensaje = 'La categoría se encuentra relacionada a un producto'
END
go





/* ----------------- PRODUCTOS ----------------- */



CREATE PROCEDURE  SP_RegistrarProducto (
@Codigo VARCHAR(50),
@Nombre VARCHAR(100),
@Descripcion VARCHAR(50),
@IdCategoria INT,
@Estado BIT,
@Respuesta INT OUTPUT,
@Mensaje VARCHAR(500) OUTPUT
)
AS BEGIN
	SET @Respuesta = 0
	IF NOT EXISTS (SELECT * FROM Producto WHERE Codigo = @Codigo)
	BEGIN 
		INSERT INTO Producto(Codigo,Nombre,Descripcion,IdCategoria,Estado)
		VALUES (@Codigo,@Nombre,@Descripcion,@IdCategoria,@Estado)
		SET @Respuesta = SCOPE_IDENTITY()
	END
	ELSE
		SET @Mensaje = 'Ya existe un producto con el mismo código'
END
GO


CREATE PROCEDURE SP_EditarProducto(
@IdProducto INT,
@Codigo VARCHAR(50),
@Nombre VARCHAR(100),
@Descripcion VARCHAR(50),
@IdCategoria INT,
@Estado BIT,
@Respuesta INT OUTPUT,
@Mensaje VARCHAR(500) OUTPUT
)
AS BEGIN
	SET @Respuesta = 1
	IF NOT EXISTS (SELECT * FROM Producto WHERE Codigo = @Codigo AND IdProducto != @IdProducto)
		UPDATE PRODUCTO SET
		Codigo = @Codigo,
		Nombre = @Nombre,
		Descripcion = @Descripcion,
		IdCategoria = @IdCategoria,
		Estado = @Estado
		WHERE IdProducto = @IdProducto
	ELSE
	BEGIN
		SET @Respuesta = 0
		SET @Mensaje = 'Ya existe un producto con el mismo código'
	END

END
GO

CREATE PROCEDURE SP_EliminarProducto(
@IdProducto INT,
@Respuesta INT OUTPUT,
@Mensaje VARCHAR(500) OUTPUT
)
AS BEGIN
	SET @Respuesta = 1;
	SET @Mensaje = '';
	DECLARE @PasoReglas BIT = 1

	IF EXISTS (	SELECT * FROM DetalleCompra C 
	INNER JOIN PRODUCTO P ON P.IdProducto = C.IdProducto
	WHERE C.IdProducto = @IdProducto)
	BEGIN 
		SET @PasoReglas = 0
		SET @Respuesta = 0;
		SET @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una COMPRA\n';
	END

	IF EXISTS (	SELECT * FROM DetalleVenta V 
	INNER JOIN PRODUCTO P ON P.IdProducto = V.IdProducto
	WHERE V.IdProducto = @IdProducto)
	BEGIN 
		SET @PasoReglas = 0
		SET @Respuesta = 0;
		SET @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una VENTA\n';
	END


	IF(@PasoReglas = 1)
	BEGIN
		DELETE FROM Producto WHERE IdProducto = @IdProducto
		SET @Respuesta = 1;
	END

END
GO




/* ----------------- CLIENTES ----------------- */
CREATE PROCEDURE  SP_RegistrarCliente (
@Documento VARCHAR(50),
@NombreCompleto VARCHAR(50),
@Correo VARCHAR(50),
@Telefono VARCHAR(50),
@Estado BIT,
@Respuesta INT OUTPUT,
@Mensaje VARCHAR(500) OUTPUT
)
AS BEGIN
	SET @Respuesta = 0
	DECLARE @IdPersona INT
	IF NOT EXISTS (SELECT * FROM Cliente WHERE Documento = @Documento)
	BEGIN 
		INSERT INTO Cliente(Documento,NombreCompleto,Correo,Telefono,Estado)
		VALUES (@Documento,@NombreCompleto,@Correo,@Telefono,@Estado)
		SET @Respuesta = SCOPE_IDENTITY()
	END
	ELSE
		SET @Mensaje = 'El número de documento ya existe'
END
GO


CREATE PROCEDURE SP_EditarCliente (
@IdCliente INT,
@Documento VARCHAR(50),
@NombreCompleto VARCHAR(50),
@Correo VARCHAR(50),
@Telefono VARCHAR(50),
@Estado BIT,
@Respuesta INT OUTPUT,
@Mensaje VARCHAR(500) OUTPUT
)
AS BEGIN
	SET @Respuesta = 1
	IF NOT EXISTS (SELECT * FROM Cliente WHERE Documento = @Documento AND IdCliente != @IdCliente)
		UPDATE Cliente SET
		Documento = @Documento,
		NombreCompleto = @NombreCompleto,
		Correo = @Correo,
		Telefono = @Telefono,
		Estado = @Estado
		WHERE IdCliente = @IdCliente
	ELSE
	BEGIN
		SET @Respuesta = 0
		SET @Mensaje = 'Ya existe un producto con el mismo código'
	END

END
GO



/* ---------------- PROVEEDORES ---------------- */
CREATE PROCEDURE  SP_RegistrarProveedor (
@Documento VARCHAR(50),
@RazonSocial VARCHAR(100),
@Correo VARCHAR(50),
@Telefono VARCHAR(50),
@Estado BIT,
@Respuesta INT OUTPUT,
@Mensaje VARCHAR(500) OUTPUT
)
AS BEGIN
	SET @Respuesta = 0
	IF NOT EXISTS (SELECT * FROM Proveedor WHERE Documento = @Documento)
	BEGIN 
		INSERT INTO Proveedor(Documento,RazonSocial,Correo,Telefono,Estado)
		VALUES (@Documento,@RazonSocial,@Correo,@Telefono,@Estado)
		SET @Respuesta = SCOPE_IDENTITY()
	END
	ELSE
		SET @Mensaje = 'El número de documento ya existe'
END
GO


CREATE PROCEDURE SP_EditarProveedor(
@IdProveedor INT,
@Documento VARCHAR(50),
@RazonSocial VARCHAR(100),
@Correo VARCHAR(50),
@Telefono VARCHAR(50),
@Estado BIT,
@Respuesta INT OUTPUT,
@Mensaje VARCHAR(500) OUTPUT
)
AS BEGIN
	SET @Respuesta = 1
	IF NOT EXISTS (SELECT * FROM Proveedor WHERE Documento = @Documento AND IdProveedor != @IdProveedor)
		UPDATE Proveedor SET
		Documento = @Documento,
		RazonSocial = @RazonSocial,
		Correo = @Correo,
		Telefono = @Telefono,
		Estado = @Estado
		WHERE IdProveedor = @IdProveedor
	ELSE
	BEGIN
		SET @Respuesta = 0
		SET @Mensaje = 'Ya existe un proveedor con el mismo docummento'
	END

END
GO

CREATE PROCEDURE SP_EliminarProveedor(
@IdProveedor INT,
@Respuesta INT OUTPUT,
@Mensaje VARCHAR(500) OUTPUT
)
AS BEGIN
	SET @Respuesta = 1;

	IF NOT EXISTS (	SELECT * FROM Compra C 
	INNER JOIN Proveedor P ON P.IdProveedor = C.IdProveedor
	WHERE C.IdProveedor = @IdProveedor)
	BEGIN
		DELETE TOP(1) FROM Proveedor WHERE IdProveedor = @IdProveedor
	END
	ELSE
	BEGIN
		SET @Respuesta = 0;
		SET @Mensaje = 'El proveedor se encuentra relaciondo con una compra'
	END
END
GO




/* ----------------- COMPRAS ----------------- */



CREATE TYPE [dbo].[EDetalle_Compra] AS TABLE(
[IdProducto] int NULL,
[PrecioCompra] decimal(18,2) NULL,
[PrecioVenta] decimal(18,2) NULL,
[Cantidad] int NULL,
[MontoTotal] decimal(18,2) NULL
)
GO

CREATE PROCEDURE sp_RegistrarCompra(
@idUsuario int,
@IdProveedor int,
@TipoDocumento varchar(500),
@NumeroDocumento varchar(500),
@MontoTotal decimal(18,2),
@DetalleCompra [EDetalle_Compra] READONLY,
@Resultado bit output,
@Mensaje varchar(500) output
)
AS 
BEGIN

	BEGIN TRY

		DECLARE @idcompra INT = 0
		SET @Resultado = 1
		SET @Mensaje = ''

		BEGIN TRANSACTION registro

			INSERT INTO Compra(IdUsuario, IdProveedor, TipoDocumento,NumeroDocumento,MontoTotal)
			VALUES(@IdUsuario,@IdProveedor,@TipoDocumento,@NumeroDocumento,@MontoTotal)

			SET @idcompra = SCOPE_IDENTITY()

			INSERT INTO DetalleCompra(IdCompra, IdProducto,PrecioCompra,PrecioVenta,Cantidad,MontoTotal)
			SELECT @idcompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal FROM @DetalleCompra

			UPDATE p SET p.Stock = p.Stock + dc.Cantidad,
			p.PrecioCompra = dc.PrecioCompra,
			p.PrecioVenta = dc.PrecioVenta
			FROM PRODUCTO p
			INNER JOIN @DetalleCompra dc on dc.IdProducto= p.IdProducto

		COMMIT TRANSACTION registro
	END TRY


	BEGIN CATCH

		SET @Resultado = 0
		SET @Mensaje = ERROR_MESSAGE()
		ROLLBACK TRANSACTION registro

	END CATCH
END






/* ----------------- VENTAS ----------------- */


CREATE TYPE [dbo].[EDetalle_Venta] AS TABLE(
[IdProducto] int NULL,
[PrecioVenta] decimal(18,2) NULL,
[Cantidad] int NULL,
[SubTotal] decimal(18,2) NULL
)
GO



CREATE PROCEDURE sp_RegistrarVenta(
@idUsuario int,
@TipoDocumento varchar(500),
@NumeroDocumento varchar(500),
@DocumentoCliente varchar(500),
@NombreCliente varchar(500),
@MontoPago decimal (18,2),
@MontoCambio decimal (18,2),
@MontoTotal decimal (18,2),
@DetalleVenta [EDetalle_Venta] READONLY,
@Resultado bit output,
@Mensaje varchar(500) output
)
AS 
BEGIN

	BEGIN TRY

		DECLARE @idventa INT = 0
		SET @Resultado = 1
		SET @Mensaje = ''

		BEGIN TRANSACTION registro

			INSERT INTO Venta(IdUsuario,TipoDocumento,NumeroDocumento,DocumentoCliente,NombreCliente,MontoPago,MontoCambio,MontoTotal)
			VALUES(@IdUsuario,@TipoDocumento,@NumeroDocumento,@DocumentoCliente,@NombreCliente,@MontoPago,@MontoCambio,@MontoTotal)


			SET @idventa = SCOPE_IDENTITY()

			INSERT INTO DetalleVenta(IdVenta, IdProducto,PrecioVenta,Cantidad,SubTotal)
			SELECT @idventa, IdProducto, PrecioVenta, Cantidad, SubTotal FROM @DetalleVenta

		COMMIT TRANSACTION registro
	END TRY


	BEGIN CATCH

		SET @Resultado = 0
		SET @Mensaje = ERROR_MESSAGE()
		ROLLBACK TRANSACTION registro

	END CATCH
END


/* ----------------- REPORTES COMPRAS ----------------- */

CREATE PROCEDURE sp_ReporteCompras (
@fechainicio varchar(10),
@fechafin varchar(10),
@idproveedor int
)
AS 
BEGIN

SET DATEFORMAT dmy;

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
WHERE CONVERT(date, c.FechaRegistro) BETWEEN @fechainicio AND @fechafin
AND pr.IdProveedor = iif(@idproveedor=0,pr.IdProveedor,@idproveedor)
END







/* ----------------- REPORTES VENTAS ----------------- */


CREATE PROCEDURE sp_ReporteVentas(
@fechainicio VARCHAR(10),
@fechafin VARCHAR(10)
)

AS 
BEGIN
SET DATEFORMAT dmy;
SELECT
	convert(char(10),v.FechaRegistro,103) [FechaRegistro],
	v.TipoDocumento,
	v.NumeroDocumento,
	v.MontoTotal,
	u.NombreCompleto[UsuarioRegistro],
	v.DocumentoCliente,
	v.NombreCliente,
	p.Codigo[CodigoProducto],
	p.Nombre[NombreProducto],
	ca.Descripcion[Categoria],
	dv.PrecioVenta,
	dv.Cantidad,
	dv.SubTotal
	FROM VENTA V
	INNER JOIN USUARIO u on u.IdUsuario = v.IdUsuario
	INNER JOIN DETALLEVENTA dv on dv.IdVenta = v.IdVenta
	INNER JOIN PRODUCTO p on p.IdProducto = dv.IdProducto
	INNER JOIN CATEGORIA ca on ca. IdCategoria = p.IdCategoria
	where CONVERT(date, v.FechaRegistro) BETWEEN @fechainicio AND @fechafin
END