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
    public partial class Report_3UC : UserControl
    {
        public Report_3UC()
        {
            InitializeComponent();
        }
        string connstring = "server=localhost;uid=root;pwd=Connhenbeo1;database=arnolda_8723388";

        private void Show_Account_table_list_Click(object sender, EventArgs e)
        {
            Report3_listview.Items.Clear();
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //MessageBox.Show("connected Suscessfully", "Message");
                string sql = "SELECT Customer.Name_Customer, Branch.Name_Branch FROM arnolda_8723388.Customer JOIN Branch ON Customer.Branch_ID = Branch.Branch_ID;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[2];
                    _Item[0] = (string)reader["Name_Customer"].ToString();
                    _Item[1] = (string)reader["Name_Branch"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Report3_listview.Items.Add(items);
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
            Report3_listview.Items.Clear();

            bool found = false;
            if (Name_of_Customer.Text.Length == 0 && Name_Of_branch_box.Text.Length == 0)
            {
                MessageBox.Show("Please Input In Customer Name or Name of Branch to search", "Warning");
                return;
            }
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "SELECT Customer.Name_Customer, Branch.Name_Branch FROM arnolda_8723388.Customer JOIN Branch ON Customer.Branch_ID = Branch.Branch_ID;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                // Check if each text box be null so just search for the text box not null
                if (Name_of_Customer.Text.Length == 0)
                {
                    while (reader.Read())
                    {
                        if (Name_Of_branch_box.Text.Equals(reader["Name_Branch"]))
                        {
                            string[] _Item = new string[2];
                            _Item[0] = (string)reader["Name_Customer"].ToString();
                            _Item[1] = (string)reader["Name_Branch"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Report3_listview.Items.Add(items);
                            found = true;
                        }
                    }
                }
                if (Name_Of_branch_box.Text.Length == 0)
                {
                    while (reader.Read())
                    {
                        if (Name_of_Customer.Text.Equals(reader["Name_Customer"]))
                        {
                            string[] _Item = new string[2];
                            _Item[0] = (string)reader["Name_Customer"].ToString();
                            _Item[1] = (string)reader["Name_Branch"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Report3_listview.Items.Add(items);
                            found = true;
                        }
                    }
                }
                if (Name_of_Customer.Text.Length != 0 && Name_Of_branch_box.Text.Length != 0)
                {
                    while (reader.Read())
                    {
                        if (Name_of_Customer.Text.Equals(reader["Name_Customer"]) && Name_Of_branch_box.Text.Equals(reader["Name_Branch"]))
                        {
                            string[] _Item = new string[2];
                            _Item[0] = (string)reader["Name_Customer"].ToString();
                            _Item[1] = (string)reader["Name_Branch"].ToString();
                            ListViewItem items = new ListViewItem(_Item);
                            Report3_listview.Items.Add(items);
                            found = true;
                        }
                    }
                }
                if (found == false)
                {
                    MessageBox.Show("Cannot Find The Item inside the Database", "Warning");
                }
                Name_of_Customer.Clear();
                Name_Of_branch_box.Clear();
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
