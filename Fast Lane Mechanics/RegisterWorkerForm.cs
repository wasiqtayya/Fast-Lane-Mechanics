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
namespace Fast_Lane_Mechanics
{
    public partial class RegisterWorkerForm : Form
    {

        clsConnection conn = new clsConnection();
        public RegisterWorkerForm()
        {
            InitializeComponent();
        }

        private void registerCutomerInfo_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(workerNameTextBox.Text))
            {

                MessageBox.Show("Enter Worker Name");
            }
            else
            {
                
                string message = "Success";
                string title = "";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    conn.dataSaveWorkerConnection(workerNameTextBox.Text);
                    WorkerAddForm form = new WorkerAddForm();
                    this.Hide();
                    form.Show();
                }
                else
                {
                    // Do something  
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            WorkerAddForm form = new WorkerAddForm();
            this.Hide();
            form.Show();
        }

        private void RegisterWorkerForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void blackLogo_Click(object sender, EventArgs e)
        {

        }

        private void workerNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
