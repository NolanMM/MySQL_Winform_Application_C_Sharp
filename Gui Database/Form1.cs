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
            if (SidePanel_Reports_panel.Visible == true)
                SidePanel_Reports_panel.Visible = false;
            
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
        private void moveSidepanel_report(Button btn)
        {
            Side_menu_run_Report_panel.Top = btn.Top;
            Side_menu_run_Report_panel.Height = btn.Height;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (SidePanel_Reports_panel.Visible == true)
                SidePanel_Reports_panel.Visible = false;
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
            Add_Branches_Items_UC UCBranch_Add = new Add_Branches_Items_UC();
            addUC(UCBranch_Add);
            moveSidepanel_input(Add_branch_table_btn);
        }

        private void Add_orders_table_btn_Click(object sender, EventArgs e)
        {
            Add_Orders_Items_UC UCOrder_Add = new Add_Orders_Items_UC();
            addUC(UCOrder_Add);
            moveSidepanel_input(Add_orders_table_btn);
        }

        private void Add_Item_Order_List_table_btn_Click(object sender, EventArgs e)
        {
            Add_Item_Order_List_Item_UC UCList_Item_Add = new Add_Item_Order_List_Item_UC();
            addUC(UCList_Item_Add);
            moveSidepanel_input(Add_Item_Order_List_table_btn);
        }

        private void Add_Account_Table_btn_Click(object sender, EventArgs e)
        {
            Add_Account_Items_UC UCSAccount_Add = new Add_Account_Items_UC();
            addUC(UCSAccount_Add);
            moveSidepanel_input(Add_Account_Table_btn);
        }

        private void Add_Customer_table_btn_Click(object sender, EventArgs e)
        {
            Add_Customer_Items_UC UCCustomer_Add = new Add_Customer_Items_UC();
            addUC(UCCustomer_Add);
            moveSidepanel_input(Add_Customer_table_btn);
        }

        private void Add_Parking_Space_Table_btn_Click(object sender, EventArgs e)
        {
            Add_Parking_Space_Item_UC UCParking_Space_Add = new Add_Parking_Space_Item_UC();
            addUC(UCParking_Space_Add);
            moveSidepanel_input(Add_Parking_Space_Table_btn);
        }

        private void Add_Items_btn_Click(object sender, EventArgs e)
        {
            Add_Item_Item_UC UCItems_Add = new Add_Item_Item_UC();
            addUC(UCItems_Add);
            moveSidepanel_input(Add_Items_btn);
        }

        private void Add_Parts_Table_btn_Click(object sender, EventArgs e)
        {
            Add_Parts_Item_UC UCParts_Add = new Add_Parts_Item_UC();
            addUC(UCParts_Add);
            moveSidepanel_input(Add_Parts_Table_btn);
        }

        private void Add_Employee_Table_btn_Click(object sender, EventArgs e)
        {
            Add_Employee_Item_UC UCemployee_Add = new Add_Employee_Item_UC();
            addUC(UCemployee_Add);
            moveSidepanel_input(Add_Employee_Table_btn);
        }

        private void Add_Supply_Table_btn_Click(object sender, EventArgs e)
        {
            Add_Supply_Item_UC UCSupply_Add = new Add_Supply_Item_UC();
            addUC(UCSupply_Add);
            moveSidepanel_input(Add_Supply_Table_btn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home_UC Home = new Home_UC();
            addUC(Home);
        }

        private void Report_1_btn_Click(object sender, EventArgs e)
        {
            Report_1UC Report1 = new Report_1UC();
            addUC(Report1);
            moveSidepanel_report(Report_1_btn);
        }

        private void Report3_btn_Click(object sender, EventArgs e)
        {
            Report_3UC Report3 = new Report_3UC();
            addUC(Report3);
            moveSidepanel_report(Report3_btn);
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            showSubMenu(SidePanel_Reports_panel);
        }

        private void Report_2_btn_Click(object sender, EventArgs e)
        {
            Report_2UC Report2 = new Report_2UC();
            addUC(Report2);
            moveSidepanel_report(Report_2_btn);
        }

        private void Dependent_table_Click(object sender, EventArgs e)
        {
            Dependent_UC Dependent = new Dependent_UC();
            addUC(Dependent);
            movesidepanel_Show(Dependent_table);
        }

        private void Skills_Table_Click(object sender, EventArgs e)
        {
            Skills_List_UC Skills = new Skills_List_UC();
            addUC(Skills);
            movesidepanel_Show(Skills_Table);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_DependentUC Add_Dependent = new Add_DependentUC();
            addUC(Add_Dependent);
            moveSidepanel_input(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add_Skills_UC Report2 = new Add_Skills_UC();
            addUC(Report2);
            moveSidepanel_input(button4);
        }
    }
}
