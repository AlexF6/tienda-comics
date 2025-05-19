CREATE DATABASE db_comics;
GO
USE db_comics;
GO

CREATE TABLE [Categorias](
	[Id] INT PRIMARY KEY IDENTITY (1,1) NOT  NULL,
	[Nombre] NVARCHAR (50) NOT NULL,
	[Edad_Recomendada] NVARCHAR (20) NOT NULL
);
GO

CREATE TABLE [Editoriales](
	[Id] INT PRIMARY KEY IDENTITY (1,1) NOT  NULL,
	[Nombre] NVARCHAR (50) NOT NULL,
	[Distribuidor_Asociado] NVARCHAR (50) NOT NULL
);
GO

CREATE TABLE [Comics](
	[Id] INT PRIMARY KEY IDENTITY (1,1) NOT  NULL,
	[Nombre] NVARCHAR (50) NOT NULL,
	[Precio] DECIMAL (10,2) NOT NULL,
	[EditorialId] INT NOT NULL,
	[CategoriaId] INT NOT NULL,
	FOREIGN KEY ([EditorialId]) REFERENCES [Editoriales]([Id]),
	FOREIGN KEY ([CategoriaId]) REFERENCES [Categorias]([Id])

);
GO

CREATE TABLE [Vendedores](
	[Id] INT PRIMARY KEY IDENTITY (1,1) NOT  NULL,
	[Carnet] NVARCHAR (50) UNIQUE NOT NULL,
	[Nombre] NVARCHAR (50) NOT NULL
);
GO

CREATE TABLE [Clientes](
	[Id] INT PRIMARY KEY IDENTITY (1,1) NOT  NULL,
	[Cedula] NVARCHAR (50) UNIQUE NOT NULL,
	[Nombre] NVARCHAR (50) NOT NULL,
	[Email] NVARCHAR (50) UNIQUE NOT NULL
);
GO

CREATE TABLE [Sucursales](
	[Id] INT PRIMARY KEY IDENTITY (1,1) NOT  NULL,
	[Nombre] NVARCHAR (50) NOT NULL,
	[Direccion] NVARCHAR (150) NOT NULL
);
GO

CREATE TABLE [Metodos_de_Pagos](
	[Id] INT PRIMARY KEY IDENTITY (1,1) NOT  NULL,
	[Nombre] NVARCHAR (50) NOT NULL,
	[Tipo] NVARCHAR (50) NOT NULL
);
GO

CREATE TABLE [Ventas](
	[Id] INT PRIMARY KEY IDENTITY (1,1) NOT  NULL,
	[SucursalId] INT NOT NULL,
	[ClienteId] INT NOT NULL,
	[VendedorId] INT NOT NULL,
	[Fecha] SMALLDATETIME NOT NULL,
	[Codigo] NVARCHAR (150) NOT NULL,
	[Metodo_de_PagoId] INT NOT NULL,
	FOREIGN KEY ([SucursalId]) REFERENCES [Sucursales]([Id]),
	FOREIGN KEY ([ClienteId]) REFERENCES [Clientes]([Id]),
	FOREIGN KEY ([VendedorId]) REFERENCES [Vendedores]([Id]),
	FOREIGN KEY ([Metodo_de_PagoId]) REFERENCES [Metodos_de_Pagos]([Id])

);
GO

CREATE TABLE [Detalles_Ventas](
	[Id] INT PRIMARY KEY IDENTITY (1,1) NOT  NULL,
	[ComicId] INT NOT NULL,
	[VentaId] INT NOT NULL,
	FOREIGN KEY ([ComicId]) REFERENCES [Comics]([Id]),
	FOREIGN KEY ([VentaId]) REFERENCES [Ventas]([Id]),
	[Cantidad] INT NOT NULL,

);
GO

INSERT INTO [Categorias]([Nombre],[Edad_Recomendada])
VALUES 
	('Super Heroes','7+'),
	('Terror','15+'),
	('Accion','7+'),
	('One Shot','18+'),
	('Comedia','5+');
GO

	
INSERT INTO [Editoriales]([Nombre],[Distribuidor_Asociado])
VALUES 
	('Marvel','Dark Horse'),
	('Fear','Panini'),
	('DC','Lunar Distribution'),
	('Shonen','Shonen Jump'),
	('LE PER','Sortir'),
	('Lumen','Lerner');
GO


INSERT INTO [Comics]([Nombre],[Precio],[EditorialId],[CategoriaId])
VALUES 
	('SPIDERMAN',25000,1,1),
	('CANARY',18000,2,2),
	('BATMAN',27500,3,1),
	('VAGABOND',33000,4,3),
	('CHAINSAWMAN',30000,4,3),
	('LINEA DE PUNTOS',15000,5,4),
	('MAFALDA',8000,6,5);
GO


INSERT INTO [Vendedores]([Carnet],[Nombre])
VALUES 
	('321','Pablo'),
	('456','Dayana'),
	('364','Carlos'),
	('469','Albert'),
	('444','Sara'),
	('555','Maria');
GO


INSERT INTO [Clientes]([Cedula],[Nombre],[Email])
VALUES 
	('123','Andres','Andres@gmail.com'),
	('456','Paulina','Paulina@gmail.com'),
	('879','Santiago','Santiago@gmail.com'),
	('444','Alex','Alex@gmail.com'),
	('564','Pepe','Pepe@gmail.com'),
	('888','Karen','Karen@gmail.com'),
	('255','Samuel','samuel@gmail.com');
GO

	
INSERT INTO [Sucursales]([Nombre],[Direccion])
VALUES 
	('BELLO','CRA 23 #23-23'),
	('ENVIGADO','CRA 56 #56-57'),
	('ITAGUI','CRA 88 #11-23'),
	('MEDELLIN','CRA 14 #66-74');
GO


INSERT INTO [Metodos_de_Pagos]([Nombre],[Tipo])
VALUES 
	('EFECTIVO','Presencial'),
	('TARJETA','En linea'),
	('PAYPAL','En linea');
GO


INSERT INTO [Ventas]([SucursalId],[ClienteId],[VendedorId],[Fecha],[Codigo],[Metodo_de_PagoId])
VALUES 
	(1,1,1,'2025-05-10','V-20250510-001',1),
	(1,2,1,'2025-05-12','V-20250512-002',2),
	(2,3,2,'2025-06-12','V-20250612-003',1),
	(3,4,3,'2025-06-13','V-20250613-004',2),
	(3,5,4,'2025-06-13','V-20250613-005',3),
	(4,6,5,'2025-07-02','V-20250702-006',1),
	(1,7,6,'2025-07-02','V-20250702-007',3);
GO


INSERT INTO [Detalles_Ventas]([ComicId],[VentaId],[Cantidad])
VALUES 
	(1,1,1),
	(2,2,1),
	(3,3,1),
	(4,3,1),
	(5,4,1),
	(6,5,1),
	(1,6,1),
	(7,7,1);
GO

SELECT * FROM [Categorias];
SELECT * FROM [Editoriales];
SELECT * FROM [Comics];
SELECT * FROM [Vendedores];
SELECT * FROM [Clientes];
SELECT * FROM [Sucursales];
SELECT * FROM [Metodos_de_Pagos];
SELECT * FROM [Detalles_Ventas];

