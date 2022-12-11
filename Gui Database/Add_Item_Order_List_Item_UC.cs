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
    public partial class Add_Item_Order_List_Item_UC : UserControl
    {
        public Add_Item_Order_List_Item_UC()
        {
            InitializeComponent();
        }
        string connstring = "server=localhost;uid=root;pwd=Connhenbeo1;database=arnolda_8723388";

        private void Add_Item_Order_List_Item_UC_Load(object sender, EventArgs e)
        {
            Item_List_Order_listview.Items.Clear();

            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //MessageBox.Show("connected Suscessfully", "Message");
                string sql = "select * from item_order_list";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[6];
                    _Item[0] = (string)reader["Order_Item_ID"].ToString();
                    _Item[1] = (string)reader["Item_Name"].ToString();
                    _Item[2] = (string)reader["Number_Of_Item"].ToString();
                    _Item[3] = (string)reader["Date_Payment"].ToString();
                    _Item[4] = (string)reader["Date_Shipment"].ToString();
                    _Item[5] = (string)reader["Order_ID"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Item_List_Order_listview.Items.Add(items);
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
                string Order_Item_ID_Id = Order_Item_ID_box.Text.ToString();
                string Item_Name = Item_Name_box.Text.ToString();
                int Number_of_items = 0;
                string Date_Payment = Date_Payment_box.Text.ToString();
                string Date_Shipment = Date_Shipment_box.Text.ToString();
                string Order_ID = Order_ID_box.Text.ToString();

                if (Order_Item_ID_box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Primary Key cannot be null", "Warning");
                    return;
                }
                if (Item_Name_box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Name of Item cannot be null", "Warning");
                    return;
                }
                if (Date_Payment_box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Date of Payment cannot be null", "Warning");
                    return;
                }
                if (Number_of_item_box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Number of items cannot be null", "Warning");
                    return;
                }
                else {
                    bool flag = false;
                    flag = Int32.TryParse(Number_of_item_box.Text, out int result);
                    if (flag == true)
                    {
                        Number_of_items = result;
                    }
                    else { MessageBox.Show("Error, Wrong Format for Payment Amount. Please Enter Integer", "Warning"); return; }
                }
                if (Date_Payment_box.Text.Length != 0)
                {
                    int[] result = new int[3];
                    bool flag = false;
                    string[] result_Split = Date_Payment_box.Text.Split('-');
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
                        Date_Payment = Date_Payment_box.Text + " 00:00:00";
                    }
                }
                if (Date_Shipment_box.Text.Length != 0)
                {
                    int[] result = new int[3];
                    bool flag = false;
                    string[] result_Split = Date_Shipment_box.Text.Split('-');
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
                        Date_Shipment = Date_Shipment_box.Text + " 00:00:00";
                    }
                }
                if (Order_ID_box.Text.Length == 0)
                {
                    Order_ID = "Unknown";
                }
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();

                string sql = @"INSERT INTO `arnolda_8723388`.`item_order_list` (`Order_Item_ID`, `Item_Name`, `Number_Of_Item`, `Date_Payment`,`Date_Shipment`,`Order_ID`) VALUES('" + Order_Item_ID_Id + "', '" + Item_Name + "', '" + Number_of_items + "', '" + Date_Payment + "', '" + Date_Shipment + "', '" + Order_ID + "');";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                sql = "select * from item_order_list";
                MySqlCommand cmd_2 = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd_2.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[6];
                    _Item[0] = (string)reader["Order_Item_ID"].ToString();
                    _Item[1] = (string)reader["Item_Name"].ToString();
                    _Item[2] = (string)reader["Number_Of_Item"].ToString();
                    _Item[3] = (string)reader["Date_Payment"].ToString();
                    _Item[4] = (string)reader["Date_Shipment"].ToString();
                    _Item[5] = (string)reader["Order_ID"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Item_List_Order_listview.Items.Add(items);
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
