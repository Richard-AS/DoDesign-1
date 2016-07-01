use DoDesign
go

----Usuarios Empresa -----
--insert into Users values('User01','abc123456');
--insert into Users values('User02','abc456789');

--Tavla Color --
insert into Color values('Rojo',0);
insert into Color values('Azul',0);
insert into Color values('Verde',0);
insert into Color values('Negro',0);
insert into Color values('Blanco',0);

--  Usuarios de Cliente Tabla TLogin---
-------------------------------------------------
--------------Loguear Usuario--------------
if OBJECT_ID('spLogin') is not null
drop proc spLogin
go 
create proc spLogin
	@NombreUsuario varchar(50), @Contrasenia varchar(40)
as
begin
	declare @NombreCompleto varchar(50)
	if exists(select NombreUsuario from TLogin where NombreUsuario=@NombreUsuario or Email=@NombreUsuario and Contrasenia=@Contrasenia)
	begin
		set @NombreCompleto= (select Apellido + ' ' + Nombre from Cliente where @NombreUsuario=NombreUsuario or @NombreUsuario=Email ) 
		select CodError=0, Mensaje='Bienvenido ' + @NombreCompleto
	end
	else
		select CodError=1, Mensaje='Usuario y/o Contrasena Invalidos'
end 
go
------------------------------------------------

if OBJECT_ID('spCrearLogin') is not null
drop proc spCrearLogin
go
create proc spCrearLogin 
@NombreUsuario varchar(50), @Email varchar(50), @Contrasenia varchar(50)
as 
begin
	declare @HashThis varchar(50);
	set @HashThis=CONVERT(NVARCHAR(50),hashBytes('sha1',@Contrasenia),2)
	insert into TLogin values(@NombreUsuario,@Email,@HashThis)
end
go
exec spCrearLogin 'tupapa','leo_mas@hotmail.com','elinviernoesfrio'
go
exec spCrearLogin 'DeneirHuanca','leo_denier96@hotmail.com','masnada123'
go
exec spCrearLogin 'OtroUsu','otro_usu@hotmail.com','masnada456'
go

-- cliente  de la tabla Cliente --

insert into Cliente values(1,'tupapa','leo_mas@hotmail.com','Mauricio','Huanca','959595595','al costado de mi vecino','1996-25-12','74831697','4565444656');
insert into Cliente values(2,'DeneirHuanca','leo_denier96@hotmail.com','Denier','Huanca','959595595','al costado de mi vecino','1996-12-12','74831697','1101110121');
insert into Cliente values(3,'OtroUsu','otro_usu@hotmail.com','Juan','Garcia','959595595','al costado de mi vecino','1996-12-12','74854697','1154530121');

-- tipos de pago Tabla Pago --
insert into Pago values('Credito');
insert into Pago values('Contado');


-- Diseños tabla Design --

insert into Design values('Renacer','El diseño plasma el significado de su nombre');

---   tabla Polo--

insert into Polo values(1,3,'Small',25.75);


-- tabla Pedido
insert into Pedido values(1,2,1,'5454555545');


-- tabla DetallePedido

insert into DetallePedido values(1,3,25.75*3);
