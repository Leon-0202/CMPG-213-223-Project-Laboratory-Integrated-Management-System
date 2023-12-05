Create Procedure AddEmployee
@Employee_first_name varchar(30),
@Employee_last_name varchar(30),
@Employee_ID_number char(13),
@Employee_contact_number varchar(20)


AS

INSERT INTO EMPLOYEE (
Employee_first_name, Employee_last_name, Employee_ID_number, Employee_contact_number)
VALUES (
@Employee_first_name, @Employee_last_name, @Employee_ID_number, @Employee_contact_number)