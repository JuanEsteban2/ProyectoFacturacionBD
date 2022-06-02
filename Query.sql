CREATE DATABASE Supermercado;

USE Supermercado;

CREATE TABLE Productos (
	id_producto int primary key,
	nombre varchar(50),
	precio int,
	cantidad int,
	id_proveedor int,
	CONSTRAINT fk_Proveedores FOREIGN KEY (id_proveedor) REFERENCES Proveedores (id_proveedor)
);
go

CREATE TABLE Ventas (
	id_venta int primary key,
	fecha varchar(50),
	precio_total int,
	estado varchar(50)
);
go

CREATE TABLE Proveedores (
	id_proveedor int primary key,
	nombre varchar(50),
	telefono int
);
go

CREATE TABLE Clientes (
	id_cliente int primary key,
	nombre varchar(50),
	telefono int
);
go




--Procedimientos para listar los registros de cada tabla:
CREATE PROC sp_ver_productos 
AS SELECT * FROM Productos
ORDER BY id_producto;
GO

CREATE PROC sp_ver_ventas 
AS SELECT * FROM Ventas
ORDER BY id_venta;
GO

CREATE PROC sp_ver_proveedores 
AS SELECT * FROM Proveedores
ORDER BY id_proveedor;
GO

CREATE PROC sp_ver_clientes
AS SELECT * FROM Clientes
ORDER BY id_cliente;
GO




--Procedimientos para buscar registros en cada tabla:
CREATE PROC sp_buscar_producto
@id int,
@nombre varchar(50)
AS SELECT * FROM Productos 
WHERE (id_producto LIKE @id) or (nombre LIKE @nombre + '%');
go

CREATE PROC sp_buscar_venta
@id int
AS SELECT * FROM Ventas
WHERE (id_venta LIKE @id);
go

CREATE PROC sp_buscar_proveedor
@id int,
@nombre varchar(50)
AS SELECT * FROM Proveedores
WHERE (id_proveedor LIKE @id) or (nombre LIKE @nombre + '%');
go

CREATE PROC sp_buscar_cliente
@id int,
@nombre varchar(50)
AS SELECT * FROM Clientes
WHERE (id_cliente LIKE @id) or (nombre LIKE @nombre + '%');
go





--Procedimientos para modificar registros en cada tabla:
CREATE PROC sp_modificar_producto
@id varchar(5),
@nombre varchar(50),
@precio int,
@cantidad int,
@id_proveedor int,
@accion varchar(50) OUTPUT 
AS
IF (@accion = '1')
BEGIN
	DECLARE @codnuevo int, @codmax int
	SET @codmax = (SELECT MAX(id_producto) FROM Productos)
	SET @codmax = ISNULL(@codmax, 0)
	SET @codnuevo = @codmax + 1

	INSERT INTO Productos (id_producto, nombre, precio, cantidad, id_proveedor)
	VALUES (@codnuevo, @nombre, @precio, @cantidad, @id_proveedor)
	SET @accion = 'El producto fue insertado'
END

ELSE IF (@accion = '2')
BEGIN
	UPDATE Productos SET nombre = @nombre, precio = @precio, cantidad = @cantidad, id_proveedor = @id 
	WHERE id_producto = @id;
	SET @accion = 'El producto fue modificado'
END

ELSE IF (@accion = '3')
BEGIN
	DELETE FROM Productos WHERE id_producto = @id;
	SET @accion = 'El producto se ha eliminado'
END


CREATE PROC sp_modificar_ventas
@id varchar(5),
@fecha varchar(50),
@precio_total int,
@estado varchar(50),
@accion varchar(50) OUTPUT 
AS
IF (@accion = '1')
BEGIN
	DECLARE @codnuevo int, @codmax int
	SET @codmax = (SELECT MAX(id_venta) FROM Ventas)
	SET @codmax = ISNULL(@codmax, 0)
	SET @codnuevo = @codmax + 1

	INSERT INTO Ventas (id_venta, fecha, precio_total, estado)
	VALUES (@codnuevo, @fecha, @precio_total, @estado)
	SET @accion = 'La venta fue insertada'
END

ELSE IF (@accion = '2')
BEGIN
	UPDATE Ventas SET fecha = @fecha, precio_total = @precio_total, estado = @estado 
	WHERE id_venta = @id;
	SET @accion = 'La venta fue modificada'
END

ELSE IF (@accion = '3')
BEGIN
	DELETE FROM Ventas WHERE id_venta = @id;
	SET @accion = 'La venta se ha eliminado'
END


CREATE PROC sp_modificar_proveedor
@id varchar(5),
@nombre varchar(50),
@telefono int,
@accion varchar(50) OUTPUT 
AS
IF (@accion = '1')
BEGIN
	DECLARE @codnuevo int, @codmax int
	SET @codmax = (SELECT MAX(id_proveedor) FROM Proveedores)
	SET @codmax = ISNULL(@codmax, 0)
	SET @codnuevo = @codmax + 1

	INSERT INTO Proveedores (id_proveedor, nombre, telefono)
	VALUES (@codnuevo, @nombre, @telefono)
	SET @accion = 'El proveedor fue insertado'
END

ELSE IF (@accion = '2')
BEGIN
	UPDATE Proveedores SET nombre = @nombre, telefono = @telefono 
	WHERE id_proveedor = @id;
	SET @accion = 'El proveedor fue modificado'
END

ELSE IF (@accion = '3')
BEGIN
	DELETE FROM Proveedores WHERE id_proveedor = @id;
	SET @accion = 'El proveedor se ha eliminado'
END


CREATE PROC sp_modificar_cliente
@id varchar(5),
@nombre varchar(50),
@telefono int,
@accion varchar(50) OUTPUT 
AS
IF (@accion = '1')
BEGIN
	DECLARE @codnuevo int, @codmax int
	SET @codmax = (SELECT MAX(id_cliente) FROM Clientes)
	SET @codmax = ISNULL(@codmax, 0)
	SET @codnuevo = @codmax + 1

	INSERT INTO Clientes (id_cliente, nombre, telefono)
	VALUES (@codnuevo, @nombre, @telefono)
	SET @accion = 'El cliente fue insertado'
END

ELSE IF (@accion = '2')
BEGIN
	UPDATE Clientes SET nombre = @nombre, telefono = @telefono 
	WHERE id_cliente = @id;
	SET @accion = 'El cliente fue modificado'
END

ELSE IF (@accion = '3')
BEGIN
	DELETE FROM Clientes WHERE id_cliente = @id;
	SET @accion = 'El cliente se ha eliminado'
END