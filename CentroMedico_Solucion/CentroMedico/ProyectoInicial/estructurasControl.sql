


DECLARE @idPaciente int
DECLARE @idTurno int
set @idPaciente  = 7

IF @idPaciente = 7
BEGIN
	set @idTurno = 20
	SELECT * FROM PACIENTE WHERE idPaciente=@idPaciente
	print @idTurno
	IF EXISTS(SELECT * FROM Paciente WHERE idPaciente = 2)
		BEGIN
		print 'EXISTE'
		END
END
ELSE
BEGIN
	print 'No se cumplio la condición'
END

--WHILE
--declare @contador int = 0
--while @contador <= 10
--BEGIN
--	print @contador
--	set @contador +=1 
--END


--CASE
declare @valor int
declare @resultado char(10)
set @valor = 20

set @resultado = (CASE 
						WHEN @valor = 10 THEN 'ROJO' 
						WHEN @valor= 20 THEN 'VERDE'
						WHEN @valor = 30 THEN 'AZUL'
				  END)

print @resultado
--
select *, (CASE WHEN estado=1 THEN 'VERDE'
				WHEN estado=2 THEN 'ROJO'
				WHEN estado=300 THEN 'AZUL'
				ELSE 'GRIS'
				END) AS  color from turno

--RETURN AND BREAK 

--declare @contador int = 0
--while @contador <= 10
--BEGIN
--	print @contador
--	set @contador +=1 
--	if @contador = 3
--		return
--	print 'hola'
--END

--declare @contador int = 0
--while @contador <= 10
--BEGIN
--	print @contador
--	set @contador +=1 
--	if @contador = 3
--		BREAK
--END
--print 'sigue ejecutando'

--//**TRY CATCH**//
declare @contador int = 00
while @contador <= 10
BEGIN
	print @contador
	set @contador +=1 
	if @contador = 3
		BREAK
END
print 'sigue ejecutando'


BEGIN TRY
	SET @contador = 'TEXTO'
END TRY
BEGIN CATCH
	print 'No es posible asignar un texto a la variable @contador'
END CATCH