use [Dxc Training]

select Client_id,Client_Name,Contact_Person,Agreement_Date from Client

--Add values into CLient
insert into Client values('Sravya','Sachin','2020-10-03')

--insert new row to the Client table
insert into Client values('Client 3','King','2020-02-02')

--insert row without value for date
insert into Client values('Client 5','Queen')

select * from Client

--Queen can not b inserted because date(null) is not mentioned.

--Update values from table Client
update Client set Contact_Person='Raja' where Client_id=2;

update Client set Agreement_Date='2020-06-05' where Client_id=2;

--Deleting rows from table
delete from Client where Client_id=2;
