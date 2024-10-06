
--TABLE FUNCTIONS

CREATE FUNCTION listaPaises()
RETURNS @paises TABLE(idPais char(3),pais varchar(50))
AS
BEGIN
	INSERT INTO @paises values('ESP','ESPAÑA')
	INSERT INTO @paises values('MEX','Mexico')
    INSERT INTO @paises values('PER','Perú')
	RETURN 
END


select * from dbo.listaPaises();