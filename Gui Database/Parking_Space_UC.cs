using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui_Database
{
    public partial class Parking_Space_UC : UserControl
    {
        public Parking_Space_UC()
        {
            InitializeComponent();
        }
        string connstring = "server=localhost;uid=root;pwd=Connhenbeo1;database=arnolda_8723388";

        private void Search_in_table_btn_Click(object sender, EventArgs e)
        {
            Parking_Space_table_listview.Items.Clear();

            bool found = false;
            if (Parking_Space_ID_box.Text.Length == 0 && Location_Box.Text.Length == 0 && Employee_ID_Box.Text.Length == 0)
            {
                MessageBox.Show("Please Input In Item ID or Order ID or Supply ID to search", "Warning");
                return;
            }
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "select * from parking_space";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                // Check if each text box be null so just search for the text box not null
                if (Parking_Space_ID_box.Text.Length != 0 && Location_Box.Text.Length == 0 && Employee_ID_Box.Text.Length == 0)
                {
                    while (reader.Read())
                    {
                        if (Parking_Space_ID_box.Text.Equals(reader["ParkingSpace_ID"]))
                        {
                            string[] _Item = new string[3];
                            _Item[0] = (string)reader["ParkingSpace_ID"].ToString();
                            _Item[1] = (string)reader["Location_Parking_Space"].ToString();
                            _Item[2] = (string)reader["Employee_ID"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Parking_Space_table_listview.Items.Add(items);
                            found = true;
                        }
                    }
                }
                if (Parking_Space_ID_box.Text.Length != 0 && Location_Box.Text.Length != 0 && Employee_ID_Box.Text.Length == 0)
                {
                    while (reader.Read())
                    {
                        if (Parking_Space_ID_box.Text.Equals(reader["ParkingSpace_ID"]) && Location_Box.Text.Equals(reader["Location_Parking_Space"]))
                        {
                            string[] _Item = new string[3];
                            _Item[0] = (string)reader["ParkingSpace_ID"].ToString();
                            _Item[1] = (string)reader["Location_Parking_Space"].ToString();
                            _Item[2] = (string)reader["Employee_ID"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Parking_Space_table_listview.Items.Add(items);
                            found = true;
                        }
                    }
                }
                if (Parking_Space_ID_box.Text.Length != 0 && Location_Box.Text.Length == 0 && Employee_ID_Box.Text.Length != 0)
                {
                    while (reader.Read())
                    {
                        if (Parking_Space_ID_box.Text.Equals(reader["ParkingSpace_ID"]) && Employee_ID_Box.Text.Equals(reader["Employee_ID"]))
                        {
                            string[] _Item = new string[3];
                            _Item[0] = (string)reader["ParkingSpace_ID"].ToString();
                            _Item[1] = (string)reader["Location_Parking_Space"].ToString();
                            _Item[2] = (string)reader["Employee_ID"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Parking_Space_table_listview.Items.Add(items);
                            found = true;
                        }
                    }
                }
                if (Parking_Space_ID_box.Text.Length == 0 && Location_Box.Text.Length != 0 && Employee_ID_Box.Text.Length != 0)
                {
                    while (reader.Read())
                    {
                        if (Location_Box.Text.Equals(reader["Location_Parking_Space"]) && Employee_ID_Box.Text.Equals(reader["Employee_ID"]))
                        {
                            string[] _Item = new string[3];
                            _Item[0] = (string)reader["ParkingSpace_ID"].ToString();
                            _Item[1] = (string)reader["Location_Parking_Space"].ToString();
                            _Item[2] = (string)reader["Employee_ID"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Parking_Space_table_listview.Items.Add(items);
                            found = true;
                        }
                    }
                }
                if (Parking_Space_ID_box.Text.Length == 0 && Location_Box.Text.Length == 0 && Employee_ID_Box.Text.Length != 0)
                {
                    while (reader.Read())
                    {
                        if (Employee_ID_Box.Text.Equals(reader["Employee_ID"]))
                        {
                            string[] _Item = new string[3];
                            _Item[0] = (string)reader["ParkingSpace_ID"].ToString();
                            _Item[1] = (string)reader["Location_Parking_Space"].ToString();
                            _Item[2] = (string)reader["Employee_ID"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Parking_Space_table_listview.Items.Add(items);
                            found = true;
                        }
                    }
                }
                if (Parking_Space_ID_box.Text.Length == 0 && Location_Box.Text.Length != 0 && Employee_ID_Box.Text.Length == 0)
                {
                    while (reader.Read())
                    {
                        if (Location_Box.Text.Equals(reader["Location_Parking_Space"]))
                        {
                            string[] _Item = new string[3];
                            _Item[0] = (string)reader["ParkingSpace_ID"].ToString();
                            _Item[1] = (string)reader["Location_Parking_Space"].ToString();
                            _Item[2] = (string)reader["Employee_ID"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Parking_Space_table_listview.Items.Add(items);
                            found = true;
                        }
                    }
                }
                if (Parking_Space_ID_box.Text.Length != 0 && Location_Box.Text.Length != 0 && Employee_ID_Box.Text.Length != 0)
                {
                    while (reader.Read())
                    {
                        if (Parking_Space_ID_box.Text.Equals(reader["ParkingSpace_ID"]) && Location_Box.Text.Equals(reader["Location_Parking_Space"]) && Employee_ID_Box.Text.Equals(reader["Employee_ID"]))
                        {
                            string[] _Item = new string[3];
                            _Item[0] = (string)reader["ParkingSpace_ID"].ToString();
                            _Item[1] = (string)reader["Location_Parking_Space"].ToString();
                            _Item[2] = (string)reader["Employee_ID"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Parking_Space_table_listview.Items.Add(items);
                            found = true;
                        }
                    }
                }
                if (found == false)
                {
                    MessageBox.Show("Cannot Find The Item inside the Database", "Warning");
                }
                Parking_Space_ID_box.Clear();
                Location_Box.Clear();
                Employee_ID_Box.Clear();
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Show_Account_table_list_Click(object sender, EventArgs e)
        {
            Parking_Space_table_listview.Items.Clear();

            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //MessageBox.Show("connected Suscessfully", "Message");
                string sql = "select * from parking_space";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[3];
                    _Item[0] = (string)reader["ParkingSpace_ID"].ToString();
                    _Item[1] = (string)reader["Location_Parking_Space"].ToString();
                    _Item[2] = (string)reader["Employee_ID"].ToString();

                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Parking_Space_table_listview.Items.Add(items);
                }
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);

        }
    }
}
