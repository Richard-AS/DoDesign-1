-----eliminar FK
---------------------

use DoDesign
go

alter table Design
drop constraint FK_DesignUsers;
--------------------------------------------------------------
alter table Polo
drop constraint FK_DesignPolo, 
constraint FK_ColorPolo;
------------------------------------------------------------------------------
alter table Cliente
drop constraint FK_CliTLogin;
-------------------------------------------------------------------------
alter table Pedido
drop constraint FK_PedPolo,
constraint FK_PedCliente,
constraint FK_PedPago;
-----------------------------------------------------------------------------------
alter table DetallePedido
drop constraint FK_DetaPedPedido;

