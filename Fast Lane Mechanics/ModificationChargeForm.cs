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
    public partial class ModificationChargeForm : Form
    {
        public ModificationChargeForm()
        {
            InitializeComponent();
        }

        private void clutchPlateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (neonLightsCheckBox.Checked == true)
            {
                neonlightsPriceTextBox.Enabled = true;
                neonlightsPriceTextBox.Text = "";

            }
            else
            {
                neonlightsPriceTextBox.Enabled = false;
                neonlightsPriceTextBox.Text = "Price";

            }
        }

        private void sparkPlugCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (catalyticConverterCheckBox.Checked == true)
            {
                catalyticconverterPriceTextBox.Enabled = true;
                catalyticconverterPriceTextBox.Text = "";

            }
            else
            {
                catalyticconverterPriceTextBox.Enabled = false;
                catalyticconverterPriceTextBox.Text = "Price";

            }
        }

        private void tyreRimsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tyreRimsCheckBox.Checked == true)
            {
               tyrePriceTextBox.Enabled = true;
                tyrePriceTextBox.Text = "";

            }
            else
            {
                tyrePriceTextBox.Enabled = false;
                tyrePriceTextBox.Text = "Price";

            }
        }

        private void spoilerPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void torquesensorPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fuelinjectorPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void crankshaftPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tyrePriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tailpipesPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exhaustsystemPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void catalyticconverterPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void neonlightsPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void paintjobsPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void windowtintPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sportseatsPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void turbochargersPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void suspensionPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backButtonPressed_Click(object sender, EventArgs e)
        {
            if (Program.index_number == 18)
            {
                MaintenanceForm form = new MaintenanceForm();
                form.Show();
                this.Hide();
            }
            else
            {
                CarMaintenanceForm form = new CarMaintenanceForm();
                form.Show();
                this.Hide();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (Program.index_number == 18)
            {
                InvoiveAnimationForm form = new InvoiveAnimationForm();
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

        private void roofRailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (roofRailCheckBox.Checked == true)
            {
                roofrilPriceTextBox.Enabled = true;
                roofrilPriceTextBox.Text = "";

            }
            else
            {
                roofrilPriceTextBox.Enabled = false;
                roofrilPriceTextBox.Text = "Price";

            }
        }

        private void spoilerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (spoilerCheckBox.Checked == true)
            {
                spoilerPriceTextBox.Enabled = true;
                spoilerPriceTextBox.Text = "";

            }
            else
            {
                spoilerPriceTextBox.Enabled = false;
                spoilerPriceTextBox.Text = "Price";

            }
        }

        private void torqueSensorsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (torqueSensorsCheckBox.Checked == true)
            {
                torquesensorPriceTextBox.Enabled = true;
                torquesensorPriceTextBox.Text = "";

            }
            else
            {
                torquesensorPriceTextBox.Enabled = false;
                torquesensorPriceTextBox.Text = "Price";

            }
        }

        private void roofrilPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void crankShaftsCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (crankShaftsCheckBox.Checked == true)
            {
                crankshaftPriceTextBox.Enabled = true;
                crankshaftPriceTextBox.Text = "";

            }
            else
            {
                crankshaftPriceTextBox.Enabled = false;
                crankshaftPriceTextBox.Text = "Price";

            }
        }

        private void fuelInjectorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fuelInjectorCheckBox.Checked == true)
            {
                fuelinjectorPriceTextBox.Enabled = true;
                fuelinjectorPriceTextBox.Text = "";

            }
            else
            {
                fuelinjectorPriceTextBox.Enabled = false;
                fuelinjectorPriceTextBox.Text = "Price";

            }
        }

        private void tailPipesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tailPipesCheckBox.Checked == true)
            {
                tailpipesPriceTextBox.Enabled = true;
                tailpipesPriceTextBox.Text = "";

            }
            else
            {
                tailpipesPriceTextBox.Enabled = false;
                tailpipesPriceTextBox.Text = "Price";

            }
        }

        private void exhaustSystemCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (exhaustSystemCheckBox.Checked == true)
            {
                exhaustsystemPriceTextBox.Enabled = true;
                exhaustsystemPriceTextBox.Text = "";

            }
            else
            {
                exhaustsystemPriceTextBox.Enabled = false;
                exhaustsystemPriceTextBox.Text = "Price";

            }
        }

        private void windowTintCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (windowTintCheckBox.Checked == true)
            {
                windowtintPriceTextBox.Enabled = true;
                windowtintPriceTextBox.Text = "";

            }
            else
            {
                windowtintPriceTextBox.Enabled = false;
                windowtintPriceTextBox.Text = "Price";

            }
        }

        private void paintJobsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (paintJobsCheckBox.Checked == true)
            {
                paintjobsPriceTextBox.Enabled = true;
                paintjobsPriceTextBox.Text = "";

            }
            else
            {
                paintjobsPriceTextBox.Enabled = false;
                paintjobsPriceTextBox.Text = "Price";

            }
        }

        private void sportSeatsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sportSeatsCheckBox.Checked == true)
            {
                  sportseatsPriceTextBox.Enabled = true;
                sportseatsPriceTextBox.Text = "";

            }
            else
            {
                sportseatsPriceTextBox.Enabled = false;
                sportseatsPriceTextBox.Text = "Price";

            }
        }

        private void turboChargeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (turboChargeCheckBox.Checked == true)
            {
                turbochargersPriceTextBox.Enabled = true;
                turbochargersPriceTextBox.Text = "";

            }
            else
            {
                turbochargersPriceTextBox.Enabled = false;
                turbochargersPriceTextBox.Text = "Price";

            }
        }

        private void suspensionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (suspensionCheckBox.Checked == true)
            {
                suspensionPriceTextBox.Enabled = true;
                suspensionPriceTextBox.Text = "";

            }
            else
            {
                suspensionPriceTextBox.Enabled = false;
                suspensionPriceTextBox.Text = "Price";

            }
        }

        private void maintanancePicture_Click(object sender, EventArgs e)
        {

        }

        private void modificationLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
