--crear tabla
CREATE TABLE [dbo].[TBL_Clientes]
(
	Nombre VARCHAR(20) NOT NULL, 
    Apellido VARCHAR(50) NOT NULL, 
    Genero VARCHAR(15) NOT NULL, 
    Estado Varchar(15) NOT NULL,
	Ceduala VARCHAR(20)NOT NULL PRIMARY KEY
)

--crea Clientes
Create PROCEDURE [dbo].[CRE_Clientes]
	@P_Nombre varchar(20),
	@P_Apellido varchar(50),
	@P_Genero  varchar(15),
	@P_Estado varchar(15),
	@P_Cedula varchar(20)
AS
	INSERT INTO [dbo].[TBL_CUSTOMERS] VALUES(@P_Nobre,@P_Apellido,@P_Genero,@P_Estado,@P_Cedula);


--Regresa todos los clientes
CREATE PROCEDURE [dbo].[RET_ALL_Clientes]
AS
	SELECT Nombre, Apellido, Genero, Estado, Ceduala FROM TBL_Clientes;
RETURN 0


--Actualizar clientes
CREATE PROCEDURE [dbo].[UPD_Clientes]
	@P_Nombre varchar(20),
	@P_Apellido varchar(50),
	@P_Genero  varchar(15),
	@P_Estado varchar(15),
	@P_Cedula varchar(20)
AS
	UPDATE [dbo].TBL_Clientes SET Nombre=@P_Nombre, Apellido=@P_Apellido, Genero=@P_Genero, Estado=@P_Estado WHERE Ceduala=@P_Cedula;

--Buscar por PK a cliente
Create PROCEDURE [dbo].[RET_Clientes]
	@P_Cedula varchar(20)
AS
	SELECT Nombre, Apellido, Genero, Estado,Ceduala FROM TBL_Clientes WHERE Ceduala=@P_Cedula;
RETURN 0

--Borrar Cliente
CREATE PROCEDURE [dbo].[DEL_Cliente]
	@P_Cedula varchar(20)
AS
	DELETE FROM TBL_Clientes WHERE Ceduala=@P_Cedula;
RETURN 0

--Tabla de mensajes  de retro alimentacion
CREATE TABLE [dbo].[TBL_MESSAGES]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Text] NVARCHAR(500) NOT NULL
);

--los mensajes que retorna las Excepciones
INSERT INTO TBL_MESSAGES VALUES(0,'Houston, tenemos un problema.');
INSERT INTO TBL_MESSAGES VALUES(1,'ID de cliente no válida.');
INSERT INTO TBL_MESSAGES VALUES(2,'The customer must be over 18 years old.');
INSERT INTO TBL_MESSAGES VALUES(3,'Este cliente ya existe.');

--Retorna todos los mensajes de las Excepciones
CREATE PROCEDURE [dbo].[RET_ALL_MESSAGE_PR]
AS
	SELECT ID, TEXT FROM TBL_MESSAGES;
RETURN 0





