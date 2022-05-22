using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_Lane_Mechanics
{
    public partial class MaintenanceForm : Form
    {
        public MaintenanceForm()
        {
            InitializeComponent();
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (oilChangeCheckBox.Checked == true || airFilterChangeCheckBox.Checked == true || oilChangeCheckBox.Checked == true || brakePadCheckBox.Checked == true || clutchPlateCheckBox.Checked == true || coolantFluidCheckBox.Checked == true || sparkPlugCheckBox.Checked == true || batteryChangeCheckBox.Checked == true || engineBeltCheckBox.Checked == true || windShieldCheckBox.Checked == true || shocksCheckBox.Checked == true || tyreRimsCheckBox.Checked == true || ringPistonCheckBox.Checked == true || parkingLightsCheckBox.Checked == true || radiatorCheckBox.Checked == true)
            {
                if (string.IsNullOrEmpty(oilChangePriceTextBox.Text))
                {
                    MessageBox.Show("Fill The Required Entity");
                    return;
                }

                if (string.IsNullOrEmpty(airFilterTextBox.Text))
                {
                    MessageBox.Show("Fill The Required Entity");
                    return;
                }

                if (string.IsNullOrEmpty(oilFilterTextBox.Text))
                {
                    MessageBox.Show("Fill The Required Entity");
                    return;
                }

                if (string.IsNullOrEmpty(brakePadTextBox.Text))
                {
                    MessageBox.Show("Fill The Required Entity");
                    return;
                }

                if (string.IsNullOrEmpty(clutchPlateTextBox.Text))
                {
                    MessageBox.Show("Fill The Required Entity");
                    return;
                }

                if (string.IsNullOrEmpty(coolantFluidTextBox.Text))
                {
                    MessageBox.Show("Fill The Required Entity");
                    return;
                }

                if (string.IsNullOrEmpty(sparkPlugsTextBox.Text))
                {
                    MessageBox.Show("Fill The Required Entity");
                    return;
                }

                if (string.IsNullOrEmpty(batteryChangeTextBox.Text))
                {
                    MessageBox.Show("Fill The Required Entity");
                    return;
                }

                if (string.IsNullOrEmpty(engineBeltTextBox.Text))
                {
                    MessageBox.Show("Fill The Required Entity");
                    return;
                }

                if (string.IsNullOrEmpty(windshieldWipersTextBox.Text))
                {
                    MessageBox.Show("Fill The Required Entity");
                    return;
                }

                if (string.IsNullOrEmpty(shocksTextBox.Text))
                {
                    MessageBox.Show("Fill The Required Entity");
                    return;
                }

                if (string.IsNullOrEmpty(tyreTextBox.Text))
                {
                    MessageBox.Show("Fill The Required Entity");
                    return;
                }

                if (string.IsNullOrEmpty(parkingLightsTextBox.Text))
                {
                    MessageBox.Show("Fill The Required Entity");
                    return;
                }

                if (string.IsNullOrEmpty(radiatorTextBox.Text))
                {
                    MessageBox.Show("Fill The Required Entity");
                    return;
                }

                if (string.IsNullOrEmpty(ringPistonTextBox.Text))
                {
                    MessageBox.Show("Fill The Required Entity");
                    return;
                }
                if (Program.index_number == 18)
                {
                    AnimationForm form = new AnimationForm();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    InvoiveAnimationForm form = new InvoiveAnimationForm();
                    form.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("You haven't selected anything");
                return;
            }
        }

        private void oilChangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (oilChangeCheckBox.Checked == true)
            {
                oilChangePriceTextBox.Enabled = true;
                oilChangePriceTextBox.Text = "";

            }
            else
            {
                oilChangePriceTextBox.Enabled = false;
                oilChangePriceTextBox.Text = "Price";

            }
        }

        private void oilChangePriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void maintenanceChargeForm_Load(object sender, EventArgs e)
        {

        }

        private void ringPistonTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radiatorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void parkingLightsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void windshieldWipersTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void shocksTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tyreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void engineBeltTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void batteryChangeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sparkPlugsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clutchPlateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void brakePadTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void coolantFluidTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void oilFilterTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void airFilterTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ringPistonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ringPistonCheckBox.Checked == true)
            {
                ringPistonTextBox.Enabled = true;
                ringPistonTextBox.Text = "";

            }
            else
            {
                ringPistonTextBox.Enabled = false;
                ringPistonTextBox.Text = "Price";

            }
        }

        private void radiatorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (radiatorCheckBox.Checked == true)
            {
                radiatorTextBox.Enabled = true;
                radiatorTextBox.Text = "";

            }
            else
            {
                radiatorTextBox.Enabled = false;
                radiatorTextBox.Text = "Price";

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //parkingLightsCheckBox
            if (parkingLightsCheckBox.Checked == true)
            {
                parkingLightsTextBox.Enabled = true;
                parkingLightsTextBox.Text = "";

            }
            else
            {
                parkingLightsTextBox.Enabled = false;
                parkingLightsTextBox.Text = "Price";

            }
        }

        private void tyreRimsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tyreRimsCheckBox.Checked == true)
            {
                tyreTextBox.Enabled = true;
                tyreTextBox.Text = "";

            }
            else
            {
                tyreTextBox.Enabled = false;
                tyreTextBox.Text = "Price";

            }
        }

        private void shocksCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (shocksCheckBox.Checked == true)
            {
                shocksTextBox.Enabled = true;
                shocksTextBox.Text = "";

            }
            else
            {
                shocksTextBox.Enabled = false;
                shocksTextBox.Text = "Price";

            }
        }

        private void windShieldCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (windShieldCheckBox.Checked == true)
            {
                windshieldWipersTextBox.Enabled = true;
                windshieldWipersTextBox.Text = "";

            }
            else
            {
                windshieldWipersTextBox.Enabled = false;
                windshieldWipersTextBox.Text = "Price";

            }
        }

        private void engineBeltCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (engineBeltCheckBox.Checked == true)
            {
                engineBeltTextBox.Enabled = true;
                engineBeltTextBox.Text = "";

            }
            else
            {
                engineBeltTextBox.Enabled = false;
                engineBeltTextBox.Text = "Price";

            }
        }

        private void batteryChangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (batteryChangeCheckBox.Checked == true)
            {
                batteryChangeTextBox.Enabled = true;
                batteryChangeTextBox.Text = "";

            }
            else
            {
                batteryChangeTextBox.Enabled = false;
                batteryChangeTextBox.Text = "Price";

            }
        }

        private void sparkPlugCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sparkPlugCheckBox.Checked == true)
            {
                sparkPlugsTextBox.Enabled = true;
                sparkPlugsTextBox.Text = "";

            }
            else
            {
                sparkPlugsTextBox.Enabled = false;
                sparkPlugsTextBox.Text = "Price";

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //coolantFluidCheckBox
            if (coolantFluidCheckBox.Checked == true)
            {
                coolantFluidTextBox.Enabled = true;
                coolantFluidTextBox.Text = "";

            }
            else
            {
                coolantFluidTextBox.Enabled = false;
                coolantFluidTextBox.Text = "Price";

            }
        }

        private void clutchPlateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (clutchPlateCheckBox.Checked == true)
            {
                clutchPlateTextBox.Enabled = true;
                clutchPlateTextBox.Text = "";

            }
            else
            {
                clutchPlateTextBox.Enabled = false;
                clutchPlateTextBox.Text = "Price";

            }
        }

        private void brakePadCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (brakePadCheckBox.Checked == true)
            {
                brakePadTextBox.Enabled = true;
                brakePadTextBox.Text = "";

            }
            else
            {
                brakePadTextBox.Enabled = false;
                brakePadTextBox.Text = "Price";

            }
        }

        private void oilFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (oilFilterCheckBox.Checked == true)
            {
                oilFilterTextBox.Enabled = true;
                oilFilterTextBox.Text = "";

            }
            else
            {
                oilFilterTextBox.Enabled = false;
                oilFilterTextBox.Text = "Price";

            }
        }

        private void airFilterChangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (airFilterChangeCheckBox.Checked == true)
            {
                airFilterTextBox.Enabled = true;
                airFilterTextBox.Text = "";

            }
            else
            {
                airFilterTextBox.Enabled = false;
                airFilterTextBox.Text = "Price";

            }
        }

        private void maintanancePicture_Click(object sender, EventArgs e)
        {

        }

        private void maintenanceLabel_Click(object sender, EventArgs e)
        {

        }

        private void backButtonPressed_Click(object sender, EventArgs e)
        {
            CarMaintenanceForm form = new CarMaintenanceForm();
            form.Show();
            this.Hide();
        }
    }
}