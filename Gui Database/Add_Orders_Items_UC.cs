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
    public partial class Add_Orders_Items_UC : UserControl
    {
        public Add_Orders_Items_UC()
        {
            InitializeComponent();
        }
        string connstring = "server=localhost;uid=root;pwd=Connhenbeo1;database=arnolda_8723388";

        private void Add_Orders_Items_UC_Load(object sender, EventArgs e)
        {
            Order_table_listview.Items.Clear();

            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //MessageBox.Show("connected Suscessfully", "Message");
                string sql = "select * from orders";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[5];
                    _Item[0] = (string)reader["Order_ID"].ToString();
                    _Item[1] = (string)reader["OrderDate"].ToString();
                    _Item[2] = (string)reader["CreditAuthorizationStatus"].ToString();
                    _Item[3] = (string)reader["Branch_ID"].ToString();
                    _Item[4] = (string)reader["Customer_ID"].ToString();


                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Order_table_listview.Items.Add(items);
                }
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string Orders_Id = Order_ID_box.Text.ToString();
                string Order_date = Order_Date_Box.Text.ToString();
                string Credit_Status = Credit_box.Text.ToString();
                string Branch_ID = Branch_ID_box.Text.ToString();
                string Customer_ID = Customer_ID_Box.Text.ToString();

                if (Order_ID_box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Primary Key cannot be null", "Warning");
                    return;
                }
                if (Credit_box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Credit Authorization Status cannot be null", "Warning");
                    return;
                }
                if (Order_Date_Box.Text.Length == 0)
                {
                    Order_date = "NULL";
                }
                if (Order_Date_Box.Text.Length != 0)
                {
                    int[] result = new int[3];
                    bool flag = false;
                    string[] result_Split = Order_Date_Box.Text.Split('-');
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
                        Order_date = Order_Date_Box.Text + " 00:00:00";
                    }
                }
                if (Branch_ID_box.Text.Length == 0)
                {
                    Branch_ID = "Unknown";
                }
                if (Customer_ID_Box.Text.Length == 0)
                {
                    Customer_ID = "Unknown";
                }
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();

                string sql = @"INSERT INTO `arnolda_8723388`.`orders` (`Order_ID`, `OrderDate`, `CreditAuthorizationStatus`, `Branch_ID`,`Customer_ID`) VALUES('" + Orders_Id + "', '" + Order_date + "', '" + Credit_Status + "', '" + Branch_ID + "', '" + Customer_ID + "');";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                sql = "select * from orders";
                MySqlCommand cmd_2 = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd_2.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[5];
                    _Item[0] = (string)reader["Order_ID"].ToString();
                    _Item[1] = (string)reader["OrderDate"].ToString();
                    _Item[2] = (string)reader["CreditAuthorizationStatus"].ToString();
                    _Item[3] = (string)reader["Branch_ID"].ToString();
                    _Item[4] = (string)reader["Customer_ID"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Order_table_listview.Items.Add(items);
                }
                MessageBox.Show("Added Suscessfully", "Message");

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
