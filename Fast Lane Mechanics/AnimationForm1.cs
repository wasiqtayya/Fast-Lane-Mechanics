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
    public partial class AnimationForm1 : Form
    {
        public AnimationForm1()
        {
            InitializeComponent();
        }

        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            loadingTimer.Enabled = true;
            loadingBar.Increment(3);
          if (loadingBar.Value == 100)   
            {
              loadingTimer.Enabled = false;
              
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loadingBar_Click(object sender, EventArgs e)
        {

        }

        private void pleaseWaitLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
