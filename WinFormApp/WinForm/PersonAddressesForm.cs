using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormLibrary.Models;

namespace WinForm
{
    public partial class PersonAddressesForm : Form
    {
        PersonalInfoSaverForm form;
        public PersonAddressesForm()
        {
            InitializeComponent();

        }

        public void SendInformationBetweenForms(PersonalInfoSaverForm form)
        {
            this.form = form;
        }

        private void addAddressesButton_Click(object sender, EventArgs e)
        {
            form.person.StreetAddress = streetAddressesTextBox.Text;
            form.person.City = cityTextBox.Text;
            form.person.Info += form.person.StreetAddress + " " + form.person.City;
            Close();
        }
    }
}
