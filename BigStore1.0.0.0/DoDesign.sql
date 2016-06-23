--base de datos DoDesign
use master
go
if OBJECT_ID('DoDesign') is not null
drop database DoDesign
go
create database DoDesign
go

use DoDesign
go

if OBJECT_ID('Users') is not null
drop table Users
go
create table Users
(
Usuario varchar(50) primary key not null,
Contrasena varchar(50) not null
);

create table Producto
(
IdProducto int identity primary key,
Nombre varchar(50) ,
Cantidad int,
Precio decimal(5,2) not null,
Stock bit not null
);

create table Design
(
IdDesign int identity primary key not null,
Nombre varchar(50) not null,
Usuario varchar(50) not null,
);

create table Cliente
(
UsuCliente varchar(50) primary key,
Nombre varchar(50) not null,
Apellido varchar(50) not null,
Telefono varchar(9) not null,
Direccion varchar(50) not null,
Edad char(2) not null,
DNI char(8) not null,
NroTarjeta char(10) null,
);
create table Color
(
IdColor int primary key not null,
Nombre varchar(20) not null,
Estado bit not null
);

create table Venta
(
IdVenta int primary key,
IdProducto int  not null,
UsuCliente varchar(50) not null,
Nombre varchar(50) not null,
NroTarjeta char(10) null,
IdColor int not null
);
create table Pago
(
IdPago int identity primary key,
Tipo varchar(20) not null
);




select * from dbo.Design
select * from dbo.Producto
select * from dbo.Users