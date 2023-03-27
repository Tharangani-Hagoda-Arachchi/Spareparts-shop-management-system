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
    public partial class Empoyee : Form
    {
        public Empoyee()
        {
            InitializeComponent();
        }

        String user_name;
        public Empoyee(String un)
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
                string sql = "SELECT * FROM employee_detail;";//sql query
                MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                                                               //SqlDataReader reader = cmd.ExecuteReader();
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                ada.Fill(dataTable);//filling the data table
                dgemployee.DataSource = dataTable;//binding
                                                  //data grid name - dgStudent

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

        private void btncal_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtemid.Text == "")
                {
                    MessageBox.Show("Please Enter Employee ID which want to Update");
                }

                else if (txtemname.Text == "")
                {
                    MessageBox.Show("Please Enter Employee Name");
                }

                else if (txtaddress.Text == "")
                {
                    MessageBox.Show("Please Enter Address");
                }
                else if (txtemail.Text == "")
                {
                    MessageBox.Show("Please Enter Employee Email");
                }

                else if (txtcontact.Text == "")
                {
                    MessageBox.Show("Please Enter Employee Contact No");
                }

                else if (txtrole.Text == "")
                {
                    MessageBox.Show("Please Enter Employee Role");
                }
                else if (txtdes.Text == "")
                {
                    MessageBox.Show("Please Enter role description");
                }


                else
                {

                    string connectingstring = "";
                    connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                    MySqlConnection conn = new MySqlConnection(connectingstring);
                    conn.Open();


                    string sql = @"UPDATE  employee_detail SET employee_name='" + txtemname.Text + "',employee_email= '" + txtemail.Text + "',employee_address= '" + txtaddress.Text + "',employee_contact='" + Convert.ToInt32(txtcontact.Text) + "',role_name='" + txtrole.Text + "',role_description= '" + txtdes.Text + "' WHERE employee_id='" + txtemid.Text + "';";


                    MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Successfully Update");
                    BindGrid();

                    txtemid.Text = "";
                    txtemname.Text = "";
                    txtaddress.Text = "";
                    txtdes.Text = "";
                    txtrole.Text = "";
                    txtemail.Text = "";
                    txtcontact.Text = "";
                }
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
                if (txtemid.Text == "")
                {
                    MessageBox.Show("Please Enter Employee ID");
                }

                else if (txtemname.Text == "")
                {
                    MessageBox.Show("Please Enter Employee Name");
                }

                else if (txtaddress.Text == "")
                {
                    MessageBox.Show("Please Enter Address");
                }
                else if (txtemail.Text == "")
                {
                    MessageBox.Show("Please Enter Employee Email");
                }

                else if (txtcontact.Text == "")
                {
                    MessageBox.Show("Please Enter Employee Contact No");
                }

                else if (txtrole.Text == "")
                {
                    MessageBox.Show("Please Enter Employee Role");
                }
                else if (txtdes.Text == "")
                {
                    MessageBox.Show("Please Enter role description");
                }


                else
                {


                    string connectingstring = "";
                    connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                    MySqlConnection conn = new MySqlConnection(connectingstring);
                    conn.Open();


                    string sql = @"INSERT INTO Employee_Detail (employee_id,employee_name,employee_email,employee_address,employee_contact,role_name,role_description)
                 VALUES ('" + txtemid.Text + "','" + txtemname.Text + "','" + txtemail.Text + "', '" + txtaddress.Text + "','" + Convert.ToInt32(txtcontact.Text) + "','" + txtrole.Text + "','" + txtdes.Text + "'); ";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Successfully added");
                    BindGrid();

                    txtemid.Text = "";
                    txtemname.Text = "";
                    txtaddress.Text = "";
                    txtdes.Text = "";
                    txtrole.Text = "";
                    txtemail.Text = "";
                    txtcontact.Text = "";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtemid.Text = "";
            txtemname.Text = "";
            txtaddress.Text = "";
            txtdes.Text = "";
            txtrole.Text = "";
            txtemail.Text = "";
            txtcontact.Text = "";
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void supply_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Supply_Detail frm = new Supply_Detail(user_name);
            frm.ShowDialog();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtemid.Text == "")
                {
                    MessageBox.Show("Please Enter Employee ID which you want to delete");
                }
                else
                {
                    if (MessageBox.Show("Are you want to Delete?", "Delete record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        string connectingstring = "";
                        connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                        MySqlConnection conn = new MySqlConnection(connectingstring);
                        conn.Open();


                        string sql = " DELETE FROM `employee_detail` WHERE employee_id='" + txtemid.Text + "';";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Deleted");
                        conn.Close();
                        BindGrid();
                        txtemid.Text = "";
                    }
                }

            }
            catch (Exception ex) {
                throw ex;
            }
        }

       

       

        private void dashboard_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard frm = new Dashboard(user_name);
            frm.ShowDialog();
        }

        private void customer_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Customer frm = new Customer(user_name);
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

        private void adduser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_user frm = new Add_user(user_name);
            frm.ShowDialog();
        }

       

        private void logout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Log_out frm = new Log_out(user_name);
            frm.ShowDialog();
        }

        private void Empoyee_Load(object sender, EventArgs e)
        {

            if (user_name != "admin")
            {
                adduser.Enabled = false;
                report.Enabled = false;
                
            }
        }

        private void report_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report frm = new Report(user_name);
            frm.ShowDialog();
        }
    }
    
}
