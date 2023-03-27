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
    public partial class Dashboard : Form
    {

        
        public Dashboard()
       {
            InitializeComponent();
           
        }


        String user_name;
        

        public Dashboard(String un)
        {
            InitializeComponent();
            user_name = un;
           


        }
        



        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard frm = new Dashboard(user_name);
            frm.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Order frm = new Order(user_name);
            frm.ShowDialog();

        }

        

        private void btnProduct_Click(object sender, EventArgs e)
        {
         
            this.Hide();
            Product frm = new Product(user_name);
            frm.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Empoyee frm = new Empoyee(user_name);
            frm.ShowDialog();
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Add_user frm = new Add_user(user_name);
            frm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            Log_out frm = new Log_out( user_name);
            frm.ShowDialog();
        }

        private void btnCoustomer_Click_1(object sender, EventArgs e)
        {

            this.Hide();
                Customer frm = new Customer(user_name);
                frm.ShowDialog();
            


        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report frm = new Report();
            frm.ShowDialog();

        }

      
        private void btnOrderItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            order_item_detail frm = new order_item_detail(user_name);
            frm.ShowDialog();
        }

        private void btncatagory_Click(object sender, EventArgs e)
        {
            this.Hide();
            catagory frm = new catagory(user_name);
            frm.ShowDialog();
        }

        private void btnsupply_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supply_Detail frm = new Supply_Detail(user_name);
            frm.ShowDialog();
        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            order_payment frm = new order_payment(user_name);
            frm.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            if (user_name != "admin")
            {
                btnAdduser.Hide();
                btnEmployee.Hide();
                btnreport.Hide();
                
            }


        }

        private void btnreport_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Report frm = new Report(user_name);
            frm.ShowDialog();
        }
    }
}
