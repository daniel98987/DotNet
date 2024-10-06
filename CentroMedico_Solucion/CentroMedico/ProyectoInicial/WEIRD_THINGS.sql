--1. SCOPE_IDENTITY()
--Descripci�n: Similar a @@IDENTITY, pero m�s seguro. Devuelve el �ltimo valor de identidad 
--insertado dentro del mismo �mbito (scope). Esto es �til si tienes triggers en tus tablas 
--que podr�an insertar otros valores de identidad en tablas diferentes.
DECLARE @auxIdturno INT;
SET @auxIdturno = SCOPE_IDENTITY();
PRINT(@auxIdturno);

ALTER PROCEDURE CREATE_ESPECIALIDAD (@Especialty_name varchar(30))
AS
BEGIN 
	DECLARE @auxIdturno INT;
    DECLARE @InsertedEspecialidadesAux TABLE (idEspecialidad INT);
	 DECLARE @InsertedEspecialidades TABLE (idEspecialidad INT);
	INSERT INTO Especialidad (Especialidad) 
	OUTPUT INSERTED.idEspecialidad INTO @InsertedEspecialidadesAux
	VALUES (@Especialty_name)
	

	SET @auxIdturno = SCOPE_IDENTITY();
--	OUTPUT Clause
--Descripci�n: Te permite capturar los valores insertados, actualizados o 
--eliminados sin la necesidad de consultar la tabla despu�s de la operaci�n.
--Es �til para obtener el ID o cualquier otro dato generado en una inserci�n.

	PRINT( @auxIdturno )
	SELECT @auxIdturno = idEspecialidad FROM @InsertedEspecialidades;
END
CREATE_ESPECIALIDAD 'Test'