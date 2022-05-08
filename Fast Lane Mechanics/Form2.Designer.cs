
namespace Fast_Lane_Mechanics
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.registrationPlate = new System.Windows.Forms.TextBox();
            this.registerPlateNumber = new System.Windows.Forms.Button();
            this.loginPlateNumber = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.addNewWorker = new System.Windows.Forms.Button();
            this.plateNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // logoImage
            // 
            this.logoImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoImage.Image = ((System.Drawing.Image)(resources.GetObject("logoImage.Image")));
            this.logoImage.Location = new System.Drawing.Point(152, 60);
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
            this.loginLabel.ForeColor = System.Drawing.Color.Orange;
            this.loginLabel.Location = new System.Drawing.Point(140, 187);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(153, 36);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "LOGIN IN";
            this.loginLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // registrationPlate
            // 
            this.registrationPlate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registrationPlate.BackColor = System.Drawing.Color.Orange;
            this.registrationPlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registrationPlate.Font = new System.Drawing.Font("Lucida Console", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationPlate.ForeColor = System.Drawing.SystemColors.Window;
            this.registrationPlate.Location = new System.Drawing.Point(85, 283);
            this.registrationPlate.Margin = new System.Windows.Forms.Padding(4);
            this.registrationPlate.Name = "registrationPlate";
            this.registrationPlate.Size = new System.Drawing.Size(277, 29);
            this.registrationPlate.TabIndex = 2;
            this.registrationPlate.TextChanged += new System.EventHandler(this.registrationPlate_TextChanged);
            // 
            // registerPlateNumber
            // 
            this.registerPlateNumber.BackColor = System.Drawing.Color.Orange;
            this.registerPlateNumber.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerPlateNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerPlateNumber.Location = new System.Drawing.Point(237, 325);
            this.registerPlateNumber.Name = "registerPlateNumber";
            this.registerPlateNumber.Size = new System.Drawing.Size(125, 31);
            this.registerPlateNumber.TabIndex = 3;
            this.registerPlateNumber.Text = "Register Now";
            this.registerPlateNumber.UseVisualStyleBackColor = false;
            this.registerPlateNumber.Click += new System.EventHandler(this.registerPlateNumber_Click);
            // 
            // loginPlateNumber
            // 
            this.loginPlateNumber.BackColor = System.Drawing.Color.Orange;
            this.loginPlateNumber.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPlateNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginPlateNumber.Location = new System.Drawing.Point(147, 381);
            this.loginPlateNumber.Name = "loginPlateNumber";
            this.loginPlateNumber.Size = new System.Drawing.Size(134, 42);
            this.loginPlateNumber.TabIndex = 4;
            this.loginPlateNumber.Text = "Login";
            this.loginPlateNumber.UseVisualStyleBackColor = false;
            this.loginPlateNumber.Click += new System.EventHandler(this.loginPlateNumber_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Orange;
            this.Exit.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(308, 432);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(54, 30);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // addNewWorker
            // 
            this.addNewWorker.BackColor = System.Drawing.Color.Orange;
            this.addNewWorker.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewWorker.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addNewWorker.Location = new System.Drawing.Point(85, 325);
            this.addNewWorker.Name = "addNewWorker";
            this.addNewWorker.Size = new System.Drawing.Size(125, 30);
            this.addNewWorker.TabIndex = 6;
            this.addNewWorker.Text = "Add Worker";
            this.addNewWorker.UseVisualStyleBackColor = false;
            this.addNewWorker.Click += new System.EventHandler(this.addNewWorker_Click);
            // 
            // plateNumberLabel
            // 
            this.plateNumberLabel.AutoSize = true;
            this.plateNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plateNumberLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.plateNumberLabel.Location = new System.Drawing.Point(81, 256);
            this.plateNumberLabel.Name = "plateNumberLabel";
            this.plateNumberLabel.Size = new System.Drawing.Size(174, 20);
            this.plateNumberLabel.TabIndex = 7;
            this.plateNumberLabel.Text = "Enter Plate Number";
            this.plateNumberLabel.Click += new System.EventHandler(this.plateNumberLabel_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 522);
            this.Controls.Add(this.plateNumberLabel);
            this.Controls.Add(this.addNewWorker);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.loginPlateNumber);
            this.Controls.Add(this.registerPlateNumber);
            this.Controls.Add(this.registrationPlate);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.logoImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "loginForm";
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
        private System.Windows.Forms.Button registerPlateNumber;
        private System.Windows.Forms.Button loginPlateNumber;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button addNewWorker;
        private System.Windows.Forms.Label plateNumberLabel;
    }
}