CREATE PROCEDURE sproc_tblStaff_Update
--create the parameters for the stored procedure
	@PhoneNo varchar (11),
    @FirstName varchar (50),
    @LastName varchar (50),
    @Email varchar (50),
    @StaffID int,
    @AddressLine1 varchar (50),
    @AddressLine2 varchar (50),
    @Active bit

	AS
	--update the record as specified by @StaffID value
	update tblStaff 
	set PhoneNo=@PhoneNo, 
		LastName=@LastName, 
		FirstName=@FirstName, 
		Email=@Email, 
		StaffID=@StaffID, 
		AddressLine1=@AddressLine1,
		AddressLine2=@AddressLine2,
		Active=@Active

	where StaffID=@StaffID
