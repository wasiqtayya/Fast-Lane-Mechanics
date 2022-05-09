﻿
namespace Fast_Lane_Mechanics
{
    partial class loginPlateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginPlateForm));
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.registrationPlate = new System.Windows.Forms.TextBox();
            this.plateNumberLabel = new System.Windows.Forms.Label();
            this.enterPlateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // logoImage
            // 
            this.logoImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoImage.Image = ((System.Drawing.Image)(resources.GetObject("logoImage.Image")));
            this.logoImage.Location = new System.Drawing.Point(152, 54);
            this.logoImage.Margin = new System.Windows.Forms.Padding(4);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(133, 123);
            this.logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoImage.TabIndex = 0;
            this.logoImage.TabStop = false;
            this.logoImage.Click += new System.EventHandler(this.logoImage_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginLabel.Location = new System.Drawing.Point(101, 181);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(235, 36);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "GET STARTED";
            this.loginLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // registrationPlate
            // 
            this.registrationPlate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registrationPlate.BackColor = System.Drawing.SystemColors.Window;
            this.registrationPlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registrationPlate.Font = new System.Drawing.Font("Lucida Console", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationPlate.ForeColor = System.Drawing.SystemColors.Window;
            this.registrationPlate.Location = new System.Drawing.Point(85, 277);
            this.registrationPlate.Margin = new System.Windows.Forms.Padding(4);
            this.registrationPlate.Name = "registrationPlate";
            this.registrationPlate.Size = new System.Drawing.Size(277, 29);
            this.registrationPlate.TabIndex = 2;
            this.registrationPlate.TextChanged += new System.EventHandler(this.registrationPlate_TextChanged);
            // 
            // plateNumberLabel
            // 
            this.plateNumberLabel.AutoSize = true;
            this.plateNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plateNumberLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.plateNumberLabel.Location = new System.Drawing.Point(81, 250);
            this.plateNumberLabel.Name = "plateNumberLabel";
            this.plateNumberLabel.Size = new System.Drawing.Size(174, 20);
            this.plateNumberLabel.TabIndex = 7;
            this.plateNumberLabel.Text = "Enter Plate Number";
            this.plateNumberLabel.Click += new System.EventHandler(this.plateNumberLabel_Click);
            // 
            // enterPlateButton
            // 
            this.enterPlateButton.BackColor = System.Drawing.SystemColors.Window;
            this.enterPlateButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterPlateButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.enterPlateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enterPlateButton.Location = new System.Drawing.Point(146, 372);
            this.enterPlateButton.Name = "enterPlateButton";
            this.enterPlateButton.Size = new System.Drawing.Size(125, 42);
            this.enterPlateButton.TabIndex = 13;
            this.enterPlateButton.Text = "Enter";
            this.enterPlateButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.Window;
            this.exitButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitButton.Location = new System.Drawing.Point(282, 433);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 42);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(237, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 42);
            this.button2.TabIndex = 15;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // loginPlateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 522);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.enterPlateButton);
            this.Controls.Add(this.plateNumberLabel);
            this.Controls.Add(this.registrationPlate);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.logoImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "loginPlateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.loginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox registrationPlate;
        private System.Windows.Forms.Label plateNumberLabel;
        private System.Windows.Forms.Button enterPlateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button2;
    }
}