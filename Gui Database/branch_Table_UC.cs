﻿using MySql.Data.MySqlClient;
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
    public partial class branch_Table_UC : UserControl
    {
        public branch_Table_UC()
        {
            InitializeComponent();
        }
        string connstring = "server=localhost;uid=root;pwd=Connhenbeo1;database=arnolda_8723388";

        void Count_Item_Function(string table)
        {
            try
            {
                using (var conn = new MySqlConnection(connstring))
                {
                    conn.Open();
                    string cmd_line = "SELECT COUNT(*) FROM " + table;
                    using (var cmd = new MySqlCommand(cmd_line, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        Count_Item_box.Text = count.ToString();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Show_Account_table_list_Click(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Account_table_listview.Items.Clear();

            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //MessageBox.Show("connected Suscessfully", "Message");
                string sql = "select * from branch";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[4];
                    _Item[0] = (string)reader["Branch_ID"].ToString();
                    _Item[1] = (string)reader["Name_Branch"].ToString();
                    _Item[2] = (string)reader["Location"].ToString();
                    _Item[3] = (string)reader["Supply_ID"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Account_table_listview.Items.Add(items);
                }
                con.Close();
                Count_Item_Function("branch");
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
            Account_table_listview.Items.Clear();

            bool found = false;
            if (Branch_ID_box.Text.Length == 0 && Supply_ID_Box.Text.Length == 0)
            {
                MessageBox.Show("Please Input In Branch ID or Supply ID to search", "Warning");
                return;
            }
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "select * from branch";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                // Check if each text box be null so just search for the text box not null
                if (Branch_ID_box.Text.Length == 0)
                {
                    while (reader.Read())
                    {
                        if (Supply_ID_Box.Text.Equals(reader["Supply_ID"]))
                        {
                            string[] _Item = new string[4];
                            _Item[0] = (string)reader["Branch_ID"].ToString();
                            _Item[1] = (string)reader["Name_Branch"].ToString();
                            _Item[2] = (string)reader["Location"].ToString();
                            _Item[3] = (string)reader["Supply_ID"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Account_table_listview.Items.Add(items);
                            found = true;
                            count++;
                        }
                    }
                }
                if (Supply_ID_Box.Text.Length == 0)
                {
                    while (reader.Read())
                    {
                        if (Branch_ID_box.Text.Equals(reader["Branch_ID"]))
                        {
                            string[] _Item = new string[4];
                            _Item[0] = (string)reader["Branch_ID"].ToString();
                            _Item[1] = (string)reader["Name_Branch"].ToString();
                            _Item[2] = (string)reader["Location"].ToString();
                            _Item[3] = (string)reader["Supply_ID"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Account_table_listview.Items.Add(items);
                            found = true;
                            count++;
                        }
                    }
                }
                if (Branch_ID_box.Text.Length != 0 && Supply_ID_Box.Text.Length != 0)
                {
                    while (reader.Read())
                    {
                        if (Supply_ID_Box.Text.Equals(reader["Supply_ID"]) && Branch_ID_box.Text.Equals(reader["Branch_ID"]))
                        {
                            string[] _Item = new string[4];
                            _Item[0] = (string)reader["Branch_ID"].ToString();
                            _Item[1] = (string)reader["Name_Branch"].ToString();
                            _Item[2] = (string)reader["Location"].ToString();
                            _Item[3] = (string)reader["Supply_ID"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Account_table_listview.Items.Add(items);
                            found = true;
                            count++;
                        }
                    }
                }
                if (found == false)
                {
                    MessageBox.Show("Cannot Find The Item inside the Database", "Warning");
                }
                Branch_ID_box.Clear();
                Supply_ID_Box.Clear();
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
