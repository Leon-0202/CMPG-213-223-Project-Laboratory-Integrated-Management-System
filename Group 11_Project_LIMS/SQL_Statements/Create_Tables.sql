USE DB_LIMS
GO

CREATE TABLE EMPLOYEE (
	Employee_ID int IDENTITY(1, 1) PRIMARY KEY,
	Employee_first_name varchar(30),
	Employee_last_name varchar(30),
	Employee_ID_number char(13),
	Employee_contact_number varchar(20)
);

CREATE TABLE CLIENT (
	Client_ID int IDENTITY(1, 1) PRIMARY KEY,
	Client_first_name varchar(30),
	Client_last_name varchar(30),
	Client_contact_number varchar(20),
	Client_email_address varchar(30),
	Billing_address_number varchar(10),
	Billing_address_street_name varchar(50),
	Billing_addres_city_ID varchar(30)
);

CREATE TABLE WORK_REQUEST (
	Work_request_ID int IDENTITY(1, 1) PRIMARY KEY,
	Client_ID int FOREIGN KEY REFERENCES CLIENT (Client_ID),
	Employee_ID int FOREIGN KEY REFERENCES EMPLOYEE (Employee_ID),
	Analytical_test_description varchar(50),
	Date_work_received date,
	Date_due date,
	Invoiced_YN bit
);

CREATE TABLE INVOICE (
	Invoice_ID int IDENTITY(1, 1) PRIMARY KEY,
	Work_request_ID int FOREIGN KEY REFERENCES WORK_REQUEST (Work_request_ID),
	Date_invoiced date,
	Date_payable date,
	Amount_invoiced smallmoney,
	Amount_paid smallmoney,
	Amount_due smallmoney,
	Paid_YN bit
);