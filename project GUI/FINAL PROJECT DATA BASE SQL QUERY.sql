CREATE DATABASE VEHICHELE_SPAREPART_SHOP;

CREATE TABLE Customer_Detail(
cus_reg_no VARCHAR(20) NOT NULL PRIMARY KEY,
cus_name VARCHAR(250) NOT NULL,
cus_address VARCHAR(350) NOT NULL,
cus_phone VARCHAR(15) NOT NULL,
cus_email VARCHAR(150)
);

CREATE TABLE Customer_Login_Detail(
cus_login_id VARCHAR(20) NOT NULL PRIMARY KEY,
cus_user_name VARCHAR(150) NOT NULL,
cus_password VARCHAR(20) NOT NULL UNIQUE,
cus_reg_no VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Customer_Detail(cus_reg_no)
);

CREATE TABLE Order_Detail(
order_id VARCHAR(20) NOT NULL PRIMARY KEY,
order_type VARCHAR(30) NOT NULL,
order_date DATE  NOT NULL,
total_quantity int NOT NULL,
cus_reg_no VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Customer_Detail(cus_reg_no),
pay_id VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Order_Payment_Detail(pay_id)
);

CREATE TABLE Order_Payment_Detail(
pay_id VARCHAR(20) NOT NULL PRIMARY KEY,
pay_amount float(2) NOT NULL,
pay_type VARCHAR(50) NOT NULL,
pay_date DATE  NOT NULL,
bill_no VARCHAR(20) NOT NULL
);

CREATE TABLE Delivery_Detail(
delivery_id VARCHAR(20) NOT NULL PRIMARY KEY,
delivery_date DATE  NOT NULL,
delivery_status VARCHAR(30) NOT NULL,
order_id VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Order_Detail(order_id)
);

CREATE TABLE Order_Item_Detail(
order_detail_id VARCHAR(20) NOT NULL PRIMARY KEY,
order_quantity float(2) NOT NULL,
discount float(2) ,
order_id VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Order_Detail(order_id),
pro_id VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Product_Detail(pro_id)
);

CREATE TABLE Product_Detail(
pro_id VARCHAR(20) NOT NULL PRIMARY KEY,
pro_name VARCHAR(150) NOT NULL,
model_no VARCHAR(30) NOT NULL,
model_name VARCHAR(150) NOT NULL,
pro_quantity float(2) NOT NULL,
unit_price float(2) NOT NULL,
size VARCHAR(50),
category_id VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Category_Detail(category_id),
supply_id VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Supply_Detail(supply_id)
);

CREATE TABLE Category_Detail(
category_id VARCHAR(20) NOT NULL PRIMARY KEY,
category_name VARCHAR(50) NOT NULL,
category_description VARCHAR(400)
);

CREATE TABLE Supply_Detail(
supply_id VARCHAR(20) NOT NULL PRIMARY KEY,
supply_name VARCHAR(150) NOT NULL,
supply_phone VARCHAR(15)
);

CREATE TABLE Employee_Detail(
emp_id VARCHAR(20) NOT NULL PRIMARY KEY,
emp_name VARCHAR(250) NOT NULL,
emp_address VARCHAR(350) NOT NULL,
emp_email VARCHAR(100)
);

CREATE TABLE Employee_Contact_Detail(
emp_id VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Employee_Detail(emp_id),
mobile_no VARCHAR(15) NOT NULL,
land_line VARCHAR(15) NOT NULL,
);


CREATE TABLE Employee_Login_Detail(
emp_login_id VARCHAR(20) NOT NULL PRIMARY KEY,
emp_user_name VARCHAR(150) NOT NULL,
emp_password VARCHAR(20) NOT NULL UNIQUE,
emp_id VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Employee_Detail(emp_id)
);

CREATE TABLE Emp_Role_Detail(
role_id VARCHAR(20) NOT NULL PRIMARY KEY,
role_name VARCHAR(150) NOT NULL,
role_description VARCHAR(200),
emp_id VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Employee_Detail(emp_id)
);

CREATE TABLE Report_Detail(
report_id VARCHAR(20) NOT NULL PRIMARY KEY,
report_title VARCHAR(100) NOT NULL,
report_description VARCHAR(400) NOT NULL,
emp_id VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Employee_Detail(emp_id),
sale_id VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Sale_Detail(sale_id)
);

CREATE TABLE Sale_Detail(
sale_id VARCHAR(20) NOT NULL PRIMARY KEY,
sale_item_name VARCHAR(100) NOT NULL,
sale_type VARCHAR(30) NOT NULL,
sale_amount float(2),
sale_description VARCHAR(400) NOT NUll
);


































