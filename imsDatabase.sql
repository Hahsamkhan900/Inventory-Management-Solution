create database imsDB

use imsDB


--Create table for User of IMS
create table users
(
	usr_id int not null identity(1,1) primary key,
	usr_name varchar(40) not null,
	usr_username varchar(30) not null,
	usr_password nvarchar(30) not null,
	usr_phone varchar(15) not null,
	usr_email varchar(50) not null,
	usr_status tinyint not null default 1
)


--Create Procedure for inserting a User
create procedure st_insertUsers
@name varchar(40),
@username varchar(30),
@pwd nvarchar(30),
@phone varchar(15),
@email varchar(50)
as insert into users (usr_name,usr_username,usr_password,usr_phone,usr_email) values(@name ,@username , @pwd,@phone,@email)

--create procedure for updating a User Data
create procedure st_updateUsers
@name varchar(40),
@username varchar(30),
@pwd nvarchar(30),
@phone varchar(15),
@email varchar(50),
@id int 
as update users
set
usr_name=@name,
usr_username=@username,
usr_password=@pwd,
usr_phone=@phone,
usr_email=@email
where 
usr_id = @id

--create procedure for delete the User Data
create procedure st_deleteUser
@id int
as
delete from users where usr_id = @id


--Create the procedure for get the Data of Users 
create procedure st_getUserData
as
select
u.usr_id as'ID',
u.usr_name as 'Name',
u.usr_username as 'UserName',
u.usr_password as 'Password',
u.usr_phone as 'Phone',
u.usr_email as 'Email',
case when(usr_status = 1 ) then 'Active' else 'Inactive' end as 'Status'
from users u
order by u.usr_name asc


create table categories
(
	cat_id int not null identity primary key,
	cat_Name varchar(50) not null,
	cat_isActive tinyint not null

)
	
create procedure st_insertCategory

@name varchar(50),
@isActice tinyint
as 
insert into categories values (@name, @isActice)

create procedure st_updateCategory
@name varchar(50),
@isActive tinyint,
@id int
as 
update categories 
set cat_Name  = @name,
cat_isActive = @isActive

where cat_id = @id

create procedure st_deleteCategory
@id int
as
delete from categories where cat_id = @id

create procedure st_getCategoriesData
as
select 
c.cat_id as 'ID',
c.cat_Name as 'Category',
case when ( c.cat_isActive = 1 ) then 'Yes' else 'No' end as 'Status'
from categories c
order by c.cat_Name asc

create procedure st_getCategoryList
as select
c.cat_Id as 'ID',
c.cat_Name as 'Category'
from categories c 
order by c.cat_Name asc	


create procedure st_getCategoriesDataLike
@data varchar(50)
as
select
c.cat_id as'ID',
c.cat_Name as 'Category Name',
case when(c.cat_isActive	 = 1 ) then 'Active' else 'Inactive' end as 'Status'
from categories c
where c.cat_Name like '%' + @data + '%'  
order by c.cat_name asc


--Working of Products

create table products
(
	prdt_ID int not null identity primary key,
	prdt_Name varchar(50) not null,
	prdt_ModelNo varchar(50) not null,
	prdt_Date date ,
	prdt_Qty varchar(50) not null,
	prdt_Price money not null,
	prdt_catID int not null foreign key references categories(cat_id)

)
--Create Procedure for inserting a Products
create procedure st_insertProducts

@prdt_Name varchar(50),
@prdt_ModelNo varchar(50),
@prdt_Date date,
@prdt_Qty varchar(50),
@prdt_Price money,
@prdt_catID int
as insert into 
products values   (@prdt_Name,@prdt_ModelNo,@prdt_Date,@prdt_Qty,@prdt_Price,@prdt_catID)

create procedure st_updateProducts


@prdt_Name varchar(50),
@prdt_ModelNo varchar(50),
@prdt_Date date,
@prdt_Qty varchar(50),
@prdt_Price money,
@prdt_id int,
@prdt_CatID int
as update products
set

prdt_Name = @prdt_Name,
prdt_ModelNo = @prdt_ModelNo,
prdt_Date =@prdt_Date,
prdt_Qty = @prdt_Qty,
prdt_Price = @prdt_Price,
prdt_catID = @prdt_CatID
where prdt_ID = @prdt_id

create procedure st_deleteProduct
@prdt_ID int
as
delete from products where prdt_ID = @prdt_ID

create procedure st_getProductData
as
select
p.prdt_ID as'prdt_ID',
p.prdt_Name as 'prdt_Name',
p.prdt_ModelNo as 'prdt_ModelNo',
format(p.prdt_Date,'dd-MMM-yyy')  as 'prdt_Date',
p.prdt_Qty as 'prdt_Qty',
p.prdt_Price as 'prdt_Price',
c.cat_Name as 'Category_Name',
c.cat_id as 'Category_ID'
from products p inner join categories c 
on c.cat_id = p.prdt_catID 


alter procedure st_getProductsDataLike
@data varchar(50)
as
select
p.prdt_ID as'prdt_ID',
p.prdt_Name as 'prdt_Name',
p.prdt_ModelNo as 'prdt_ModelNo',
format(p.prdt_Date,'dd-MMM-yyy') as 'prdt_Date',
p.prdt_Qty as 'prdt_Qty',
p.prdt_Price as 'prdt_Price',
c.cat_Name as 'Category_Name',
c.cat_id as 'Category_ID'
from products  p inner join categories c on c.cat_id = p.prdt_catID
where
p.prdt_Name like '%' + @data + '%' or
p.prdt_ModelNo like '%' + @data + '%' or
p.prdt_Date like '%' + @data + '%' or
p.prdt_Qty like '%' + @data + '%' or
p.prdt_Price like '%' + @data + '%' or
c.cat_Name like '%' + @data + '%' 
order by p.prdt_Name asc

create procedure st_getUserDetails
@user varchar(30),
@pass nvarchar(30)
as
select u.usr_username as 'Username',
	   u.usr_password as 'Password',
	   u.usr_id as 'ID',
	   u.usr_name as 'Name'
	   from users u 
where u.usr_username = @user and u.usr_password = @pass 



create table supplier
(
	sup_ID int not null identity primary key,
	sup_SupplierName varchar(30) not null,
	sup_PhoneNo1 varchar(15) not null,
	sup_PhoneNo2 varchar(15),
	sup_email varchar(50),
	sup_Status tinyint not null,
	sup_compID int not null

)



create procedure st_insertSuppliers
@sup_SupplierName varchar(30),
@sup_PhoneNo1 varchar(15),
@sup_PhoneNo2 varchar(15),
@sup_email nvarchar(50),
@sup_Status tinyint,
@sup_compID int
as insert into 
supplier values   (@sup_SupplierName,@sup_PhoneNo1,@sup_PhoneNo2,@sup_email,@sup_Status,@sup_compID)

alter procedure st_upateSuppliers
@sup_SupplierName varchar(30),
@sup_PhoneNo1 varchar(15),
@sup_PhoneNo2 varchar(15),
@sup_email nvarchar(100),
@sup_Status tinyint,
@sup_ID int,
@sup_compID int
as update supplier
set
sup_SupplierName = @sup_SupplierName,
sup_PhoneNo1 = @sup_PhoneNo1,
sup_PhoneNo2 = @sup_PhoneNo2,
sup_email =@sup_email,
sup_Status = @sup_Status,
sup_compID = @sup_compID
where 
sup_ID = @sup_ID


create procedure st_deleteSupplier
@id int
as
delete from supplier where sup_ID = @id


alter procedure st_getSupplierData
as
select
s.sup_ID as'ID',
s.sup_SupplierName as 'Supplier_Name',
s.sup_PhoneNo1 as 'PhoneNo1',
s.sup_PhoneNo2 as 'PhoneNo2',
s.sup_email as 'Address',
c.comp_Name as 'Company_Name',
case when(s.sup_Status = 1 ) then 'Active' else 'Inactive' end as 'Status'
from supplier  s inner join company c on c.comp_ID = s.sup_compID



create procedure st_getSupplierDataLike
@data varchar(50)
as
select
sup_ID as'ID',
sup_CompName as 'Company_Name',
sup_ContactPerson as 'Supplier_Name',
sup_PhoneNo1 as 'PhoneNo1',
sup_PhoneNo2 as 'PhoneNo2',
sup_Address as 'Address',
sup_Ntn as 'Ntn #'
from supplier 
where 
sup_ID like '%' + @data + '%' or
sup_CompName like '%' + @data + '%' or
sup_ContactPerson like '%' + @data + '%' or
sup_PhoneNo1 like '%' + @data + '%' or
sup_PhoneNo2 like '%' + @data + '%' or
sup_Ntn like '%' + @data + '%' or
sup_Status like '%' + @data + '%'  
order by sup_ContactPerson asc

alter procedure st_getSupplierList
as select
s.sup_ID as 'ID',
s.sup_CompName as 'Company'
from supplier s
where s.sup_Status = 1
order by s.sup_CompName asc


alter procedure st_getProductByModelNo
@prdt_ModelNo varchar(50)
as
select 
p.prdt_ID as 'Product ID',
p.prdt_Name as 'Product Name',
p.prdt_Price as 'Product Price',
p.prdt_ModelNo as 'Product ModelNo'
from products p where p.prdt_ModelNo = @prdt_ModelNo

create procedure st_getSupplierNameByCompany
@sup_CompName varchar(50)
as
select 
s.sup_ID as 'Supplier ID',
s.sup_ContactPerson as 'Supplier Name'

from supplier s where s.sup_CompName = @sup_CompName


create table company
(
	comp_ID int not null identity primary key,
	comp_Name varchar(50) not null unique,
	comp_Address varchar(100) not null,
	comp_phoneNo1 varchar(15) not null,
	comp_phoneNo2 varchar(15),
	comp_Ntn varchar(20),
	comp_Status tinyint not null
)
insert into company values	('Sigma','Saddar','asda','sadasd','Ad',1)

create procedure st_insertCompany
@comp_Name varchar(50),
@comp_Address varchar(100),
@comp_phoneNo1 varchar(15),
@comp_phoneNo2 varchar(15),
@comp_Ntn varchar (20),
@comp_Status tinyint
as insert into 
company values   (@comp_Name,@comp_Address,@comp_phoneNo1,@comp_phoneNo2,@comp_Ntn,@comp_Status)

create procedure st_getCompanyData
as
select
comp_ID as'comp_ID',
comp_Name as 'Company_Name',
comp_Address as 'Company_Address',
comp_phoneNo1 as 'Comp_Phone1',
comp_phoneNo2 as 'Comp_Phone2',
comp_Ntn as 'Comp_NTN',
case when(comp_Status = 1 ) then 'Active' else 'Inactive' end as 'Status'
from company 
order by comp_Name asc


alter procedure st_getCompanyDataLike
@data varchar(50)
as
select
comp_ID as'comp_ID',
comp_Name as 'Company_Name',
comp_Address as 'Company_Address',
comp_phoneNo1 as 'Comp_Phone1',
comp_phoneNo2 as 'Comp_Phone2',
comp_Ntn as 'Comp_NTN',
case when(comp_Status = 1 ) then 'Active' else 'Inactive' end as 'Status'
from company 
where 
comp_ID like '%' + @data + '%' or
comp_Name like '%' + @data + '%' or
comp_Address like '%' + @data + '%' or
comp_phoneNo1 like '%' + @data + '%' or
comp_phoneNo2 like '%' + @data + '%' or
comp_Ntn like '%' + @data + '%' or
comp_Status like '%' + @data + '%'  
order by comp_Name asc

create procedure st_deleteCompany
@id int
as
delete from company where comp_ID = @id


create procedure st_updateCompany
@comp_Name varchar(50),
@comp_Address varchar(100),
@comp_phoneNo1 varchar(15),
@comp_phoneNo2 varchar(15),
@comp_Ntn varchar (20),
@comp_Status tinyint,
@comp_ID int
as update company
set
comp_Name = @comp_Name,
comp_Address = @comp_Address,
comp_phoneNo1 =@comp_phoneNo1,
comp_phoneNo2 = @comp_phoneNo2,
comp_Ntn = @comp_Ntn,
comp_Status = @comp_Status
where comp_ID = @comp_ID

create procedure st_getCompanyList
as select
c.comp_ID as 'compID',
c.comp_Name as 'Company_Name'
from company c
where c.comp_Status = 1
order by c.comp_Name asc

alter procedure st_getSupplierList
as select
s.sup_compID as 'supplierID',
s.sup_SupplierName as 'supplierName'
from supplier  s ,company c
where s.sup_compID = c.comp_ID
order by s.sup_SupplierName asc

create table purchaseInvoice
(
	pi_id bigint not null identity primary key,
	pi_date date not null,
	pi_doneBy int not null,
	pi_compId int not null

)

create procedure st_insertPurchaseInvoice
@date date,
@doneBy int,
@compID int
as
insert into purchaseInvoice values (@date,@doneBy,@compID)

create procedure st_getLastPurchaseId
as
select top 1 pii.pi_id from	purchaseInvoice pii order by pii.pi_id desc


create table purchaseInvoiceDetails
(	
	pid_id bigint not null identity,
	pid_purchaseid bigint not null foreign key references purchaseInvoice(pi_id),
	pid_proID int not null,
	pid_proQty int not null,
	pid_totalPrice money not null,
)

create procedure st_insertPurchaseInvoiceDetails
@purchaseid bigint,
@proID int,
@proQty int,
@totalPrice money
as
insert into purchaseInvoiceDetails values (@purchaseid,@proID,@proQty,@totalPrice)

DROP TABLE stock
create table stock
(
	st_proID int not null unique,
	st_quan int not null
)

create procedure st_insertStock
@proID int,
@quan int
as
insert into stock values(@proID,@quan)

create procedure st_updateStock
@proID int,
@quan int
as
update stock
set st_quan=@quan
where st_proID = @proID

create procedure st_getProductQuantity
@proID int
as
select s.st_quan as 'Quantity' from stock s
where s.st_proID = @proID

delete from purchaseInvoiceDetails DBCC CheckIDent('purchaseInvoiceDetails', RESEED,0)
delete from purchaseInvoice DBCC CheckIDent('purchaseInvoice', RESEED,0)

create procedure st_deleteProductFromPID
@mPID bigint
as
delete from purchaseInvoiceDetails
where pid_id = @mPid

alter procedure st_getAllStock
as
select 
p.prdt_ID as 'Product Id',
p.prdt_Name as 'Product Name',
c.cat_Name as 'Category Name',
p.prdt_ModelNo as 'Model No',
p.prdt_Price as 'Product Price',
s.st_quan as 'Stock Available',
case when(s.st_quan = 0) then 'Empty' else case when(s.st_quan<50) then 'Low Qty' else case when (s.st_quan < 100 and s.st_quan >50 ) then 'Average Qty' else case when(s.st_quan >=100) then 'Good Qty' end end end
end as 'Status',
p.prdt_Price * s.st_quan as 'Total Amount'
from stock s
inner join products p 
inner join categories c on c.cat_id = p.prdt_catID on p.prdt_ID = s.st_proID