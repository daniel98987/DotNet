ALTER PROC SeveralEspecialtiesInsert(@ListEspecialties dbo.EspecialidadTipoTabla READONLY )
AS
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			INSERT INTO Especialidad(Especialidad) 
			SELECT Especialidad FROM @ListEspecialties
		    COMMIT TRAN
		END TRY
		BEGIN CATCH
				ROLLBACK TRAN
		END CATCH
END;

CREATE TYPE dbo.EspecialidadTipoTabla AS TABLE
(
    Especialidad VARCHAR(30) -- Misma estructura que la columna "Especialidad" en la tabla original
);
GO

DECLARE @Especialidades dbo.EspecialidadTipoTabla;
INSERT INTO @Especialidades (Especialidad)
VALUES ('CardiologíaAgresivA'), ('NeurASASología'), ('ASAS'); 
EXEC SeveralEspecialtiesInsert  @Especialidades;