Create Procedure SelectSearchWorkRequest
@Request_search_value varchar(30)

AS

SELECT * FROM WORK_REQUEST
WHERE Work_request_ID LIKE '%' + @Request_search_value + '%'