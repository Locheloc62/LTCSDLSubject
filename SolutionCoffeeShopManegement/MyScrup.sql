USE COFFEESHOP
GO

CREATE PROC uspAddSupplier
	@id varchar(20),
	@name nvarchar(100),
	@address nvarchar(200)
AS 
BEGIN
	INSERT INTO Supplier (ID,NAME,ADDRESS) 
	VALUES(@id,@name,@address);
END
GO