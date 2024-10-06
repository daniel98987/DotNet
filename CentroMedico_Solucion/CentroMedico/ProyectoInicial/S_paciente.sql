

CREATE PROC S_paciente(
	@idPaciente int

)
AS 

SELECT * FROM paciente where idPaciente = @idPaciente

GO


EXEC S_paciente 7



USE [CentroMedico]
GO
/****** Object:  StoredProcedure [dbo].[S_paciente]    Script Date: 22/9/2024 14:26:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROC [dbo].[S_paciente](
	@idPaciente int

)
AS 
DECLARE @ordenamiento char(1)
DECLARE @valorOrdenamiento char(1)

SET @valorOrdenamiento = ISNULL(@ordenamiento,'A')
print @valorOrdenamiento

SELECT apellido,nombre,idPais,observacion FROM paciente where idPaciente = @idPaciente

