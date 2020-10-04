use [Dxc Training]

select * from Employee
select * from Dept

 select * from client
 select * from project

select emp.empID,emp.EmpName,dep.DeptName
from Employee emp
join Dept dep
on emp.Dept=dep.ID
where DeptName='Planning'

select * from Dept

select dep.DeptName, emp.empID, emp.EmpName 
from Dept dep 
join Employee emp 
on emp.Dept = dep.ID
order by DeptName

select dep.DeptName, emp.empID, emp.EmpName 
from Dept dep 
left outer join Employee emp 
on emp.Dept = dep.ID
order by DeptName


select DeptName, empID, EmpName 
from Dept  
right outer join Employee  
on Dept = ID
order by DeptName

-- get employees from selected departments
select dep.DeptName, emp.empID, emp.EmpName 
from Dept dep 
left outer join Employee emp 
on emp.Dept = dep.ID 
--where DeptName IN ('Planning','Finance', 'Purchase')
where DeptName not IN ('Purchase')

-- get numner of employees
select count(EmpID) as Emp_Count from Employee

select * from project

-- project cost of all projects
select sum(Prj_Cost) as Project_All_Value from Project 
where Prj_ID>1

select * from project
select client, sum(prj_cost) from Project group by Client

select * from client

select Client_Name, sum(prj_cost) from Project 
join Client on Client_ID
where prj_cost>20000 
group by Client_Name, prj_cost, Prj_Start_Date
having Prj_Start_Date > '2020-07-01'

select * from project where Prj_Start_Date > '2020-07-01'

select top 3 * from Employee