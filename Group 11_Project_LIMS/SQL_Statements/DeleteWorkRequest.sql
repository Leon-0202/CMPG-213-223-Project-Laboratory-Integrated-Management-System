Create Procedure DeleteWorkRequest
@Work_request_ID int

AS

DELETE FROM WORK_REQUEST
WHERE Work_request_ID = @Work_request_ID