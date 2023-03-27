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


namespace project_GUI
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        String user_name;
        public Report(String un)
        {
            InitializeComponent();
            user_name = un;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string connectingstring = "";
                connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
                MySqlConnection conn = new MySqlConnection(connectingstring);
                conn.Open();

                if (dateTimePickerreport.Text == " ")
                {



                    string sql = @" select customer_detail.cus_reg_id,customer_detail.cus_name,order_detail.order_id,order_detail.order_type,order_detail.order_date,order_detail.total_quantity,order_item_detail.order_detail_id,order_item_detail.pro_id,order_item_detail.pro_name,order_item_detail.quantity,order_item_detail.discount,order_payment_detail.pay_id,order_payment_detail.pay_ammount,order_payment_detail.pay_type,order_payment_detail.date 
                             From customer_detail
                             inner join order_detail
                             on customer_detail.cus_reg_id=order_detail.cus_reg_id
                             inner join order_item_detail
                             on order_item_detail.order_id=order_detail.order_id
                             inner join order_payment_detail
                             on order_payment_detail.order_id=order_detail.order_id
                              ;";




                    MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                                                                   //SqlDataReader reader = cmd.ExecuteReader();
                    MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    ada.Fill(dataTable);//filling the data table
                    dataGridViewreport.DataSource = dataTable;
                }

                else
                {
                    string sql = @" select customer_detail.cus_reg_id,customer_detail.cus_name,order_detail.order_id,order_detail.order_type,order_detail.order_date,order_detail.total_quantity,order_item_detail.order_detail_id,order_item_detail.pro_id,order_item_detail.pro_name,order_item_detail.quantity,order_item_detail.discount,order_payment_detail.pay_id,order_payment_detail.pay_ammount,order_payment_detail.pay_type,order_payment_detail.date 
                             From customer_detail
                             inner join order_detail
                             on customer_detail.cus_reg_id=order_detail.cus_reg_id
                             inner join order_item_detail
                             on order_item_detail.order_id=order_detail.order_id
                             inner join order_payment_detail
                             on order_payment_detail.order_id=order_detail.order_id
                             where order_detail.order_date='" + (dateTimePickerreport.Text) + "'; ";




                    MySqlCommand cmd = new MySqlCommand(sql, conn);//sql command object
                                                                   //SqlDataReader reader = cmd.ExecuteReader();
                    MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    ada.Fill(dataTable);//filling the data table
                    dataGridViewreport.DataSource = dataTable;
                   
                }
                dateTimePickerreport.Text = "";
                conn.Close();

                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard frm = new Dashboard(user_name);
            frm.ShowDialog();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer frm = new Customer(user_name);
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

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_out frm = new Log_out(user_name);
            frm.ShowDialog();
        }

      
        
        private void employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empoyee frm = new Empoyee(user_name);
            frm.ShowDialog();
        }

        private void adduser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_user frm = new Add_user(user_name);
            frm.ShowDialog();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            if (user_name != "admin")
            {
                adduser.Enabled = false;
                employee.Enabled = false;

            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            
                    try {
                        Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                        Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                        Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                        worksheet = workbook.Sheets["Sheet1"];
                        worksheet = workbook.ActiveSheet;
                        worksheet.Name = "Report";

                        for (int i = 1; i < dataGridViewreport.Columns.Count + 1; i++){
                            worksheet.Cells[1, i] = dataGridViewreport.Columns[i - 1].HeaderText;
                        }

                        for(int i=0; i < dataGridViewreport.Rows.Count; i++)
                        {
                           for(int j = 0; j < dataGridViewreport.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2,j + 1] = dataGridViewreport.Rows[i].Cells[j].Value;

                            }

                        }

                        var saveFileDialoge = new SaveFileDialog();
                        saveFileDialoge.FileName = "order report";
                        saveFileDialoge.DefaultExt = ".xlsx";
                        if (saveFileDialoge.ShowDialog() == DialogResult.OK)
                        {
                            workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                            
                        }
                        app.Quit();






                        
                            
                        
                        
                    
                    }
                    catch(Exception ex) {
                throw ex;
            }
                }
            
        

        private void dateTimePickerreport_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerreport.CustomFormat = "dd-MM-yyyy";
        }

        private void dateTimePickerreport_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dateTimePickerreport.CustomFormat = " ";
            }
        }
    }
}
