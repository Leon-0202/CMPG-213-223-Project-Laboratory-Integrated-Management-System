Create Procedure UpdateWorkRequest
@Work_request_ID int,
@Client_ID int,
@Employee_ID int,
@Analytical_test_description varchar(50)

AS

UPDATE WORK_REQUEST
SET Client_ID = @Client_ID, Employee_ID = @Employee_ID, Analytical_test_description = @Analytical_test_description
WHERE Work_request_ID = @Work_request_ID