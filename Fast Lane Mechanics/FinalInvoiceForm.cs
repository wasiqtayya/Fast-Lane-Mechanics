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
        }
       
       
        private void currentDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void printButton_Click(object sender, EventArgs e)
        {

            // Create document
            PrintDocument _document = new PrintDocument();
            // Add print handler
            _document.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage_1);
            // Create the dialog to display results
            PrintPreviewDialog _dlg = new PrintPreviewDialog();
            _dlg.ClientSize = new System.Drawing.Size(Width / 2, Height / 2);
            _dlg.Location = new System.Drawing.Point(Left, Top);
            _dlg.MinimumSize = new System.Drawing.Size(375, 250);
            _dlg.UseAntiAlias = true;
            // Setting up our document
            _dlg.Document = _document;
            
            pdfButton.Visible = false;
            startOverButton.Visible = false;
            printButton.Visible = false;


            if (_dlg.ShowDialog() == DialogResult.OK)
            {
                _document.Print();
            }
            else
            {
                pdfButton.Visible = true;
                startOverButton.Visible = true;
                printButton.Visible = true;
     
            }
         
            _document.Dispose();

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
