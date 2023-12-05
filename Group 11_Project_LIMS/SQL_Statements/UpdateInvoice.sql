Create Procedure UpdateInvoice
@Invoice_ID int,
@Amount_invoiced smallmoney,
@Amount_paid smallmoney,
@Amount_due smallmoney,
@Paid_YN bit

AS

UPDATE INVOICE
SET Amount_invoiced = @Amount_invoiced, Amount_paid = @Amount_paid, Amount_due = @Amount_due, Paid_YN = @Paid_YN
WHERE Invoice_ID = @Invoice_ID