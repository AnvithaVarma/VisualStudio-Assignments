use [Dxc Training]
--Create new table Client
create table Client(
Client_id int not null primary key identity(1,1),
Client_Name varchar(64) not null,
Contact_Person varchar(40),
Agreement_Date date
)

insert into Client values('Kumar','Varma','2020-10-24')

select * from Client

--Create new table named Project
create table Project(
Prj_ID int not null primary key identity(1,1),
Prj_Name varchar(64) not null,
Prj_Description varchar(1024),
Prj_Start_Date date,
Client_id int,
foreign key(Client_id) references Client(Client_id))

--insert into Project values('Queen','It is a game','2020-12-1')


--Create table Dept
create table Dept(
ID int not null primary key identity(1,1),
DeptName varchar(32) not null)

--CREATE TABLE EMPLOYEE
 create table Employee(
EmpID varchar(8) not null primary key,
EmpName varchar(64) not null,
Email varchar(64) null,
Phone varchar(815) not null,
Dept int not null,
foreign key(Dept) references Dept(ID))

insert into EMployee values(101,'Aish','aish1@gmail.com',9999999999,000)
insert into Dept values('ECE')

--adding new column
alter table Project
Add Prj_Cost decimal(12,2) null

alter table Project
alter column Prj_Description varchar(512)