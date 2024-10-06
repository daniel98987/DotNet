--*********************Texto************************

--LEFT  AND RIGHT : Cuantos caraacteres quiero tomar
declare @var1 varchar(20)
declare @var2 varchar(20)
set @var1 = '		Ramir"o  '
set @var2 = 'Gonz@ales		'


print left(@var1,2);
print right(@var1,2);
--LEN
print (LEN(@var1));

--LOWER AND UPPER
print lower(@var1)+upper(@var1);
--REPLACE
select REPLACE (@var1,'"','');
select REPLACE (@var2,'@','');
--REPLICATE
print REPLICATE('0',5);
--LTRIM AND RTRIM
SELECT LTRIM(RTRIM(@VAR1))+' '+ LTRIM(@var2)+'*';
--CONCAT
SELECT 'CONCAT',CONCAT(@var1,@var2);

r.--La función SUBSTRING en SQL Server es muy útil cuando necesitas extraer una p
--arte de una cadena de texto. Permite tomar una porción de una cadena especificando 
--la posición inicial y la longitud de la subcadena que quieres obtene
--SUBSTRING
--SUBSTRING(expresión, posición_inicial, longitud)

SELECT SUBSTRING('Hola Mundo', 6, 5) AS Subcadena;
--DATE
--GETDATE y GETUTCDATE        

select GETDATE();
--obtiene la hora universal
select GETUTCDATE();

--DATEADD

select DATEADD(DAY,2,GETDATE());
select DATEADD(DAY,-2,GETDATE());
select DATEADD(HOUR,-2,GETDATE());

--DATEDIFF : Diferencia entre dos fechas
--DATEDIFF(unidad_de_tiempo, fecha_inicial, fecha_final)
select DATEDIFF(DAY,GETDATE(),'2016-01-20');
select DATEDIFF(DAY, '2016-01-20',GETDATE());
--DATEPART: obtener un intervalo especifico de una fecha
--DATEPART(parte_de_fecha, fecha)

select DATEPART(MONTH,GETDATE());
select DATEPART(DW,GETDATE());

--ISDATE: Evalua si es una fecha
print(ISDATE(GETDATE()));
print(ISDATE('20190131'));
--FUNCIONES DE CONVERSIÓN
--CAST: CONVIERTE UN TIPO DE DATO A OTRO SIEMPRE Y CUANDO SEAN DEL MISMO GENERO, SOLO A MODO DE VISUALIZACIÓN
declare @numero money;
set @numero = 500.40
print @numero
SELECT CAST(idPaciente as money) FROM paciente;
SELECT CAST(@numero AS int) numero;
--CONVERT: CONVIERTE UN TIPO DE DATO A OTRO
print CONVERT(int,@numero);
declare @fecha datetime
set @fecha = GETDATE()
print(@fecha)
print CONVERT(char(8),@fecha);
print CONVERT(char(8),@fecha,112);