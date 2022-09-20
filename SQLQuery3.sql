use Shopping

create table products
(
prodid int primary key,
prodname varchar(20)
)
drop table products

create table products 
(prodid int identity(1,1) constraint pk_key primary key,
prodname varchar(20),
unitprice int constraint price_check check(unitprice>0),
mfgdate date default getdate(),
saledate date,
constraint date_check check(saledate>=mfgdate))

select SYSDATETIME()

sp_help products

select*from products


create table ProductSales
(invno int primary key identity(101,1),
invdate date default getdate(),
amt numeric(10,2)
)

insert int productSales(amt)values(67896.67)

select*from productsales

update ProductSales
set amt=100000
where invno=101

update ProductSales
set amt=40000,invdate='2022-09-24'
where invno=102

delete from products
where 






--M-N
create table teacher 
(teacher int primary key,
teacher varchar(20))

create 