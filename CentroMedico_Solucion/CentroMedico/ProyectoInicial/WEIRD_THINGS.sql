--1. SCOPE_IDENTITY()
--Descripción: Similar a @@IDENTITY, pero más seguro. Devuelve el último valor de identidad 
--insertado dentro del mismo ámbito (scope). Esto es útil si tienes triggers en tus tablas 
--que podrían insertar otros valores de identidad en tablas diferentes.
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
--Descripción: Te permite capturar los valores insertados, actualizados o 
--eliminados sin la necesidad de consultar la tabla después de la operación.
--Es útil para obtener el ID o cualquier otro dato generado en una inserción.

	PRINT( @auxIdturno )
	SELECT @auxIdturno = idEspecialidad FROM @InsertedEspecialidades;
END
CREATE_ESPECIALIDAD 'Test'