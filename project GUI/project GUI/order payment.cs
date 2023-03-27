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
    public partial class order_payment : Form
    {
        public order_payment()
        {
            InitializeComponent();
        }

        String user_name;
        public order_payment(String un)
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
                string sql = "SELECT * FROM order_payment_detail;";//sql query
                MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                                                               //SqlDataReader reader = cmd.ExecuteReader();
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                ada.Fill(dataTable);//filling the data table
                dataGridViewPayment.DataSource = dataTable;//binding
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
                if (txtpayamo.Text == "")
                {
                    MessageBox.Show("Please Enter pay amount");
                }

                else if (txtorderid.Text == "")
                {
                    MessageBox.Show("Please Enter Order id");
                }

                else if (dateTimePickerpay.Text == "")
                {
                    MessageBox.Show("Please Enter Pay date");
                }
                else if (cmbtype.Text == "")
                {
                    MessageBox.Show("Please Enter Payment Type");
                }


                else
                {
                    string connectingstring = "";
                    connectingstring = @"data source = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                    MySqlConnection DBConnect = new MySqlConnection(connectingstring);

                    DBConnect.Open();


                    string sql = @"INSERT INTO order_payment_detail(pay_ammount,pay_type,date,order_id)
                 VALUES ('" + Convert.ToDouble(txtpayamo.Text) + "','" + cmbtype.SelectedItem + "','" + (dateTimePickerpay.Text) + "','"+Convert.ToInt32(txtorderid.Text) +"' ); ";
                    MySqlCommand cmd = new MySqlCommand(sql, DBConnect);//sql command object
                    cmd.ExecuteNonQuery();
                    DBConnect.Close();
                    MessageBox.Show("Successfully added");
                    BindGrid();
                    txtpayamo.Text = "";
                    cmbtype.Text = "";
                    txtorderid.Text = "";

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtpayamo.Text = "";
            cmbtype.Text = "";
            txtorderid.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to Delete?", "Delete record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridViewPayment.CurrentCell.Value);
                string connectingstring = "";
                connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                MySqlConnection conn = new MySqlConnection(connectingstring);
                conn.Open();


                string sql = " DELETE FROM `order_payment_detail` WHERE pay_id='" + id + "';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted");
                conn.Close();
                BindGrid();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtpayamo.Text == "")
            {
                MessageBox.Show("Please Enter pay amount");
            }

            else if (txtorderid.Text == "")
            {
                MessageBox.Show("Please Enter Order id");
            }

            else if (dateTimePickerpay.Text == "")
            {
                MessageBox.Show("Please Enter Pay date");
            }
            else if (cmbtype.Text == "")
            {
                MessageBox.Show("Please Enter Payment Type");
            }


            else
            {


                if (MessageBox.Show("Are you want to Update?", "Update record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridViewPayment.CurrentCell.Value);
                    string connectingstring = "";
                    connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                    MySqlConnection conn = new MySqlConnection(connectingstring);
                    conn.Open();


                    string sql = @"UPDATE order_payment_detail SET pay_ammount = '" + Convert.ToDouble(txtpayamo.Text) + "', pay_type = '" + cmbtype.SelectedItem + "',date='" + (dateTimePickerpay.Text) + "',order_id='"+ Convert.ToInt32(txtorderid.Text) +"'  WHERE pay_id ='" + id + "';";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated");
                    conn.Close();
                    BindGrid();
                    txtpayamo.Text = "";
                    cmbtype.Text = "";
                    txtorderid.Text = "";
                }
            }
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard frm = new Dashboard(user_name);
            frm.ShowDialog();
        }

        private void catagory_Click(object sender, EventArgs e)
        {
            this.Hide();
            catagory frm = new catagory(user_name);
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

        private void customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer frm = new Customer(user_name);
            frm.ShowDialog();
        }

       

       

        private void supply_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supply_Detail frm = new Supply_Detail(user_name);
            frm.ShowDialog();
        }

       

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_out frm = new Log_out(user_name);
            frm.ShowDialog();
        }


        private void order_payment_Load(object sender, EventArgs e)
        {

            if (user_name != "admin")
            {
                AddUser.Enabled = false;
                Employee.Enabled = false;
                report.Enabled = false;
                btnonlinePay.Hide();
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

        private void product_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product frm = new Product(user_name);
            frm.ShowDialog();
        }

        private void report_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report frm = new Report(user_name);
            frm.ShowDialog();
        }

        private void btnonlinePay_Click(object sender, EventArgs e)
        {
            try
            {
                string connectingstring = "";
                connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                MySqlConnection conn = new MySqlConnection(connectingstring);
                conn.Open();
                string sql = "SELECT * FROM online_order_details;";//sql query
                MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                                                               //SqlDataReader reader = cmd.ExecuteReader();
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                ada.Fill(dataTable);//filling the data table
                dataGridViewPayment.DataSource = dataTable;//binding
                                                           //data grid name - dgStudent

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    } }
