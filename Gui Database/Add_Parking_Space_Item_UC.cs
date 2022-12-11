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
    public partial class Add_Parking_Space_Item_UC : UserControl
    {
        public Add_Parking_Space_Item_UC()
        {
            InitializeComponent();
        }
        string connstring = "server=localhost;uid=root;pwd=Connhenbeo1;database=arnolda_8723388";

        private void Add_Parking_Space_Item_UC_Load(object sender, EventArgs e)
        {
            Parking_Space_table_listview.Items.Clear();

            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //MessageBox.Show("connected Suscessfully", "Message");
                string sql = "select * from parking_space";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[3];
                    _Item[0] = (string)reader["ParkingSpace_ID"].ToString();
                    _Item[1] = (string)reader["Location_Parking_Space"].ToString();
                    _Item[2] = (string)reader["Employee_ID"].ToString();

                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Parking_Space_table_listview.Items.Add(items);
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
                string Space_Parking_Id = Parking_Space_ID_box.Text.ToString();
                string Location = Location_Box.Text.ToString();
                string Employee_Id = Employee_ID_Box.Text.ToString();

                if (Parking_Space_ID_box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Primary Key cannot be null", "Warning");
                    return;
                }
                if (Location_Box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Name of Location cannot be null", "Warning");
                    return;
                }
                if (Employee_ID_Box.Text.Length == 0)
                {
                    Employee_Id = "Unknown";
                }
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();

                string sql = @"INSERT INTO `arnolda_8723388`.`parking_space` (`ParkingSpace_ID`, `Location_Parking_Space`, `Employee_ID`) VALUES('" + Space_Parking_Id + "', '" + Location + "', '" + Employee_Id + "');";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                sql = "select * from parking_space";
                MySqlCommand cmd_2 = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd_2.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[3];
                    _Item[0] = (string)reader["ParkingSpace_ID"].ToString();
                    _Item[1] = (string)reader["Location_Parking_Space"].ToString();
                    _Item[2] = (string)reader["Employee_ID"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Parking_Space_table_listview.Items.Add(items);
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
