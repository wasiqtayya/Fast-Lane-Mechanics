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
    public partial class PlateNumberLoginForm : Form
    {
        public PlateNumberLoginForm()
        {
            InitializeComponent();
        }

        private void logoImage_Click(object sender, EventArgs e)
        {

        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registrationPlate_TextChanged(object sender, EventArgs e)
        {

        }

        private void plateNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterUserForm forms = new RegisterUserForm();
            forms.Show();
            this.Hide();

        }

        private void enterPlateButton_Click(object sender, EventArgs e)
        {
            if (registrationPlate.Text == string.Empty)
            {
                MessageBox.Show("Enter Registration Plate Number");
                return;
            }
            else
            {
                CarMaintenanceForm form = new CarMaintenanceForm();
                form.Show();
                this.Hide();

            }
            
        }
    }
}
