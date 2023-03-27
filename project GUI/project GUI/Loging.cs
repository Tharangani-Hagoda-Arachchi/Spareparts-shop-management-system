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
    public partial class Loging : Form
    {

        public Loging()
        {
            InitializeComponent();
        }

        public string user_name { get; private set; }


        private void button1_Click(object sender, EventArgs e)
        {

            string connectingstring = "";
            connectingstring = @"server = localhost;Username = root;Password =;database=vehicle_spareparts_shop";
            MySqlConnection conn = new MySqlConnection(connectingstring);
            conn.Open();
            string Uname = txtUser_name.Text;
            string Password = txtPassword.Text;
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee_login_detail WHERE emp_user_name= '" + txtUser_name.Text + "' &&  emp_password='" + txtPassword.Text + "'", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                user_name = txtUser_name.Text;
                if (txtUser_name.Text == "admin" && txtPassword.Text == "admin")
                {
                    this.Hide();
                    Dashboard frm = new Dashboard(user_name);
                    frm.ShowDialog();
                }
                else
                {
                    this.Hide();
                    Dashboard frm = new Dashboard(user_name);
                    frm.ShowDialog();
                }


            }
            else
            {
                MessageBox.Show("Invalid Login Please Enter Correct Username and Password");
                txtPassword.Text = "";
                txtUser_name.Text = "";
            }
            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void linkLabelShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabelShow.Text == "SHOW") { 
            
                txtPassword.UseSystemPasswordChar = false;
            
            linkLabelShow.Text = "HIDE";
            }
            else
            {
             txtPassword.UseSystemPasswordChar = true;
            
            linkLabelShow.Text = "SHOW";
            }
        }

        private void Loging_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        
    } 
    }
}
