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
    public partial class Add_Skills_UC : UserControl
    {
        public Add_Skills_UC()
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
        private void Add_Skills_UC_Load(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Skills_table_listview.Items.Clear();
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //MessageBox.Show("connected Suscessfully", "Message");
                string sql = "select * from skills";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[2];
                    _Item[0] = (string)reader["Employee_ID"].ToString();
                    _Item[1] = (string)reader["Skills"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Skills_table_listview.Items.Add(items);
                }

                con.Close();
                Count_Item_Function("skills");
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
            Skills_table_listview.Items.Clear();

            //Account_table_listview.Clear();
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            try
            {
                string Employee_ID = Employee_box.Text.ToString();
                string Skills = Skills_box.Text.ToString();

                if (Employee_box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Employee_ID cannot be null", "Warning");
                    return;
                }
                if (Skills_box.Text.Length == 0)
                {
                    Skills = "NULL";
                }
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //"INSERT INTO `arnolda_8723388`.`accounts` (`AccountNumber`, `PaymentDate`, `PaymentAmount`, `Customer_ID`) VALUES('"+2828282282+"', '"+2021-09-28 00:00:00+"', '"+2134+"', '"+CBA321+"');";
                //MessageBox.Show("connected Suscessfully", "Message");
                string sql = @"INSERT INTO `arnolda_8723388`.`skills` (`Employee_ID`, `Skills`) VALUES('" + Employee_ID + "', '" + Skills + "');";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.ExecuteNonQuery();
                sql = "select * from skills";
                MySqlCommand cmd_2 = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd_2.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[2];
                    _Item[0] = (string)reader["Employee_ID"].ToString();
                    _Item[1] = (string)reader["Skills"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Skills_table_listview.Items.Add(items);
                }
                //MessageBox.Show("connected Suscessfully", "Message");
                Employee_box.Clear();
                Skills_box.Clear();
                con.Close();

                Count_Item_Function("skills");
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
