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
    public partial class Add_Employee_Item_UC : UserControl
    {
        public Add_Employee_Item_UC()
        {
            InitializeComponent();
        }
        string connstring = "server=localhost;uid=root;pwd=Connhenbeo1;database=arnolda_8723388";

        private void Add_Employee_Item_UC_Load(object sender, EventArgs e)
        {
            Employee_table_listview.Items.Clear();

            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                //MessageBox.Show("connected Suscessfully", "Message");
                string sql = "select * from employee";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[12];
                    _Item[0] = (string)reader["Employee_ID"].ToString();
                    _Item[1] = (string)reader["Name_Employee"].ToString();
                    _Item[2] = (string)reader["Address"].ToString();
                    _Item[3] = (string)reader["City"].ToString();
                    _Item[4] = (string)reader["Province"].ToString();
                    _Item[5] = (string)reader["Postal Code"].ToString();
                    _Item[6] = (string)reader["Telephone"].ToString();
                    _Item[7] = (string)reader["Date_of_Hire"].ToString();
                    _Item[8] = (string)reader["Salary"].ToString();
                    _Item[9] = (string)reader["Title"].ToString();
                    _Item[10] = (string)reader["Age"].ToString();
                    _Item[11] = (string)reader["Branch_ID"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Employee_table_listview.Items.Add(items);
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
                
                string Employee_Id = Employee_ID_box.Text.ToString();
                string Name_Employee = Name_Employee_Box.Text.ToString();
                string Address = Address_box.Text.ToString();
                string City = City_box.Text.ToString();
                string State = Province_State_box.Text.ToString();
                string Zip_Code = Postal_Zip_Code_box.Text.ToString();
                string Telephone = Telephone_box.Text.ToString();
                int telephone_Unknow = 0;
                string Hire = Date_Of_Hire_box.Text.ToString();
                string Salary = Telephone_box.Text.ToString();
                int Salary_unknow = 0;
                string Age = Age_box.Text.ToString();
                int Age_unknowns = 0;
                string Title = Title_box.Text.ToString();
                string Branch_ID = Branch_ID_box.Text.ToString();

                if (Employee_ID_box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Primary Key cannot be null", "Warning");
                    return;
                }
                if (Name_Employee_Box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Name of Employee cannot be null", "Warning");
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
                if (Title_box.Text.Length == 0)
                {
                    Title = "Unknowm";
                }
                if (Branch_ID_box.Text.Length == 0)
                {
                    Branch_ID = "Unknowm";
                }
                if (Age_box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Telephone cannot be null", "Warning");
                    return;
                }
                else
                {
                    bool flag = false;
                    flag = Int32.TryParse(Age_box.Text, out int result_Age);
                    if (flag == true && result_Age<70)
                    {
                        Age_unknowns = result_Age;
                    }
                    else { MessageBox.Show("Error, Wrong Format for Salary Input. Please Enter Integer", "Warning"); return; }
                }
                if (Salary_box.Text.Length == 0)
                {
                    MessageBox.Show("Error, Telephone cannot be null", "Warning");
                    return;
                }
                else
                {
                    bool flag = false;
                    flag = Int32.TryParse(Salary_box.Text, out int result_salary);
                    if (flag == true)
                    {
                        Salary_unknow = result_salary;
                    }
                    else { MessageBox.Show("Error, Wrong Format for Salary Input. Please Enter Integer", "Warning"); return; }
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
                if (Date_Of_Hire_box.Text.Length != 0)
                {
                    int[] result = new int[3];
                    bool flag = false;
                    string[] result_Split = Date_Of_Hire_box.Text.Split('-');
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
                        Hire = Date_Of_Hire_box.Text + " 00:00:00";
                    }
                }
                else { MessageBox.Show("Error, Hire Date cannot be null. Format must be DD-MM-YYYY", "Warning"); }

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();


                string sql = @"INSERT INTO `arnolda_8723388`.`employee` (`Employee_ID`, `Name_Employee`, `Address`, `City`,`Province`,`Postal Code`,`Telephone`,`Date_of_Hire`,`Salary`,`Title`,`Age`,`Branch_ID`) VALUES('" 
                + Employee_Id + "', '" + Name_Employee + "', '" + Address + "', '" + City + "', '" + State + "', '" + Zip_Code + "', '" + telephone_Unknow + "', '" + Hire + "', '" + Salary_unknow + "', '" + Title + "', '" + Age_unknowns + "', '" + Branch_ID + "');";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                sql = "select * from employee";
                MySqlCommand cmd_2 = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd_2.ExecuteReader();
                while (reader.Read())
                {
                    string[] _Item = new string[12];
                    _Item[0] = (string)reader["Employee_ID"].ToString();
                    _Item[1] = (string)reader["Name_Employee"].ToString();
                    _Item[2] = (string)reader["Address"].ToString();
                    _Item[3] = (string)reader["City"].ToString();
                    _Item[4] = (string)reader["Province"].ToString();
                    _Item[5] = (string)reader["Postal Code"].ToString();
                    _Item[6] = (string)reader["Telephone"].ToString();
                    _Item[7] = (string)reader["Date_of_Hire"].ToString();
                    _Item[8] = (string)reader["Salary"].ToString();
                    _Item[9] = (string)reader["Title"].ToString();
                    _Item[10] = (string)reader["Age"].ToString();
                    _Item[11] = (string)reader["Branch_ID"].ToString();
                    //MessageBox.Show("Account Number: " + reader["AccountNumber"] + " Payment Date " + reader["PaymentDate"]);
                    ListViewItem items = new ListViewItem(_Item);
                    Employee_table_listview.Items.Add(items);
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
