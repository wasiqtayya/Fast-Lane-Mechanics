using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using connection.data_access_layer;

namespace Fast_Lane_Mechanics
{
    public partial class RegisterUserForm : Form
    {
        clsConnection conn = new clsConnection();
        int car_id;
        public RegisterUserForm()
        {
            InitializeComponent();
            carModelLabel.Hide();
            carModelListBox.Hide();
            selectTransmissionLabel.Hide();
            selectTransmissionBox.Hide();
            enginePowerLabel.Hide();
            enginePowerBox.Hide();
            registerCutomerInfo.Hide();

           
            conn.textboxConnection("select id,brand_name from CarBrand", carManufacturerListBox, "brand_name", "id");
            conn.textboxConnection("select id,car_model from CarModel", carModelListBox, "car_model", "id");
            conn.comboboxConnection("select id,car_transmission from CarTransmission", selectTransmissionBox, "car_transmission", "id");
            conn.comboboxConnection("select id,car_power_engine from CarEnginePower", enginePowerBox, "car_power_engine", "id");
            
        }
       

        // SYSTEM MADE SELECTION

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carManufacturerListBox.CanSelect == true)
            {
                carModelLabel.Show();
                carModelListBox.Show();

            }
            else
            {
                carModelLabel.Hide();
                carModelListBox.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carModelListBox.CanSelect == true)
            {
                selectTransmissionLabel.Show();
                selectTransmissionBox.Show();

            }
            else
            {
                selectTransmissionLabel.Hide();
                selectTransmissionBox.Hide();
            }
        }

        private void selectTransmissionLabel_Click(object sender, EventArgs e)
        {

        }

        private void selectTransmissionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectTransmissionBox.CanSelect == true)
            {
                enginePowerLabel.Show();
                enginePowerBox.Show();

            }
            else
            {
                enginePowerLabel.Hide();
                enginePowerBox.Hide();
            }
        }

        private void enginePowerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (enginePowerBox.CanSelect == true)
            {
                registerCutomerInfo.Show();
               

            }
            else
            {
                registerCutomerInfo.Hide();
               
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            PlateNumberLoginForm form = new PlateNumberLoginForm();
            form.Show();
            this.Hide();
        }

        private void registerCutomerInfo_Click(object sender, EventArgs e)
        {
           if (string.IsNullOrEmpty(customerNameTextBox.Text))
            {
                MessageBox.Show("Enter Customer Name");
                return;
            } else if (string.IsNullOrEmpty(plateNumberTextBox.Text))
            {
                MessageBox.Show("Enter Plate Number");
                return;
            }else
            {



                conn.dataSaveCarConnection(carManufacturerListBox.GetItemText(carManufacturerListBox.SelectedValue), selectTransmissionBox.GetItemText(selectTransmissionBox.SelectedValue), enginePowerBox.GetItemText(enginePowerBox.SelectedValue), carModelListBox.GetItemText(carModelListBox.SelectedValue));
                //conn.dataSaveCustomerConnection(customerNameTextBox.Text);
                conn.retriveDataFromAccess("select id from Car", "id");
               

                string message = "Success";
                string title = "";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    PlateNumberLoginForm form = new PlateNumberLoginForm();
                    this.Hide();
                    form.Show();
                }
                else
                {
                    // Do something  
                }
                
            }
           
        }

        private void customerNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrationForm_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void plateNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void enginePowerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
