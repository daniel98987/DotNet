
SELECT * FROM Paciente;
SELECT * FROM Turno;

--INNER JOIN
SELECT * FROM Paciente P 
INNER JOIN TurnoPaciente T
ON T.idPaciente = P.idPaciente;
--LEFT JOIN

SELECT * FROM Paciente P 
LEFT JOIN TurnoPaciente T
ON T.idPaciente = P.idPaciente;

SELECT * FROM Paciente P 
RIGHT JOIN TurnoPaciente T
ON T.idPaciente = P.idPaciente;
--UNION 
--valida si los dos resultados son iguales si es asi los une y solo sacara los registros diferentes
SELECT * from Turno 
UNION
SELECT * from Turno 
--valida si los dos resultados son iguales si es asi los une y UNIRAR TODOS LOS REGISTROS
SELECT * from Turno 
UNION ALL
SELECT * from Turno 