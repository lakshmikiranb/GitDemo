create database LibrarySystem
create table Member
(
Member_Id int,
Member_Name char(25),
Acc_Open_Date date,
Max_Books_Allowed int,
Penalty_Amount int 

)

create table Book
(
Book_No int,
Book_Name VarChar(30),
Author Char(30),
Cost int,
Category Char(10)
)

create table Issue
(
Lib_Issue_Id int,
Book_No int,
Issue_Date date,
Return_date date
)

--Task 10
create table Member101(select * from table Member)