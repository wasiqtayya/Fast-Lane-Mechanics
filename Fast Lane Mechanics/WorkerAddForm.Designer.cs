
namespace Fast_Lane_Mechanics
{
    partial class WorkerAddForm
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
            this.workerListLabel = new System.Windows.Forms.Label();
            this.workerList = new System.Windows.Forms.ListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // workerListLabel
            // 
            this.workerListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workerListLabel.AutoSize = true;
            this.workerListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerListLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.workerListLabel.Location = new System.Drawing.Point(117, 29);
            this.workerListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.workerListLabel.Name = "workerListLabel";
            this.workerListLabel.Size = new System.Drawing.Size(178, 36);
            this.workerListLabel.TabIndex = 17;
            this.workerListLabel.Text = "Worker List";
            // 
            // workerList
            // 
            this.workerList.FormattingEnabled = true;
            this.workerList.ItemHeight = 16;
            this.workerList.Items.AddRange(new object[] {
            "10 Absham",
            "Wasiq"});
            this.workerList.Location = new System.Drawing.Point(22, 97);
            this.workerList.Name = "workerList";
            this.workerList.Size = new System.Drawing.Size(226, 180);
            this.workerList.TabIndex = 18;
            this.workerList.SelectedIndexChanged += new System.EventHandler(this.workerList_SelectedIndexChanged);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.SystemColors.Window;
            this.removeButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.removeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeButton.Location = new System.Drawing.Point(268, 165);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(115, 42);
            this.removeButton.TabIndex = 20;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Window;
            this.addButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.Location = new System.Drawing.Point(268, 97);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(115, 42);
            this.addButton.TabIndex = 19;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Window;
            this.backButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backButton.Location = new System.Drawing.Point(268, 235);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(115, 42);
            this.backButton.TabIndex = 21;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // WorkerAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 312);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.workerList);
            this.Controls.Add(this.workerListLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkerAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label workerListLabel;
        private System.Windows.Forms.ListBox workerList;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button backButton;
    }
}