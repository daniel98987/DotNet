create function concatenar (
							@apellido varchar(50),
							@nombre varchar(50))
RETURNS VARCHAR(100)
AS
BEGIN
	declare @resultado varchar(100) 
	set @resultado = @nombre+', '+@apellido
	return @resultado
END

select dbo.concatenar('Lopez','Roberto')


CREATE FUNCTION  obtenerPais(@idPaciente paciente)
RETURNS varchar(50)
AS
BEGIN
	declare @pais varchar(50)
	set @pais = (select p.idPais from Paciente p 
	INNER JOIN Pais pa
	ON pa.idPais = p.idPais
	where idPaciente = @idPaciente)
	return @pais

END
select dbo.obtenerPais(1);
