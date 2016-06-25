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

if OBJECT_ID('Polo') is not null
drop table Polo
go
create table Polo
(
IdPolo int identity primary key,
Nombre varchar(50) ,
Cantidad int,
Precio decimal(5,2) not null
);

if OBJECT_ID('DetallePolo') is not null
drop table DetallePolo
go
create table DetallePolo
(
IdDetallePolo int identity primary key,
IdPolo int,
Tipo varchar(50) ,
Talla varchar(50)
);

if OBJECT_ID('Design') is not null
drop table Design
go
create table Design
(
IdDesign int identity primary key not null,
Nombre varchar(50) not null,
Usuario varchar(50) not null,
);


if OBJECT_ID('TLogin') is not null
drop table TLogin
go
create table TLogin
(
UsuCliente varchar(50) primary key,
Contrasenia varchar(50)
);

if OBJECT_ID('Cliente') is not null
drop table Cliente
go
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

if OBJECT_ID('Color') is not null
drop table Color
go
create table Color
(
IdColor int primary key not null,
Nombre varchar(20) not null,
Estado bit not null
);

if OBJECT_ID('Pedido') is not null
drop table Pedido
go
create table Pedido
(
IdPedido int primary key,
IdPolo int  not null,
UsuCliente varchar(50) not null,
Nombre varchar(50) not null,
NroTarjeta char(10) null,
IdColor int not null
);

if OBJECT_ID('Pago') is not null
drop table Pago
go
create table Pago
(
IdPago int identity primary key,
Tipo varchar(20) not null
);




select * from dbo.Design
select * from dbo.Producto
select * from dbo.Users