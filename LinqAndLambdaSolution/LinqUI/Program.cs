using LinqUI;
using LinqUI.Models;

LambdaTests();
LinqTests();
Console.ReadLine();
static void LinqTests()
{
    var contactData = MockData.GetContactData();
    var addressData = MockData.GetAddressData();

    Console.WriteLine("Linq test results:");
    Console.WriteLine();

    var results = (from c in contactData
                   where c.Addresses.Count > 1
                   select c);
    foreach (var item in results)
    {
        Console.Write($" {item.FirstName} {item.LastName} ");
    }

    Console.WriteLine();

    var results2 = (from c in contactData
                    join a in addressData
                    on c.Id equals a.ContactId
                    select new { c.FirstName, c.LastName, a.City });
    foreach (var item in results2)
    {
        Console.WriteLine($" {item.FirstName} {item.LastName} {item.City}");
    }

    Console.WriteLine();

    var results3 = (from c in contactData
                    select new { c.FirstName, c.LastName, Addresses = addressData.Where(a => a.ContactId == c.Id) });
    foreach (var item in results3)
    {
        Console.WriteLine($" {item.FirstName} {item.LastName} ");
        foreach (var address in item.Addresses)
        {
            Console.WriteLine($" --{address.City} {address.County}-- ");
        }
        Console.WriteLine();
    }

    Console.WriteLine("--------------------");
    Console.WriteLine();

    var results4 = (from c in contactData
                    select new { c.FirstName, c.LastName, Addresses = addressData.Where(a => c.Addresses.Contains(a.Id)) });
    foreach (var item in results4)
    {
        Console.WriteLine($" {item.FirstName} {item.LastName} ");
        foreach (var address in item.Addresses)
        {
            Console.WriteLine($" --{address.City} {address.County}-- ");
        }
        Console.WriteLine();
    }
}
static void LambdaTests()
{
    var contactData = MockData.GetContactData();

    Console.WriteLine("Lambda test results:");
    Console.WriteLine();

    var resultsWhere = contactData.Where(x => x.Addresses.Count < 3);
    foreach (var item in resultsWhere)
    {
        Console.Write($" {item.FirstName} {item.LastName} ");
    }

    Console.WriteLine();

    var resultsSelect = contactData.Select(x => x.FirstName);
    foreach (var item in resultsSelect)
    {
        Console.Write($" {item} ");
    }

    Console.WriteLine();

    var resultsSkipTake = contactData.Skip(2).Take(2);
    foreach (var item in resultsSkipTake)
    {
        Console.Write($" {item.FirstName} {item.LastName} ");
    }

    Console.WriteLine();

    var resultsOrderBy = contactData.OrderBy(x => x.LastName);
    foreach (var item in resultsOrderBy)
    {
        Console.Write($" {item.FirstName} {item.LastName} ");
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("--------------------");
}