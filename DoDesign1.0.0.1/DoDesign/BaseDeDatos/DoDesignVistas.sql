use DoDesign
go

select * from dbo.Cliente;
select * from dbo.Color;
select * from dbo.Design;
select * from dbo.DetallePedido;
select * from dbo.Pago;
select * from dbo.Pedido;
select * from dbo.Polo;
select * from dbo.TLogin;

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

exec spLogin 'DeneirHuanca','masnada123'
go