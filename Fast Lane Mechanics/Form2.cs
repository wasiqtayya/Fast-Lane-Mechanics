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
    public partial class loginPlateForm : Form
    {
        public loginPlateForm()
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

        private void registerPlateNumber_Click(object sender, EventArgs e)
        {
            registrationForm form = new registrationForm();
            form.Show();
            this.Hide();
        }

        private void loginPlateNumber_Click(object sender, EventArgs e)
        {
            if (registrationPlate.Text.Length != 0)
            {
                postLoginForm form = new postLoginForm();
                this.Hide();
                form.Show();
            } else
            {
                MessageBox.Show("Enter Plate Number");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewWorker_Click(object sender, EventArgs e)
        {
            addWorkerForm form = new addWorkerForm();
            this.Hide();
            form.Show();

        }

        private void plateNumberLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
