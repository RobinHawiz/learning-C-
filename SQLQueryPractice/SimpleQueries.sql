

/* My dictionary:

Rows : I mean records.

*/

/* select - The columns that you are going to select. */

/* from - The table that you are going to select columns from. */

/* order by (ascending)(a-z or 0-9) - Allows us to sort the resulting data. 
If you put <desc> at the end you'll order by descending (z-a or 9-0). 

Example: order by LastName desc

*/

/* where - Allows us to do some type of comparison to see if a row gets shown or not. 
If you put <like> at the end and a wildcard character (%) you can filter by a letter or a number.

Ex: where LastName like 'T%'

% represents 0 or more characters of an unknown type

So the example above says that:
The string in the LastName column must start with a T but then can have any kind of character or none, after it.
*/

/*

select FirstName, LastName, EmailAddress, PayRate, BillRate
from dbo.Employees
where LastName like 'T%'
order by LastName desc, FirstName desc

*/

/* You can rename table names, like this: from dbo.Customers c (dbo.Customers get renamed to just c) */

/* inner join - connect tables with each other
but you have to have a <from> statement before the <inner join> to know which table we are connecting with.

You put <on> ate the end to tell sql by which values it should link the tables together by.

IMPORTANT NOTICE: If there are no matches found on a given row, the row for both tables does not get shown.
*/

/* left join - Says give me ALL THE ROWS from the left table and if we have a match give me the row that equates to the right.
If we dont have a match, anytime we have a field from the right table, we just put NULL there. 

So in contrast to inner join, the left join shows the rows from both tables even though there were no matches.
*/

/* right join - Just the reverse of left join. */

/*

select c.CompanyName, l.City
from dbo.Customers c
right join dbo.Locations l on c.id = l.CustomerId;

*/

/* Looking up by id is more efficient than a text lookup. 

ex: where c.CompanyName = 'Acme Inc'
or doing:
where c.CompanyName like 'Acme %'

is less efficient than:

where c.id = 2
*/

/*  

You can use logic to decide what to show with <or> and <and>, ex:

where (c.CompanyName = 'Acme Inc' and c.id = 2) or c.id = 3 

You can also do:

where c.id in (2,3)

*/

select c.CompanyName
	, j.JobName
	, e.FirstName + ' ' + e.LastName as 'Employee Name'
	, w.[Description] as 'Explanation of work'
	, w.HoursWorked
	, l.StreetAddress
	, l.City
	, l.[State]
	, l.ZipCode
from dbo.WorkDone w
right join dbo.Employees e on e.id = w.EmployeeId
left join dbo.Jobs j on j.id = w.JobId
left join dbo.Locations l on l.id = w.LocationId
left join dbo.Customers c on c.id = j.CustomerId
--where (c.CompanyName = 'Acme Inc' and c.id = 2) or c.id = 3
where c.id in (2,3)
order by l.City;