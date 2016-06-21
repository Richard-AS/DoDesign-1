--alter table nombreTabla
--add foreign key(parametro) references TablaRefencia

use DoDesign
go

--------------Loguear Usuario--------------
if OBJECT_ID('spLogin') is not null
drop proc spLogin
go 
create proc spLogin
	@NombreUsuario varchar(50), @Contrasenia varchar(40)
as
begin
	declare @NombreCompleto varchar(50)
	if exists(select NombreUsuario from TLogin where NombreUsuario=@NombreUsuario and Contrasenia=@Contrasenia)
	begin
		set @NombreCompleto= (select Apellido + ' ' + Nombre from Cliente where @NombreUsuario=NombreUsuario) 
		select CodError=0, Mensaje='Bienvenido ' + @NombreCompleto
	end
	else
		select CodError=1, Mensaje='Usuario y/o Contrasena Invalidos'
end 
go
----------------------------------------------------------------
alter table Design
add constraint FK_DesignUsers 
foreign key(Usuario)references Users(Usuario);
--------------------------------------------------------------
alter table Polo
add constraint FK_DesignPolo 
foreign key(IdDesign)references Design(IdDesign), 
constraint FK_ColorPolo 
foreign key(IdColor)references Color(IdColor);
------------------------------------------------------------------------------
alter table Cliente
add constraint FK_CliTLogin
foreign key(NombreUsuario)references TLogin(NombreUsuario);
-------------------------------------------------------------------------
alter table Pedido
add constraint FK_PedPolo
foreign key (IdPolo) references Polo(IdPolo),
constraint FK_PedCliente
foreign key (NombreUsuario) references Cliente(NombreUsuario),
constraint FK_PedPago
foreign key (IdPago) references Pago(IdPago);
-----------------------------------------------------------------------------------
alter table DetallePedido
add constraint FK_DetaPedPedido
foreign key(IdPedido)references Pedido(IdPedido);


