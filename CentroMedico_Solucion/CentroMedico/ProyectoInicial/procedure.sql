ALTER PROCEDURE RETORNANDO_GROUP (@Result int OUTPUT)
AS
BEGIN
	DECLARE @Adding int = 0
	while @Adding <10
	BEGIN
		PRINT(@Adding)
		SET @Adding = @Adding+1
	END

END;

--Número de digitos
ALTER PROCEDURE NUMBER_DIGITS(@Number int)
AS
BEGIN	
	DECLARE @Auxiliary CHAR(10) = CONVERT(CHAR(10),@Number)
	PRINT(LEN(@Auxiliary))
	--PRINT('El numero tiene '+LEN(@Auxiliary) +'digitos')
END

--INVERTIR NUMERO
ALTER PROCEDURE INVERT_NUMBER (@Number int)
AS
BEGIN
	DECLARE @NumberInvert varchar(10) = ''
    DECLARE @AbsNumber varchar(10) = CONVERT(varchar(10),ABS(@Number))
	DECLARE @i int = LEN(@AbsNumber)
	WHILE @i > 0
	BEGIN
		SET @NumberInvert = @NumberInvert+SUBSTRING(@AbsNumber,@i,1)
		SET @i = @i-1
	END
	IF @Number<0
	 SET @NumberInvert ='-'+ @NumberInvert
	print(@NumberInvert)
END
--Reto 1: Calcular la edad en años a partir de una fecha de nacimiento
--Crea un procedimiento almacenado que calcule la edad en años a partir de una fecha de nacimiento.
ALTER PROCEDURE CALCULATING_AGE (@Date_birth Date)
AS
BEGIN
	DECLARE @Age_test varchar(10) = DATEDIFF(YEAR,@Date_birth,GETDATE())
	PRINT('La edada de nacimiento es '+@Age_test)
END
--Reto 2: Días hasta una fecha futura
--Crea un procedimiento almacenado que calcule cuántos días faltan para una fecha futura dada.

--Requisitos:

--El procedimiento debe recibir un parámetro @FechaFutura de tipo DATE.
--Calcular la diferencia en días entre la fecha futura y la fecha actual (GETDATE()).
--Si la fecha ya ha pasado, imprimir un mensaje que indique que la fecha ya ha ocurrido.

ALTER PROCEDURE DAYS_UNTIL_FUTURE (@Future_day DATE)
AS
BEGIN
	DECLARE @Days int = DATEDIFF(DAY,GETDATE(),@Future_day)
	IF @Days <0
		PRINT 'Feha ya es antigua'
	ELSE
		PRINT(@Days)


END

NUMBER_DIGITS 1222212222
INVERT_NUMBER -12345
CALCULATING_AGE '05-04-1998'
DAYS_UNTIL_FUTURE '05-04-2025'