Create Procedure SelectSearchClient
@Client_search_value varchar(30)

AS

SELECT * FROM CLIENT
WHERE Client_first_name LIKE '%' + @Client_search_value + '%' OR Client_last_name LIKE '%' + @Client_search_value + '%'