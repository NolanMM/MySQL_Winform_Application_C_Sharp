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
    public partial class New_Item_UC : UserControl
    {
        public New_Item_UC()
        {
            InitializeComponent();
        }
        string connstring = "server=localhost;uid=root;pwd=Connhenbeo1;database=arnolda_8723388";

        private void Show_Account_table_list_Click(object sender, EventArgs e)
        {
            Items_listview.Items.Clear();

            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //MessageBox.Show("connected Suscessfully", "Message");
                string sql = "select * from item";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[7];
                    _Item[0] = (string)reader["Item_ID"].ToString();
                    _Item[1] = (string)reader["Description"].ToString();
                    _Item[2] = (string)reader["Colour"].ToString();
                    _Item[3] = (string)reader["Size"].ToString();
                    _Item[4] = (string)reader["Type"].ToString();
                    _Item[5] = (string)reader["Order_Item_ID"].ToString();
                    _Item[6] = (string)reader["Supply_ID"].ToString();

                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Items_listview.Items.Add(items);
                }
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Search_in_table_btn_Click(object sender, EventArgs e)
        {
            Items_listview.Items.Clear();

            bool found = false;
            if (Item_ID_box.Text.Length == 0 && Order_Item_Box.Text.Length == 0 && Supply_ID_Box.Text.Length == 0)
            {
                MessageBox.Show("Please Input In Item ID or Order ID or Supply ID to search", "Warning");
                return;
            }
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "select * from item";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                // Check if each text box be null so just search for the text box not null
                if (Item_ID_box.Text.Length != 0 && Order_Item_Box.Text.Length == 0 && Supply_ID_Box.Text.Length == 0)
                {
                    while (reader.Read())
                    {
                        if (Item_ID_box.Text.Equals(reader["Item_ID"]))
                        {
                            string[] _Item = new string[7];
                            _Item[0] = (string)reader["Item_ID"].ToString();
                            _Item[1] = (string)reader["Description"].ToString();
                            _Item[2] = (string)reader["Colour"].ToString();
                            _Item[3] = (string)reader["Size"].ToString();
                            _Item[4] = (string)reader["Type"].ToString();
                            _Item[5] = (string)reader["Order_Item_ID"].ToString();
                            _Item[6] = (string)reader["Supply_ID"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Items_listview.Items.Add(items);
                            found = true;
                        }
                    }
                }
                if (Item_ID_box.Text.Length != 0 && Order_Item_Box.Text.Length != 0 && Supply_ID_Box.Text.Length == 0)
                {
                    while (reader.Read())
                    {
                        if (Item_ID_box.Text.Equals(reader["Item_ID"]) && Order_Item_Box.Text.Equals(reader["Order_Item_ID"]))
                        {
                            string[] _Item = new string[7];
                            _Item[0] = (string)reader["Item_ID"].ToString();
                            _Item[1] = (string)reader["Description"].ToString();
                            _Item[2] = (string)reader["Colour"].ToString();
                            _Item[3] = (string)reader["Size"].ToString();
                            _Item[4] = (string)reader["Type"].ToString();
                            _Item[5] = (string)reader["Order_Item_ID"].ToString();
                            _Item[6] = (string)reader["Supply_ID"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Items_listview.Items.Add(items);
                            found = true;
                        }
                    }
                }
                if (Item_ID_box.Text.Length != 0 && Order_Item_Box.Text.Length == 0 && Supply_ID_Box.Text.Length != 0)
                {
                    while (reader.Read())
                    {
                        if (Item_ID_box.Text.Equals(reader["Item_ID"]) && Supply_ID_Box.Text.Equals(reader["Supply_ID"]))
                        {
                            string[] _Item = new string[7];
                            _Item[0] = (string)reader["Item_ID"].ToString();
                            _Item[1] = (string)reader["Description"].ToString();
                            _Item[2] = (string)reader["Colour"].ToString();
                            _Item[3] = (string)reader["Size"].ToString();
                            _Item[4] = (string)reader["Type"].ToString();
                            _Item[5] = (string)reader["Order_Item_ID"].ToString();
                            _Item[6] = (string)reader["Supply_ID"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Items_listview.Items.Add(items);
                            found = true;
                        }
                    }
                }
                if (Item_ID_box.Text.Length == 0 && Order_Item_Box.Text.Length != 0 && Supply_ID_Box.Text.Length != 0)
                {
                    while (reader.Read())
                    {
                        if (Order_Item_Box.Text.Equals(reader["Order_Item_ID"]) && Supply_ID_Box.Text.Equals(reader["Supply_ID"]))
                        {
                            string[] _Item = new string[7];
                            _Item[0] = (string)reader["Item_ID"].ToString();
                            _Item[1] = (string)reader["Description"].ToString();
                            _Item[2] = (string)reader["Colour"].ToString();
                            _Item[3] = (string)reader["Size"].ToString();
                            _Item[4] = (string)reader["Type"].ToString();
                            _Item[5] = (string)reader["Order_Item_ID"].ToString();
                            _Item[6] = (string)reader["Supply_ID"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Items_listview.Items.Add(items);
                            found = true;
                        }
                    }
                }
                if (Item_ID_box.Text.Length == 0 && Order_Item_Box.Text.Length == 0 && Supply_ID_Box.Text.Length != 0)
                {
                    while (reader.Read())
                    {
                        if (Supply_ID_Box.Text.Equals(reader["Supply_ID"]))
                        {
                            string[] _Item = new string[7];
                            _Item[0] = (string)reader["Item_ID"].ToString();
                            _Item[1] = (string)reader["Description"].ToString();
                            _Item[2] = (string)reader["Colour"].ToString();
                            _Item[3] = (string)reader["Size"].ToString();
                            _Item[4] = (string)reader["Type"].ToString();
                            _Item[5] = (string)reader["Order_Item_ID"].ToString();
                            _Item[6] = (string)reader["Supply_ID"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Items_listview.Items.Add(items);
                            found = true;
                        }
                    }
                }
                if (Item_ID_box.Text.Length == 0 && Order_Item_Box.Text.Length != 0 && Supply_ID_Box.Text.Length == 0)
                {
                    while (reader.Read())
                    {
                        if (Order_Item_Box.Text.Equals(reader["Order_Item_ID"]))
                        {
                            string[] _Item = new string[7];
                            _Item[0] = (string)reader["Item_ID"].ToString();
                            _Item[1] = (string)reader["Description"].ToString();
                            _Item[2] = (string)reader["Colour"].ToString();
                            _Item[3] = (string)reader["Size"].ToString();
                            _Item[4] = (string)reader["Type"].ToString();
                            _Item[5] = (string)reader["Order_Item_ID"].ToString();
                            _Item[6] = (string)reader["Supply_ID"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Items_listview.Items.Add(items);
                            found = true;
                        }
                    }
                }
                if (Item_ID_box.Text.Length != 0 && Order_Item_Box.Text.Length != 0 && Supply_ID_Box.Text.Length != 0)
                {
                    while (reader.Read())
                    {
                        if (Item_ID_box.Text.Equals(reader["Item_ID"]) && Order_Item_Box.Text.Equals(reader["Order_Item_ID"]) && Supply_ID_Box.Text.Equals(reader["Supply_ID"]))
                        {
                            string[] _Item = new string[7];
                            _Item[0] = (string)reader["Item_ID"].ToString();
                            _Item[1] = (string)reader["Description"].ToString();
                            _Item[2] = (string)reader["Colour"].ToString();
                            _Item[3] = (string)reader["Size"].ToString();
                            _Item[4] = (string)reader["Type"].ToString();
                            _Item[5] = (string)reader["Order_Item_ID"].ToString();
                            _Item[6] = (string)reader["Supply_ID"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Items_listview.Items.Add(items);
                            found = true;
                        }
                    }
                }
                if (found == false)
                {
                    MessageBox.Show("Cannot Find The Item inside the Database", "Warning");
                }
                Item_ID_box.Clear();
                Order_Item_Box.Clear();
                Supply_ID_Box.Clear();
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
