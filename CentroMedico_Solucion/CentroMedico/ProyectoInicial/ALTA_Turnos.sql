
/*
select * from turno
select * from paciente
select * from turnopaciente
select * from medico
insert into medico values(2,'Pablo','Ramirez')
*/

EXEC ALTA_Turno '20190219',2,2,'Nada'

CREATE proc ALTA_Turno(
			@fecha char(14), --20190215 12:00
			@idpaciente paciente,
			@idmedico medico,
			@observacion observacion=''
			)

as

/*
ESTADO = 0 (pendiente)
ESTADO = 1 (realizado)
ESTADO = 2 (cancelado)

*/
set nocount on

IF NOT EXISTS(SELECT TOP 1 idturno from Turno WHERE fechaturno=@fecha)
BEGIN
	INSERT INTO Turno (fechaturno,estado,observacion)
	VALUES (@fecha,0,@observacion)

	--extra el ultimo id que se inserto melo
	declare @auxIdturno turno
	set @auxIdturno = @@IDENTITY

	INSERT INTO TurnoPaciente (idturno,idpaciente,idmedico)
	VALUES (@auxIdturno,@idpaciente,@idmedico)

	print 'El turno se agreg� correctamente'
	return

	
END
ELSE
BEGIN
	print 'El turno ya existe.'
	return
END


