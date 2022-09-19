--ps1
create database Shopping

--ps2
--a
use Shopping
create table customer
(
custid int,
custname varchar(20),
city varchar(20),
state varchar(20)
)

--b
use Shopping
create table products
(
prodid int,
prodname varchar(20),
unitprice int,
UnitOfMeasurement int,
QtyinStock int
)

--c
 use Shopping
 create table sales_header
 (
 invno int,
 invdate date,
 invamt int,
 disPercent int
 )

 --d
use Shopping
 create table sales_detail
 (
 invno int,
 custid int, 
 prodid int,
 qtysold int
 )

 --e
use Shopping
(
 custid int primary key,
 prodid int
 invno int
 )

 --f
 alter table sales_detail
 add foreign key(invno)
  
   --ps3
 alter table sales_detail
 add foreign key(custid)
 add foreign key(prodid)

