Create Procedure DeleteEmployee
@Employee_ID int

AS

DELETE FROM EMPLOYEE
WHERE Employee_ID = @Employee_ID