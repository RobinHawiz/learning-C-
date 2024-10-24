using LinqUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUI;
public static class MockData
{
    public static List<ContactModel> GetContactData()
    {
        List<ContactModel> output = new List<ContactModel>()
        {
        new ContactModel() { Id = 1, FirstName = "Tom", LastName = "Bombadill", Addresses = new List<int> { 1, 2, 3,}},
        new ContactModel() { Id = 2, FirstName = "John", LastName = "Jones", Addresses = new List<int> { 1 }},
        new ContactModel() { Id = 3, FirstName = "Tim", LastName = "Horton", Addresses = new List<int> { 2 }},
        new ContactModel() { Id = 4, FirstName = "Christina", LastName = "Aguilera", Addresses = new List<int> { 3 }},
        new ContactModel() { Id = 5, FirstName = "Kim", LastName = "Kay", Addresses = new List<int> { 2, 3 }},
        };

        return output;
    }

    public static List<AddressModel> GetAddressData()
    {
        List<AddressModel> output = new List<AddressModel>()
        {
            new AddressModel() { Id = 1, ContactId = 1, City = "Uppsala", County = "Uppland"},
            new AddressModel() { Id = 2, ContactId = 1, City = "Malmö", County = "Skåne"},
            new AddressModel() { Id = 3, ContactId = 2, City = "Västerås", County = "Västmanland"},
            new AddressModel() { Id = 4, ContactId = 5, City = "Malmö", County = "Skåne"},
            new AddressModel() { Id = 5, ContactId = 5, City = "Västerås", County = "Västmanland"},
            new AddressModel() { Id = 6, ContactId = 4, City = "Malmö", County = "Skåne"},
            new AddressModel() { Id = 7, ContactId = 3, City = "Västerås", County = "Västmanland"},

        };

        return output;
    }
}