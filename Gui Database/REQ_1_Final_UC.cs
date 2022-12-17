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
    public partial class REQ_1_Final_UC : UserControl
    {
        public REQ_1_Final_UC()
        {
            InitializeComponent();
        }
        string connstring = "server=localhost;uid=root;pwd=Connhenbeo1;database=arnolda_8723388";

        private void Show_Account_table_list_Click(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            int count = 0;
            REQ1_listview.Items.Clear();
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //MessageBox.Show("connected Suscessfully", "Message");
                string sql = "SELECT customer.Name_Customer, orders.Order_ID, item.Item_ID, parts.Part_Name FROM customer,orders,parts,item_order_list,item  WHERE customer.Customer_ID = orders.Customer_ID AND  orders.Order_ID = item_order_list.Order_ID AND item_order_list.Order_Item_ID = item.Order_Item_ID AND item.Item_ID = parts.Item_ID;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[4];
                    _Item[0] = (string)reader["Name_Customer"].ToString();
                    _Item[1] = (string)reader["Order_ID"].ToString();
                    _Item[2] = (string)reader["Item_ID"].ToString();
                    _Item[3] = (string)reader["Part_Name"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    REQ1_listview.Items.Add(items);
                    count++;
                }

                con.Close();
                Count_Item_box.Text = count.ToString();
                watch.Stop();
                Time_Execute_box.Text = watch.Elapsed.ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            REQ1_listview.Items.Clear();
        }
    }
}
