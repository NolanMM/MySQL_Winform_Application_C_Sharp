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
    public partial class Report_1UC : UserControl
    {
        public Report_1UC()
        {
            InitializeComponent();
        }
        string connstring = "server=localhost;uid=root;pwd=Connhenbeo1;database=arnolda_8723388";

        private void Show_Account_table_list_Click(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            int count = 0;
            Report1_listview.Items.Clear();
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //MessageBox.Show("connected Suscessfully", "Message");
                string sql = "SELECT Branch.Name_Branch, Branch.Location, Supply.Name_Supply, Supply.Location FROM arnolda_8723388.Branch JOIN Supply ON Branch.Supply_ID = Supply.Supply_ID;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[4];
                    _Item[0] = (string)reader["Name_Branch"].ToString();
                    _Item[1] = (string)reader["Location"].ToString();
                    _Item[2] = (string)reader["Name_Supply"].ToString();
                    _Item[3] = (string)reader["Location"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Report1_listview.Items.Add(items);
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
            Report1_listview.Items.Clear();

            bool found = false;
            if (Name_of_Branch_box.Text.Length == 0 && Name_Of_Supply_Box.Text.Length == 0)
            {
                MessageBox.Show("Please Input In Branch Name or Name of Supply to search", "Warning");
                return;
            }
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "SELECT Branch.Name_Branch, Branch.Location, Supply.Name_Supply, Supply.Location FROM arnolda_8723388.Branch JOIN Supply ON Branch.Supply_ID = Supply.Supply_ID;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                // Check if each text box be null so just search for the text box not null
                if (Name_of_Branch_box.Text.Length == 0)
                {
                    while (reader.Read())
                    {
                        if (Name_Of_Supply_Box.Text.Equals(reader["Name_Supply"]))
                        {
                            string[] _Item = new string[4];
                            _Item[0] = (string)reader["Name_Branch"].ToString();
                            _Item[1] = (string)reader["Location"].ToString();
                            _Item[2] = (string)reader["Name_Supply"].ToString();
                            _Item[3] = (string)reader["Location"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Report1_listview.Items.Add(items);
                            found = true;
                            count++;

                        }
                    }
                }
                if (Name_Of_Supply_Box.Text.Length == 0)
                {
                    while (reader.Read())
                    {
                        if (Name_of_Branch_box.Text.Equals(reader["Name_Branch"]))
                        {
                            string[] _Item = new string[4];
                            _Item[0] = (string)reader["Name_Branch"].ToString();
                            _Item[1] = (string)reader["Location"].ToString();
                            _Item[2] = (string)reader["Name_Supply"].ToString();
                            _Item[3] = (string)reader["Location"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Report1_listview.Items.Add(items);
                            found = true;
                            count++;

                        }
                    }
                }
                if (Name_of_Branch_box.Text.Length != 0 && Name_Of_Supply_Box.Text.Length != 0)
                {
                    while (reader.Read())
                    {
                        if (Name_of_Branch_box.Text.Equals(reader["Name_Branch"]) && Name_Of_Supply_Box.Text.Equals(reader["Name_Supply"]))
                        {
                            string[] _Item = new string[4];
                            _Item[0] = (string)reader["Name_Branch"].ToString();
                            _Item[1] = (string)reader["Location"].ToString();
                            _Item[2] = (string)reader["Name_Supply"].ToString();
                            _Item[3] = (string)reader["Location"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Report1_listview.Items.Add(items);
                            found = true;
                            count++;

                        }
                    }
                }
                if (found == false)
                {
                    MessageBox.Show("Cannot Find The Item inside the Database", "Warning");
                }
                Name_of_Branch_box.Clear();
                Name_Of_Supply_Box.Clear();
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
