DECLARE @Especialidad varchar(100)
DECLARE @total varchar(100)
DECLARE EspecialidadCursor CURSOR FOR SELECT Especialidad FROM dbo.Especialidad
OPEN EspecialidadCursor
	FETCH NEXT FROM EspecialidadCursor INTO @Especialidad
	--SI ES CERO SIGNIFICA QUE AUN TIENE REGISTROS
	WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @total = CONCAT(@total,@Especialidad)
		SELECT @total as total;
		FETCH NEXT FROM EspecialidadCursor INTO @Especialidad
	END
CLOSE EspecialidadCursor
DEALLOCATE EspecialidadCursor