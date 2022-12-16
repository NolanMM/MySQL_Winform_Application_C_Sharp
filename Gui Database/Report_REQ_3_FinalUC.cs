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
    public partial class Report_REQ_3_FinalUC : UserControl
    {
        public Report_REQ_3_FinalUC()
        {
            InitializeComponent();
        }
        string connstring = "server=localhost;uid=root;pwd=Connhenbeo1;database=arnolda_8723388";

        private void Show_Account_table_list_Click(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            int count = 0;
            int total_sale_all_order = 0;
            REQ3_listview.Items.Clear();
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //MessageBox.Show("connected Suscessfully", "Message");
                string sql = "SELECT orders.Order_ID, item_order_list.Order_Item_ID, SUM(item.Price * item_order_list.Number_Of_Item) AS 'Total Sales',AVG(item.Price * item_order_list.Number_Of_Item) AS 'Average Order Price' FROM orders INNER JOIN item_order_list ON orders.Order_ID = item_order_list.Order_ID INNER JOIN item ON item_order_list.Item_Name = item.Item_ID GROUP BY orders.Order_ID;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[4];
                    _Item[0] = (string)reader["Order_ID"].ToString();
                    _Item[1] = (string)reader["Order_Item_ID"].ToString();
                    _Item[2] = (string)reader["Total Sales"].ToString();
                    _Item[3] = (string)reader["Average Order Price"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    REQ3_listview.Items.Add(items);
                    count++;
                    bool isParsable = Int32.TryParse(_Item[2], out int number);
                    if(isParsable == true)
                    {
                        total_sale_all_order += number;
                    }
                }

                con.Close();
                Count_Item_box.Text = count.ToString();
                Total_Sale_Order_box.Text = total_sale_all_order.ToString();
                watch.Stop();
                Time_Execute_box.Text = watch.Elapsed.ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
