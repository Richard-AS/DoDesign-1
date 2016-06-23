--alter table nombreTabla
--add foreign key(parametro) references TablaRefencia

use DoDesign
go

alter table Desing
add foreign key(Usuario)references Users;

alter table Venta
add foreign key (IdProducto) references Producto,
foreign key (UsuCliente) references Cliente,
foreign key (IdColor) references Color;