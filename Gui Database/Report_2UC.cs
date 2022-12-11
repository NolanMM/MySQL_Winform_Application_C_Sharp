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
    public partial class Report_2UC : UserControl
    {
        public Report_2UC()
        {
            InitializeComponent();
        }
        string connstring = "server=localhost;uid=root;pwd=Connhenbeo1;database=arnolda_8723388";

        private void Show_Account_table_list_Click(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            int count = 0;
            Report2_listview.Items.Clear();
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //MessageBox.Show("connected Suscessfully", "Message");
                string sql = "SELECT Employee.Name_Employee, Employee.Title, Parking_Space.Location_Parking_Space FROM arnolda_8723388.Employee JOIN Parking_Space ON Parking_Space.Employee_ID = Employee.Employee_ID;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[3];
                    _Item[0] = (string)reader["Name_Employee"].ToString();
                    _Item[1] = (string)reader["Title"].ToString();
                    _Item[2] = (string)reader["Location_Parking_Space"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Report2_listview.Items.Add(items);
                    count++;

                }
                con.Close();
                Count_Item_box.Text = count.ToString();
                watch.Stop();
                Time_Execute_box.Text = watch.Elapsed.ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Search_in_table_btn_Click(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            int count = 0;
            Report2_listview.Items.Clear();

            bool found = false;
            if (Name_of_Employee_box.Text.Length == 0 && Location_parking_box.Text.Length == 0)
            {
                MessageBox.Show("Please Input In Employee Name or Location of Parking to search", "Warning");
                return;
            }
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "SELECT Employee.Name_Employee, Employee.Title, Parking_Space.Location_Parking_Space FROM arnolda_8723388.Employee JOIN Parking_Space ON Parking_Space.Employee_ID = Employee.Employee_ID;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                // Check if each text box be null so just search for the text box not null
                if (Name_of_Employee_box.Text.Length == 0)
                {
                    while (reader.Read())
                    {
                        if (Location_parking_box.Text.Equals(reader["Location_Parking_Space"]))
                        {
                            string[] _Item = new string[3];
                            _Item[0] = (string)reader["Name_Employee"].ToString();
                            _Item[1] = (string)reader["Title"].ToString();
                            _Item[2] = (string)reader["Location_Parking_Space"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Report2_listview.Items.Add(items);
                            found = true;
                            count++;

                        }
                    }
                }
                if (Location_parking_box.Text.Length == 0)
                {
                    while (reader.Read())
                    {
                        if (Name_of_Employee_box.Text.Equals(reader["Name_Employee"]))
                        {
                            string[] _Item = new string[3];
                            _Item[0] = (string)reader["Name_Employee"].ToString();
                            _Item[1] = (string)reader["Title"].ToString();
                            _Item[2] = (string)reader["Location_Parking_Space"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Report2_listview.Items.Add(items);
                            found = true;
                            count++;

                        }
                    }
                }
                if (Name_of_Employee_box.Text.Length != 0 && Location_parking_box.Text.Length != 0)
                {
                    while (reader.Read())
                    {
                        if (Name_of_Employee_box.Text.Equals(reader["Name_Employee"]) && Location_parking_box.Text.Equals(reader["Location_Parking_Space"]))
                        {
                            string[] _Item = new string[3];
                            _Item[0] = (string)reader["Name_Employee"].ToString();
                            _Item[1] = (string)reader["Title"].ToString();
                            _Item[2] = (string)reader["Location_Parking_Space"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Report2_listview.Items.Add(items);
                            found = true;
                            count++;

                        }
                    }
                }
                if (found == false)
                {
                    MessageBox.Show("Cannot Find The Item inside the Database", "Warning");
                }
                Name_of_Employee_box.Clear();
                Location_parking_box.Clear();
                con.Close();
                watch.Stop();
                Time_Execute_box.Text = watch.Elapsed.ToString();
                Count_Item_box.Text = count.ToString();
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
