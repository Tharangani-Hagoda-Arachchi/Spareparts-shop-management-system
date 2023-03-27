using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace project_GUI
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        string user_name;
        public Customer(String un)
        {
            InitializeComponent();
            user_name=un;
        }


        public void BindGrid()
        {
            try
            {
                string connectingstring = "";
                connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                MySqlConnection conn = new MySqlConnection(connectingstring);
                conn.Open();
                string sql = "SELECT * FROM customer_detail;";//sql query
                MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                                                               //SqlDataReader reader = cmd.ExecuteReader();
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                ada.Fill(dataTable);//filling the data table
                dataGridViewCustomer.DataSource = dataTable;//binding
                                                  //data grid name - dgStudent

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtaddress.Text = "";
            txtCusEmail.Text = "";
            txtcusname.Text = "";
            
            txtcontact.Text = "";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtcusname.Text == "")
                {
                    MessageBox.Show("Please Enter Customer Name");
                }

                else if (txtaddress.Text == "")
                {
                    MessageBox.Show("Please Enter Customer Address");
                }

                else if (txtcontact.Text == "")
                {
                    MessageBox.Show("Please Enter Customer Contact No");
                }
                else if (txtCusEmail.Text == "")
                {
                    MessageBox.Show("Please Enter Customer Email");
                }

                else
                {

                    string connectingstring = "";
                    connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                    MySqlConnection conn = new MySqlConnection(connectingstring);
                    conn.Open();


                    string sql = @"INSERT INTO customer_detail (cus_name,cus_address,cus_phone,cus_email)
                 VALUES ('" + txtcusname.Text + "','" + txtaddress.Text + "','" + Convert.ToInt32(txtcontact.Text) + "','" + txtCusEmail.Text + "'); ";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Successfully added");
                    BindGrid();

                    txtaddress.Text = "";
                    txtCusEmail.Text = "";
                    txtcusname.Text = "";


                    txtcontact.Text = "";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

       

       

       
    
        private void Customer_Load(object sender, EventArgs e)
        {

            if (user_name != "admin")
            {
                Employee.Enabled = false;
                AddUser.Enabled = false;
                report.Enabled = false;
                button1.Hide();
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtcusname.Text == "")
            {
                MessageBox.Show("Please Enter Customer Name");
            }

            else if (txtaddress.Text == "")
            {
                MessageBox.Show("Please Enter Customer Address");
            }

            else if (txtcontact.Text == "")
            {
                MessageBox.Show("Please Enter Customer Contact No");
            }
            else if (txtCusEmail.Text == "")
            {
                MessageBox.Show("Please Enter Customer Email");
            }

            else
            {

                if (MessageBox.Show("Are you want to Update?", "Update record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridViewCustomer.CurrentCell.Value);
                    string connectingstring = "";
                    connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                    MySqlConnection conn = new MySqlConnection(connectingstring);
                    conn.Open();


                    string sql = @"UPDATE customer_detail SET cus_name = '" + txtcusname.Text + "', cus_address = '" + txtaddress.Text + "',cus_phone='" + txtcontact.Text + "', cus_email='" + txtCusEmail + "'  WHERE cus_reg_id ='" + id + "';";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated");
                    conn.Close();
                    BindGrid();
                    txtaddress.Text = "";
                    txtCusEmail.Text = "";
                    txtcusname.Text = "";

                    txtcontact.Text = "";
                }

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you want to Delete?", "Delete record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridViewCustomer.CurrentCell.Value);
                string connectingstring = "";
                connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                MySqlConnection conn = new MySqlConnection(connectingstring);
                conn.Open();


                string sql = " DELETE FROM `customer_detail` WHERE cus_reg_id='" + id + "';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted");
                conn.Close();
                BindGrid();
            }
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard frm = new Dashboard(user_name);
            frm.ShowDialog();
        }

        private void order_Click_1(object sender, EventArgs e)
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

        private void product_Click_1(object sender, EventArgs e)
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

       
        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_out frm = new Log_out(user_name);
            frm.ShowDialog();

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectingstring = "";
                connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                MySqlConnection conn = new MySqlConnection(connectingstring);
                conn.Open();
                string sql = "SELECT * FROM online_customer_detail;";//sql query
                MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                                                               //SqlDataReader reader = cmd.ExecuteReader();
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                ada.Fill(dataTable);//filling the data table
                dataGridViewCustomer.DataSource = dataTable;//binding
                                                            //data grid name - dgStudent

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
