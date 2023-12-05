Create Procedure SelectSearchInvoice
@Invoice_search_value varchar(30)

AS

SELECT * FROM INVOICE
WHERE Invoice_ID LIKE '%' + @Invoice_search_value