
CREATE TRIGGER PacientesCreados ON Paciente 
AFTER INSERT 
AS
IF (select idPais from inserted) = 'MEX'
	INSERT INTO PacienteLog(idPaciente,idPais,fechaAlta)
		SELECT i.idPaciente,I.idPais,GETDATE() FROM inserted I

ALTER TABLE PacienteLog ADD fechaModificacion Datetime
SELECT * FROM PacienteLog

----TRIGGER UPDATE
CREATE TRIGGER PacientesModificados ON Paciente
AFTER UPDATE
AS
IF EXISTS (SELECT idPaciente  from PacienteLog where idPaciente = (select idPaciente from inserted))
	UPDATE PacienteLog set fechaModificacion = GETDATE()
	where idPaciente = (select idPaciente from inserted)
ELSE
	INSERT INTO PacienteLog(idPaciente,idPais,fechaAlta)
		SELECT i.idPaciente,I.idPais,GETDATE() FROM inserted i

select * from Paciente where idPaciente = 19

UPDATE Paciente SET nombre = 'Francismo Manuel' where idPaciente = 1;