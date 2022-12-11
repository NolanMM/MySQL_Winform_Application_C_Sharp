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
    public partial class Add_Item_Item_UC : UserControl
    {
        public Add_Item_Item_UC()
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
        private void Add_Item_Item_UC_Load(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
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
                Count_Item_Function("item");
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
            Items_listview.Items.Clear();
            try
            {
                string Item_Id = Item_ID_box.Text.ToString();
                string Description = Description_box.Text.ToString();
                string Colour = Colour_box.Text.ToString();
                string Size = Size_box.Text.ToString();
                string Type = Type_Box.Text.ToString();
                string Order_Item = Order_Item_Box.Text.ToString();
                string Supply_ID = Supply_ID_Box.Text.ToString();


                if (Item_ID_box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Primary Key cannot be null", "Warning");
                    return;
                }
                if (Description_box.Text.Length == 0)
                {
                    Description = "Unknown";
                }
                if (Colour_box.Text.Length == 0)
                {
                    Colour = "Unknown";
                }
                if (Size_box.Text.Length == 0)
                {
                    Size = "Unknown";
                }
                if (Type_Box.Text.Length == 0)
                {
                    Type = "Unknown";
                }
                if (Order_Item_Box.Text.Length == 0)
                {
                    Order_Item = "Unknown";
                }
                if (Supply_ID_Box.Text.Length == 0)
                {
                    Supply_ID = "Unknown";
                }
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();

                string sql = @"INSERT INTO `arnolda_8723388`.`item` (`Item_ID`, `Description`, `Colour`, `Size`, `Type`, `Order_Item_ID`, `Supply_ID`) VALUES('" + Item_Id + "', '" + Description + "', '" + Colour + "', '" + Size + "', '" + Type + "', '" + Order_Item + "', '" + Supply_ID + "');";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                sql = "select * from item";
                MySqlCommand cmd_2 = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd_2.ExecuteReader();
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
                MessageBox.Show("Added Suscessfully", "Message");
                Item_ID_box.Clear();
                Description_box.Clear();
                Colour_box.Clear();
                Size_box.Clear();
                Type_Box.Clear();
                Order_Item_Box.Clear();
                Supply_ID_Box.Clear();
                con.Close();

                Count_Item_Function("item");
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
