using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using WinFormLibrary.Models;

namespace WinForm
{
    public partial class PersonalInfoSaverForm : Form
    {
        public BindingList<PersonModel> people = new BindingList<PersonModel>();
        public PersonModel person;
        public PersonalInfoSaverForm()
        {
            InitializeComponent();

            WireUpLists();
        }
        private void WireUpLists()
        {
            listBoxPersonInfo.DataSource = people;
            listBoxPersonInfo.DisplayMember = "Info";
        }
        private void addPersonButton_Click(object sender, EventArgs e)
        {
            person = new PersonModel();
            person.FirstName = textBoxFirstName.Text;
            person.LastName = textBoxLastName.Text;
            person.Info = person.FirstName + " " + person.LastName + " ";

            people.Add(person);
        }

        private void addAddressesButton_Click(object sender, EventArgs e)
        {
            PersonAddressesForm form = new PersonAddressesForm();
            form.SendInformationBetweenForms(this);
            form.Show();
        }
    }
}
