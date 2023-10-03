CREATE DATABASE PruebaSD

 
 -- NO EJECUTAR: LA TABLA SE CREA DESDE EL EF CORE CUANDO SE EJECUTE LA MIGRACIÓN
--CREATE TABLE Usuario
--(
--	UsuID NUMERIC(18,0) PRIMARY KEY IDENTITY,
--	nombre VARCHAR(100) NULL,
--	apellido VARCHAR(100) NULL
--)

GO

INSERT INTO Usuario VALUES 
('Daniel', 'Posada'),
('Valentina', 'Henao'),
('María','Garces'),
('Juan','Ramirez'),
('Josue','Lopez')

