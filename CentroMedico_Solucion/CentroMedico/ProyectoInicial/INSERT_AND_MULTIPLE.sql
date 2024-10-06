INSERT INTO PAGO (concepto,fecha,monto,estado,observacion) values
(1,'2019-02-15','4500',1,'Pago pendiente'),
(1,'2019-05-20','6800',1,'Pago pendiente'),
(1,'2019-09-27','5600',1,'Pago pendiente');

INSERT INTO PagoPaciente (idPago,idPaciente,idTurno) value(1 , 1 , 1);