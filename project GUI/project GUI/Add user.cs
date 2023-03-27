using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace project_GUI
{
    public partial class Add_user : Form
    {
        public Add_user()
        {
            InitializeComponent();
        }
        String user_name;
        public Add_user(String un)
        {
            InitializeComponent();
            user_name = un;
        }
        public void BindGrid()
        {
            try
            {
                string connectingstring = "";
                connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                MySqlConnection conn = new MySqlConnection(connectingstring);
                conn.Open();
                string sql = "SELECT * FROM employee_login_detail;";//sql query
                MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                                                               //SqlDataReader reader = cmd.ExecuteReader();
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                ada.Fill(dataTable);//filling the data table
                dataGridViewAdduser.DataSource = dataTable;//binding
                                                           //data grid name - dgStudent

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

      
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEId.Text == "")
                {
                    MessageBox.Show("Please Enter Employee Id");
                }

                else if (txtUsername.Text == "")
                {
                    MessageBox.Show("Please Enter user name");

                }

                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Please Enter password");

                }


                else
                {


                    string connectingstring = "";
                    connectingstring = @"data source = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                    MySqlConnection DBConnect = new MySqlConnection(connectingstring);

                    DBConnect.Open();


                    string sql = @"INSERT INTO employee_login_detail(emp_id,emp_user_name,emp_password)
                 VALUES ('" + txtEId.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "' ); ";
                    MySqlCommand cmd = new MySqlCommand(sql, DBConnect);//sql command object
                    cmd.ExecuteNonQuery();
                    DBConnect.Close();
                    MessageBox.Show("Successfully added");
                    BindGrid();
                    txtEId.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Text = "";
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEId.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";

        }

        
     
        private void Add_user_Load(object sender, EventArgs e)
        {

            if (user_name != "admin")
            {
                
                employee.Enabled = false;
                report.Enabled = false;
            }
        }

       
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEId.Text == "")
                {
                    MessageBox.Show("Please Enter Employee Id  Which Want To Update");
                }

                else if (txtUsername.Text == "")
                {
                    MessageBox.Show("Please Enter user name");

                }

                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Please Enter password");

                }


                else
                {


                    string connectingstring = "";
                    connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                    MySqlConnection conn = new MySqlConnection(connectingstring);
                    conn.Open();


                    string sql = @"UPDATE  employee_login_detail SET emp_user_name='" + txtUsername.Text + "',emp_password= '" + txtPassword.Text + "'  WHERE emp_id='" + txtEId.Text + "';";


                    MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Successfully Update");
                    BindGrid();

                    txtEId.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Text = ""; ;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEId.Text == "")
                {
                    MessageBox.Show("Please Enter Employee Id  Which Want To Delete");
                }
                else
                {
                    if (MessageBox.Show("Are you want to Delete?", "Delete record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        string connectingstring = "";
                        connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                        MySqlConnection conn = new MySqlConnection(connectingstring);
                        conn.Open();


                        string sql = " DELETE FROM `employee_login_detail` WHERE emp_id='" + txtEId.Text + "';";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Deleted");
                        conn.Close();
                        BindGrid();
                        txtEId.Text = "";
                    }
                }
            }
            catch (Exception ex) {

                throw ex;
            }
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

        private void employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empoyee frm = new Empoyee(user_name);
            frm.ShowDialog();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer frm = new Customer(user_name);
            frm.ShowDialog();
        }

       

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_out frm = new Log_out(user_name);
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
