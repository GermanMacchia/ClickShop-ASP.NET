Delete from Carritos
Delete from Productos
Delete from Empleados
Delete from Direcciones
Delete from Clientes

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
VALUES ('Gorra Army USS', 1999, 10, 1, './imagenes/Gorra.jpg'); 

INSERT INTO Direcciones(provincia, calle, numero, localidad, referencia)
VALUES('Buenos Aires', 'Callao', 392, 'CABA', 'Dto 7B');

INSERT INTO Direcciones(provincia, calle, numero, localidad, referencia)
VALUES('La Pampa', 'Rivadavia', 3141, 'Santa Rosa', 'Casa');

INSERT INTO Clientes(telefono, direccionId, mail, nombre, apellido, dni)
VALUES('1123447394', 1, 'jceo@hotmail.com', 'Jose', 'Aristimuño', 27389483);

INSERT INTO Clientes(telefono, direccionId, mail, nombre, apellido, dni)
VALUES('1146783467', 2, 'garle@gmail.com', 'Gabriel', 'Lopez', 34353456);

INSERT INTO Empleados(nombre, apellido)
VALUES ('Camila', 'Capua'); 

INSERT INTO Empleados(nombre, apellido)
VALUES ('German', 'Macchia'); 