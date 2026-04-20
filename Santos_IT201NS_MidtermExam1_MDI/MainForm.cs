using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Santos_IT201NS_MidtermExam1_MDI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pOSCashierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pOSAdministratorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void payrollToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jeePOSIncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codes for calling the form to be displayed once the submenu has been clicked
            Example2 newMDIChi1d = new Example2();//create a class and instatiate it
            newMDIChi1d.MdiParent = this;//code for calling the new class created use for calling the form
            newMDIChi1d.Show();//code for displaying the pointed form to be displayed
        }

        private void jeePOSOrderingToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Example4 newMDIChi1d = new Example4();
            newMDIChi1d.MdiParent = this;
            newMDIChi1d.Show();
        }

        private void simplePOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Example1 newMDIChild = new Example1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jeePOSIncToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Pos_Admin posAdmin = new Pos_Admin();
            posAdmin.MdiParent = this;
            posAdmin.Show();
                    }

        private void jeePOSOrderingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OrderingPOS_Admin orderAdmin = new OrderingPOS_Admin();
            orderAdmin.MdiParent = this;
            orderAdmin.Show();
        }

        private void userAccountPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_AccountFrm newMDIChild = new User_AccountFrm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void payrolApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payrol_ApplicationFrm newMDIChild = new Payrol_ApplicationFrm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void employeeRegistrationPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_RegistrationFrm newMDIChild = new Employee_RegistrationFrm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void salesReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_ReportsFrm newMDIChild = new Sales_ReportsFrm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void productsReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_ReportsFrm newMDIChild = new Product_ReportsFrm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void employeesReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_ReportsFrm newMDIChild = new Employee_ReportsFrm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void payrolReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payrol_ReportsFrm newMDIChild = new Payrol_ReportsFrm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void userReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_ReportsFrm newMDIChild = new User_ReportsFrm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
