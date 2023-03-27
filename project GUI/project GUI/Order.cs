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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace project_GUI
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        String user_name;
        public Order(String un)
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
                string sql = "SELECT * FROM order_detail;";//sql query
                MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                                                               //SqlDataReader reader = cmd.ExecuteReader();
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                ada.Fill(dataTable);//filling the data table
                dgorder.DataSource = dataTable;//binding
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
                if (cbotype.Text == "")
                {
                    MessageBox.Show("Please Enter order type");
                }

                else if (dateorder.Text == "")
                {
                    MessageBox.Show("Please Enter Order date");
                }

                else if (txtqun.Text == "")
                {
                    MessageBox.Show("Please Enter total product Quantity");
                }
                else if (txtcusid.Text == "")
                {
                    MessageBox.Show("Please Enter Customer ID");
                }

                else
                {

                    string connectingstring = "";
                    connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                    MySqlConnection conn = new MySqlConnection(connectingstring);
                    conn.Open();


                    string sql = @"INSERT INTO order_detail (order_type,order_date,total_quantity,cus_reg_id)
                 VALUES ('" + cbotype.SelectedItem + "','" + dateorder.Text + "','" + Convert.ToInt32(txtqun.Text) + "', '" + Convert.ToInt32(txtcusid.Text) + "'); ";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Successfully added");
                    BindGrid();

                    txtcusid.Text = "";
                    txtqun.Text = "";
                    dateorder.Text = "";

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

        private void btnclear_Click(object sender, EventArgs e)
        {

            txtqun.Clear();
            txtcusid.Clear();
            txtcusid.Clear();
            cbotype.Text = "";
            // DateTime date = dateorder.Value;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void Order_Load(object sender, EventArgs e)
        {


            if (user_name != "admin")
            {
                AddUser.Enabled = false;
                Employee.Enabled = false;
                report.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbotype.Text == "")
            {
                MessageBox.Show("Please Enter order type");
            }

            else if (dateorder.Text == "")
            {
                MessageBox.Show("Please Enter Order date");
            }

            else if (txtqun.Text == "")
            {
                MessageBox.Show("Please Enter total product Quantity");
            }
            else if (txtcusid.Text == "")
            {
                MessageBox.Show("Please Enter Customer ID");
            }
            else
            {
                int id = Convert.ToInt32(dgorder.CurrentCell.Value);
                string connectingstring = "";
                connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                MySqlConnection conn = new MySqlConnection(connectingstring);
                conn.Open();


                string sql = @"UPDATE order_detail SET order_type = '" + cbotype.SelectedItem + "', order_date= '" + (dateorder.Text) + "',total_quantity='" + Convert.ToInt32(txtqun.Text) + "',cus_reg_id='" + Convert.ToInt32(txtcusid.Text) + "'  WHERE order_id ='" + id + "';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated");
                conn.Close();
                BindGrid();
                txtcusid.Text = "";
                txtqun.Text = "";
                cbotype.Text = "";

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to Delete?", "Delete record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgorder.CurrentCell.Value);
                string connectingstring = "";
                connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                MySqlConnection conn = new MySqlConnection(connectingstring);
                conn.Open();


                string sql = " DELETE FROM `order_detail` WHERE order_id ='" + id + "';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted");
                conn.Close();
                BindGrid();
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

       

        private void product_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product frm = new Product(user_name);
            frm.ShowDialog();
        }

        


       

        private void logout_Click_1(object sender, EventArgs e)
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

        private void catagory_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            catagory frm = new catagory(user_name);
            frm.ShowDialog();
        }

        private void supply_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supply_Detail frm = new Supply_Detail(user_name);
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

