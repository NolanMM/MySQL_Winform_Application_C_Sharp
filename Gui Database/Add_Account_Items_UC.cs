using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Gui_Database
{
    public partial class Add_Account_Items_UC : UserControl
    {
        public Add_Account_Items_UC()
        {
            InitializeComponent();
        }
        string connstring = "server=localhost;uid=root;pwd=Connhenbeo1;database=arnolda_8723388";

        private void Add_Account_Items_UC_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //MessageBox.Show("connected Suscessfully", "Message");
                string sql = "select * from accounts";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[4];
                    _Item[0] = (string)reader["AccountNumber"].ToString();
                    _Item[1] = (string)reader["PaymentDate"].ToString();
                    _Item[2] = (string)reader["PaymentAmount"].ToString();
                    _Item[3] = (string)reader["Customer_ID"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Account_table_listview.Items.Add(items);
                }

                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Show_Account_table_list_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //MessageBox.Show("connected Suscessfully", "Message");
                string sql = "select * from accounts";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[4];
                    _Item[0] = (string)reader["AccountNumber"].ToString();
                    _Item[1] = (string)reader["PaymentDate"].ToString();
                    _Item[2] = (string)reader["PaymentAmount"].ToString();
                    _Item[3] = (string)reader["Customer_ID"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Account_table_listview.Items.Add(items);
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
                DateTime date2 = new DateTime(2022, 11, 01, 00, 00, 00);
                string payment_date = Payment_Date.Text.ToString();
                string account_number = Account_number_box.Text.ToString();
                string payment_amount = Payment_amount_box.Text.ToString();
                string customer_id = Customer_ID_Box.Text.ToString();
                if (Account_number_box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Primary Key cannot be null", "Warning");
                    return;
                }
                if (Payment_Date.Text.Length == 0)
                {
                    payment_date = "NULL";
                }
                if (Payment_Date.Text.Length != 0)
                {
                    int[] result = new int[3];
                    bool flag = false;
                    string[] result_Split = Payment_Date.Text.Split('-');
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
                    if(final_flag == true)
                    {
                        payment_date = Payment_Date.Text + " 00:00:00";
                    }
                }
                if (Payment_amount_box.Text.Length == 0)
                {

                    payment_amount = "Unknown";
                }
                else { 
                    bool flag = false;
                    flag = Int32.TryParse(Payment_amount_box.Text, out int result);
                    if(flag == true)
                    {
                        payment_amount = Payment_amount_box.Text;
                    }
                    else { MessageBox.Show("Error, Wrong Format for Payment Amount. Please Enter Integer", "Warning"); return; }
                }
                if (Customer_ID_Box.Text.Length == 0)
                {
                    customer_id = "Unknown";
                }
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //"INSERT INTO `arnolda_8723388`.`accounts` (`AccountNumber`, `PaymentDate`, `PaymentAmount`, `Customer_ID`) VALUES('"+2828282282+"', '"+2021-09-28 00:00:00+"', '"+2134+"', '"+CBA321+"');";
                //MessageBox.Show("connected Suscessfully", "Message");
                string sql = @"INSERT INTO `arnolda_8723388`.`accounts` (`AccountNumber`, `PaymentDate`, `PaymentAmount`, `Customer_ID`) VALUES('" + account_number + "', '" + payment_date + "', '" + payment_amount + "', '" + customer_id + "');";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                
                cmd.ExecuteNonQuery();
                sql = "select * from accounts";
                MySqlCommand cmd_2 = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd_2.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[4];
                    _Item[0] = (string)reader["AccountNumber"].ToString();
                    _Item[1] = (string)reader["PaymentDate"].ToString();
                    _Item[2] = (string)reader["PaymentAmount"].ToString();
                    _Item[3] = (string)reader["Customer_ID"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Account_table_listview.Items.Add(items);
                }
                MessageBox.Show("connected Suscessfully", "Message");

                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
