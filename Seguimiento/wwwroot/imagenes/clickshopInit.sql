TRUNCATE TABLE  Carritos
TRUNCATE TABLE  Productos
TRUNCATE TABLE  Empleados
TRUNCATE TABLE  Direcciones
TRUNCATE TABLE Clientes

INSERT INTO Productos(nombre, precio, cantidad, talle, imagen)
VALUES ('Buzo Negro Hoodie', 9999, 11, 2, './imagenes/Buzo.jpg'); 

INSERT INTO Productos(nombre, precio, cantidad, talle, imagen)
VALUES ('Remera Azul Francia', 4999, 11, 5, './imagenes/Remera.jpg'); 

INSERT INTO Productos(nombre, precio, cantidad, talle, imagen)
VALUES ('Pantalon Jean Baggy', 6999, 10, 33, './imagenes/Baggy.jpg'); 

INSERT INTO Productos(nombre, precio, cantidad, talle, imagen)
VALUES ('Zapas Yoda', 19999, 10, 41, './imagenes/Zapas.jpg'); 

INSERT INTO Productos(nombre, precio, cantidad, talle, imagen)
VALUES ('Pantalon Cargo Retro', 6999, 10, 36, './imagenes/Cargo.jpg'); 

INSERT INTO Productos(nombre, precio, cantidad, talle, imagen)
VALUES ('Pantalon Jean Ocean', 4799, 10, 38, './imagenes/Jean.jpg'); 

INSERT INTO Productos(nombre, precio, cantidad, talle, imagen)
VALUES ('Remera Rosa Model', 3499, 3,  4, './imagenes/Remera2.jpg'); 

INSERT INTO Productos(nombre, precio, cantidad, talle, imagen)
VALUES ('Vestido Vintage', 7999, 4,  3, './imagenes/Vestido.jpg'); 

INSERT INTO Productos(nombre, precio, cantidad, talle, imagen)
VALUES ('Zapatillas Right Now', 16999, 5,  40, './imagenes/Zapas2.jpg'); 

INSERT INTO Productos(nombre, precio, cantidad, talle, imagen)
VALUES ('Zapatillas Depo Van', 12999, 6, 42, './imagenes/Zapas3.jpg'); 

INSERT INTO Productos(nombre, precio, cantidad, talle, imagen)
VALUES ('Calza Training Negra', 8999, 9,  3, './imagenes/Calza.jpg'); 

INSERT INTO Productos(nombre, precio, cantidad, talle, imagen)
VALUES ('Gorra Army USS', 1999, 10, 1, './imagenes/Gorra.jpg'); 

INSERT INTO Direcciones(provincia, calle, numero, localidad, referencia)
VALUES('Buenos Aires', 'Callao', 392, 'CABA', 'Dto 7B');

INSERT INTO Direcciones(provincia, calle, numero, localidad, referencia)
VALUES('La Pampa', 'Rivadavia', 3141, 'Santa Rosa', 'Casa');

INSERT INTO Direcciones(provincia, calle, numero, localidad, referencia)
VALUES('Misiones', 'Cataratas', 56, 'Iguazú', '2H');

INSERT INTO Direcciones(provincia, calle, numero, localidad, referencia)
VALUES('Entre Rios', 'El Ñandu', 456, 'Gualeguachu', 'Casa');

INSERT INTO Direcciones(provincia, calle, numero, localidad, referencia)
VALUES('Cordoba', 'El Fernet', 1245, 'Villa Maria', 'PH');

INSERT INTO Clientes(telefono, direccionId, mail, nombre, apellido, dni)
VALUES('1123447394', 1, 'jceo@hotmail.com', 'Jose', 'Aristimuño', 27389483);

INSERT INTO Clientes(telefono, direccionId, mail, nombre, apellido, dni)
VALUES('1146783467', 2, 'garle@gmail.com', 'Gabriel', 'Lopez', 36345565);

INSERT INTO Clientes(telefono, direccionId, mail, nombre, apellido, dni)
VALUES('1146484457', 3, 'ggonzano@gmail.com', 'Gonzalo', 'Pedregoza', 34353456);

INSERT INTO Clientes(telefono, direccionId, mail, nombre, apellido, dni)
VALUES('1145643778', 4, 'Lautari23@gmail.com', 'Lautar', 'Salvatierra', 41827397);

INSERT INTO Clientes(telefono, direccionId, mail, nombre, apellido, dni)
VALUES('1145773736', 5, 'VivianaT@gmail.com', 'Viviana', 'Torres', 24367982);

INSERT INTO Empleados(nombre, apellido)
VALUES ('Camila', 'Capua'); 

INSERT INTO Empleados(nombre, apellido)
VALUES ('German', 'Macchia'); 