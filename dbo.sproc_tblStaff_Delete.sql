CREATE PROCEDURE [dbo].sproc_tblStaff_Delete

--this stored procedure is situated in the data layer (App_Data folder)

--this stored procedure is used to delete a single record in the table tblAddress
--it accepts a single parameter @StaffID and returns no value
	
	--declare the parameter 
	@StaffID int
	
AS
	--delete the record in tblAddress specified by the value of @StaffID
	delete from tblStaff where StaffID = @StaffID;