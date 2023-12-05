Create Procedure UpdateClient
@Client_ID int,
@Client_first_name varchar(30),
@Client_last_name varchar(30),
@Client_contact_number varchar(20),
@Client_email_address varchar(30),
@Billing_address_number varchar(10),
@Billing_address_street_name varchar(50),
@Billing_addres_city_ID varchar(30)

AS

UPDATE CLIENT
SET Client_first_name = @Client_first_name, Client_last_name = @Client_last_name, Client_contact_number = @Client_contact_number, Client_email_address = @Client_email_address, Billing_address_number = @Billing_address_number, Billing_address_street_name = @Billing_address_street_name, Billing_addres_city_ID = @Billing_addres_city_ID
WHERE Client_ID = @Client_ID