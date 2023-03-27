using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_GUI
{
    public partial class Log_out : Form
    {
        public Log_out()
        {
            InitializeComponent();
        }

        String user_name;
        public Log_out(String un)
        {
            InitializeComponent();
            user_name = un;
        }




        private void btnLogout_Click(object sender, EventArgs e)
        {
         if  ( MessageBox.Show("Do you want to log out","Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Hide();
                frmLoading frm = new frmLoading();
                frm.ShowDialog();
            }
         else
            {
                this.Hide();
                Dashboard frm = new Dashboard(user_name);
                frm.ShowDialog();
            }
        }

       


        private void customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer frm = new Customer(user_name);
            frm.ShowDialog();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard frm = new Dashboard(user_name);
            frm.ShowDialog();
        }

        private void order_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order frm = new Order(user_name);
            frm.ShowDialog();
        }

        private void orderitem_Click(object sender, EventArgs e)
        {
            this.Hide();
            order_item_detail frm = new order_item_detail(user_name);
            frm.ShowDialog();
        }

        private void payment_Click(object sender, EventArgs e)
        {
            this.Hide();
            order_payment frm = new order_payment(user_name);
            frm.ShowDialog();
        }

        private void category_Click(object sender, EventArgs e)
        {
            this.Hide();
            catagory frm = new catagory(user_name);
            frm.ShowDialog();
        }

        private void product_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product frm = new Product(user_name);
            frm.ShowDialog();
        }

        private void supply_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supply_Detail frm = new Supply_Detail(user_name);
            frm.ShowDialog();
        }

      

       
       

        private void Log_out_Load(object sender, EventArgs e)
        {

            if (user_name != "admin")
            {
                Employee.Enabled = false;
                AddUser.Enabled = false;
                report.Enabled = false;
            }
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empoyee frm = new Empoyee(user_name);
            frm.ShowDialog();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_user frm = new Add_user(user_name);
            frm.ShowDialog();
        }

        private void report_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report frm = new Report(user_name);
            frm.ShowDialog();
        }
    }
}
