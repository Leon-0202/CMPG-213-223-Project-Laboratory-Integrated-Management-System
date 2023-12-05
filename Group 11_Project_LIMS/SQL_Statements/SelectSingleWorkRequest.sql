Create Procedure SelectSingleWorkRequest
@Work_request_ID int

AS

SELECT * FROM WORK_REQUEST
WHERE Work_request_ID = @Work_request_ID