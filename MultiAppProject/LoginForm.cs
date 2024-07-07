using System;
using System.Windows.Forms;

namespace MultiAppProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Username: {txtUsername.Text}\nPassword: {txtPassword.Text}");
        }
    }
}
