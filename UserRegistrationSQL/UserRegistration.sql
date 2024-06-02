Create PROC UserAdd
@UserID int,
@FirstName varchar(50),
@LastName varchar(50),
@Email varchar(50),
@Address varchar(200),
@Username varchar(50),
@Password varchar(50)
AS
	INSERT INTO [dbo].[User](FirstName, LastName, Email, Address, Username, Password)
	Values(@FirstName, @LastName, @Email, @Address, @Username, @Password)

ALTER PROC UserAdd
@FirstName varchar(50),
@LastName varchar(50),
@Email varchar(50),
@Address varchar(200),
@Username varchar(50),
@Password varchar(50)
AS
	INSERT INTO [dbo].[User](FirstName, LastName, Email, Address, Username, Password)
	Values(@FirstName, @LastName, @Email, @Address, @Username, @Password)