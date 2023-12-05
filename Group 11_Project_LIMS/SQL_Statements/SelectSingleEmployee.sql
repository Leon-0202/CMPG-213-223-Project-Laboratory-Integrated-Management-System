Create Procedure SelectSingleEmployee
@Employee_ID int

AS

SELECT * FROM EMPLOYEE
WHERE Employee_ID = @Employee_ID