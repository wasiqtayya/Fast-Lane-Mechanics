using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_Lane_Mechanics
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void blacklogo_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            if (usernameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Enter valid username");
                return;
            }else if (passwordTextBox.Text == string.Empty)
            {
                MessageBox.Show("Enter valid password");
                return;
            }
            else
            {
                string username = "admin";
                string password = "admin";

                if (usernameTextBox.Text == username && passwordTextBox.Text == password)
                {
                    AdminForm form = new AdminForm();
                    form.Show();
                    this.Hide();
                }else
                {
                    MessageBox.Show("Invalid Credential");
                }

               
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
