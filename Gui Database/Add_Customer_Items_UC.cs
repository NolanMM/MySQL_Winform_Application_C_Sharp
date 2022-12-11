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
    public partial class Add_Customer_Items_UC : UserControl
    {
        public Add_Customer_Items_UC()
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
        private void Add_Customer_Items_UC_Load(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
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
                Count_Item_Function("customer");
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
            Customer_table_listview.Items.Clear();


            try
            {
                int telephone_Unknow = 0;
                string Customer_Id = Customer_ID_box.Text.ToString();
                string Name_customer = Name_Customer_Box.Text.ToString();
                string Address = Address_box.Text.ToString();
                string City = City_box.Text.ToString();
                string State = Province_State_box.Text.ToString();
                string Zip_Code = Postal_Zip_Code_box.Text.ToString();
                string Telephone = Telephone_box.Text.ToString();
                string Birth = Date_Of_birth_box.Text.ToString();
                string Primary_Language = Primary_Language_box.Text.ToString();
                string Branch_ID = Branch_ID_box.Text.ToString();

                if (Customer_ID_box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Primary Key cannot be null", "Warning");
                    return;
                }
                if (Name_Customer_Box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Name of Customer cannot be null", "Warning");
                    return;
                }
                if (Address_box.Text.Length == 0)
                {
                    Address = "Unknowm";
                }
                if (City_box.Text.Length == 0)
                {
                    City = "Unknowm";
                }
                if (Province_State_box.Text.Length == 0)
                {
                    State = "Unknowm";
                }
                if (Postal_Zip_Code_box.Text.Length == 0)
                {
                    Zip_Code = "Unknowm";
                }
                if (Primary_Language_box.Text.Length == 0)
                {
                    Primary_Language = "Unknowm";
                }
                if (Branch_ID_box.Text.Length == 0)
                {
                    Branch_ID = "Unknowm";
                }
                if (Telephone_box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Telephone cannot be null", "Warning");
                    return;
                }
                else
                {
                    bool flag = false;
                    flag = Int32.TryParse(Telephone_box.Text, out int result);
                    if (flag == true)
                    {
                        telephone_Unknow = result;
                    }
                    else { MessageBox.Show("Error, Wrong Format for Payment Amount. Please Enter Integer", "Warning"); return; }
                }
                if (Date_Of_birth_box.Text.Length != 0)
                {
                    int[] result = new int[3];
                    bool flag = false;
                    string[] result_Split = Date_Of_birth_box.Text.Split('-');
                    for (int i = 0; i < 3; i++)
                    {
                        flag = Int32.TryParse(result_Split[i], out result[i]);
                    }
                    bool final_flag = false;

                    if (flag == true && result[0] < 2023)
                    {
                        final_flag = true;
                    }
                    else { final_flag = false; }

                    if (final_flag == true && result[1] < 12)
                    {
                        final_flag = true;
                    }
                    else { MessageBox.Show("Error, Wrong Format for Datetime. Format must be DD-MM-YYYY", "Warning"); return; }

                    if (final_flag == true && result[2] < 31)
                    {
                        final_flag = true;
                    }
                    else { MessageBox.Show("Error, Wrong Format for Datetime. Format must be DD-MM-YYYY", "Warning"); return; }
                    if (final_flag == true)
                    {
                        Birth = Date_Of_birth_box.Text + " 00:00:00";
                    }
                }
                else { Birth = "NULL"; }
                
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();

                string sql = @"INSERT INTO `arnolda_8723388`.`customer` (`Customer_ID`, `Name_Customer`, `Address`, `City`,`Province/State`,`Postal/Zip Code`,`Telephone`,`DateofBirth`,`Primary Language`,`Branch_ID`) VALUES('" + Customer_Id + "', '" + Name_customer + "', '" + Address + "', '" + City + "', '" + State + "', '" + Zip_Code + "', '" + telephone_Unknow + "', '" + Birth + "', '" + Primary_Language + "', '" + Branch_ID + "');";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                sql = "select * from customer";
                MySqlCommand cmd_2 = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd_2.ExecuteReader();
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
                MessageBox.Show("Added Suscessfully", "Message");

                Customer_ID_box.Clear();
                Name_Customer_Box.Clear();
                Address_box.Clear();
                City_box.Clear();
                Province_State_box.Clear();
                Postal_Zip_Code_box.Clear();
                Telephone_box.Clear();
                Date_Of_birth_box.Clear();
                Primary_Language_box.Clear();
                Branch_ID_box.Clear();

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
