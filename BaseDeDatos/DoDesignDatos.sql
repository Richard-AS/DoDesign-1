use DoDesign
go

----Usuarios Empresa -----
insert into Users values('User01','abc123456');
insert into Users values('User02','abc456789');

--Tavla Color --
insert into Color values('Rojo',0);
insert into Color values('Azul',0);
insert into Color values('Verde',0);
insert into Color values('Negro',0);
insert into Color values('Blanco',0);

--  Usuarios de Cliente Tabla TLogin---

insert into TLogin values('DeneirHuanca','leo_denier96@hotmail.com','masnada123');
insert into TLogin values('OtroUsu','otro_usu@hotmail.com','masnada456');


-- cliente  de la tabla Cliente --

insert into Cliente values('DeneirHuanca','Denier','Huanca','959595595','al costado de mi vecino','1996-08-13','74831697','1101110121');
insert into Cliente values('OtroUsu','wsad','wda','959595595','al costado de mi vecino','1996-12-12','74854697','1154530121');

-- tipos de pago Tabla Pago --
insert into Pago values('Credito');
insert into Pago values('Contado');


-- Diseños tabla Design --

insert into Design values('Renacer','El diseño plasma el significado de su nombre','User01');

---   tabla Polo--

insert into Polo values('2','3','Small',25.75);


-- tabla Pedido
insert into Pedido values('4','2','DeneirHuanca','5454555545');


-- tabla DetallePedido

insert into DetallePedido values('2',3,25.75*3);
select * from Pedido;