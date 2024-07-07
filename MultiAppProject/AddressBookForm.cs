using System;
using System.Windows.Forms;

namespace MultiAppProject
{
    public partial class AddressBookForm : Form
    {
        public AddressBookForm()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Name: {txtName.Text}\nEmail: {txtEmail.Text}\nPhone: {txtPhone.Text}");
        }
    }
}
