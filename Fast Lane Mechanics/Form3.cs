﻿using System;
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
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            InitializeComponent();
            carModelLabel.Hide();
            carModelListBox.Hide();
            selectTransmissionLabel.Hide();
            selectTransmissionBox.Hide();
            enginePowerLabel.Hide();
            enginePowerBox.Hide();
            registerCutomerInfo.Hide();

        }

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
            loginForm form = new loginForm();
            form.Show();
            this.Hide();
        }

        private void registerCutomerInfo_Click(object sender, EventArgs e)
        {
            
            if (customerNameTextBox.Text.Length == 0 && plateNumberTextBox.Text.Length == 0)
            {
                MessageBox.Show("Enter customer name and plate number");
            }else
            {
                MessageBox.Show("Success");
            }
        }
    }
}
