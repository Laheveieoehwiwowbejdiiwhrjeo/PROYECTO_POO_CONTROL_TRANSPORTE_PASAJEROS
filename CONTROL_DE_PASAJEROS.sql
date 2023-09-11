CREATE DATABASE CONTROL_DE_PASAJEROS
GO

USE CONTROL_DE_PASAJEROS
GO

--TABLA ADMINISTRATIVO------------------------------

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE TYPE='U' AND NAME='ADMINISTRATIVO')
DROP TABLE ADMINISTRATIVO
CREATE TABLE ADMINISTRATIVO
(
COD_ADMIN CHAR(4)NOT NULL,
NOMBRES VARCHAR (50)NOT NULL,
APELLIDOS VARCHAR (50)NOT NULL,
DIRECCION VARCHAR (100)NOT NULL,
TELEFONO CHAR (9)NOT NULL,
SUELDO FLOAT NOT NULL,
CARGO VARCHAR(50)NOT NULL,
TIPO_DOC VARCHAR(15)NOT NULL,
NRO_DOC VARCHAR(40)NOT NULL,
NACIONALIDAD CHAR(40)NOT NULL,
PRIMARY KEY(COD_ADMIN)
)
GO
INSERT INTO ADMINISTRATIVO VALUES ('A001','HARRY','CCORI CCORI','KENI','987871232',1500,'ADMINISTRADOR','DNI','78234310','ARGENTINA')
GO
SELECT *FROM ADMINISTRATIVO
GO

--TABLA CHOFERES------------------------------

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE TYPE='U' AND NAME='CHOFERES')
DROP TABLE CHOFERES
CREATE TABLE CHOFERES
(
COD_CHOF CHAR(4)NOT NULL,
NOMBRES VARCHAR (50)NOT NULL,
APELLIDOS VARCHAR (50)NOT NULL,
DIRECCION VARCHAR (100)NOT NULL,
TELEFONO CHAR (9)NOT NULL,
SUELDO FLOAT NOT NULL,
CARGO VARCHAR(50)NOT NULL,
TIPO_DOC VARCHAR(15)NOT NULL,
NRO_DOC VARCHAR(40)NOT NULL,
NACIONALIDAD CHAR(40)NOT NULL,
NRO_LICENCIA CHAR (12) NOT NULL,
PRIMARY KEY(COD_CHOF)
)
GO
INSERT INTO CHOFERES VALUES ('C001','SAMUEL','MAMANI MAMANI','LA SALLE','987823231',2000,'CHOFER','DNI','71234322','PERU','Q07864165')
GO
SELECT *FROM CHOFERES
GO
--TABLA VEHICULOS O AUTOBUSES------------------------------

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE TYPE='U' AND NAME='VEHICULOS')
DROP TABLE VEHICULOS
CREATE TABLE VEHICULOS
(
COD_VEHI CHAR(4)NOT NULL,
COD_CHOF CHAR(4)NOT NULL,
TIPO_TRANSPORTE VARCHAR(15)NOT NULL,
SOAT_SEGURO VARCHAR (20)NOT NULL,
COLOR VARCHAR (35)NOT NULL,
PLACA CHAR (7)NOT NULL,
MODELO_AUTO VARCHAR(40)NOT NULL,
NRO_LLANTAS INT NOT NULL,
NRO_ASIENTOS INT NOT NULL,
NRO_PISO INT NOT NULL,
PRIMARY KEY(COD_VEHI),
FOREIGN KEY (COD_CHOF) REFERENCES CHOFERES(COD_CHOF)
)
GO

INSERT INTO VEHICULOS VALUES ('V001','C001','TERRESTRE','CB 160F DLX','BLANCO','AA1-193','YUNDAY',10,48,2)
GO
SELECT *FROM VEHICULOS
GO
---***************************** TABLA PARA PASAJEROS *********************************-----
IF EXISTS(SELECT * FROM SYSOBJECTS WHERE TYPE='U' AND NAME='PASAJEROS')
DROP TABLE PASAJEROS
CREATE TABLE  PASAJEROS
(
COD_CLIENTE CHAR(4)NOT NULL,
NOMBRE_APELLIDOS VARCHAR(50)NOT NULL,
TIPO_DOC VARCHAR(30),
RUC CHAR(11)NOT NULL,
DNI CHAR(8)NOT NULL,
DIRECCION VARCHAR(100)NOT NULL,
FECHA_NACIMIENTO CHAR(11)NOT NULL,
TELEFONO CHAR(12)NOT NULL,
CELULAR CHAR(11)NOT NULL,
PRIMARY KEY(COD_CLIENTE)
)
GO

INSERT INTO PASAJEROS VALUES ('CO01','EDWAR PACCO','DNI','73792409091','73792465','SOCABAYA','12/01/2012','01 87667','999883404')
GO
SELECT *FROM PASAJEROS
GO
-----TABLA DE SERVICIO
IF EXISTS(SELECT * FROM SYSOBJECTS WHERE TYPE='U' AND NAME='SERVICIO')
DROP TABLE SERVICIO
CREATE TABLE  SERVICIO
(
COD_SERV CHAR(4)NOT NULL,
ORINGE VARCHAR(50)NOT NULL,
DESTINO VARCHAR(50)NOT NULL,
PRECIO FLOAT NOT NULL ,
PRIMARY KEY(COD_SERV)
)
GO
INSERT INTO SERVICIO VALUES ('S001','AREQUIPA','CUSCO',45)
GO

SELECT *FROM SERVICIO
GO

--TABLA BOLETAJE------------------------------
IF EXISTS(SELECT * FROM SYSOBJECTS WHERE TYPE='U' AND NAME='BOLETAJE')
DROP TABLE BOLETAJE
CREATE TABLE BOLETAJE
(
COD_BOLETO CHAR(4)NOT NULL,
COD_CLIENTE CHAR(4)NOT NULL,
COD_CHOF CHAR(4)NOT NULL,
COD_ADMIN CHAR(4)NOT NULL,
COD_VEHI CHAR(4)NOT NULL,
COD_SERV CHAR(4)NOT NULL,
HORAS_SALIDA CHAR (8)NOT NULL,
HORA_LLEGADA VARCHAR (10)NOT NULL,
BOLE_PRECIO FLOAT NOT NULL,
PRIMARY KEY(COD_BOLETO),
FOREIGN KEY (COD_CLIENTE) REFERENCES PASAJEROS(COD_CLIENTE),
FOREIGN KEY (COD_CHOF) REFERENCES CHOFERES(COD_CHOF),
FOREIGN KEY (COD_ADMIN) REFERENCES ADMINISTRATIVO(COD_ADMIN),
FOREIGN KEY (COD_VEHI) REFERENCES VEHICULOS (COD_VEHI),
FOREIGN KEY (COD_SERV) REFERENCES SERVICIO (COD_SERV)
)
GO
INSERT INTO BOLETAJE VALUES ('B001','CO01','C001','A001','V001','S001','8:35 PM','7:00 AM',50)
GO
SELECT *FROM BOLETAJE
GO

--TABLA EQUIPAJE------------------------------

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE TYPE='U' AND NAME='EQUIPAJE')
DROP TABLE EQUIPAJE
CREATE TABLE  EQUIPAJE
(
COD_EQUIPAJE CHAR(4)NOT NULL,
COD_BOLETO CHAR(4)NOT NULL,
TIPO_EQUIPAJE VARCHAR(50)NOT NULL,
PESO_EQUIPAJE VARCHAR(50)NOT NULL,
PRIMARY KEY(COD_EQUIPAJE),
FOREIGN KEY (COD_BOLETO) REFERENCES BOLETAJE (COD_BOLETO)
)
GO
INSERT INTO EQUIPAJE VALUES ('E001','B001','MALESTAS','13 KL')
GO
SELECT *FROM EQUIPAJE
GO




IF EXISTS(SELECT TABLE_NAME FROM INFORMATION_SCHEMA.VIEWS
WHERE TABLE_NAME='REPOR_PASAJERO')
DROP VIEW REPOR_PASAJERO
GO
CREATE VIEW REPOR_PASAJERO AS

--SELECT CODIGO,NOMNRES,APELLIDOS,DIRECCION,TELEFONO,NACIONALIDAD,CARGO,SUEDO FROM EMPLEADOS


SELECT   B.COD_BOLETO,P.NOMBRE_APELLIDOS,P.TIPO_DOC,P.DNI,P.RUC,P.FECHA_NACIMIENTO,P.CELULAR,P.TELEFONO,
S.ORINGE,S.DESTINO,B.HORAS_SALIDA,B.HORA_LLEGADA,B.BOLE_PRECIO
FROM BOLETAJE B
INNER JOIN PASAJEROS P ON B.COD_CLIENTE=P.COD_CLIENTE
INNER JOIN CHOFERES C ON B.COD_CHOF=C.COD_CHOF
INNER JOIN ADMINISTRATIVO A ON B.COD_ADMIN=A.COD_ADMIN
INNER JOIN VEHICULOS V ON B.COD_VEHI=V.COD_VEHI
INNER JOIN SERVICIO S ON B.COD_SERV=S.COD_SERV
GO


SELECT * FROM REPOR_PASAJERO
GO