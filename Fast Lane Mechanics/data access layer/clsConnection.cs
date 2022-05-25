using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using Fast_Lane_Mechanics;

namespace connection.data_access_layer
{
    internal class clsConnection
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\wasiq\Documents\FastLaneMechanics.accdb;Persist Security Info=False";
        
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

        internal void dataRetriveCarConnection(string brand_id, string car_transmission, string car_engine_id)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            conn.Open();
           
            cmd.CommandText = "select id from Car where brand_id=" + brand_id + "and car_transmission_id =" + car_transmission + "and car_engine_id = "+ car_engine_id;
            
            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string id = reader["id"].ToString();
                Program.car_id = Convert.ToInt32(id);
                
            }
           
            conn.Close();
          
        }

        internal void dataRetriveCustomerConnection()
        {
            OleDbConnection conn = new OleDbConnection(connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "select id from Customer where id = (select max(id) from Customer)";

            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string id = reader["id"].ToString();
                Program.customer_id = Convert.ToInt32(id);

            }

            conn.Close();

        }

        internal void dataSaveWorkerConnection(string worker_name)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Worker (worker_name) values(?)";
            cmd.Parameters.AddWithValue("@worker_name", worker_name);


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


        internal void dataSaveCustomerMetaConnection(int customer_id,string plate_number,int car_id,int car_model)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into CustomerMeta (customer_id, plate_no, car_id ,car_model_id) values(?,?,?,?)";
            cmd.Parameters.AddWithValue("@customer_id", customer_id);
            cmd.Parameters.AddWithValue("@plate_no", plate_number);
            cmd.Parameters.AddWithValue("@car_id", car_id);
            cmd.Parameters.AddWithValue("@car_model,id", car_model);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        internal void dataRetriveLoginConnection()
        {
            OleDbConnection conn = new OleDbConnection(connectionString);

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "select id,username from Login where id = 1";

            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string username = reader["username"].ToString();
                Program.username = username;

            }

            conn.Close();

        }

    }
}
