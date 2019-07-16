USE Master
GO
CREATE DATABASE CineFrenz
GO

USE CineFrenz
GO

CREATE TABLE Peliculas (
ID_Pelicula char(6) Primary Key not null,
Titulo_Pelicula varchar(40) not null,
Genero_Pelicula text not null,
Clasificacion_Pelicula varchar(10) not null,
FechaEstreno_Pelicula date not null,
Director_Pelicula varchar(40) not null,
Sinopsis_Pelicula text not null, 
ImagenURL text not null, 
Duracion time(7) not null,
TrailerUrl text not null,
Estado bit not null
)
GO

CREATE TABLE Formatos (
ID_Formato char(6) not null,
Nombre_Formato varchar(20) not null,
Idioma_Formato varchar(40) not null,
Subtitulos_Formato bit not null,
Precio_Formato float not null
)
GO

CREATE TABLE PeliculasXFormatos (
ID_Pelicula char(6) not null,
ID_Formato char(6) not null 
)
GO

CREATE TABLE Sucursales (
ID_Sucursal char(6) not null,
Nombre_Sucursal varchar(20) not null UNIQUE,
Direccion_Sucursal varchar(60) not null,
Localidad_Sucursal varchar(40) not null,
Provincia_Sucursal varchar(40)  not null,
DireccionURL text not null
)
GO

CREATE TABLE Salas (
ID_Sala char(6) not null, 
ID_Sucursal char(6) not null,
Sala varchar(20) not null,
Butacas_Sala int not null
)
GO

CREATE TABLE Funciones (
ID_Funcion char(6) not null,
ID_Pelicula char(6) not null,
ID_Formato char(6) not null,
ID_Sucursal char(6) not null,
ID_Sala char(6) not null,
FechaHora_Funcion datetime not null,
Estado bit not null
)
GO

CREATE TABLE ButacaXFunciones (
ID_Butaca char(6) not null,
ID_Funcion char(6) not null,
Fila_Butaca varchar(20) not null,
Butaca char(20) not null
)
GO

CREATE TABLE Usuarios (
ID_Usuario int identity (1,1) not null,
Usuario varchar(40) unique not null,
Contrasenia varchar(16) not null,
Email_Usuario varchar(40) not null,
Apellidos_Usuario varchar(40) not null,
Nombres_Usuario varchar(40) not null,
DNI_Usuario varchar(8) not null,
Telefono_Usuario varchar(15) not null,
FechaNac_Usuario date not null,
Administrador bit not null,
Activo bit not null
)
GO

CREATE TABLE Snacks( 
ID_Snack char(6) primary key not null,
Nombre_Snack varchar(30) not null,
Tipo_Snack varchar(20) not null,
Precio_Snack smallmoney not null,
URLImagen_Snack text not null,
Estado_Snack bit not null
)
GO

CREATE TABLE Ventas(
ID_Venta char(6) not null,
IDUsuario_Venta int not null,
Usuario_Venta varchar(40) not null,
FechaHora_Venta datetime not null,
CantEntradas_Venta int not null,
PrecioFinal_Venta smallmoney not null
)
GO

CREATE TABLE SnacksXVentas(
ID_Venta char(6) not null,
ID_Snack char(6) not null,
Nombre_Snack varchar(30) not null,
Precio_Snack smallmoney not null,
Cantidad_Snack int not null
)
GO

CREATE TABLE DetalleVentas(
ID_Venta char(6) not null,
ID_Funcion char(6) not null,
ID_Butaca char (6) not null,
Fila_Butaca varchar(20) not null,
Butaca varchar(20) not null,
PrecioEntrada smallmoney not null 
)
GO

ALTER TABLE ButacaXFunciones ADD PRIMARY KEY (ID_Butaca , ID_Funcion );

ALTER TABLE DetalleVentas ADD PRIMARY KEY (ID_Venta , ID_Funcion , ID_Butaca );

ALTER TABLE Formatos ADD PRIMARY KEY ( ID_Formato );

ALTER TABLE Funciones ADD PRIMARY KEY ( ID_Funcion );

ALTER TABLE PeliculasXFormatos ADD PRIMARY KEY ( ID_Pelicula , ID_Formato );

ALTER TABLE Salas ADD PRIMARY KEY ( ID_Sala , ID_Sucursal );

ALTER TABLE Sucursales ADD PRIMARY KEY(ID_Sucursal);

ALTER TABLE SnacksXVentas ADD PRIMARY KEY ( ID_Venta , ID_Snack );

ALTER TABLE Usuarios ADD PRIMARY KEY ( ID_Usuario );

ALTER TABLE Ventas ADD PRIMARY KEY ( ID_Venta );

ALTER TABLE  PeliculasXFormatos
ADD CONSTRAINT FK_PeliXFor
FOREIGN KEY ( ID_Pelicula ) REFERENCES Peliculas (ID_Pelicula); 

ALTER TABLE  PeliculasXFormatos
ADD CONSTRAINT FK_FormatosXForxPeli
FOREIGN KEY ( ID_Formato ) REFERENCES Formatos (ID_Formato); 

ALTER TABLE  Funciones
ADD CONSTRAINT FK_FuncionesXForxPeli
FOREIGN KEY ( ID_Pelicula, ID_Formato  ) REFERENCES PeliculasXFormatos (ID_Pelicula, ID_Formato ); 

ALTER TABLE  ButacaXFunciones
ADD CONSTRAINT FK_ButacXFunxFunciones
FOREIGN KEY ( ID_Funcion ) REFERENCES Funciones (ID_Funcion); 
 
ALTER TABLE  Funciones
ADD CONSTRAINT FK_FuncXsalas
FOREIGN KEY ( ID_Sala , ID_Sucursal ) REFERENCES Salas (ID_Sala , ID_Sucursal); 

ALTER TABLE  Salas
ADD CONSTRAINT FK_SalasxSuc
FOREIGN KEY ( ID_Sucursal ) REFERENCES Sucursales (ID_Sucursal); 	

ALTER TABLE  Ventas
ADD CONSTRAINT FK_VentasXUsuarios
FOREIGN KEY (IDUsuario_Venta) REFERENCES Usuarios (ID_Usuario); 

ALTER TABLE  DetalleVentas
ADD CONSTRAINT FK_DetalleVentaXButacxFunc
FOREIGN KEY (ID_Butaca , ID_Funcion) REFERENCES ButacaXFunciones (ID_Butaca , ID_Funcion); 

ALTER TABLE  SnacksXVentas
ADD CONSTRAINT FK_SnackXVent
FOREIGN KEY (ID_Venta) REFERENCES Ventas (ID_Venta); 

ALTER TABLE  SnacksXVentas
ADD CONSTRAINT FK_SnacksxSnacksxventa
FOREIGN KEY (ID_Snack ) REFERENCES Snacks (ID_Snack); 


ALTER TABLE DetalleVentas
ADD CONSTRAINT FK_VentasXdellateVenta
FOREIGN KEY (ID_Venta) REFERENCES Ventas (ID_Venta); 
 