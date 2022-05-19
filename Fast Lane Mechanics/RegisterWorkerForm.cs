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
    public partial class RegisterWorkerForm : Form
    {
        public RegisterWorkerForm()
        {
            InitializeComponent();
        }

        private void registerCutomerInfo_Click(object sender, EventArgs e)
        {
            Console.WriteLine(workerIdTextBox.Text.Length);
            if (workerIdTextBox.Text.Length > 0 && workerNameTextBox.Text.Length > 0)
            {
             
                string message = "Success";
                string title = "";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    WorkerAddForm form = new WorkerAddForm();
                    this.Hide();
                    form.Show();
                }
                else
                {
                    // Do something  
                }
            }
            else
            {
                MessageBox.Show("Enter Worker ID and Name");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            WorkerAddForm form = new WorkerAddForm();
            this.Hide();
            form.Show();
        }

        private void workerIdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(workerIdTextBox.Text, "[^0-9]" ))
            {
                MessageBox.Show("Please enter only numbers.");
                workerIdTextBox.Text = workerIdTextBox.Text.Remove(workerIdTextBox.Text.Length - 1);
                return;
            }
            else
            if (workerIdTextBox.Text.Length > 3)
            {
                MessageBox.Show("Please enter only 3 numbers.");
                workerIdTextBox.Text = workerIdTextBox.Text.Remove(workerIdTextBox.Text.Length - 1);
                return;
            }else
            {

            }
        }

        private void RegisterWorkerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
