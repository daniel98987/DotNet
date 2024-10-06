//--ALMACENA UNA CONSULTA COMO TABLA :V, se comporta como una tabla
CREATE VIEW PacienteTurnosNoPendientes AS 
SELECT P.idPaciente,P.nombre,P.apellido,T.idTurno,T.estado from Paciente P
inner join TurnoPaciente TP
on TP.idPaciente = P.idPaciente
inner join Turno T
on T.idTurno = TP.idTurno
WHERE T.estado <> 0

select * from PacienteTurnosNoPendientes;
select * from VistaPruebaConDesign;