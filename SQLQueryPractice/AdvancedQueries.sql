
/* group by - groups rows that have the same values into summary rows, like:

"find the number of hours worked for each company".

The GROUP BY statement is often used with aggregate functions:
count(), max(), min(), sum(), avg() to group the result-set by one or more columns.

*/

/*

select c.CompanyName
	 --, e.FirstName
	 , sum(w.HoursWorked) as 'Total Work'
	 , count(1) as 'Number of Entries'
	 , min(w.HoursWorked) as 'Minimum'
	 , max(w.HoursWorked) as 'Maximum'
	 , avg(w.HoursWorked) as 'Average'
from dbo.WorkDone w
inner join dbo.Jobs j on j.id = w.JobId
inner join dbo.Customers c on c.id = j.CustomerId
inner join dbo.Employees e on e.id = w.EmployeeId
-- <where> acts upon the above query, before the group by and order by.
-- This: where w.id != 9 : will not include the work hours for that job.
--where w.id != 9
group by c.CompanyName--, e.FirstName
-- <having> works after the group by
having sum(w.HoursWorked) > 5
order by c.CompanyName

*/


-- union (all) - Takes two different select statements and appends them.
-- If you use <union> without (all) then you'll exclude any duplicate rows (the entire row, not just one entry).


/* Good example if you want a mailing list from two tables:

select c.EmailAddress
from dbo.Customers c
union
select e.EmailAddress
from dbo.Employees e

But union all is more efficient than just union, because we allow for dublicates with union all.

*/

/* distinct - Checks if the rows are distinct.
ex:

select distinct JobId
from dbo.WorkDone

*/ 

/* top - show the first rows in your table. Ex select top 2 * gets the first two rows.

ex:

select top 5 *
from dbo.WorkDone
-- DatePerformed makes sure that if the rows have the same HoursWorked, then we order those by which job was performed first.
order by HoursWorked desc, DatePerformed

*/

/*
select e.*
--instead of specifying a table, we use a query instead (which gets used as a table). 
from (select FirstName, LastName from dbo.Employees) e
*/

select c.*
	 --You cant return more than one row or column inside this subquery. Only one cells worth of information.
	 , (select top 1 e.FirstName + ' ' + e.LastName
	    from dbo.WorkDone w
		inner join dbo.Locations l on l.id = w.LocationId
		inner join dbo.Employees e on e.id = w.EmployeeId
		where c.id = l.CustomerId
		group by e.FirstName, e.LastName
		order by sum(w.HoursWorked) desc
		)
	--Here you can return tables worth of information.
from dbo.Customers c


select c.CompanyName, count(c.id) as 'Number of Work Entries'
from dbo.WorkDone w
inner join dbo.Locations l on l.id = w.LocationId
inner join dbo.Customers c on c.id = l.CustomerId
group by c.CompanyName
order by COUNT(c.id) desc
