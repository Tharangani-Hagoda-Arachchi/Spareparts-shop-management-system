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
    public partial class Supply_Detail : Form
    {
        public Supply_Detail()
        {
            InitializeComponent();
        }

        String user_name;
        public Supply_Detail(String un)
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
                string sql = "SELECT * FROM supply_detail;";//sql query
                MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                                                               //SqlDataReader reader = cmd.ExecuteReader();
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                ada.Fill(dataTable);//filling the data table
                dataGridViewSupplier.DataSource = dataTable;//binding
                                                           //data grid name - dgStudent

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void lblpassword_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
               

                 if (txtSupname.Text == "")
                {
                    MessageBox.Show("Please Enter supply name");

                }

                else if (txtSuoTp.Text == "")
                {
                    MessageBox.Show("Please Enter supplier Contact No");

                }


                else
                {


                    string connectingstring = "";
                    connectingstring = @"data source = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                    MySqlConnection DBConnect = new MySqlConnection(connectingstring);

                    DBConnect.Open();


                    string sql = @"INSERT INTO supply_detail(suppiy_name,supply_phone)
                 VALUES ('" + txtSupname.Text + "','" + Convert.ToInt32(txtSuoTp.Text) + "' ); ";
                    MySqlCommand cmd = new MySqlCommand(sql, DBConnect);//sql command object
                    cmd.ExecuteNonQuery();
                    DBConnect.Close();
                    MessageBox.Show("Successfully added");
                    BindGrid();
                    txtSuoTp.Text = "";
                    txtSupname.Text = "";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSupname.Text == "")
                {
                    MessageBox.Show("Please Enter supply name");

                }

                else if (txtSuoTp.Text == "")
                {
                    MessageBox.Show("Please Enter supplier Contact No");

                }


                else
                {
                    int id = Convert.ToInt32(dataGridViewSupplier.CurrentCell.Value);
                    string connectingstring = "";
                    connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                    MySqlConnection conn = new MySqlConnection(connectingstring);
                    conn.Open();


                    string sql = @"UPDATE  supply_detail SET suppiy_name='" + txtSupname.Text + "',supply_phone= '" + Convert.ToInt32(txtSuoTp.Text) + "'  WHERE supply_id='" + id+ "';";


                    MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Successfully Update");
                    BindGrid();

                    txtSuoTp.Text = "";
                    txtSupname.Text = "";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSuoTp.Text = "";
          
            txtSupname.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to Delete?", "Delete record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridViewSupplier.CurrentCell.Value);
                string connectingstring = "";
                connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                MySqlConnection conn = new MySqlConnection(connectingstring);
                conn.Open();


                string sql = " DELETE FROM `supply_detail` WHERE supply_id='" + id + "';";
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

        private void order_Click(object sender, EventArgs e)
        {

            this.Hide();
            Order frm = new Order(user_name);
            frm.ShowDialog();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {

            this.Hide();
            Dashboard frm = new Dashboard(user_name);
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



       

       

        private void logout_Click(object sender, EventArgs e)
        {

            this.Hide();
            Log_out frm = new Log_out(user_name);
            frm.ShowDialog();
        }

        private void Supply_Detail_Load(object sender, EventArgs e)
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
    }
}
