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
    public partial class InvoiveAnimationForm : Form
    {
        public InvoiveAnimationForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pleaseWaitLabel_Click(object sender, EventArgs e)
        {

        }

        private void loadingBar_Click(object sender, EventArgs e)
        {
           
        }

        private void InvoiveAnimationForm_Load(object sender, EventArgs e)
        {

        }

        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            loadingTimer.Enabled = true;
            loadingBar.Increment(2);
             if (loadingBar.Value == 100)
             {
               loadingTimer.Enabled = false;
               FinalInvoiceForm form = new FinalInvoiceForm();
                form.Show();
               this.Hide();
              
            }
        }
    }
}
