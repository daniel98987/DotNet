
--TABLE FUNCTIONS

CREATE FUNCTION listaPaises()
RETURNS @paises TABLE(idPais char(3),pais varchar(50))
AS
BEGIN
	INSERT INTO @paises values('ESP','ESPA�A')
	INSERT INTO @paises values('MEX','Mexico')
    INSERT INTO @paises values('PER','Per�')
	RETURN 
END


select * from dbo.listaPaises();