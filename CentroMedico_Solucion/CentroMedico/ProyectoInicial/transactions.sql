--Se utiliza para evaluar una porci�n de c�digo en la cual el proceso es critico
select * from Paciente;

BEGIN TRAN
	UPDATE Paciente set telefono = 444 where idPaciente = 8 
	--ROWCOUNT -> CUANTOS REGISTROS FUERON MODIFICAS EN LA ACCI�N ANTERIOR
	if @@ROWCOUNT = 1
		COMMIT TRAN
	else
		ROLLBACK TRAN

select * from Turno;

BEGIN TRAN
	DELETE FROM TURNO WHERE estado = 1;
	if @@ROWCOUNT = 1
		commit tran
	else
		rollback tran