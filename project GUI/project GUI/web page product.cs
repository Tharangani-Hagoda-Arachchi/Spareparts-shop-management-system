using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace project_GUI
{
    public partial class web_page_product : Form
    {
        public web_page_product()
        {
            InitializeComponent();
        }

        public void BindGrid()
        {
            try
            {
                string connectingstring = "";
                connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                MySqlConnection conn = new MySqlConnection(connectingstring);
                conn.Open();
                if (rbtnbike.Checked)
                {
                    string sql = "SELECT * FROM tbl_product;";//sql query
                    MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                                                                   //SqlDataReader reader = cmd.ExecuteReader();
                    MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    ada.Fill(dataTable);//filling the data table
                    dgWebPro.DataSource = dataTable;//binding
                                                    //data grid name - dgStudent
                }
                else if (rbtnthreewheel.Checked)
                {
                    string sql = "SELECT * FROM bike_product;";//sql query
                    MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                                                                   //SqlDataReader reader = cmd.ExecuteReader();
                    MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    ada.Fill(dataTable);//filling the data table
                    dgWebPro.DataSource = dataTable;

                }
                else
                {
                    MessageBox.Show("Please select product type");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }




        private void web_page_product_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                

                 if (txtPName.Text == "")
                {
                    MessageBox.Show("Please Enter Product Name");
                }

                else if (txtIname.Text == "")
                {
                    MessageBox.Show("Please Enter Image Name");
                }
                else if (txtPrice.Text == "")
                {
                    MessageBox.Show("Please Enter price");
                }

                string connectingstring = "";
                connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                MySqlConnection conn = new MySqlConnection(connectingstring);
                conn.Open();


                if (rbtnbike.Checked)
                {



                    string sql = @"INSERT INTO tbl_product (name,image,price)
                 VALUES ('" + txtPName.Text + "','" + txtIname.Text + "', '" + Convert.ToDouble(txtPrice.Text) + "'); ";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Successfully added");
                    BindGrid();

                    
                    txtPName.Text = "";
                    txtIname.Text = "";
                    txtPrice.Text = "";

                }

                else if (rbtnthreewheel.Checked)
                {

                    string sql = @"INSERT INTO bike_product (name,image,price)
                 VALUES ('" + txtPName.Text + "','" + txtIname.Text + "', '" + Convert.ToDouble(txtPrice.Text) + "'); ";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Successfully added");
                    BindGrid();

                    txtPName.Text = "";
                    txtIname.Text = "";
                    txtPrice.Text = "";

                }
                else { MessageBox.Show("Select Your Product Type"); }


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
          
            txtPName.Text = "";
            txtIname.Text = "";
            txtPrice.Text = "";

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                
                 if (txtPName.Text == "")
                {
                    MessageBox.Show("Please Enter product name");
                }

                else if (txtIname.Text == "")
                {
                    MessageBox.Show("Please Enter image Name");
                }
                else if (txtPrice.Text == "")
                {
                    MessageBox.Show("Please Enter Cost");
                }



                else
                {
                    int id = Convert.ToInt32(dgWebPro.CurrentCell.Value);
                    string connectingstring = "";
                    connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                    MySqlConnection conn = new MySqlConnection(connectingstring);
                    conn.Open();
                    if (rbtnbike.Checked)
                    {

                        string sql = @"UPDATE  tbl_product SET name='" + txtPName.Text + "',image= '" + txtIname.Text + "',price= '" + (Convert.ToDouble(txtPrice.Text) + "' WHERE id='" + id + "';");


                        MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Successfully Update");
                        BindGrid();


                       
                        txtPName.Text = "";
                        txtIname.Text = "";
                        txtPrice.Text = "";
                    }
                    else if (rbtnthreewheel.Checked)
                    {

                        string sql = @"UPDATE  bike_product SET name='" + txtPName.Text + "',image= '" + txtIname.Text + "',price= '" + (Convert.ToDouble(txtPrice.Text) + "' WHERE id='" + id + "';");


                        MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Successfully Update");
                        BindGrid();


                        
                        txtPName.Text = "";
                        txtIname.Text = "";
                        txtPrice.Text = "";

                    }

                    else { MessageBox.Show("select your vehicle type"); }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

           
           
            
                if (MessageBox.Show("Are you want to Delete?", "Delete record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgWebPro.CurrentCell.Value);
                    string connectingstring = "";
                    connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                    MySqlConnection conn = new MySqlConnection(connectingstring);
                    conn.Open();

                    if (rbtnbike.Checked)
                    {
                        string sql = " DELETE FROM `tbl_product` WHERE id='" + id + "';";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Deleted");
                        conn.Close();
                        BindGrid();
                        
                    }
                    if (rbtnthreewheel.Checked)
                    {
                        string sql = " DELETE FROM `bike_product` WHERE id='" + id + "';";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Deleted");
                        conn.Close();
                        BindGrid();
                        
                    }
                

            }
        }
    }
}
