
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


ALTER PROCEDURE SP_EliminarCategoria (
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
	WHERE C.IdProducto != @IdProducto)
	BEGIN 
		SET @PasoReglas = 0
		SET @Respuesta = 0;
		SET @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una COMPRA\n';
	END

	IF EXISTS (	SELECT * FROM DetalleVenta V 
	INNER JOIN PRODUCTO P ON P.IdProducto = V.IdProducto
	WHERE V.IdProducto != @IdProducto)
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




/* ----------------- VENTAS ----------------- */





/* ----------------- COMPRAS ----------------- */

/* ----------------- CLIENTES ----------------- */

/* ----------------- PROVEEDORES ----------------- */

