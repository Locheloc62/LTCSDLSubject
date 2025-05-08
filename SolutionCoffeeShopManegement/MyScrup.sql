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

CREATE PROC uspDeleteSupplier
	@id varchar(20)
AS 
BEGIN
	DELETE FROM Supplier 
	WHERE ID =@id;
END
GO

CREATE PROC uspUpdateSupplier
	@id varchar(20),
	@name nvarchar(100),
	@address nvarchar(200)
AS 
BEGIN
	UPDATE Supplier
    SET 
        name = @name,
        address = @address
    WHERE ID = @id;
END
GO

drop PROC uspUpdateSupplier
PRINT 'uspUpdateSupplier called with ID = ' + @id