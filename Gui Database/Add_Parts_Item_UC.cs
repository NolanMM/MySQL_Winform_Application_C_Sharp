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
    public partial class Add_Parts_Item_UC : UserControl
    {
        public Add_Parts_Item_UC()
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
        private void Add_Parts_Item_UC_Load(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Parts_table_listview.Items.Clear();

            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //MessageBox.Show("connected Suscessfully", "Message");
                string sql = "select * from parts";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[4];
                    _Item[0] = (string)reader["Part_Name"].ToString();
                    _Item[1] = (string)reader["Colour"].ToString();
                    _Item[2] = (string)reader["Descriptions"].ToString();
                    _Item[3] = (string)reader["Item_ID"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Parts_table_listview.Items.Add(items);
                }
                con.Close();
                Count_Item_Function("parts");
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
            Parts_table_listview.Items.Clear();

            try
            {
                string Item_Id = Item_ID_box.Text.ToString();
                string Parts_Name = Part_Name_Box.Text.ToString();
                string Colour = Colour_box.Text.ToString();
                string Description = Description_box.Text.ToString();

                if (Item_ID_box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Primary Key cannot be null", "Warning");
                    return;
                }
                if (Part_Name_Box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Name of Parts cannot be null", "Warning");
                    return;
                }
                if (Colour_box.Text.Length == 0)
                {
                    Colour = "Unknown";
                }
                if (Description_box.Text.Length == 0)
                {
                    Description = "Unknown";
                }
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();

                string sql = @"INSERT INTO `arnolda_8723388`.`parts` (`Part_Name`, `Colour`, `Descriptions`, `Item_ID`) VALUES('" + Parts_Name + "', '" + Colour + "', '" + Description + "', '" + Item_Id + "');";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                sql = "select * from parts";
                MySqlCommand cmd_2 = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd_2.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[4];
                    _Item[0] = (string)reader["Part_Name"].ToString();
                    _Item[1] = (string)reader["Colour"].ToString();
                    _Item[2] = (string)reader["Descriptions"].ToString();
                    _Item[3] = (string)reader["Item_ID"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Parts_table_listview.Items.Add(items);
                }
                MessageBox.Show("Added Suscessfully", "Message");
                Item_ID_box.Clear();
                Part_Name_Box.Clear();
                Colour_box.Clear();
                Description_box.Clear();
                con.Close();

                Count_Item_Function("customer");
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
