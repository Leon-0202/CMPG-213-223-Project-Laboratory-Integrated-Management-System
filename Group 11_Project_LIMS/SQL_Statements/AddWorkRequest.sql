Create Procedure AddWorkRequest
@Client_ID int,
@Employee_ID int,
@Analytical_test_description varchar(50),
@Date_work_received date,
@Date_work_due date,
@Invoiced_YN bit

AS

INSERT INTO WORK_REQUEST (
Client_ID, Employee_ID, Analytical_test_description, Date_work_received, Date_due, Invoiced_YN)
VALUES (
@Client_ID, @Employee_ID, @Analytical_test_description, @Date_work_received, @Date_work_due, @Invoiced_YN)