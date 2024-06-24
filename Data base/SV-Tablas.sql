CREATE DATABASE DB_SISTEMA_VENTA
GO

USE DB_SISTEMA_VENTA
GO

CREATE TABLE Rol (
IdRol int primary key identity,
Descripcion varchar (50),
FechaRegistro datetime default getdate()
)
GO

CREATE TABLE Permiso (
IdPermiso int primary key identity,
IdRol int references Rol(IdRol),
NombreMenu varchar(100),
FechaRegistro datetime default getdate()
)
GO

CREATE TABLE Proveedor (
IdProveedor int primary key identity,
Documento varchar(50),
RazonSocial varchar(50),
Correo varchar(50),
Telefono varchar (50),
Estado bit,
FechaRegistro datetime default getdate()
)
GO

CREATE TABLE Cliente (
IdCliente int primary key identity,
Documento varchar(50),
NombreCompleto varchar(50),
Correo varchar(50),
Telefono varchar (50),
Estado bit,
FechaRegistro datetime default getdate()
)
GO

CREATE TABLE Usuario (
IdUsuario int primary key identity,
Documento varchar(50),
NombreCompleto varchar(50),
Correo varchar(50),
Clave varchar(50),
IdRol int references ROL (IdRol),
Estado bit,
FechaRegistro datetime default getdate()
)
GO

CREATE TABLE Categoria (
IdCategoria int primary key identity,
Descripcion varchar(100),
Estado bit,
FechaRegistro datetime default getdate()
)
GO

CREATE TABLE Producto (
IdProducto int primary key identity,
Codigo varchar(50),
Nombre varchar(50),
Descripcion varchar(50),
IdCategoria int references Categoria(IdCategoria),
Stock int not null default 0,
PrecioCompra decimal(10,2) default 0,
PrecioVenta decimal(10,2) default 0,
Estado bit,
FechaRegistro datetime default getdate()
)
GO

CREATE TABLE Compra (
IdCompra int primary key identity,
IdUsuario int references Usuario(IdUsuario),
IdProveedor int references Proveedor(IdProveedor),
TipoDocumento varchar(50),
NumeroDocumento varchar(50),
MontoTotal decimal(10,2),
FechaRegistro datetime default getdate()
)
GO

CREATE TABLE DetalleCompra (
IdDetalleCompra int primary key identity,
IdCompra int references Compra(IdCompra),
IdProducto int references Producto(IdProducto),
PrecioCompra decimal(10,2) default 0,
PrecioVenta decimal(10,2) default 0,
Cantidad int,
MontoTotal decimal(10,2),
FechaRegistro datetime default getdate()
)
GO


CREATE TABLE Venta (
IdVenta int primary key identity,
IdUsuario int references Usuario(IdUsuario),
TipoDocumento varchar(50),
NumeroDocumento varchar(50),
DocumentoCliente varchar(50),
NombreCliente varchar(100),
MontoPago decimal(10,2),
MontoCambio decimal(10,2),
MontoTotal decimal(10,2),
FechaRegistro datetime default getdate()
)
GO

CREATE TABLE DetalleVenta (
IdDetalleVenta int primary key identity,
IdVenta int references Venta(IdVenta),
IdProducto int references Producto(IdProducto),
PrecioVenta decimal(10,2),
Cantidad int,
SubTotal decimal(10,2),
FechaRegistro datetime default getdate()
)
GO