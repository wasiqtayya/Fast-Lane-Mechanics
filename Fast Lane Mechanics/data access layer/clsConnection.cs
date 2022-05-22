using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace connection.data_access_layer
{
    internal class clsConnection
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\wasiq\Documents\FastLaneMechanics.accdb;Persist Security Info=False";
        string car_id;
        internal void textboxConnection(string command, ListBox items, string db_attribute, string db_attribute1)
        {

            OleDbConnection conn = new OleDbConnection(connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = command;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            items.DataSource = dt;

            items.DisplayMember = db_attribute;
            items.ValueMember = db_attribute1;
           
            items.ClearSelected();

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        internal void comboboxConnection(string command, ComboBox comboBox, string db_attribute, string db_attribute1)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = command;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt, db_attribute);
            comboBox.DataSource = dt.Tables[db_attribute];

            comboBox.DisplayMember = db_attribute;
            comboBox.ValueMember = db_attribute1;
            comboBox.SelectedItem = null;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        internal void dataSaveCarConnection(string brand,string transmission,string engine_id,string car_model)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Car (brand_id, car_transmission_id,car_engine_id,car_model_id) values(?,?,?,?)";
            cmd.Parameters.AddWithValue("@brand_id", Convert.ToInt32(brand));
            cmd.Parameters.AddWithValue("@car_transmission_id", Convert.ToInt32(transmission));
            cmd.Parameters.AddWithValue("@car_engine_id", Convert.ToInt32(engine_id));
            cmd.Parameters.AddWithValue("@car_model", Convert.ToInt32(car_model));

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }




         internal void dataSaveCustomerConnection(string customer_name)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Customer (customer_name) values(?)";
            cmd.Parameters.AddWithValue("@customer_name",customer_name);
           

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        internal void dataSaveCustomerMetaConnection(string customer_id,string plate_number,string car_id)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into CustomerMeta (customer_id, plate_no, car_id) values(?,?,?)";
            cmd.Parameters.AddWithValue("@customer_id", Convert.ToInt32(customer_id));
            cmd.Parameters.AddWithValue("@plate_no", plate_number);
            cmd.Parameters.AddWithValue("@car_id", Convert.ToInt32(car_id));

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        internal void retriveDataFromAccess(string command, string db_attribute)
        {

            OleDbConnection conn = new OleDbConnection(connectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = command;

            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                car_id = reader[db_attribute].ToString();
                MessageBox.Show(car_id);
            }else
            {
                MessageBox.Show("Data Read Error");
            }
            conn.Close();

        }
    }
}
