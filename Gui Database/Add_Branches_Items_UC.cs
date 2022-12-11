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
    public partial class Add_Branches_Items_UC : UserControl
    {
        public Add_Branches_Items_UC()
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
        private void Add_btn_Click(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            try {
                string Branch_Id = Branch_Id_box.Text.ToString();
                string Branch_Name = Name_Branch_box.Text.ToString();
                string Location = Location_box.Text.ToString();
                string customer_id = Customer_ID_Box.Text.ToString();

                if (Branch_Id_box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Primary Key cannot be null", "Warning");
                    return;
                }
                if (Name_Branch_box.Text.Length == 0)
                {
                    Branch_Name = "Unknown";
                }
                if (Location_box.Text.Length == 0)
                {
                    Location = "Unknown";
                }
                if (Customer_ID_Box.Text.Length == 0)
                {
                    customer_id = "Unknown";
                }
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();

                string sql = @"INSERT INTO `arnolda_8723388`.`branch` (`Branch_ID`, `Name_Branch`, `Location`, `Supply_ID`) VALUES('" + Branch_Id + "', '" + Branch_Name + "', '" + Location + "', '" + customer_id + "');";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                sql = "select * from branch";
                MySqlCommand cmd_2 = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd_2.ExecuteReader();
                Branch_listview.Items.Clear();
                while (reader.Read())
                {
                    string[] _Item = new string[4];
                    _Item[0] = (string)reader["Branch_ID"].ToString();
                    _Item[1] = (string)reader["Name_Branch"].ToString();
                    _Item[2] = (string)reader["Location"].ToString();
                    _Item[3] = (string)reader["Supply_ID"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Branch_listview.Items.Add(items);
                }
                //MessageBox.Show("connected Suscessfully", "Message");

                Branch_Id_box.Clear();
                Name_Branch_box.Clear();
                Location_box.Clear();
                Customer_ID_Box.Clear();
                con.Close();
                watch.Stop();
                Time_Execute_box.Text = watch.Elapsed.ToString();
                Count_Item_Function("branch");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Add_Branches_Items_UC_Load(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
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
                    Branch_listview.Items.Add(items);
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

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);

        }
    }
}
