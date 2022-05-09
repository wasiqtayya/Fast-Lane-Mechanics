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
    public partial class userLoginForm : Form
    {
        public userLoginForm()
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
                MessageBox.Show("Success");
            }



            
        }
    }
}
