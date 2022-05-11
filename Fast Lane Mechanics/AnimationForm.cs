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
    public partial class AnimationForm : Form
    {
        public AnimationForm()
        {
            InitializeComponent();
        }

        private void pleaseWaitLabel_Click(object sender, EventArgs e)
        {

        }

        private void loadingBar_Click(object sender, EventArgs e)
        {

        }

        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            loadingTimer.Enabled = true;
            loadingBar.Increment(3);
            if (loadingBar.Value == 100)
            {
                loadingTimer.Enabled = false;
                PlateNumberLoginForm form = new PlateNumberLoginForm();
                form.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
