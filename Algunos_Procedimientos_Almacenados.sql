CREATE PROC spGuardarMarcacion
@idmodalidad int,
@idpais int,
@idposicion int
AS
INSERT INTO dbo.tblmarcaciones (idmodalidad, idpais, idposicion)
VALUES (@idmodalidad, @idpais, @idposicion)
GO

ALTER PROC spConsultaMarcaciones
AS
SELECT 
moda.nombre AS "Modalidad", 
pais.nombrepais AS "País", 
mar.idposicion AS "Posición" 
FROM dbo.tblmarcaciones mar
INNER JOIN dbo.tblmodalidades moda
ON mar.idmodalidad = moda.id
INNER JOIN dbo.tblpaises pais
ON mar.idpais = pais.idpais
GO

truncate table dbo.tblmarcaciones

CREATE PROC spConsultarPosiciones
AS
SELECT * FROM dbo.tblposicion ORDER BY idposicion ASC
GO
