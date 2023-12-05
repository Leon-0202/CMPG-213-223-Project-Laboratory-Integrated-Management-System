Create Procedure SelectSingleClient
@Client_ID int

AS

SELECT * FROM CLIENT
WHERE Client_ID = @Client_ID