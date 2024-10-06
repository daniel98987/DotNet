--Tablas temporales en memoria
DECLARE @miTabla TABLE(id int identity(1,1),pais varchar(50))
INSERT into @miTabla values('Colombia')
INSERT into @miTabla values('Mexico')
INSERT into @miTabla values('Peru')
INSERT into @miTabla values('Colombia')

select * from @miTabla


--tabla temporal fisica : va a existir en la bd como una tabla temporal hasta que reiniciemos el servicios
--de bd
create table #miTabla(id int identity(1,1),nombre varchar(50), apellido varchar(50))
INSERT INTO #miTabla values ('Alejandro','Lopez')
INSERT INTO #miTabla values ('Daniel','Lopez')
select * from #miTabla;
DROP TABLE #miTabla

--SCRIPT
--Generar una tabla temporal que va almacenar los turnos de todos los pacientes
declare @turnos table (id int identity(1,1),idTurno turno, idPaciente paciente)
declare @idPaciente paciente
set @idPaciente =  8
insert into @turnos(idTurno,idPaciente)

select Tp.idTurno,Tp.idPaciente from paciente P
	inner join TurnoPaciente Tp
	ON Tp.idPaciente = P.idPaciente
declare @i int
set @i = 1

WHILE @i<=(select count(*) from @turnos)
BEGIN
	if (select idPaciente from @turnos where id = @i) <>@idPaciente
		delete from @turnos where id=@i


	set @i = @i+1
END

select * from Paciente p 
	inner join @turnos T
	ON T.idPaciente = p.idPaciente