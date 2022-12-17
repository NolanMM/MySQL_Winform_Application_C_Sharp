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
    public partial class Home_UC : UserControl
    {
        public Home_UC()
        {
            InitializeComponent();
        }
        private void addUC(UserControl uc)
        {
            panelcenter.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelcenter.Controls.Clear();
            panelcenter.Controls.Add(uc);
        }

        private void Exit_btn_Click_1(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void REQ_3_Final_btn_Click_1(object sender, EventArgs e)
        {
            Report_REQ_3_FinalUC Report3_Final = new Report_REQ_3_FinalUC();
            addUC(Report3_Final);
        }

        private void REQ_4_Final_btn_Click_1(object sender, EventArgs e)
        {
            Report_REQ_4_FinalUC Report4_Final = new Report_REQ_4_FinalUC();
            addUC(Report4_Final);
        }

        private void REQ_1_Final_btn_Click(object sender, EventArgs e)
        {
            REQ_1_Final_UC Report1_Final = new REQ_1_Final_UC();
            addUC(Report1_Final);
        }
    }
}
