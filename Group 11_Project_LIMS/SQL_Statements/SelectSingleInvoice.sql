Create Procedure SelectSingleInvoice
@Invoice_ID int

AS

SELECT * FROM INVOICE
WHERE Invoice_ID = @Invoice_ID