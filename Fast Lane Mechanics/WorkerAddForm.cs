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
    public partial class WorkerAddForm : Form
    {
        clsConnection conn = new clsConnection();
        public WorkerAddForm()
        {
            InitializeComponent();
            conn.textboxConnection("select id,worker_name from Worker", workerList, "worker_name", "id");
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

        private void workerList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WorkerAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
