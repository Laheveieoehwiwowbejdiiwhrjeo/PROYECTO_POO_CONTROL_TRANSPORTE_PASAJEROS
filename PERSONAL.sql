CREATE DATABASE CONTROL_DE_PASAJEROS
GO
USE CONTROL_DE_PASAJEROS
GO

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE TYPE='U' AND NAME='PERSONAL')
DROP TABLE PERSONAL
CREATE TABLE PERSONAL
(
NUM_BOLE CHAR(3)NOT NULL,
NOMBRE VARCHAR (30)NOT NULL,
APELLIDOS VARCHAR (50)NOT NULL,
TIPO_DOC VARCHAR(15)NOT NULL,
NRO_DOC CHAR(13)NOT NULL,
TELEFONO CHAR (10)NOT NULL,
FECHA_DE_PART CHAR(10)NOT NULL,
PRECIO CHAR (10)NOT NULL,
HORA_DE_SALIDA CHAR (9)NOT NULL,
PRIMARY KEY(NUM_BOLE)
)
GO

USE CONTROL_DE_PASAJEROS
GO
INSERT INTO PERSONAL VALUES('A01','JOSE','PACCO PACCO','DNI','73792470','999883404','12/08/2023','50 S/','8:30 PM')
INSERT INTO PERSONAL VALUES('A02','EDWAR','CCARITA CCARITA','DNI','78987665','999883404','11/03/2023','70 S/','8:30 AM')
INSERT INTO PERSONAL VALUES('A03','MARY','MAMANI JACINTO','DNI','73192270','999883404','09/02/2023','100 S/','9:30 PM')
INSERT INTO PERSONAL VALUES('A04','RONALD','PACCO PUMA','DNI','43792451','999883404','09/02/2023','100 S/','9:30 PM')
INSERT INTO PERSONAL VALUES('A05','RICHARD','PERS MAMANI','DNI','73792470','999883404','12/02/2023','120 S/','8:30 PM')
GO



USE CONTROL_DE_PASAJEROS
GO

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE TYPE='U' AND NAME='ORIGEN')
DROP TABLE ORIGEN
CREATE TABLE ORIGEN
(
CODIGO CHAR(3)NOT NULL,
ORIGEN VARCHAR(50)NOT NULL,
PRIMARY KEY(CODIGO) 
)
GO
INSERT INTO ORIGEN VALUES('001','AREQUIPA')
INSERT INTO ORIGEN VALUES('002','AREQUIPA')
INSERT INTO ORIGEN VALUES('003','AREQUIPA')
INSERT INTO ORIGEN VALUES('004','AREQUIPA')
INSERT INTO ORIGEN VALUES('005','AREQUIPA')
INSERT INTO ORIGEN VALUES('006','AREQUIPA')


USE CONTROL_DE_PASAJEROS
GO

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE TYPE='U' AND NAME='DESTINO')
DROP TABLE DESTINO
CREATE TABLE DESTINO
(
CODIGO CHAR(3)NOT NULL,
DESTINO VARCHAR(50)NOT NULL,
PRIMARY KEY(CODIGO) 
)
GO
INSERT INTO DESTINO VALUES('001','LIMA')
INSERT INTO DESTINO VALUES('002','TACNA')
INSERT INTO DESTINO VALUES('003','CUSCO')
INSERT INTO DESTINO VALUES('004','MADRE DE DIOS')
INSERT INTO DESTINO VALUES('005','LORETO')
INSERT INTO DESTINO VALUES('006','ILO')

 SELECT * FROM DESTINO
 GO
 SELECT *FROM PERSONAL
GO


 SELECT * FROM ORIGEN
 GO


