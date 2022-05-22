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
    public partial class WorkerAddForm : Form
    {
        public WorkerAddForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            RegisterWorkerForm form = new RegisterWorkerForm();
            form.Show();
            this.Hide();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            workerList.Items.Remove(workerList.SelectedItem);
        }

        private void workerList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
