create procedure FetchEmployees
as
begin
select employeeid as ID, employeename as NAME, employeesalary as SALARY, location as LOCATION from employees
end