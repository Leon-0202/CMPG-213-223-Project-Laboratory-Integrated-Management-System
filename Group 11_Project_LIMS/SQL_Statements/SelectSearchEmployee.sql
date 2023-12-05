Create Procedure SelectSearchEmployee
@Employee_search_value varchar(30)

AS

SELECT * FROM EMPLOYEE
WHERE Employee_first_name LIKE '%' + @Employee_search_value + '%' OR Employee_last_name LIKE '%' + @Employee_search_value + '%'