using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;


namespace Fast_Lane_Mechanics
{
    public partial class FinalInvoiceForm : Form
    {
        
        public FinalInvoiceForm()
        {
            InitializeComponent();
            string date = DateTime.UtcNow.ToString("dd-MM-yyyy");

            currentDateLabel.Text = date;
        }
       
       
        private void currentDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void printButton_Click(object sender, EventArgs e)
        {

            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = printDocument1;

            startOverButton.Visible = false;
            printButton.Visible = false;

            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
               
                printDocument1.Print();
                
            }
            else
            {
                
                printDocument1.Dispose();
            }
            startOverButton.Visible = true;
            printButton.Visible = true;


        }

        private void FinalInvoiceForm_Load(object sender, EventArgs e)
        {
           
        }
        

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            // Create Bitmap according form size
            Bitmap _bitmap = new Bitmap(Width, Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            // Draw from into Bitmap DC
            this.DrawToBitmap(_bitmap, this.DisplayRectangle);
            // Draw Bitmap into Printer DC
            e.Graphics.DrawImage(_bitmap, 0, 0);
            // No longer deeded - dispose it
            _bitmap.Dispose();
        }

        private void discountLabel_Click(object sender, EventArgs e)
        {

        }
       

        private void startOverButton_Click(object sender, EventArgs e)
        {
            AnimationForm3 form = new AnimationForm3();
            this.Hide();
            form.Show();
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalPriceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
