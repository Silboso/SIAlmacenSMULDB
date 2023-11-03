-- Crea la base de datos SQLSMulAlmacen
CREATE DATABASE SQLSMulAlmacen;

-- Establece la base de datos recién creada como la base de datos actual
USE SQLSMulAlmacen;

-- Crea la tabla CategoriasProductos
CREATE TABLE CategoriasProductos (
    CategoriaID int NULL,
    Nombre nvarchar(100),
    Descripcion nvarchar(max),
    Estado int NULL
);

-- Crea la tabla Productos
CREATE TABLE Productos (
    ProductoID int NULL,
    Nombre nvarchar(255),
    Descripcion nvarchar(max),
    Precio decimal NULL,
    Stock int NULL,
    CategoriaID int NULL,
    Estado int NULL
);

-- Crea la tabla Proveedores
CREATE TABLE Proveedores (
    ProveedorID int NULL,
    Nombre nvarchar(255),
    Direccion nvarchar(255),
    Telefono nvarchar(15),
    Email nvarchar(255),
    Contacto nvarchar(255),
    Estado int NULL
);

-- Crea la tabla ProductosProveedores
CREATE TABLE ProductosProveedores (
    ProductoProveedorID int NULL,
    ProductoID int NULL,
    ProveedorID int NULL,
    Estado int NULL
);
