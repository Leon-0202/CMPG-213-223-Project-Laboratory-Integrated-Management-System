Create Procedure InvoiceWorkRequest
@Work_request_ID int,
@Date_invoiced date,
@Date_payable date,
@Amount_invoiced smallmoney,
@Amount_paid smallmoney,
@Amount_due smallmoney,
@Paid_YN bit

AS

UPDATE WORK_REQUEST
SET Invoiced_YN = 1
WHERE Work_request_ID = @Work_request_ID

INSERT INTO INVOICE (
Work_request_ID, Date_invoiced, Date_payable, Amount_invoiced, Amount_paid, Amount_due, Paid_YN)
VALUES (
@Work_request_ID, @Date_invoiced, @Date_payable, @Amount_invoiced, @Amount_paid, @Amount_due, @Paid_YN)