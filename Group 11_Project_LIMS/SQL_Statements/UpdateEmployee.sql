Create Procedure UpdateEmployee
@Employee_ID int,
@Employee_first_name varchar(30),
@Employee_last_name varchar(30),
@Employee_ID_number char(13),
@Employee_contact_number varchar(20)

AS

UPDATE EMPLOYEE
SET Employee_first_name = @Employee_first_name, Employee_last_name = @Employee_last_name, Employee_ID_number = @Employee_ID_number, Employee_contact_number = @Employee_contact_number
WHERE Employee_ID = @Employee_ID