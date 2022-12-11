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
    public partial class Add_Supply_Item_UC : UserControl
    {
        public Add_Supply_Item_UC()
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
        private void Add_Supply_Item_UC_Load(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Supply_table_listview.Items.Clear();

            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //MessageBox.Show("connected Suscessfully", "Message");
                string sql = "select * from supply";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[5];
                    _Item[0] = (string)reader["Supply_ID"].ToString();
                    _Item[1] = (string)reader["Name_Supply"].ToString();
                    _Item[2] = (string)reader["Location"].ToString();
                    _Item[3] = (string)reader["Branch_ID"].ToString();
                    _Item[4] = (string)reader["Item_ID"].ToString();


                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Supply_table_listview.Items.Add(items);
                }
                con.Close();
                Count_Item_Function("supply");
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
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Supply_table_listview.Items.Clear();
            try
            {
                string Supply_Id = Supply_ID_box.Text.ToString();
                string Supply_Name = Name_Supply_box.Text.ToString();
                string Location = Location_box.Text.ToString();
                string brand_id = Branch_ID_box.Text.ToString();
                string Item_id = Item_ID_Box.Text.ToString();

                if (Supply_ID_box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Primary Key cannot be null", "Warning");
                    return;
                }
                if (Name_Supply_box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Name of Supply cannot be null", "Warning");
                    return;
                }
                if (Branch_ID_box.Text.Length == 0)
                {
                    brand_id = "Unknown";
                }
                if (Location_box.Text.Length == 0)
                {
                    Location = "Unknown";
                }
                if (Item_ID_Box.Text.Length == 0)
                {
                    Item_id = "Unknown";
                }
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();

                string sql = @"INSERT INTO `arnolda_8723388`.`supply` (`Supply_ID`, `Name_Supply`, `Location`, `Branch_ID`,`Item_ID`) VALUES('" + Supply_Id + "', '" + Supply_Name + "', '" + Location + "', '"+ brand_id + "', '" + Item_id + "');";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                sql = "select * from supply";
                MySqlCommand cmd_2 = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd_2.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[5];
                    _Item[0] = (string)reader["Supply_ID"].ToString();
                    _Item[1] = (string)reader["Name_Supply"].ToString();
                    _Item[2] = (string)reader["Location"].ToString();
                    _Item[3] = (string)reader["Branch_ID"].ToString();
                    _Item[4] = (string)reader["Item_ID"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Supply_table_listview.Items.Add(items);
                }
                MessageBox.Show("Added Suscessfully", "Message");
                Supply_ID_box.Clear();
                Name_Supply_box.Clear();
                Location_box.Clear();
                Branch_ID_box.Clear();
                Item_ID_Box.Clear();
                con.Close();
                Count_Item_Function("supply");
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
