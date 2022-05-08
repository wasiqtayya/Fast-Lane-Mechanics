
namespace Fast_Lane_Mechanics
{
    partial class postLoginForm
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
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.maintenanceButton = new System.Windows.Forms.Button();
            this.modificationButton = new System.Windows.Forms.Button();
            this.bothButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Enabled = false;
            this.customerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextBox.HideSelection = false;
            this.customerNameTextBox.Location = new System.Drawing.Point(28, 63);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.ReadOnly = true;
            this.customerNameTextBox.Size = new System.Drawing.Size(295, 27);
            this.customerNameTextBox.TabIndex = 3;
            this.customerNameTextBox.Text = "Absham Ali";
            this.customerNameTextBox.TextChanged += new System.EventHandler(this.customerNameTextBox_TextChanged);
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerNameLabel.Location = new System.Drawing.Point(24, 34);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(144, 20);
            this.customerNameLabel.TabIndex = 2;
            this.customerNameLabel.Text = "Customer Name";
            this.customerNameLabel.Click += new System.EventHandler(this.customerNameLabel_Click);
            // 
            // maintenanceButton
            // 
            this.maintenanceButton.BackColor = System.Drawing.SystemColors.Window;
            this.maintenanceButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenanceButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.maintenanceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.maintenanceButton.Location = new System.Drawing.Point(87, 141);
            this.maintenanceButton.Name = "maintenanceButton";
            this.maintenanceButton.Size = new System.Drawing.Size(175, 42);
            this.maintenanceButton.TabIndex = 16;
            this.maintenanceButton.Text = "Maintenance";
            this.maintenanceButton.UseVisualStyleBackColor = false;
            this.maintenanceButton.Click += new System.EventHandler(this.maintenanceButton_Click);
            // 
            // modificationButton
            // 
            this.modificationButton.BackColor = System.Drawing.SystemColors.Window;
            this.modificationButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.modificationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modificationButton.Location = new System.Drawing.Point(28, 211);
            this.modificationButton.Name = "modificationButton";
            this.modificationButton.Size = new System.Drawing.Size(110, 42);
            this.modificationButton.TabIndex = 17;
            this.modificationButton.Text = "Modify";
            this.modificationButton.UseVisualStyleBackColor = false;
            this.modificationButton.Click += new System.EventHandler(this.modificationButton_Click);
            // 
            // bothButton
            // 
            this.bothButton.BackColor = System.Drawing.SystemColors.Window;
            this.bothButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bothButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bothButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bothButton.Location = new System.Drawing.Point(213, 211);
            this.bothButton.Name = "bothButton";
            this.bothButton.Size = new System.Drawing.Size(110, 42);
            this.bothButton.TabIndex = 18;
            this.bothButton.Text = "Both";
            this.bothButton.UseVisualStyleBackColor = false;
            this.bothButton.Click += new System.EventHandler(this.bothButton_Click);
            // 
            // postLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 305);
            this.Controls.Add(this.bothButton);
            this.Controls.Add(this.modificationButton);
            this.Controls.Add(this.maintenanceButton);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.customerNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "postLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Button maintenanceButton;
        private System.Windows.Forms.Button modificationButton;
        private System.Windows.Forms.Button bothButton;
    }
}