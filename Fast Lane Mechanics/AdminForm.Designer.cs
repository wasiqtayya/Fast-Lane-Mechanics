
namespace Fast_Lane_Mechanics
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.registrationPlate = new System.Windows.Forms.TextBox();
            this.workerListButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.getStartedButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usernameLabel.Location = new System.Drawing.Point(60, 217);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(94, 20);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.Click += new System.EventHandler(this.plateNumberLabel_Click);
            // 
            // registrationPlate
            // 
            this.registrationPlate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registrationPlate.BackColor = System.Drawing.SystemColors.Window;
            this.registrationPlate.Enabled = false;
            this.registrationPlate.Font = new System.Drawing.Font("Lucida Console", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationPlate.ForeColor = System.Drawing.SystemColors.Window;
            this.registrationPlate.Location = new System.Drawing.Point(64, 247);
            this.registrationPlate.Margin = new System.Windows.Forms.Padding(4);
            this.registrationPlate.Name = "registrationPlate";
            this.registrationPlate.Size = new System.Drawing.Size(352, 29);
            this.registrationPlate.TabIndex = 8;
            this.registrationPlate.TextChanged += new System.EventHandler(this.registrationPlate_TextChanged);
            // 
            // workerListButton
            // 
            this.workerListButton.BackColor = System.Drawing.SystemColors.Window;
            this.workerListButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerListButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.workerListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.workerListButton.Location = new System.Drawing.Point(64, 315);
            this.workerListButton.Name = "workerListButton";
            this.workerListButton.Size = new System.Drawing.Size(166, 42);
            this.workerListButton.TabIndex = 16;
            this.workerListButton.Text = "Worker List";
            this.workerListButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.Window;
            this.exitButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitButton.Location = new System.Drawing.Point(170, 403);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 42);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // getStartedButton
            // 
            this.getStartedButton.BackColor = System.Drawing.SystemColors.Window;
            this.getStartedButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getStartedButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.getStartedButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.getStartedButton.Location = new System.Drawing.Point(250, 315);
            this.getStartedButton.Name = "getStartedButton";
            this.getStartedButton.Size = new System.Drawing.Size(166, 42);
            this.getStartedButton.TabIndex = 18;
            this.getStartedButton.Text = "Get Started";
            this.getStartedButton.UseVisualStyleBackColor = false;
            this.getStartedButton.Click += new System.EventHandler(this.getStartedButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(175, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 494);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.getStartedButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.workerListButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.registrationPlate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox registrationPlate;
        private System.Windows.Forms.Button workerListButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button getStartedButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}