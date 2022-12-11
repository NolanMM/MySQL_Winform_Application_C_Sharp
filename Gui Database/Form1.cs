using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Gui_Database
{

    public partial class Form1 : Form
    {

        string connstring = "server=localhost;uid=root;pwd=Connhenbeo1;database=arnolda_8723388";
        public Form1()
        {
            InitializeComponent();
            CustomizeDes();
        }

        private void CustomizeDes()
        {
            Show_The_List_Table_Panel.Visible = false;
            SideMenuPanel.Visible = false;
        }

        private void hideMenu()
        {
            if (Show_The_List_Table_Panel.Visible == true)
                Show_The_List_Table_Panel.Visible = false;
            if (SideMenuPanel.Visible == true)
                SideMenuPanel.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideMenu();
                subMenu.Visible = true;
            }
            else { subMenu.Visible = false; }
        }
        private void Show_List_table_btn_Click(object sender, EventArgs e)
        {
            showSubMenu(Show_The_List_Table_Panel);
        }
        private void Input_tables_btn_Click(object sender, EventArgs e)
        {
            showSubMenu(SideMenuPanel);
        }
        private void movesidepanel_Show(Button btn)
        {
            sidepanel_Show.Top = btn.Top;
            sidepanel_Show.Height = btn.Height;
        }
        private void moveSidepanel_input(Button btn)
        {
            Sidepanel_input.Top = btn.Top;
            Sidepanel_input.Height = btn.Height;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void addUC(UserControl uc)
        {
            panelcenter.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelcenter.Controls.Clear();
            panelcenter.Controls.Add(uc);
        }

        private void Branch_table_btn_Click(object sender, EventArgs e)
        {
            branch_Table_UC UCbranch_show = new branch_Table_UC();
            addUC(UCbranch_show);
            movesidepanel_Show(Branch_table_btn);
        }

        private void Order_table_btn_Click(object sender, EventArgs e)
        {
            Order_UC UCOrder_show = new Order_UC();
            addUC(UCOrder_show);
            movesidepanel_Show(Order_table_btn);
        }

        private void Item_orderlist_table_btn_Click(object sender, EventArgs e)
        {
            Item_Order_List_UC UCOrder_List_show = new Item_Order_List_UC();
            addUC(UCOrder_List_show);
            movesidepanel_Show(Item_orderlist_table_btn);
        }

        private void List_account_table_btn_Click(object sender, EventArgs e)
        {
            Accounts_Table_Uc UCAccount_list_show = new Accounts_Table_Uc();
            addUC(UCAccount_list_show);
            movesidepanel_Show(List_account_table_btn);
        }

        private void Customer_table_btn_Click(object sender, EventArgs e)
        {
            Customer_UC UCCustomer_table_show = new Customer_UC();
            addUC(UCCustomer_table_show);
            movesidepanel_Show(Customer_table_btn);
        }

        private void Parking_Space_List_btn_Click(object sender, EventArgs e)
        {
            Parking_Space_UC UCParking_Space_show = new Parking_Space_UC();
            addUC(UCParking_Space_show);
            movesidepanel_Show(Parking_Space_List_btn);
        }

        private void Items_List_table_btn_Click(object sender, EventArgs e)
        {
            New_Item_UC UCItem_show = new New_Item_UC();
            addUC(UCItem_show);
            movesidepanel_Show(Items_List_table_btn);
        }

        private void Parts_List_btn_Click(object sender, EventArgs e)
        {
            Parts_UC UCParts_show = new Parts_UC();
            addUC(UCParts_show);
            movesidepanel_Show(Parts_List_btn);
        }

        private void Emplyee_List_table_btn_Click(object sender, EventArgs e)
        {
            Employee_UC UCEmployee_show = new Employee_UC();
            addUC(UCEmployee_show);
            movesidepanel_Show(Emplyee_List_table_btn);
        }

        private void Supply_List_Table_Click(object sender, EventArgs e)
        {
            Supply_Uc UCSupply_show = new Supply_Uc();
            addUC(UCSupply_show);
            movesidepanel_Show(Supply_List_Table);
        }

        private void Add_branch_table_btn_Click(object sender, EventArgs e)
        {
            moveSidepanel_input(Add_branch_table_btn);
        }

        private void Add_orders_table_btn_Click(object sender, EventArgs e)
        {
            moveSidepanel_input(Add_orders_table_btn);
        }

        private void Add_Item_Order_List_table_btn_Click(object sender, EventArgs e)
        {
            moveSidepanel_input(Add_Item_Order_List_table_btn);
        }

        private void Add_Account_Table_btn_Click(object sender, EventArgs e)
        {
            moveSidepanel_input(Add_Account_Table_btn);
        }

        private void Add_Customer_table_btn_Click(object sender, EventArgs e)
        {
            moveSidepanel_input(Add_Customer_table_btn);
        }

        private void Add_Parking_Space_Table_btn_Click(object sender, EventArgs e)
        {
            moveSidepanel_input(Add_Parking_Space_Table_btn);
        }

        private void Add_Items_btn_Click(object sender, EventArgs e)
        {
            moveSidepanel_input(Add_Items_btn);
        }

        private void Add_Parts_Table_btn_Click(object sender, EventArgs e)
        {
            moveSidepanel_input(Add_Parts_Table_btn);
        }

        private void Add_Employee_Table_btn_Click(object sender, EventArgs e)
        {
            moveSidepanel_input(Add_Employee_Table_btn);
        }

        private void Add_Supply_Table_btn_Click(object sender, EventArgs e)
        {
            moveSidepanel_input(Add_Supply_Table_btn);
        }
    }
}
