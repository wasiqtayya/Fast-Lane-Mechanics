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
  
    public partial class CarMaintenanceForm : Form
    {
        public CarMaintenanceForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void maintenanceButton_Click(object sender, EventArgs e)
        {
            Program.index_number = maintenanceButton.TabIndex;
            AnimationForm1 form = new AnimationForm1();
            form.Show();
            this.Hide();
        }

        private void customerNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void customerNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void modificationButton_Click(object sender, EventArgs e)
        {
            Program.index_number = modificationButton.TabIndex;
            AnimationForm form = new AnimationForm();
            form.Show();
            this.Hide();
        }

        private void bothButton_Click(object sender, EventArgs e)
        {
            Program.index_number = bothButton.TabIndex;
            AnimationForm1 form = new AnimationForm1();
            form.Show();
            this.Hide();
        }
    }
}
