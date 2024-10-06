exec Alta_Paciente  '22121','Jorge','Lopez','20180518','CALLE 1','MEX','','jorge@gmail.com','';

alter proc Alta_Paciente(
							@dni varchar(20),
							@nombre varchar(50), 
							@apellido varchar(50),
							@fnacimiento varchar(8),
							@domicilio varchar(50),
							@idPais char(3),
							@tel varchar(20)='',
							@email varchar(30),
							@observacion varchar(1000) = ''
							)
as

IF NOT EXISTS(SELECT * FROM Paciente where dni=@dni)
BEGIN
	INSERT INTO Paciente(dni,nombre,apellido,fNacimiento,domicilio,idPais,telefono,email,observacion)
	values (@dni, @nombre,@apellido,@fNacimiento,@domicilio,@idPais,@tel,@email,@observacion);
	PRINT('Se agrego correctamente')
	return
END
ELSE
BEGIN
	PRINT('Paciente con '+@dni+' ya existe!!!')
	return
END
