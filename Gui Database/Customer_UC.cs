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
    public partial class Customer_UC : UserControl
    {
        public Customer_UC()
        {
            InitializeComponent();
        }
        string connstring = "server=localhost;uid=root;pwd=Connhenbeo1;database=arnolda_8723388";

        private void Search_in_table_btn_Click(object sender, EventArgs e)
        {
            Customer_table_listview.Items.Clear();

            bool found = false;
            if (Customer_ID_box.Text.Length == 0 && Name_Customer_Box.Text.Length == 0)
            {
                MessageBox.Show("Please Input In Customer ID or Customer Name to search", "Warning");
                return;
            }
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "select * from customer";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                // Check if each text box be null so just search for the text box not null
                if (Customer_ID_box.Text.Length == 0)
                {
                    while (reader.Read())
                    {
                        if (Name_Customer_Box.Text.Equals(reader["Name_Customer"]))
                        {
                            string[] _Item = new string[10];
                            _Item[0] = (string)reader["Customer_ID"].ToString();
                            _Item[1] = (string)reader["Name_Customer"].ToString();
                            _Item[2] = (string)reader["Address"].ToString();
                            _Item[3] = (string)reader["City"].ToString();
                            _Item[4] = (string)reader["Province/State"].ToString();
                            _Item[5] = (string)reader["Postal/Zip Code"].ToString();
                            _Item[6] = (string)reader["Telephone"].ToString();
                            _Item[7] = (string)reader["DateofBirth"].ToString();
                            _Item[8] = (string)reader["Primary Language"].ToString();
                            _Item[9] = (string)reader["Branch_ID"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Customer_table_listview.Items.Add(items);
                            found = true;
                        }
                    }
                }
                if (Name_Customer_Box.Text.Length == 0)
                {
                    while (reader.Read())
                    {
                        if (Customer_ID_box.Text.Equals(reader["Customer_ID"]))
                        {
                            string[] _Item = new string[10];
                            _Item[0] = (string)reader["Customer_ID"].ToString();
                            _Item[1] = (string)reader["Name_Customer"].ToString();
                            _Item[2] = (string)reader["Address"].ToString();
                            _Item[3] = (string)reader["City"].ToString();
                            _Item[4] = (string)reader["Province/State"].ToString();
                            _Item[5] = (string)reader["Postal/Zip Code"].ToString();
                            _Item[6] = (string)reader["Telephone"].ToString();
                            _Item[7] = (string)reader["DateofBirth"].ToString();
                            _Item[8] = (string)reader["Primary Language"].ToString();
                            _Item[9] = (string)reader["Branch_ID"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Customer_table_listview.Items.Add(items);
                            found = true;
                        }
                    }
                }
                if (Customer_ID_box.Text.Length != 0 && Name_Customer_Box.Text.Length != 0)
                {
                    while (reader.Read())
                    {
                        if (Name_Customer_Box.Text.Equals(reader["Name_Customer"]) && Customer_ID_box.Text.Equals(reader["Customer_ID"]))
                        {
                            string[] _Item = new string[10];
                            _Item[0] = (string)reader["Customer_ID"].ToString();
                            _Item[1] = (string)reader["Name_Customer"].ToString();
                            _Item[2] = (string)reader["Address"].ToString();
                            _Item[3] = (string)reader["City"].ToString();
                            _Item[4] = (string)reader["Province/State"].ToString();
                            _Item[5] = (string)reader["Postal/Zip Code"].ToString();
                            _Item[6] = (string)reader["Telephone"].ToString();
                            _Item[7] = (string)reader["DateofBirth"].ToString();
                            _Item[8] = (string)reader["Primary Language"].ToString();
                            _Item[9] = (string)reader["Branch_ID"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Customer_table_listview.Items.Add(items);
                            found = true;
                        }
                    }
                }
                if (found == false)
                {
                    MessageBox.Show("Cannot Find The Item inside the Database", "Warning");
                }
                Customer_ID_box.Clear();
                Name_Customer_Box.Clear();
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Show_Account_table_list_Click(object sender, EventArgs e)
        {
            Customer_table_listview.Items.Clear();

            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //MessageBox.Show("connected Suscessfully", "Message");
                string sql = "select * from customer";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[10];
                    _Item[0] = (string)reader["Customer_ID"].ToString();
                    _Item[1] = (string)reader["Name_Customer"].ToString();
                    _Item[2] = (string)reader["Address"].ToString();
                    _Item[3] = (string)reader["City"].ToString();
                    _Item[4] = (string)reader["Province/State"].ToString();
                    _Item[5] = (string)reader["Postal/Zip Code"].ToString();
                    _Item[6] = (string)reader["Telephone"].ToString();
                    _Item[7] = (string)reader["DateofBirth"].ToString();
                    _Item[8] = (string)reader["Primary Language"].ToString();
                    _Item[9] = (string)reader["Branch_ID"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Customer_table_listview.Items.Add(items);
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
