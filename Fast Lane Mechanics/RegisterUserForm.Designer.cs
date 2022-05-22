
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
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plateNumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(37, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select car Manufacturer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // carModelLabel
            // 
            this.carModelLabel.AutoSize = true;
            this.carModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carModelLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.carModelLabel.Location = new System.Drawing.Point(328, 199);
            this.carModelLabel.Name = "carModelLabel";
            this.carModelLabel.Size = new System.Drawing.Size(154, 20);
            this.carModelLabel.TabIndex = 5;
            this.carModelLabel.Text = "Select Car Model";
            this.carModelLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // carManufacturerListBox
            // 
            this.carManufacturerListBox.FormattingEnabled = true;
            this.carManufacturerListBox.ItemHeight = 16;
            this.carManufacturerListBox.Location = new System.Drawing.Point(41, 240);
            this.carManufacturerListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carManufacturerListBox.Name = "carManufacturerListBox";
            this.carManufacturerListBox.Size = new System.Drawing.Size(208, 164);
            this.carManufacturerListBox.TabIndex = 6;
            this.carManufacturerListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // carModelListBox
            // 
            this.carModelListBox.FormattingEnabled = true;
            this.carModelListBox.ItemHeight = 16;
            this.carModelListBox.Location = new System.Drawing.Point(332, 240);
            this.carModelListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carModelListBox.Name = "carModelListBox";
            this.carModelListBox.Size = new System.Drawing.Size(208, 164);
            this.carModelListBox.TabIndex = 7;
            this.carModelListBox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // selectTransmissionLabel
            // 
            this.selectTransmissionLabel.AutoSize = true;
            this.selectTransmissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTransmissionLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectTransmissionLabel.Location = new System.Drawing.Point(37, 432);
            this.selectTransmissionLabel.Name = "selectTransmissionLabel";
            this.selectTransmissionLabel.Size = new System.Drawing.Size(181, 20);
            this.selectTransmissionLabel.TabIndex = 8;
            this.selectTransmissionLabel.Text = "Select Transmission";
            this.selectTransmissionLabel.Click += new System.EventHandler(this.selectTransmissionLabel_Click);
            // 
            // selectTransmissionBox
            // 
            this.selectTransmissionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectTransmissionBox.FormattingEnabled = true;
            this.selectTransmissionBox.Location = new System.Drawing.Point(41, 468);
            this.selectTransmissionBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectTransmissionBox.Name = "selectTransmissionBox";
            this.selectTransmissionBox.Size = new System.Drawing.Size(208, 24);
            this.selectTransmissionBox.TabIndex = 9;
            this.selectTransmissionBox.SelectedIndexChanged += new System.EventHandler(this.selectTransmissionBox_SelectedIndexChanged);
            // 
            // enginePowerLabel
            // 
            this.enginePowerLabel.AutoSize = true;
            this.enginePowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enginePowerLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enginePowerLabel.Location = new System.Drawing.Point(328, 432);
            this.enginePowerLabel.Name = "enginePowerLabel";
            this.enginePowerLabel.Size = new System.Drawing.Size(219, 20);
            this.enginePowerLabel.TabIndex = 10;
            this.enginePowerLabel.Text = "Select Car Engine Power";
            this.enginePowerLabel.Click += new System.EventHandler(this.enginePowerLabel_Click);
            // 
            // enginePowerBox
            // 
            this.enginePowerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enginePowerBox.FormattingEnabled = true;
            this.enginePowerBox.Location = new System.Drawing.Point(332, 468);
            this.enginePowerBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enginePowerBox.Name = "enginePowerBox";
            this.enginePowerBox.Size = new System.Drawing.Size(208, 24);
            this.enginePowerBox.TabIndex = 11;
            this.enginePowerBox.SelectedIndexChanged += new System.EventHandler(this.enginePowerBox_SelectedIndexChanged);
            // 
            // registerCutomerInfo
            // 
            this.registerCutomerInfo.BackColor = System.Drawing.SystemColors.Window;
            this.registerCutomerInfo.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerCutomerInfo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.registerCutomerInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registerCutomerInfo.Location = new System.Drawing.Point(415, 543);
            this.registerCutomerInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerCutomerInfo.Name = "registerCutomerInfo";
            this.registerCutomerInfo.Size = new System.Drawing.Size(125, 42);
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
            this.backButton.Location = new System.Drawing.Point(41, 543);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 42);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerNameLabel.Location = new System.Drawing.Point(37, 49);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(144, 20);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Customer Name";
            this.customerNameLabel.Click += new System.EventHandler(this.customerNameLabel_Click);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextBox.Location = new System.Drawing.Point(41, 71);
            this.customerNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(295, 27);
            this.customerNameTextBox.TabIndex = 1;
            this.customerNameTextBox.TextChanged += new System.EventHandler(this.customerNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(37, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Plate Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // plateNumberTextBox
            // 
            this.plateNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plateNumberTextBox.Location = new System.Drawing.Point(41, 140);
            this.plateNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plateNumberTextBox.Name = "plateNumberTextBox";
            this.plateNumberTextBox.Size = new System.Drawing.Size(295, 27);
            this.plateNumberTextBox.TabIndex = 3;
            this.plateNumberTextBox.TextChanged += new System.EventHandler(this.plateNumberTextBox_TextChanged);
            // 
            // RegisterUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 629);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.registrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox plateNumberTextBox;
    }
}