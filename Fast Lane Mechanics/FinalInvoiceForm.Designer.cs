
namespace Fast_Lane_Mechanics
{
    partial class FinalInvoiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalInvoiceForm));
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.startOverButton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(26, 191);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(153, 23);
            this.customerNameLabel.TabIndex = 17;
            this.customerNameLabel.Text = "Customer Name:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(185, 191);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(104, 22);
            this.nameLabel.TabIndex = 18;
            this.nameLabel.Text = "Absham Ali";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateLabel.Location = new System.Drawing.Point(915, 192);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(94, 22);
            this.currentDateLabel.TabIndex = 20;
            this.currentDateLabel.Text = "20-5-2022";
            this.currentDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.currentDateLabel.Click += new System.EventHandler(this.currentDateLabel_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(851, 191);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(58, 23);
            this.dateLabel.TabIndex = 19;
            this.dateLabel.Text = "Date:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(90, 235);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(121, 22);
            this.usernameLabel.TabIndex = 22;
            this.usernameLabel.Text = "Wasiq Tayyab";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(26, 234);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(57, 23);
            this.userLabel.TabIndex = 21;
            this.userLabel.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(996, 78);
            this.label2.TabIndex = 23;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // dataListBox
            // 
            this.dataListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataListBox.BackColor = System.Drawing.SystemColors.Window;
            this.dataListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListBox.FormattingEnabled = true;
            this.dataListBox.ItemHeight = 23;
            this.dataListBox.Items.AddRange(new object[] {
            "Absham",
            "Wasiq"});
            this.dataListBox.Location = new System.Drawing.Point(30, 382);
            this.dataListBox.Name = "dataListBox";
            this.dataListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.dataListBox.Size = new System.Drawing.Size(991, 69);
            this.dataListBox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(996, 78);
            this.label3.TabIndex = 25;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 642);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Total Payment:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(157, 643);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(95, 23);
            this.totalPriceLabel.TabIndex = 27;
            this.totalPriceLabel.Text = "PKR 1000";
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalPriceLabel.Click += new System.EventHandler(this.totalPriceLabel_Click);
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLabel.Location = new System.Drawing.Point(108, 676);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(58, 23);
            this.discountLabel.TabIndex = 29;
            this.discountLabel.Text = "0.0 %";
            this.discountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.discountLabel.Click += new System.EventHandler(this.discountLabel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 676);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Discount:";
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.SystemColors.Window;
            this.printButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.printButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.printButton.Location = new System.Drawing.Point(16, 731);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(95, 42);
            this.printButton.TabIndex = 30;
            this.printButton.Text = "PRINT";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // startOverButton
            // 
            this.startOverButton.AutoSize = true;
            this.startOverButton.BackColor = System.Drawing.SystemColors.Window;
            this.startOverButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startOverButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.startOverButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startOverButton.Location = new System.Drawing.Point(868, 731);
            this.startOverButton.Name = "startOverButton";
            this.startOverButton.Size = new System.Drawing.Size(153, 42);
            this.startOverButton.TabIndex = 32;
            this.startOverButton.Text = "START OVER";
            this.startOverButton.UseVisualStyleBackColor = false;
            this.startOverButton.Click += new System.EventHandler(this.startOverButton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(395, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // FinalInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1050, 807);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.startOverButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.currentDateLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.customerNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinalInvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinalInvoiceForm";
            this.Load += new System.EventHandler(this.FinalInvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label currentDateLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox dataListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button startOverButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}