using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using connection.data_access_layer;
using Fast_Lane_Mechanics;
namespace Fast_Lane_Mechanics
{
    public partial class AdminForm : Form
    {
        clsConnection conn = new clsConnection();
        public AdminForm()
        {
            InitializeComponent();
            conn.dataRetriveLoginConnection();
            usernameTextBox.Text = Program.username;
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
            AnimationForm form = new AnimationForm();
            form.Show();
            this.Hide();

        }

        private void workerListButton_Click(object sender, EventArgs e)
        {
            WorkerAddForm form = new WorkerAddForm();
            form.Show();
            this.Hide();

        }
    }
}
