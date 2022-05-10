
namespace Fast_Lane_Mechanics
{
    partial class MaintenanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceForm));
            this.maintenanceLabel = new System.Windows.Forms.Label();
            this.maintanancePicture = new System.Windows.Forms.PictureBox();
            this.oilChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.airFilterChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.oilFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.brakePadCheckBox = new System.Windows.Forms.CheckBox();
            this.clutchPlateCheckBox = new System.Windows.Forms.CheckBox();
            this.coolantFluidCheckBox = new System.Windows.Forms.CheckBox();
            this.sparkPlugCheckBox = new System.Windows.Forms.CheckBox();
            this.batteryChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.engineBeltCheckBox = new System.Windows.Forms.CheckBox();
            this.windShieldCheckBox = new System.Windows.Forms.CheckBox();
            this.shocksCheckBox = new System.Windows.Forms.CheckBox();
            this.tyreRimsCheckBox = new System.Windows.Forms.CheckBox();
            this.parkingLightsCheckBox = new System.Windows.Forms.CheckBox();
            this.radiatorCheckBox = new System.Windows.Forms.CheckBox();
            this.ringPistonCheckBox = new System.Windows.Forms.CheckBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButtonPressed = new System.Windows.Forms.Button();
            this.oilChangePriceTextBox = new System.Windows.Forms.TextBox();
            this.airFilterTextBox = new System.Windows.Forms.TextBox();
            this.oilFilterTextBox = new System.Windows.Forms.TextBox();
            this.coolantFluidTextBox = new System.Windows.Forms.TextBox();
            this.brakePadTextBox = new System.Windows.Forms.TextBox();
            this.clutchPlateTextBox = new System.Windows.Forms.TextBox();
            this.sparkPlugsTextBox = new System.Windows.Forms.TextBox();
            this.batteryChangeTextBox = new System.Windows.Forms.TextBox();
            this.engineBeltTextBox = new System.Windows.Forms.TextBox();
            this.tyreTextBox = new System.Windows.Forms.TextBox();
            this.shocksTextBox = new System.Windows.Forms.TextBox();
            this.windshieldWipersTextBox = new System.Windows.Forms.TextBox();
            this.parkingLightsTextBox = new System.Windows.Forms.TextBox();
            this.radiatorTextBox = new System.Windows.Forms.TextBox();
            this.ringPistonTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.maintanancePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // maintenanceLabel
            // 
            this.maintenanceLabel.AutoSize = true;
            this.maintenanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenanceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.maintenanceLabel.Location = new System.Drawing.Point(73, 24);
            this.maintenanceLabel.Name = "maintenanceLabel";
            this.maintenanceLabel.Size = new System.Drawing.Size(214, 38);
            this.maintenanceLabel.TabIndex = 5;
            this.maintenanceLabel.Text = "Maintenance";
            this.maintenanceLabel.Click += new System.EventHandler(this.maintenanceLabel_Click);
            // 
            // maintanancePicture
            // 
            this.maintanancePicture.Image = ((System.Drawing.Image)(resources.GetObject("maintanancePicture.Image")));
            this.maintanancePicture.InitialImage = null;
            this.maintanancePicture.Location = new System.Drawing.Point(27, 24);
            this.maintanancePicture.Name = "maintanancePicture";
            this.maintanancePicture.Size = new System.Drawing.Size(40, 40);
            this.maintanancePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maintanancePicture.TabIndex = 6;
            this.maintanancePicture.TabStop = false;
            this.maintanancePicture.Click += new System.EventHandler(this.maintanancePicture_Click);
            // 
            // oilChangeCheckBox
            // 
            this.oilChangeCheckBox.AutoSize = true;
            this.oilChangeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.oilChangeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oilChangeCheckBox.Location = new System.Drawing.Point(27, 98);
            this.oilChangeCheckBox.Name = "oilChangeCheckBox";
            this.oilChangeCheckBox.Size = new System.Drawing.Size(165, 30);
            this.oilChangeCheckBox.TabIndex = 7;
            this.oilChangeCheckBox.Text = "OIL CHANGE";
            this.oilChangeCheckBox.UseVisualStyleBackColor = true;
            this.oilChangeCheckBox.CheckedChanged += new System.EventHandler(this.oilChangeCheckBox_CheckedChanged);
            // 
            // airFilterChangeCheckBox
            // 
            this.airFilterChangeCheckBox.AutoSize = true;
            this.airFilterChangeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airFilterChangeCheckBox.Location = new System.Drawing.Point(325, 98);
            this.airFilterChangeCheckBox.Name = "airFilterChangeCheckBox";
            this.airFilterChangeCheckBox.Size = new System.Drawing.Size(138, 29);
            this.airFilterChangeCheckBox.TabIndex = 10;
            this.airFilterChangeCheckBox.Text = "AIR FILTER";
            this.airFilterChangeCheckBox.UseVisualStyleBackColor = true;
            this.airFilterChangeCheckBox.CheckedChanged += new System.EventHandler(this.airFilterChangeCheckBox_CheckedChanged);
            // 
            // oilFilterCheckBox
            // 
            this.oilFilterCheckBox.AutoSize = true;
            this.oilFilterCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oilFilterCheckBox.Location = new System.Drawing.Point(614, 98);
            this.oilFilterCheckBox.Name = "oilFilterCheckBox";
            this.oilFilterCheckBox.Size = new System.Drawing.Size(138, 29);
            this.oilFilterCheckBox.TabIndex = 13;
            this.oilFilterCheckBox.Text = "OIL FILTER";
            this.oilFilterCheckBox.UseVisualStyleBackColor = true;
            this.oilFilterCheckBox.CheckedChanged += new System.EventHandler(this.oilFilterCheckBox_CheckedChanged);
            // 
            // brakePadCheckBox
            // 
            this.brakePadCheckBox.AutoSize = true;
            this.brakePadCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brakePadCheckBox.Location = new System.Drawing.Point(27, 212);
            this.brakePadCheckBox.Name = "brakePadCheckBox";
            this.brakePadCheckBox.Size = new System.Drawing.Size(147, 29);
            this.brakePadCheckBox.TabIndex = 16;
            this.brakePadCheckBox.Text = "BRAKE PAD";
            this.brakePadCheckBox.UseVisualStyleBackColor = true;
            this.brakePadCheckBox.CheckedChanged += new System.EventHandler(this.brakePadCheckBox_CheckedChanged);
            // 
            // clutchPlateCheckBox
            // 
            this.clutchPlateCheckBox.AutoSize = true;
            this.clutchPlateCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clutchPlateCheckBox.Location = new System.Drawing.Point(325, 212);
            this.clutchPlateCheckBox.Name = "clutchPlateCheckBox";
            this.clutchPlateCheckBox.Size = new System.Drawing.Size(185, 29);
            this.clutchPlateCheckBox.TabIndex = 19;
            this.clutchPlateCheckBox.Text = "CLUTCH PLATE";
            this.clutchPlateCheckBox.UseVisualStyleBackColor = true;
            this.clutchPlateCheckBox.CheckedChanged += new System.EventHandler(this.clutchPlateCheckBox_CheckedChanged);
            // 
            // coolantFluidCheckBox
            // 
            this.coolantFluidCheckBox.AutoSize = true;
            this.coolantFluidCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coolantFluidCheckBox.Location = new System.Drawing.Point(614, 212);
            this.coolantFluidCheckBox.Name = "coolantFluidCheckBox";
            this.coolantFluidCheckBox.Size = new System.Drawing.Size(194, 29);
            this.coolantFluidCheckBox.TabIndex = 22;
            this.coolantFluidCheckBox.Text = "COOLANT FLUID";
            this.coolantFluidCheckBox.UseVisualStyleBackColor = true;
            this.coolantFluidCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // sparkPlugCheckBox
            // 
            this.sparkPlugCheckBox.AutoSize = true;
            this.sparkPlugCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sparkPlugCheckBox.Location = new System.Drawing.Point(27, 327);
            this.sparkPlugCheckBox.Name = "sparkPlugCheckBox";
            this.sparkPlugCheckBox.Size = new System.Drawing.Size(174, 29);
            this.sparkPlugCheckBox.TabIndex = 25;
            this.sparkPlugCheckBox.Text = "SPARK PLUGS";
            this.sparkPlugCheckBox.UseVisualStyleBackColor = true;
            this.sparkPlugCheckBox.CheckedChanged += new System.EventHandler(this.sparkPlugCheckBox_CheckedChanged);
            // 
            // batteryChangeCheckBox
            // 
            this.batteryChangeCheckBox.AutoSize = true;
            this.batteryChangeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryChangeCheckBox.Location = new System.Drawing.Point(325, 327);
            this.batteryChangeCheckBox.Name = "batteryChangeCheckBox";
            this.batteryChangeCheckBox.Size = new System.Drawing.Size(216, 29);
            this.batteryChangeCheckBox.TabIndex = 28;
            this.batteryChangeCheckBox.Text = "BATTERY CHANGE";
            this.batteryChangeCheckBox.UseVisualStyleBackColor = true;
            this.batteryChangeCheckBox.CheckedChanged += new System.EventHandler(this.batteryChangeCheckBox_CheckedChanged);
            // 
            // engineBeltCheckBox
            // 
            this.engineBeltCheckBox.AutoSize = true;
            this.engineBeltCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineBeltCheckBox.Location = new System.Drawing.Point(614, 327);
            this.engineBeltCheckBox.Name = "engineBeltCheckBox";
            this.engineBeltCheckBox.Size = new System.Drawing.Size(163, 29);
            this.engineBeltCheckBox.TabIndex = 31;
            this.engineBeltCheckBox.Text = "ENGINE BELT";
            this.engineBeltCheckBox.UseVisualStyleBackColor = true;
            this.engineBeltCheckBox.CheckedChanged += new System.EventHandler(this.engineBeltCheckBox_CheckedChanged);
            // 
            // windShieldCheckBox
            // 
            this.windShieldCheckBox.AutoSize = true;
            this.windShieldCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windShieldCheckBox.Location = new System.Drawing.Point(27, 431);
            this.windShieldCheckBox.Name = "windShieldCheckBox";
            this.windShieldCheckBox.Size = new System.Drawing.Size(241, 29);
            this.windShieldCheckBox.TabIndex = 34;
            this.windShieldCheckBox.Text = "WINDSHIELD WIPERS";
            this.windShieldCheckBox.UseVisualStyleBackColor = true;
            this.windShieldCheckBox.CheckedChanged += new System.EventHandler(this.windShieldCheckBox_CheckedChanged);
            // 
            // shocksCheckBox
            // 
            this.shocksCheckBox.AutoSize = true;
            this.shocksCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shocksCheckBox.Location = new System.Drawing.Point(325, 431);
            this.shocksCheckBox.Name = "shocksCheckBox";
            this.shocksCheckBox.Size = new System.Drawing.Size(121, 29);
            this.shocksCheckBox.TabIndex = 37;
            this.shocksCheckBox.Text = "SHOCKS";
            this.shocksCheckBox.UseVisualStyleBackColor = true;
            this.shocksCheckBox.CheckedChanged += new System.EventHandler(this.shocksCheckBox_CheckedChanged);
            // 
            // tyreRimsCheckBox
            // 
            this.tyreRimsCheckBox.AutoSize = true;
            this.tyreRimsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyreRimsCheckBox.Location = new System.Drawing.Point(614, 431);
            this.tyreRimsCheckBox.Name = "tyreRimsCheckBox";
            this.tyreRimsCheckBox.Size = new System.Drawing.Size(201, 29);
            this.tyreRimsCheckBox.TabIndex = 40;
            this.tyreRimsCheckBox.Text = "TYRES AND RIMS";
            this.tyreRimsCheckBox.UseVisualStyleBackColor = true;
            this.tyreRimsCheckBox.CheckedChanged += new System.EventHandler(this.tyreRimsCheckBox_CheckedChanged);
            // 
            // parkingLightsCheckBox
            // 
            this.parkingLightsCheckBox.AutoSize = true;
            this.parkingLightsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkingLightsCheckBox.Location = new System.Drawing.Point(27, 536);
            this.parkingLightsCheckBox.Name = "parkingLightsCheckBox";
            this.parkingLightsCheckBox.Size = new System.Drawing.Size(199, 29);
            this.parkingLightsCheckBox.TabIndex = 43;
            this.parkingLightsCheckBox.Text = "PARKING LIGHTS";
            this.parkingLightsCheckBox.UseVisualStyleBackColor = true;
            this.parkingLightsCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // radiatorCheckBox
            // 
            this.radiatorCheckBox.AutoSize = true;
            this.radiatorCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiatorCheckBox.Location = new System.Drawing.Point(325, 536);
            this.radiatorCheckBox.Name = "radiatorCheckBox";
            this.radiatorCheckBox.Size = new System.Drawing.Size(136, 29);
            this.radiatorCheckBox.TabIndex = 46;
            this.radiatorCheckBox.Text = "RADIATOR";
            this.radiatorCheckBox.UseVisualStyleBackColor = true;
            this.radiatorCheckBox.CheckedChanged += new System.EventHandler(this.radiatorCheckBox_CheckedChanged);
            // 
            // ringPistonCheckBox
            // 
            this.ringPistonCheckBox.AutoSize = true;
            this.ringPistonCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ringPistonCheckBox.Location = new System.Drawing.Point(614, 536);
            this.ringPistonCheckBox.Name = "ringPistonCheckBox";
            this.ringPistonCheckBox.Size = new System.Drawing.Size(175, 29);
            this.ringPistonCheckBox.TabIndex = 49;
            this.ringPistonCheckBox.Text = "RING PISTONS";
            this.ringPistonCheckBox.UseVisualStyleBackColor = true;
            this.ringPistonCheckBox.CheckedChanged += new System.EventHandler(this.ringPistonCheckBox_CheckedChanged);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.SystemColors.Window;
            this.nextButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.nextButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nextButton.Location = new System.Drawing.Point(683, 653);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(125, 42);
            this.nextButton.TabIndex = 52;
            this.nextButton.Text = "NEXT";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // backButtonPressed
            // 
            this.backButtonPressed.BackColor = System.Drawing.SystemColors.Window;
            this.backButtonPressed.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButtonPressed.ForeColor = System.Drawing.SystemColors.Desktop;
            this.backButtonPressed.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backButtonPressed.Location = new System.Drawing.Point(27, 653);
            this.backButtonPressed.Name = "backButtonPressed";
            this.backButtonPressed.Size = new System.Drawing.Size(125, 42);
            this.backButtonPressed.TabIndex = 53;
            this.backButtonPressed.Text = "BACK";
            this.backButtonPressed.UseVisualStyleBackColor = false;
            this.backButtonPressed.Click += new System.EventHandler(this.backButtonPressed_Click);
            // 
            // oilChangePriceTextBox
            // 
            this.oilChangePriceTextBox.Enabled = false;
            this.oilChangePriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oilChangePriceTextBox.Location = new System.Drawing.Point(27, 133);
            this.oilChangePriceTextBox.Name = "oilChangePriceTextBox";
            this.oilChangePriceTextBox.Size = new System.Drawing.Size(100, 27);
            this.oilChangePriceTextBox.TabIndex = 54;
            this.oilChangePriceTextBox.Text = "Price";
            this.oilChangePriceTextBox.TextChanged += new System.EventHandler(this.oilChangePriceTextBox_TextChanged);
            // 
            // airFilterTextBox
            // 
            this.airFilterTextBox.Enabled = false;
            this.airFilterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airFilterTextBox.Location = new System.Drawing.Point(325, 133);
            this.airFilterTextBox.Name = "airFilterTextBox";
            this.airFilterTextBox.Size = new System.Drawing.Size(100, 27);
            this.airFilterTextBox.TabIndex = 55;
            this.airFilterTextBox.Text = "Price";
            this.airFilterTextBox.TextChanged += new System.EventHandler(this.airFilterTextBox_TextChanged);
            // 
            // oilFilterTextBox
            // 
            this.oilFilterTextBox.Enabled = false;
            this.oilFilterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oilFilterTextBox.Location = new System.Drawing.Point(614, 133);
            this.oilFilterTextBox.Name = "oilFilterTextBox";
            this.oilFilterTextBox.Size = new System.Drawing.Size(100, 27);
            this.oilFilterTextBox.TabIndex = 56;
            this.oilFilterTextBox.Text = "Price";
            this.oilFilterTextBox.TextChanged += new System.EventHandler(this.oilFilterTextBox_TextChanged);
            // 
            // coolantFluidTextBox
            // 
            this.coolantFluidTextBox.Enabled = false;
            this.coolantFluidTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coolantFluidTextBox.Location = new System.Drawing.Point(614, 247);
            this.coolantFluidTextBox.Name = "coolantFluidTextBox";
            this.coolantFluidTextBox.Size = new System.Drawing.Size(100, 27);
            this.coolantFluidTextBox.TabIndex = 57;
            this.coolantFluidTextBox.Text = "Price";
            this.coolantFluidTextBox.TextChanged += new System.EventHandler(this.coolantFluidTextBox_TextChanged);
            // 
            // brakePadTextBox
            // 
            this.brakePadTextBox.Enabled = false;
            this.brakePadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brakePadTextBox.Location = new System.Drawing.Point(27, 247);
            this.brakePadTextBox.Name = "brakePadTextBox";
            this.brakePadTextBox.Size = new System.Drawing.Size(100, 27);
            this.brakePadTextBox.TabIndex = 58;
            this.brakePadTextBox.Text = "Price";
            this.brakePadTextBox.TextChanged += new System.EventHandler(this.brakePadTextBox_TextChanged);
            // 
            // clutchPlateTextBox
            // 
            this.clutchPlateTextBox.Enabled = false;
            this.clutchPlateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clutchPlateTextBox.Location = new System.Drawing.Point(325, 247);
            this.clutchPlateTextBox.Name = "clutchPlateTextBox";
            this.clutchPlateTextBox.Size = new System.Drawing.Size(100, 27);
            this.clutchPlateTextBox.TabIndex = 59;
            this.clutchPlateTextBox.Text = "Price";
            this.clutchPlateTextBox.TextChanged += new System.EventHandler(this.clutchPlateTextBox_TextChanged);
            // 
            // sparkPlugsTextBox
            // 
            this.sparkPlugsTextBox.Enabled = false;
            this.sparkPlugsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sparkPlugsTextBox.Location = new System.Drawing.Point(27, 362);
            this.sparkPlugsTextBox.Name = "sparkPlugsTextBox";
            this.sparkPlugsTextBox.Size = new System.Drawing.Size(100, 27);
            this.sparkPlugsTextBox.TabIndex = 60;
            this.sparkPlugsTextBox.Text = "Price";
            this.sparkPlugsTextBox.TextChanged += new System.EventHandler(this.sparkPlugsTextBox_TextChanged);
            // 
            // batteryChangeTextBox
            // 
            this.batteryChangeTextBox.Enabled = false;
            this.batteryChangeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryChangeTextBox.Location = new System.Drawing.Point(325, 362);
            this.batteryChangeTextBox.Name = "batteryChangeTextBox";
            this.batteryChangeTextBox.Size = new System.Drawing.Size(100, 27);
            this.batteryChangeTextBox.TabIndex = 61;
            this.batteryChangeTextBox.Text = "Price";
            this.batteryChangeTextBox.TextChanged += new System.EventHandler(this.batteryChangeTextBox_TextChanged);
            // 
            // engineBeltTextBox
            // 
            this.engineBeltTextBox.Enabled = false;
            this.engineBeltTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineBeltTextBox.Location = new System.Drawing.Point(614, 362);
            this.engineBeltTextBox.Name = "engineBeltTextBox";
            this.engineBeltTextBox.Size = new System.Drawing.Size(100, 27);
            this.engineBeltTextBox.TabIndex = 62;
            this.engineBeltTextBox.Text = "Price";
            this.engineBeltTextBox.TextChanged += new System.EventHandler(this.engineBeltTextBox_TextChanged);
            // 
            // tyreTextBox
            // 
            this.tyreTextBox.Enabled = false;
            this.tyreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyreTextBox.Location = new System.Drawing.Point(614, 466);
            this.tyreTextBox.Name = "tyreTextBox";
            this.tyreTextBox.Size = new System.Drawing.Size(100, 27);
            this.tyreTextBox.TabIndex = 63;
            this.tyreTextBox.Text = "Price";
            this.tyreTextBox.TextChanged += new System.EventHandler(this.tyreTextBox_TextChanged);
            // 
            // shocksTextBox
            // 
            this.shocksTextBox.Enabled = false;
            this.shocksTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shocksTextBox.Location = new System.Drawing.Point(325, 466);
            this.shocksTextBox.Name = "shocksTextBox";
            this.shocksTextBox.Size = new System.Drawing.Size(100, 27);
            this.shocksTextBox.TabIndex = 64;
            this.shocksTextBox.Text = "Price";
            this.shocksTextBox.TextChanged += new System.EventHandler(this.shocksTextBox_TextChanged);
            // 
            // windshieldWipersTextBox
            // 
            this.windshieldWipersTextBox.Enabled = false;
            this.windshieldWipersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windshieldWipersTextBox.Location = new System.Drawing.Point(27, 466);
            this.windshieldWipersTextBox.Name = "windshieldWipersTextBox";
            this.windshieldWipersTextBox.Size = new System.Drawing.Size(100, 27);
            this.windshieldWipersTextBox.TabIndex = 65;
            this.windshieldWipersTextBox.Text = "Price";
            this.windshieldWipersTextBox.TextChanged += new System.EventHandler(this.windshieldWipersTextBox_TextChanged);
            // 
            // parkingLightsTextBox
            // 
            this.parkingLightsTextBox.Enabled = false;
            this.parkingLightsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkingLightsTextBox.Location = new System.Drawing.Point(27, 571);
            this.parkingLightsTextBox.Name = "parkingLightsTextBox";
            this.parkingLightsTextBox.Size = new System.Drawing.Size(100, 27);
            this.parkingLightsTextBox.TabIndex = 66;
            this.parkingLightsTextBox.Text = "Price";
            this.parkingLightsTextBox.TextChanged += new System.EventHandler(this.parkingLightsTextBox_TextChanged);
            // 
            // radiatorTextBox
            // 
            this.radiatorTextBox.Enabled = false;
            this.radiatorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiatorTextBox.Location = new System.Drawing.Point(325, 571);
            this.radiatorTextBox.Name = "radiatorTextBox";
            this.radiatorTextBox.Size = new System.Drawing.Size(100, 27);
            this.radiatorTextBox.TabIndex = 67;
            this.radiatorTextBox.Text = "Price";
            this.radiatorTextBox.TextChanged += new System.EventHandler(this.radiatorTextBox_TextChanged);
            // 
            // ringPistonTextBox
            // 
            this.ringPistonTextBox.Enabled = false;
            this.ringPistonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ringPistonTextBox.Location = new System.Drawing.Point(614, 571);
            this.ringPistonTextBox.Name = "ringPistonTextBox";
            this.ringPistonTextBox.Size = new System.Drawing.Size(100, 27);
            this.ringPistonTextBox.TabIndex = 68;
            this.ringPistonTextBox.Text = "Price";
            this.ringPistonTextBox.TextChanged += new System.EventHandler(this.ringPistonTextBox_TextChanged);
            // 
            // MaintaenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 718);
            this.Controls.Add(this.ringPistonTextBox);
            this.Controls.Add(this.radiatorTextBox);
            this.Controls.Add(this.parkingLightsTextBox);
            this.Controls.Add(this.windshieldWipersTextBox);
            this.Controls.Add(this.shocksTextBox);
            this.Controls.Add(this.tyreTextBox);
            this.Controls.Add(this.engineBeltTextBox);
            this.Controls.Add(this.batteryChangeTextBox);
            this.Controls.Add(this.sparkPlugsTextBox);
            this.Controls.Add(this.clutchPlateTextBox);
            this.Controls.Add(this.brakePadTextBox);
            this.Controls.Add(this.coolantFluidTextBox);
            this.Controls.Add(this.oilFilterTextBox);
            this.Controls.Add(this.airFilterTextBox);
            this.Controls.Add(this.oilChangePriceTextBox);
            this.Controls.Add(this.backButtonPressed);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.ringPistonCheckBox);
            this.Controls.Add(this.radiatorCheckBox);
            this.Controls.Add(this.parkingLightsCheckBox);
            this.Controls.Add(this.tyreRimsCheckBox);
            this.Controls.Add(this.shocksCheckBox);
            this.Controls.Add(this.windShieldCheckBox);
            this.Controls.Add(this.engineBeltCheckBox);
            this.Controls.Add(this.batteryChangeCheckBox);
            this.Controls.Add(this.sparkPlugCheckBox);
            this.Controls.Add(this.coolantFluidCheckBox);
            this.Controls.Add(this.clutchPlateCheckBox);
            this.Controls.Add(this.brakePadCheckBox);
            this.Controls.Add(this.oilFilterCheckBox);
            this.Controls.Add(this.airFilterChangeCheckBox);
            this.Controls.Add(this.oilChangeCheckBox);
            this.Controls.Add(this.maintanancePicture);
            this.Controls.Add(this.maintenanceLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaintaenanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.maintenanceChargeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maintanancePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label maintenanceLabel;
        private System.Windows.Forms.PictureBox maintanancePicture;
        private System.Windows.Forms.CheckBox oilChangeCheckBox;
        private System.Windows.Forms.CheckBox airFilterChangeCheckBox;
        private System.Windows.Forms.CheckBox oilFilterCheckBox;
        private System.Windows.Forms.CheckBox brakePadCheckBox;
        private System.Windows.Forms.CheckBox clutchPlateCheckBox;
        private System.Windows.Forms.CheckBox coolantFluidCheckBox;
        private System.Windows.Forms.CheckBox sparkPlugCheckBox;
        private System.Windows.Forms.CheckBox batteryChangeCheckBox;
        private System.Windows.Forms.CheckBox engineBeltCheckBox;
        private System.Windows.Forms.CheckBox windShieldCheckBox;
        private System.Windows.Forms.CheckBox shocksCheckBox;
        private System.Windows.Forms.CheckBox tyreRimsCheckBox;
        private System.Windows.Forms.CheckBox parkingLightsCheckBox;
        private System.Windows.Forms.CheckBox radiatorCheckBox;
        private System.Windows.Forms.CheckBox ringPistonCheckBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButtonPressed;
        private System.Windows.Forms.TextBox oilChangePriceTextBox;
        private System.Windows.Forms.TextBox airFilterTextBox;
        private System.Windows.Forms.TextBox oilFilterTextBox;
        private System.Windows.Forms.TextBox coolantFluidTextBox;
        private System.Windows.Forms.TextBox brakePadTextBox;
        private System.Windows.Forms.TextBox clutchPlateTextBox;
        private System.Windows.Forms.TextBox sparkPlugsTextBox;
        private System.Windows.Forms.TextBox batteryChangeTextBox;
        private System.Windows.Forms.TextBox engineBeltTextBox;
        private System.Windows.Forms.TextBox tyreTextBox;
        private System.Windows.Forms.TextBox shocksTextBox;
        private System.Windows.Forms.TextBox windshieldWipersTextBox;
        private System.Windows.Forms.TextBox parkingLightsTextBox;
        private System.Windows.Forms.TextBox radiatorTextBox;
        private System.Windows.Forms.TextBox ringPistonTextBox;
    }
}