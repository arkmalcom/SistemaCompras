create database GestionCompras

use GestionCompras;

create table Departamentos(
ID_Departamento int primary key identity(1,1),
Nombre_Departamento varchar(100) not null,
Estado_Departamento bit
)

create table Marcas(
ID_Marca int primary key identity(1,1),
Descripcion_Marca varchar(50) not null,
Estado_Marca bit
)

create table Unidades_Medida (
ID_Unidad int primary key identity(1,1),
Descripcion_Unidad varchar(50) not null,
Estado_Unidad bit
)

create table Proveedores (
ID_Proveedor int primary key identity(1,1),
Cedula_Proveedor bigint not null,
Nombre_Proveedor varchar(100) not null,
Estado_Proveedor bit
)

create table Articulos (
ID_Articulo int primary key identity(1,1),
Descripcion_Articulo varchar(100) not null,
Marca_Articulo int,
Unidad_Articulo int,
Existencia_Articulo int,
Costo_Unitario_Articulo int,
Estado_Articulo bit
FOREIGN KEY (Marca_Articulo) REFERENCES Marcas(ID_Marca),
FOREIGN KEY (Unidad_Articulo) REFERENCES Unidades_Medida(ID_Unidad)
)

create table Empleados(
ID_Empleado int primary key identity(1,1),
Cedula_Empleado bigint not null,
Nombre_Empleado varchar(100) not null,
Departamento_Empleado int,
Estado_Empleado bit
FOREIGN KEY (Departamento_Empleado) REFERENCES Departamentos(ID_Departamento)
)

create table Solicitud_Articulos (
ID_Solicitud int primary key identity(1,1),
Empleado_Solicitud int,
Fecha_Solicitud datetime,
Articulo_Solicitud int,
Cantidad_Solicitud int,
Unidad_Solicitud int,
Estado_Solicitud bit,
FOREIGN KEY (Empleado_Solicitud) REFERENCES Empleados(ID_Empleado),
FOREIGN KEY (Articulo_Solicitud) REFERENCES Articulos(ID_Articulo),
)

create table Orden_Compras (
ID_Orden int primary key identity(1,1),
ID_Solicitud_Orden int,
Fecha_Orden datetime,
Estado_Orden bit,
Articulo_Orden int,
Cantidad_Orden int
FOREIGN KEY (Articulo_Orden) REFERENCES Articulos(ID_Articulo)
)

Insert into Departamentos values ('Recursos Humanos', 1)

Insert into Empleados values (40007376632, 'John', 1, 1)