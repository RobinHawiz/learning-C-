using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormLibrary.Interfaces;
using WinFormLibrary.Models;

namespace WinForm
{
    public partial class AddressEntry : Form
    {
        ISaveAddressInfo _form;
        public AddressEntry(ISaveAddressInfo form)
        {
            InitializeComponent();
            _form = form;
        }

        private void addAddressesButton_Click(object sender, EventArgs e)
        {
            _form.SaveAddressInfo(streetAddressesTextBox.Text, cityTextBox.Text);
            Close();
        }
    }
}
