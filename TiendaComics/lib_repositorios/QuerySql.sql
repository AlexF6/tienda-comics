CREATE DATABASE db_comics;
GO
USE db_comics;
GO

CREATE TABLE Categorias (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Codigo VARCHAR(50),
    Nombre VARCHAR(100),
    EdadRecomendada VARCHAR(10)
);

CREATE TABLE Editoriales (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Codigo VARCHAR(50),
    Nombre VARCHAR(100),
    DistribuidorAsociado VARCHAR(100)
);

CREATE TABLE Comics (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Codigo VARCHAR(50),
    Nombre VARCHAR(100),
    Precio DECIMAL(10,2),
    Editorial INT,
    Categoria INT,
    FOREIGN KEY (Editorial) REFERENCES Editoriales(Id),
    FOREIGN KEY (Categoria) REFERENCES Categorias(Id)
);

CREATE TABLE Clientes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Cedula VARCHAR(30),
    Nombre VARCHAR(100),
    Email VARCHAR(100)
);

CREATE TABLE Vendedores (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Carnet VARCHAR(30),
    Nombre VARCHAR(100)
);

CREATE TABLE Sucursales (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Codigo VARCHAR(30),
    Nombre VARCHAR(100),
    Direccion VARCHAR(200)
);

CREATE TABLE MetodosDePagos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Codigo VARCHAR(30),
    Nombre VARCHAR(100),
    Tipo VARCHAR(50)
);

CREATE TABLE Ventas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Codigo VARCHAR(30),
    Fecha DATE,
    Cliente INT,
    Vendedor INT,
    MetodoDePago INT,
    Sucursal INT,
    FOREIGN KEY (Cliente) REFERENCES Clientes(Id),
    FOREIGN KEY (Vendedor) REFERENCES Vendedores(Id),
    FOREIGN KEY (MetodoDePago) REFERENCES MetodosDePagos(Id),
    FOREIGN KEY (Sucursal) REFERENCES Sucursales(Id)
);

CREATE TABLE DetallesVentas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Codigo VARCHAR(30),
    Cantidad INT,
    Venta INT,
    Comic INT,
    FOREIGN KEY (Venta) REFERENCES Ventas(Id),
    FOREIGN KEY (Comic) REFERENCES Comics(Id)
);

INSERT INTO Categorias (Codigo, Nombre, EdadRecomendada) VALUES
('CAT001', 'Super Heroes', '7+'),
('CAT002', 'Terror', '15+'),
('CAT003', 'Accion', '7+'),
('CAT004', 'One Shot', '18+'),
('CAT005', 'Comedia', '5+');

INSERT INTO Editoriales (Codigo, Nombre, DistribuidorAsociado) VALUES
('ED001', 'Marvel', 'Dark Horse'),
('ED002', 'Fear', 'Panini'),
('ED003', 'DC', 'Lunar Distribution'),
('ED004', 'Shonen', 'Shonen Jump'),
('ED005', 'LE PER', 'Sortir'),
('ED006', 'Lumen', 'Lerner');

INSERT INTO Comics (Codigo, Nombre, Precio, Editorial, Categoria) VALUES
('COM001', 'SPIDERMAN', 25000, 1, 1),
('COM002', 'CANARY', 18000, 2, 2),
('COM003', 'BATMAN', 27500, 3, 1),
('COM004', 'VAGABOND', 33000, 4, 3),
('COM005', 'CHAINSAWMAN', 30000, 4, 3),
('COM006', 'LINEA DE PUNTOS', 15000, 5, 4),
('COM007', 'MAFALDA', 8000, 6, 5);

INSERT INTO Vendedores (Carnet, Nombre) VALUES
('321', 'Pablo'),
('456', 'Dayana'),
('364', 'Carlos'),
('469', 'Albert'),
('444', 'Sara'),
('555', 'Maria');

INSERT INTO Clientes (Cedula, Nombre, Email) VALUES
('123', 'Andres', 'Andres@gmail.com'),
('456', 'Paulina', 'Paulina@gmail.com'),
('879', 'Santiago', 'Santiago@gmail.com'),
('444', 'Alex', 'Alex@gmail.com'),
('564', 'Pepe', 'Pepe@gmail.com'),
('888', 'Karen', 'Karen@gmail.com'),
('255', 'Samuel', 'samuel@gmail.com');

INSERT INTO Sucursales (Codigo, Nombre, Direccion) VALUES
('SUC001', 'BELLO', 'CRA 23 #23-23'),
('SUC002', 'ENVIGADO', 'CRA 56 #56-57'),
('SUC003', 'ITAGUI', 'CRA 88 #11-23'),
('SUC004', 'MEDELLIN', 'CRA 14 #66-74');

INSERT INTO MetodosDePagos (Codigo, Nombre, Tipo) VALUES
('MP001', 'EFECTIVO', 'Presencial'),
('MP002', 'TARJETA', 'En linea'),
('MP003', 'PAYPAL', 'En linea');

INSERT INTO Ventas (Codigo, Fecha, Cliente, Vendedor, MetodoDePago, Sucursal) VALUES
('V-20250510-001', '2025-05-10', 1, 1, 1, 1),
('V-20250512-002', '2025-05-12', 2, 1, 2, 1),
('V-20250612-003', '2025-06-12', 3, 2, 1, 2),
('V-20250613-004', '2025-06-13', 4, 3, 2, 3),
('V-20250613-005', '2025-06-13', 5, 4, 3, 3),
('V-20250702-006', '2025-07-02', 6, 5, 1, 4),
('V-20250702-007', '2025-07-02', 7, 6, 3, 1);

INSERT INTO DetallesVentas (Codigo, Cantidad, Venta, Comic) VALUES
('D001', 1, 1, 1),
('D002', 1, 2, 2),
('D003', 1, 3, 3),
('D004', 1, 3, 4),
('D005', 1, 4, 5),
('D006', 1, 5, 6),
('D007', 1, 6, 1),
('D008', 1, 7, 7);

SELECT * FROM [Categorias];
SELECT * FROM [Editoriales];
SELECT * FROM [Comics];
SELECT * FROM [Vendedores];
SELECT * FROM [Clientes];
SELECT * FROM [Sucursales];
SELECT * FROM [MetodosDePagos];
SELECT * FROM [DetallesVentas];
SELECT * FROM [Ventas];