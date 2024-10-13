using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;

SqlCrud sql = new SqlCrud(GetConnectionString());

// ReadAllContacts(sql);
// ReadContact(sql, 1);
// CreateNewContact(sql);
// UpdateContact(sql);
// RemovePhoneNumberFromContact(sql, 1, 2);

static void RemovePhoneNumberFromContact(SqlCrud sql, int contactId, int phoneNumberId)
{
    sql.RemovePhoneNumberFromContact(contactId, phoneNumberId);
}
static void UpdateContact(SqlCrud sql)
{
    BasicContactModel contact = new BasicContactModel()
    {
        Id = 2,
        FirstName = "Mi",
        LastName = "Amor",
    };

    sql.UpdateContactName(contact);
}
static void CreateNewContact(SqlCrud sql)
{
    FullContactModel user = new FullContactModel()
    {
        BasicInfo = new BasicContactModel { FirstName = "Simon", LastName = "Jensen" }
    };
    user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "kd.netroh@jis" });
    user.PhoneNumbers.Add(new PhoneNumberModel { Id = 2, PhoneNumber = "070-5678" });

    sql.CreateContact(user);
}

static void ReadAllContacts(SqlCrud sql)
{
    var rows = sql.GetAllContacts();

    foreach (var row in rows)
    {
        Console.WriteLine($"{row.Id}: {row.FirstName} {row.LastName}");
    }
}
static void ReadContact(SqlCrud sql, int contactId)
{
    var contact = sql.GetFullContactById(contactId);

    Console.WriteLine($"{contact.BasicInfo.Id}: {contact.BasicInfo.FirstName} {contact.BasicInfo.LastName}");
    Console.WriteLine("Email addresses:");
    foreach (var email in contact.EmailAddresses)
    {
        Console.WriteLine($"{email.EmailAddress}");
    }
    Console.WriteLine("Phone numbers:");
    foreach (var phoneNumber in contact.PhoneNumbers)
    {
        Console.WriteLine($"{phoneNumber.PhoneNumber}");
    }
}
static string GetConnectionString(string connectionString = "Default")
{
    string output = "";

    var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json");

    var config = builder.Build();

    output = config.GetConnectionString(connectionString);

    return output;
}