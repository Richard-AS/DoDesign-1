--base de datos DoDesign
use master
go
if db_ID('DoDesign') is not null
drop database DoDesign
go
create database DoDesign
go
----------------------------------------------
use DoDesign
go
-------------------------------------------

if OBJECT_ID('Polo') is not null
drop table Polo
go
create table Polo
(
IdPolo int identity primary key,
IdDesign int not null,
IdColor int not null,
Talla varchar(20),
Precio decimal(5,2) not null

);
----------------------------------------------------



if OBJECT_ID('Design') is not null
drop table Design
go
create table Design
(
IdDesign int identity primary key not null,
Nombre varchar(50) not null,
Descripcion nvarchar(2000),
Usuario varchar(50) not null,
);

-----------------------------------



-----------------------------------


if OBJECT_ID('Pedido') is not null
drop table Pedido
go
create table Pedido
(
IdPedido int identity primary key,
IdPolo int  not null,
IdPago int not null,
NombreUsuario varchar(50) not null,
NroTarjeta char(10) null
);
------------------------------------------
if OBJECT_ID('DetallePedido') is not null
drop table DetallePedido
go
create table DetallePedido
(
IdDetallePedido int identity primary key,
IdPedido int,
Cantidad int,
Costo decimal(8,2)
);
--------------------------------
if OBJECT_ID('Pago') is not null
drop table Pago
go
create table Pago
(
IdPago int identity primary key,
Tipo varchar(20) not null
);
---------------------------------------------
if OBJECT_ID('Users') is not null
drop table Users
go
create table Users
(
Usuario varchar(50) primary key not null,
Contrasena varchar(50) not null
);
-----------------------------------
if OBJECT_ID('Color') is not null
drop table Color
go
create table Color
(
IdColor int identity primary key not null,
Nombre varchar(20) not null,
Estado bit not null
);
----------------------------------

if OBJECT_ID('TLogin') is not null
drop table TLogin
go
create table TLogin
(
NombreUsuario varchar(50) primary key,
Email varchar(50),
Contrasenia varchar(50)
);
-----------------------------------
if OBJECT_ID('Cliente') is not null
drop table Cliente
go
create table Cliente
(
NombreUsuario varchar(50) primary key,
Nombre varchar(50) not null,
Apellido varchar(50) not null,
Telefono varchar(9) not null,
Direccion varchar(50) not null,
FechaNacimiento date not null,
DNI char(8) not null,
NroTarjeta char(10) null,
);
----------------------------------
if OBJECT_ID('TRegistro') is not null
drop table TRegistro
go
create table TRegistro
(
NombreUsuario varchar(50) primary key,
Email varchar(50),
Contrasenia varchar(50)
);
select * from dbo.Design
select * from dbo.Polo
select * from dbo.Users