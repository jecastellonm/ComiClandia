INSERT INTO PRODUCTO(Nombre,Descripcion,Stock,Valor,Departamento,Activo) VALUES ('Televisor LG','TV 55 pulgdas',10,3000000,1,1)
INSERT INTO PRODUCTO(Nombre,Descripcion,Stock,Valor,Departamento,Activo) VALUES ('Nevera LG','Nevera 350litros',20,1500000,1,1)
INSERT INTO PRODUCTO(Nombre,Descripcion,Stock,Valor,Departamento,Activo) VALUES ('Lavadora','Lavadora 35lbs',15,2000000,1,1)
INSERT INTO PRODUCTO(Nombre,Descripcion,Stock,Valor,Departamento,Activo) VALUES ('Televisor SAMSUNG','TV 50 pulgadas',8,2900000,2,1)
INSERT INTO PRODUCTO(Nombre,Descripcion,Stock,Valor,Departamento,Activo) VALUES ('Nevera SAMSUNG','Nevera 400litros',18,1800000,2,1)
INSERT INTO PRODUCTO(Nombre,Descripcion,Stock,Valor,Departamento,Activo) VALUES ('Lavadora SAMSUNG','Lavadora 38libras',8,2200000,2,1)
INSERT INTO PRODUCTO(Nombre,Descripcion,Stock,Valor,Departamento,Activo) VALUES ('Procesador B&D','Procesador de Alimentos',10,100000,2,1)

INSERT INTO CLIENTE(Nombre,Identificacion,Direccion,Telefono,Ciudad,Exclusivo,Activo) VALUES ('Javier Castellon','73155022','Kra98','310','Bogota',1,1)
INSERT INTO CLIENTE(Nombre,Identificacion,Direccion,Telefono,Ciudad,Exclusivo,Activo) VALUES ('Carlos Ramirez','108898797','Calle 20','323','Bogota',0,1)

INSERT INTO PEDIDO(FechaPedido,FechaModificacionPedido,IdCliente,EstadoPedido,IdTipoPedido) VALUES ('2023-04-23 00:00:00.000',NULL,1,1,1)
INSERT INTO PEDIDO(FechaPedido,FechaModificacionPedido,IdCliente,EstadoPedido,IdTipoPedido) VALUES ('2023-04-23 00:00:00.000',NULL,2,0,2)

INSERT INTO DETALLEPEDIDO(IdProducto,IdPedido,Cantidad,TotalDetalleP,FechaAdiciDetaPedido,FechaModifiDetaPedido,Observaciones,Activo) VALUES (1,1,1,3000000,'2023-04-23 00:00:00.000',NULL,'A',1)
INSERT INTO DETALLEPEDIDO(IdProducto,IdPedido,Cantidad,TotalDetalleP,FechaAdiciDetaPedido,FechaModifiDetaPedido,Observaciones,Activo) VALUES (2,1,1,1500000,'2023-04-23 00:00:00.000',NULL,'B',1)
INSERT INTO DETALLEPEDIDO(IdProducto,IdPedido,Cantidad,TotalDetalleP,FechaAdiciDetaPedido,FechaModifiDetaPedido,Observaciones,Activo) VALUES (3,2,1,2000000,'2023-04-23 00:00:00.000',NULL,'C',1)
INSERT INTO DETALLEPEDIDO(IdProducto,IdPedido,Cantidad,TotalDetalleP,FechaAdiciDetaPedido,FechaModifiDetaPedido,Observaciones,Activo) VALUES (4,2,1,2900000,'2023-04-23 00:00:00.000',NULL,'D',1)

