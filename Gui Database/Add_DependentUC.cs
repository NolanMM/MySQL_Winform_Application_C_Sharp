﻿using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
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

    public partial class Add_DependentUC : UserControl
    {
        public Add_DependentUC()
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
        private void Add_DependentUC_Load(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //MessageBox.Show("connected Suscessfully", "Message");
                string sql = "select * from dependent";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[4];
                    _Item[0] = (string)reader["Employee_ID"].ToString();
                    _Item[1] = (string)reader["Dependent_Name"].ToString();
                    _Item[2] = (string)reader["Age"].ToString();
                    _Item[3] = (string)reader["Relationship"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Account_table_listview.Items.Add(items);
                }

                con.Close();

                Count_Item_Function("dependent");
                watch.Stop();
                Time_Execute_box.Text = watch.Elapsed.ToString();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            Account_table_listview.Items.Clear();

            //Account_table_listview.Clear();
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            try
            {
                //DateTime date2 = new DateTime(2022, 11, 01, 00, 00, 00);
                string Age = Age_box.Text.ToString();
                string employee_id = Employee_ID_box.Text.ToString();
                string dependent_name = Dependent_name_box.Text.ToString();
                string Relationship = Relationship_Box.Text.ToString();
                if (Employee_ID_box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Primary Key cannot be null", "Warning");
                    return;
                }
                
                if (Age_box.Text.Length == 0)
                {

                    Age = "NULL";
                }
                else
                {
                    bool flag = false;
                    flag = Int32.TryParse(Age_box.Text, out int result);
                    if (flag == true && result < 100)
                    {
                        Age = Dependent_name_box.Text;
                    }
                    else { MessageBox.Show("Error, Wrong Format for Age. Please Enter Integer", "Warning"); return; }
                }
                if (Dependent_name_box.Text.Length == 0)
                {
                    dependent_name = "Unknown";
                }
                if (Relationship_Box.Text.Length == 0)
                {
                    Relationship = "Unknown";
                }
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //"INSERT INTO `arnolda_8723388`.`accounts` (`AccountNumber`, `PaymentDate`, `PaymentAmount`, `Customer_ID`) VALUES('"+2828282282+"', '"+2021-09-28 00:00:00+"', '"+2134+"', '"+CBA321+"');";
                //MessageBox.Show("connected Suscessfully", "Message");
                string sql = @"INSERT INTO `arnolda_8723388`.`dependent` (`Employee_ID`, `Dependent_Name`, `Age`, `Relationship`) VALUES('" + employee_id + "', '" + dependent_name + "', '" + Age + "', '" + Relationship + "');";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.ExecuteNonQuery();
                sql = "select * from dependent";
                MySqlCommand cmd_2 = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd_2.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[4];
                    _Item[0] = (string)reader["Employee_ID"].ToString();
                    _Item[1] = (string)reader["Dependent_Name"].ToString();
                    _Item[2] = (string)reader["Age"].ToString();
                    _Item[3] = (string)reader["Relationship"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Account_table_listview.Items.Add(items);
                }
                //MessageBox.Show("connected Suscessfully", "Message");
                Age_box.Clear();
                Employee_ID_box.Clear();
                Dependent_name_box.Clear();
                Relationship_Box.Clear();
                con.Close();

                Count_Item_Function("dependent");
                watch.Stop();
                Time_Execute_box.Text = watch.Elapsed.ToString();

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
        
        int number_of_dependent = 0;
        LinkedList<string> list_item = new LinkedList<string>();
        string employee_id;

        private void button1_Click(object sender, EventArgs e)
        {
            bool Is_valid = true;
            if (list_item.Count == 0)
            {
                Account_table_listview.Items.Clear();
                Is_valid = Int32.TryParse(Number_of_Dependent_box.Text.ToString(), out number_of_dependent);
            }
            string send_total_collection;
            if (Is_valid == true)
            {
                string Age = Age_box.Text.ToString();
                employee_id = Employee_ID_box.Text.ToString();
                string dependent_name = Dependent_name_box.Text.ToString();
                string Relationship = Relationship_Box.Text.ToString();

                if (Employee_ID_box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Primary Key cannot be null", "Warning");
                    return;
                }

                if (Age_box.Text.Length == 0)
                {

                    Age = "NULL";
                }
                else
                {
                    bool flag = false;
                    flag = Int32.TryParse(Age_box.Text, out int result);
                    if (flag == true && result < 100)
                    {
                        Age = Dependent_name_box.Text;
                    }
                    else { MessageBox.Show("Error, Wrong Format for Age. Please Enter Integer", "Warning"); return; }
                }
                if (Dependent_name_box.Text.Length == 0)
                {
                    dependent_name = "Unknown";
                }
                if (Relationship_Box.Text.Length == 0)
                {
                    Relationship = "Unknown";
                }

                if (list_item.Count() < number_of_dependent - 1)
                {
                    // Format (Employee_ID,Dependent_Name,Age, Relationship)
                    // ('employee_id','dependent_name','Age','Relationship'),
                    send_total_collection = "(" + "'" + employee_id + "'" + "," + "'" + dependent_name + "'" + "," + "'" + Age + "'" + "," + "'" + Relationship + "'" + ")" + ",";
                    list_item.AddFirst(send_total_collection);

                    string[] _Item = new string[4];
                    _Item[0] = employee_id;
                    _Item[1] = dependent_name;
                    _Item[2] = Age;
                    _Item[3] = Relationship;
                    ListViewItem items = new ListViewItem(_Item);
                    Account_table_listview.Items.Add(items);

                    Dependent_name_box.Clear();
                    Relationship_Box.Clear();
                    Age_box.Clear();

                }
                else if(list_item.Count() == number_of_dependent - 1)
                {
                    send_total_collection = "(" + "'" + employee_id + "'" + "," + "'" + dependent_name + "'" + "," + "'" + Age + "'" + "," + "'" + Relationship + "'" + ")" +";";
                    list_item.AddLast(send_total_collection);

                    string[] _Item = new string[4];
                    _Item[0] = employee_id;
                    _Item[1] = dependent_name;
                    _Item[2] = Age;
                    _Item[3] = Relationship;
                    ListViewItem items = new ListViewItem(_Item);
                    Account_table_listview.Items.Add(items);

                    Dependent_name_box.Clear();
                    Relationship_Box.Clear();
                    Age_box.Clear();
                }
                else { MessageBox.Show("Error, Out range of the number dependents", "Warning"); return; }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account_table_listview.Items.Clear();
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            try
            {
                string item_total_send = null;
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //"INSERT INTO `arnolda_8723388`.`accounts` (`AccountNumber`, `PaymentDate`, `PaymentAmount`, `Customer_ID`) VALUES('"+2828282282+"', '"+2021-09-28 00:00:00+"', '"+2134+"', '"+CBA321+"');";
                //MessageBox.Show("connected Suscessfully", "Message");
                foreach(var item in list_item)
                {
                    item_total_send += item;
                }
                string sql = @"INSERT INTO `arnolda_8723388`.`dependent` (`Employee_ID`, `Dependent_Name`, `Age`, `Relationship`) VALUES " + item_total_send;

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.ExecuteNonQuery();
                sql = "select * from dependent";
                MySqlCommand cmd_2 = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd_2.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[4];
                    _Item[0] = (string)reader["Employee_ID"].ToString();
                    _Item[1] = (string)reader["Dependent_Name"].ToString();
                    _Item[2] = (string)reader["Age"].ToString();
                    _Item[3] = (string)reader["Relationship"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Account_table_listview.Items.Add(items);
                }
                //MessageBox.Show("connected Suscessfully", "Message");
                Age_box.Clear();
                Employee_ID_box.Clear();
                Dependent_name_box.Clear();
                Relationship_Box.Clear();
                Number_of_Dependent_box.Clear();
                list_item.Clear();
                con.Close();

                Count_Item_Function("dependent");
                watch.Stop();
                Time_Execute_box.Text = watch.Elapsed.ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
