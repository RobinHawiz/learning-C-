using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using WinFormLibrary.Interfaces;
using WinFormLibrary.Models;

namespace WinForm
{
    public partial class PersonEntry : Form, ISaveAddressInfo
    {
        public BindingList<PersonModel> people = new BindingList<PersonModel>();
        public PersonModel person = new PersonModel();
        public PersonEntry()
        {
            InitializeComponent();
            WireUpLists();
        }
        private void WireUpLists()
        {
            listBoxPersonInfo.DataSource = people;
            listBoxPersonInfo.DisplayMember = "AddressInfo";
        }
        private void addPersonButton_Click(object sender, EventArgs e)
        {
            person = new PersonModel();
            person.FirstName = textBoxFirstName.Text;
            person.LastName = textBoxLastName.Text;

            people.Add(person);
        }

        private void addAddressesButton_Click(object sender, EventArgs e)
        {
            AddressEntry form = new AddressEntry(this);
            form.Show();
        }

        public void SaveAddressInfo(string streetAddress, string city)
        {
            person.StreetAddress = streetAddress;
            person.City = city;
            person.invokePropertyChanged();
        }
    }
}
