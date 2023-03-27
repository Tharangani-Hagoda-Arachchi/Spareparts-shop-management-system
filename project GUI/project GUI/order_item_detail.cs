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
    public partial class order_item_detail : Form
    {
        public order_item_detail()
        {
            InitializeComponent();
        }

        String user_name;
        public order_item_detail(String un)
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
                string sql = "SELECT * FROM order_item_detail;";//sql query
                MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                                                               //SqlDataReader reader = cmd.ExecuteReader();
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                ada.Fill(dataTable);//filling the data table
                dataGridVieworderitem.DataSource = dataTable;//binding
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
                if (txtproname.Text == "")
                {
                    MessageBox.Show("Please Enter product Name");
                }

                else if (txtquantity.Text == "")
                {
                    MessageBox.Show("Please Enter Quantity");
                }

                else if (txtdiscount.Text == "")
                {
                    MessageBox.Show("Please Enter Discount Amount");
                }
                else if (txtordid.Text == "")
                {
                    MessageBox.Show("Please Enter Order Id");
                }

                else if (txtproid.Text == "")
                {
                    MessageBox.Show("Please Enter product Id");
                }

                else
                {

                    string connectingstring = "";
                    connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                    MySqlConnection conn = new MySqlConnection(connectingstring);
                    conn.Open();


                    string sql = @"INSERT INTO order_item_detail (pro_name,quantity,discount,order_id,pro_id)
                 VALUES ('" + txtproname.Text + "','" + Convert.ToDouble(txtquantity.Text) + "','" + Convert.ToDouble(txtdiscount.Text) + "', '" + Convert.ToInt32(txtordid.Text) + "','" + txtproid.Text + "'); ";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Successfully added");
                    BindGrid();

                    txtdiscount.Text = "";
                    txtordid.Text = "";
                    txtproid.Text = "";
                    txtproname.Text = "";
                    txtquantity.Text = "";

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtproname.Text == "")
            {
                MessageBox.Show("Please Enter product Name");
            }

            else if (txtquantity.Text == "")
            {
                MessageBox.Show("Please Enter Quantity");
            }

            else if (txtdiscount.Text == "")
            {
                MessageBox.Show("Please Enter Discount Amount");
            }
            else if (txtordid.Text == "")
            {
                MessageBox.Show("Please Enter Order Id");
            }

            else if (txtproid.Text == "")
            {
                MessageBox.Show("Please Enter product Id");
            }

            else
            {
                if (MessageBox.Show("Are you want to Update?", "Update record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridVieworderitem.CurrentCell.Value);
                    string connectingstring = "";
                    connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                    MySqlConnection conn = new MySqlConnection(connectingstring);
                    conn.Open();


                    string sql = @"UPDATE order_item_detail SET pro_name = '" + txtproname.Text + "', quantity = '" + Convert.ToDouble(txtquantity.Text) + "',discount='" + Convert.ToDouble(txtdiscount.Text) + "',order_id='" + Convert.ToInt32(txtordid.Text) + "',pro_id='" + txtproid.Text + "'  WHERE order_detail_id ='" + id + "';";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated");
                    conn.Close();
                    BindGrid();
                    txtdiscount.Text = "";
                    txtordid.Text = "";
                    txtproid.Text = "";
                    txtproname.Text = "";
                    txtquantity.Text = "";
                }
            } }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtdiscount.Text = "";
            txtordid.Text = "";
            txtproid.Text = "";
            txtproname.Text = "";
            txtquantity.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to Delete?", "Delete record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridVieworderitem.CurrentCell.Value);
                string connectingstring = "";
                connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                MySqlConnection conn = new MySqlConnection(connectingstring);
                conn.Open();


                string sql = " DELETE FROM `order_item_detail` WHERE order_detail_id ='" + id + "';";
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

        private void order_Click(object sender, EventArgs e)
        {

            this.Hide();
            Order frm = new Order(user_name);
            frm.ShowDialog();
        }

        private void customer_Click(object sender, EventArgs e)
        {

            this.Hide();
            Customer frm = new Customer(user_name);
            frm.ShowDialog();
        }

        private void payment_Click(object sender, EventArgs e)
        {

            this.Hide();
            order_payment frm = new order_payment(user_name);
            frm.ShowDialog();
        }

        private void catageory_Click(object sender, EventArgs e)
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

       


        private void logout_Click(object sender, EventArgs e)
        {

            this.Hide();
            Log_out frm = new Log_out(user_name);
            frm.ShowDialog();
        }

        private void order_item_detail_Load(object sender, EventArgs e)
        {

            if (user_name != "admin")
            {
                Employee.Enabled = false;
                AddUser.Enabled = false;
                report.Enabled = false;
            }
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
           Add_user frm = new Add_user(user_name);
            frm.ShowDialog();
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empoyee frm = new Empoyee(user_name);
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

