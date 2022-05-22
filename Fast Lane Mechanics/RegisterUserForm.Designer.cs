
namespace Fast_Lane_Mechanics
{
    partial class RegisterUserForm
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
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plateNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.carModelLabel = new System.Windows.Forms.Label();
            this.carManufacturerListBox = new System.Windows.Forms.ListBox();
            this.carModelListBox = new System.Windows.Forms.ListBox();
            this.selectTransmissionLabel = new System.Windows.Forms.Label();
            this.selectTransmissionBox = new System.Windows.Forms.ComboBox();
            this.enginePowerLabel = new System.Windows.Forms.Label();
            this.enginePowerBox = new System.Windows.Forms.ComboBox();
            this.registerCutomerInfo = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerNameLabel.Location = new System.Drawing.Point(28, 40);
            this.customerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(122, 17);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Customer Name";
            this.customerNameLabel.Click += new System.EventHandler(this.customerNameLabel_Click);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextBox.Location = new System.Drawing.Point(31, 58);
            this.customerNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(222, 23);
            this.customerNameTextBox.TabIndex = 1;
            this.customerNameTextBox.TextChanged += new System.EventHandler(this.customerNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(28, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Plate Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // plateNumberTextBox
            // 
            this.plateNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plateNumberTextBox.Location = new System.Drawing.Point(31, 114);
            this.plateNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.plateNumberTextBox.Name = "plateNumberTextBox";
            this.plateNumberTextBox.Size = new System.Drawing.Size(222, 23);
            this.plateNumberTextBox.TabIndex = 3;
            this.plateNumberTextBox.TextChanged += new System.EventHandler(this.plateNumberTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(28, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select car Manufacturer";
            // 
            // carModelLabel
            // 
            this.carModelLabel.AutoSize = true;
            this.carModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carModelLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.carModelLabel.Location = new System.Drawing.Point(246, 162);
            this.carModelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.carModelLabel.Name = "carModelLabel";
            this.carModelLabel.Size = new System.Drawing.Size(131, 17);
            this.carModelLabel.TabIndex = 5;
            this.carModelLabel.Text = "Select Car Model";
            this.carModelLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // carManufacturerListBox
            // 
            this.carManufacturerListBox.FormattingEnabled = true;
            this.carManufacturerListBox.Items.AddRange(new object[] {
            "Honda",
            "Suzuki",
            "Toyota",
            "Nissan",
            "Mitsubishi",
            "Changan",
            "Proton",
            "Faw",
            "Hyundai",
            "Prince",
            "Audi",
            "BMW",
            "MG",
            "Glory"});
            this.carManufacturerListBox.Location = new System.Drawing.Point(31, 195);
            this.carManufacturerListBox.Margin = new System.Windows.Forms.Padding(2);
            this.carManufacturerListBox.Name = "carManufacturerListBox";
            this.carManufacturerListBox.Size = new System.Drawing.Size(157, 134);
            this.carManufacturerListBox.TabIndex = 6;
            this.carManufacturerListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // carModelListBox
            // 
            this.carModelListBox.FormattingEnabled = true;
            this.carModelListBox.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990"});
            this.carModelListBox.Location = new System.Drawing.Point(249, 195);
            this.carModelListBox.Margin = new System.Windows.Forms.Padding(2);
            this.carModelListBox.Name = "carModelListBox";
            this.carModelListBox.Size = new System.Drawing.Size(157, 134);
            this.carModelListBox.TabIndex = 7;
            this.carModelListBox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // selectTransmissionLabel
            // 
            this.selectTransmissionLabel.AutoSize = true;
            this.selectTransmissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTransmissionLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectTransmissionLabel.Location = new System.Drawing.Point(28, 351);
            this.selectTransmissionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectTransmissionLabel.Name = "selectTransmissionLabel";
            this.selectTransmissionLabel.Size = new System.Drawing.Size(154, 17);
            this.selectTransmissionLabel.TabIndex = 8;
            this.selectTransmissionLabel.Text = "Select Transmission";
            this.selectTransmissionLabel.Click += new System.EventHandler(this.selectTransmissionLabel_Click);
            // 
            // selectTransmissionBox
            // 
            this.selectTransmissionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectTransmissionBox.FormattingEnabled = true;
            this.selectTransmissionBox.Items.AddRange(new object[] {
            "Automatic",
            "Manual"});
            this.selectTransmissionBox.Location = new System.Drawing.Point(31, 380);
            this.selectTransmissionBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectTransmissionBox.Name = "selectTransmissionBox";
            this.selectTransmissionBox.Size = new System.Drawing.Size(157, 21);
            this.selectTransmissionBox.TabIndex = 9;
            this.selectTransmissionBox.SelectedIndexChanged += new System.EventHandler(this.selectTransmissionBox_SelectedIndexChanged);
            // 
            // enginePowerLabel
            // 
            this.enginePowerLabel.AutoSize = true;
            this.enginePowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enginePowerLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enginePowerLabel.Location = new System.Drawing.Point(246, 351);
            this.enginePowerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enginePowerLabel.Name = "enginePowerLabel";
            this.enginePowerLabel.Size = new System.Drawing.Size(187, 17);
            this.enginePowerLabel.TabIndex = 10;
            this.enginePowerLabel.Text = "Select Car Engine Power";
            // 
            // enginePowerBox
            // 
            this.enginePowerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enginePowerBox.FormattingEnabled = true;
            this.enginePowerBox.Items.AddRange(new object[] {
            "660 cc",
            "796 cc",
            "1000 cc",
            "1200 cc",
            "1300 cc",
            "1500 cc",
            "1800 cc",
            "2000 cc",
            "upto 2000 cc"});
            this.enginePowerBox.Location = new System.Drawing.Point(249, 380);
            this.enginePowerBox.Margin = new System.Windows.Forms.Padding(2);
            this.enginePowerBox.Name = "enginePowerBox";
            this.enginePowerBox.Size = new System.Drawing.Size(157, 21);
            this.enginePowerBox.TabIndex = 11;
            this.enginePowerBox.SelectedIndexChanged += new System.EventHandler(this.enginePowerBox_SelectedIndexChanged);
            // 
            // registerCutomerInfo
            // 
            this.registerCutomerInfo.BackColor = System.Drawing.SystemColors.Window;
            this.registerCutomerInfo.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerCutomerInfo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.registerCutomerInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registerCutomerInfo.Location = new System.Drawing.Point(311, 441);
            this.registerCutomerInfo.Margin = new System.Windows.Forms.Padding(2);
            this.registerCutomerInfo.Name = "registerCutomerInfo";
            this.registerCutomerInfo.Size = new System.Drawing.Size(94, 34);
            this.registerCutomerInfo.TabIndex = 12;
            this.registerCutomerInfo.Text = "Register";
            this.registerCutomerInfo.UseVisualStyleBackColor = false;
            this.registerCutomerInfo.Click += new System.EventHandler(this.registerCutomerInfo_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Window;
            this.backButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backButton.Location = new System.Drawing.Point(31, 441);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 34);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // RegisterUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 511);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.registerCutomerInfo);
            this.Controls.Add(this.enginePowerBox);
            this.Controls.Add(this.enginePowerLabel);
            this.Controls.Add(this.selectTransmissionBox);
            this.Controls.Add(this.selectTransmissionLabel);
            this.Controls.Add(this.carModelListBox);
            this.Controls.Add(this.carManufacturerListBox);
            this.Controls.Add(this.carModelLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plateNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.customerNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegisterUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.registrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox plateNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label carModelLabel;
        private System.Windows.Forms.ListBox carManufacturerListBox;
        private System.Windows.Forms.ListBox carModelListBox;
        private System.Windows.Forms.Label selectTransmissionLabel;
        private System.Windows.Forms.ComboBox selectTransmissionBox;
        private System.Windows.Forms.Label enginePowerLabel;
        private System.Windows.Forms.ComboBox enginePowerBox;
        private System.Windows.Forms.Button registerCutomerInfo;
        private System.Windows.Forms.Button backButton;
    }
}