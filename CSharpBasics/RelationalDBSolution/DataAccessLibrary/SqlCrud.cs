﻿using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary;

public class SqlCrud
{
    private readonly string _connectionString;
    private SqlDataAccess db = new SqlDataAccess();
    public SqlCrud(string connectionString)
    {
        _connectionString = connectionString;
    }
    public List<BasicContactModel> GetAllContacts()
    {
        string sql = "select Id, FirstName, LastName from dbo.Contacts";

        return db.LoadData<BasicContactModel, dynamic>(sql, new { }, _connectionString);
    }

    public FullContactModel GetFullContactById(int id)
    {
        string sql = "select Id, FirstName, LastName from dbo.Contacts where Id = @Id";
        FullContactModel output = new FullContactModel();

        output.BasicInfo = db.LoadData<BasicContactModel, dynamic>(sql, new { id }, _connectionString).FirstOrDefault();

        if (output.BasicInfo == null)
        {
            // do something to tell the user that the record was not found
            throw new Exception("User was not found");
            return null;
        }

        sql = @"select e.*
                from dbo.EmailAddresses e 
                inner
                join dbo.ContactEmail ce on ce.EmailAddressId = e.Id
                where ce.ContactId = @Id";

        output.EmailAddresses = db.LoadData<EmailAddressModel, dynamic>(sql, new { id }, _connectionString);

        sql = @"select p.*
                from dbo.PhoneNumbers p
                inner
                join dbo.ContactPhoneNumbers cp on cp.PhoneNumberId = p.Id
                where cp.ContactId = @Id";

        output.PhoneNumbers = db.LoadData<PhoneNumberModel, dynamic>(sql, new { id }, _connectionString);

        return output;
    }

    public void CreateContact(FullContactModel contact)
    {
        string sql = "insert into dbo.Contacts (FirstName, LastName) values (@FirstName, @LastName);";
        // Save the basic contact
        db.SaveData(sql, new { contact.BasicInfo.FirstName, contact.BasicInfo.LastName }, _connectionString);

        // Get the ID number of the contact
        sql = "select Id from dbo.Contacts where FirstName = @FirstName and LastName = @LastName;";
        int contactId = db.LoadData<IdLookupModel, dynamic>(sql, new { contact.BasicInfo.FirstName, contact.BasicInfo.LastName }, _connectionString).First().Id;

        foreach (var phoneNumber in contact.PhoneNumbers)
        {
            if (phoneNumber.Id == 0)
            {
                sql = "insert into dbo.PhoneNumbers (PhoneNumber) values (@PhoneNumber);";
                db.SaveData(sql, new { phoneNumber.PhoneNumber }, _connectionString);

                sql = "select Id from dbo.PhoneNumbers where PhoneNumber = @PhoneNumber";
                phoneNumber.Id = db.LoadData<IdLookupModel, dynamic>(sql, new { phoneNumber.PhoneNumber }, _connectionString).First().Id;
            }

            sql = "insert into dbo.ContactPhoneNumbers (ContactId, PhoneNumberId) values (@ContactId, @PhoneNumberId);";
            db.SaveData(sql, new { contactId, PhoneNumberId = phoneNumber.Id }, _connectionString);
        }

        foreach (var email in contact.EmailAddresses)
        {
            if (email.Id == 0)
            {
                sql = "insert into dbo.EmailAddresses (EmailAddress) values (@EmailAddress);";
                db.SaveData(sql, new { email.EmailAddress }, _connectionString);

                sql = "select Id from dbo.EmailAddresses where EmailAddress = @EmailAddress";
                email.Id = db.LoadData<IdLookupModel, dynamic>(sql, new { email.EmailAddress }, _connectionString).First().Id;
            }

            sql = "insert into dbo.ContactEmail (ContactId, EmailAddressId) values (@ContactId, @EmailAddressId);";
            db.SaveData(sql, new { contactId, EmailAddressId = email.Id }, _connectionString);
        }
    }

    public void UpdateContactName(BasicContactModel contact)
    {
        string sql = "update dbo.Contacts set FirstName = @FirstName, LastName = @LastName where Id = @Id";
        db.SaveData(sql, contact, _connectionString);
    }

    public void RemovePhoneNumberFromContact(int contactId, int phoneNumberId)
    {
        // Find all of the usages of the phone number id
        // If 1, then delete link and phone number
        // If > 1, then delete link for contact
        string sql = "select Id, ContactId, PhoneNumberId from dbo.ContactPhoneNumbers where PhoneNumberId = @PhoneNumberId;";
        var links = db.LoadData<ContactPhoneNumberModel, dynamic>(sql, new { PhoneNumberId = phoneNumberId }, _connectionString);

        sql = "delete from dbo.ContactPhoneNumbers where PhoneNumberId = @PhoneNumberId and ContactId = @ContactId";
        db.SaveData(sql, new { PhoneNumberId = phoneNumberId, ContactId = contactId }, _connectionString);

        if (links.Count == 1)
        {
            sql = "delete from dbo.PhoneNumbers where Id = @PhoneNumberId;";
            db.SaveData(sql, new { PhoneNumberId = phoneNumberId }, _connectionString);
        }
    }
}

