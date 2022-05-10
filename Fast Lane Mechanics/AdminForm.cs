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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void plateNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void registrationPlate_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void getStartedButton_Click(object sender, EventArgs e)
        {
            PlateNumberLoginForm form = new PlateNumberLoginForm();
            form.Show();
            this.Hide();

        }
    }
}
