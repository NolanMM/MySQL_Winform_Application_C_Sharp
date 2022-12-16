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
    public partial class Report_REQ_4_FinalUC : UserControl
    {
        public Report_REQ_4_FinalUC()
        {
            InitializeComponent();
        }
        string connstring = "server=localhost;uid=root;pwd=Connhenbeo1;database=arnolda_8723388";

        private void Show_List_Group_By_btn_Click(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            int count = 0;
            int total_sale_all_order = 0;
            REQ4_listview_Group_By.Items.Clear();
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //MessageBox.Show("connected Suscessfully", "Message");
                string sql = "SELECT employee.Name_Employee,skills.Skills FROM employee,skills GROUP BY skills.Skills,employee.Name_Employee;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[2];
                    _Item[0] = (string)reader["Name_Employee"].ToString();
                    _Item[1] = (string)reader["Skills"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    REQ4_listview_Group_By.Items.Add(items);
                    count++;
                }
                con.Close();
                Count_Item_box.Text = count.ToString();
                REQ4_listview_Group_By.Text = total_sale_all_order.ToString();
                watch.Stop();
                Time_Execute_box.Text = watch.Elapsed.ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Show_List_Having_Function_btn_Click(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            int count = 0;
            int total_sale_all_order = 0;
            REQ4_listview_Having.Items.Clear();
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //MessageBox.Show("connected Suscessfully", "Message");
                string sql = "SELECT employee.Name_Employee,skills.Skills FROM employee,skills GROUP BY skills.Skills,employee.Name_Employee HAVING skills.Skills = \"C++\";";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[2];
                    _Item[0] = (string)reader["Name_Employee"].ToString();
                    _Item[1] = (string)reader["Skills"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    REQ4_listview_Having.Items.Add(items);
                    count++;
                }
                con.Close();
                Count_Item_box.Text = count.ToString();
                REQ4_listview_Having.Text = total_sale_all_order.ToString();
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
            REQ4_listview_Having.Items.Clear();
            REQ4_listview_Group_By.Items.Clear();
        }
    }
}
