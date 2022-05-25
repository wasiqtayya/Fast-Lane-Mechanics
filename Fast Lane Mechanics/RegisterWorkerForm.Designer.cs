
namespace Fast_Lane_Mechanics
{
    partial class RegisterWorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterWorkerForm));
            this.workerNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.registerCutomerInfo = new System.Windows.Forms.Button();
            this.blackLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.blackLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // workerNameTextBox
            // 
            this.workerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerNameTextBox.Location = new System.Drawing.Point(34, 211);
            this.workerNameTextBox.Name = "workerNameTextBox";
            this.workerNameTextBox.Size = new System.Drawing.Size(295, 27);
            this.workerNameTextBox.TabIndex = 7;
            this.workerNameTextBox.TextChanged += new System.EventHandler(this.workerNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(30, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Worker Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Window;
            this.backButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backButton.Location = new System.Drawing.Point(34, 354);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 42);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // registerCutomerInfo
            // 
            this.registerCutomerInfo.BackColor = System.Drawing.SystemColors.Window;
            this.registerCutomerInfo.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerCutomerInfo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.registerCutomerInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registerCutomerInfo.Location = new System.Drawing.Point(204, 354);
            this.registerCutomerInfo.Name = "registerCutomerInfo";
            this.registerCutomerInfo.Size = new System.Drawing.Size(125, 42);
            this.registerCutomerInfo.TabIndex = 14;
            this.registerCutomerInfo.Text = "Register";
            this.registerCutomerInfo.UseVisualStyleBackColor = false;
            this.registerCutomerInfo.Click += new System.EventHandler(this.registerCutomerInfo_Click);
            // 
            // blackLogo
            // 
            this.blackLogo.Image = ((System.Drawing.Image)(resources.GetObject("blackLogo.Image")));
            this.blackLogo.Location = new System.Drawing.Point(120, 12);
            this.blackLogo.Name = "blackLogo";
            this.blackLogo.Size = new System.Drawing.Size(136, 113);
            this.blackLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blackLogo.TabIndex = 16;
            this.blackLogo.TabStop = false;
            this.blackLogo.Click += new System.EventHandler(this.blackLogo_Click);
            // 
            // RegisterWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 420);
            this.Controls.Add(this.blackLogo);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.registerCutomerInfo);
            this.Controls.Add(this.workerNameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterWorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RegisterWorkerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blackLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox workerNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button registerCutomerInfo;
        private System.Windows.Forms.PictureBox blackLogo;
    }
}