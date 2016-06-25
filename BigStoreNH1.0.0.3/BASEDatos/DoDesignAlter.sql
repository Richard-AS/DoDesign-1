--alter table nombreTabla
--add foreign key(parametro) references TablaRefencia

use DoDesign
go

alter table Design
add foreign key(Usuario)references Users;

alter table DetallePolo
add foreign key(IdPolo)references Polo;

alter table Cliente
add foreign key(UsuCliente)references TLogin;

alter table Pedido
add foreign key (IdPolo) references Polo,
foreign key (UsuCliente) references Cliente,
foreign key (IdColor) references Color;
-------------------------------

