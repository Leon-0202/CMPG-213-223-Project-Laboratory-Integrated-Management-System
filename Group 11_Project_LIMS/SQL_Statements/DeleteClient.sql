Create Procedure DeleteClient
@Client_ID int

AS

DELETE FROM CLIENT
WHERE Client_ID = @Client_ID