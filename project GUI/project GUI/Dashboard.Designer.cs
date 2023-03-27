
namespace project_GUI
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnreport = new System.Windows.Forms.Button();
            this.btnSupply = new System.Windows.Forms.Button();
            this.btncatagory = new System.Windows.Forms.Button();
            this.btnpayment = new System.Windows.Forms.Button();
            this.btnOrderItem = new System.Windows.Forms.Button();
            this.btnCoustomer = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAdduser = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnreport);
            this.panel1.Controls.Add(this.btnSupply);
            this.panel1.Controls.Add(this.btncatagory);
            this.panel1.Controls.Add(this.btnpayment);
            this.panel1.Controls.Add(this.btnOrderItem);
            this.panel1.Controls.Add(this.btnCoustomer);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnAdduser);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 653);
            this.panel1.TabIndex = 0;
            // 
            // btnreport
            // 
            this.btnreport.FlatAppearance.BorderSize = 0;
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreport.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnreport.Location = new System.Drawing.Point(6, 598);
            this.btnreport.Margin = new System.Windows.Forms.Padding(2);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(218, 28);
            this.btnreport.TabIndex = 13;
            this.btnreport.Text = "REPORTS";
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click_1);
            // 
            // btnSupply
            // 
            this.btnSupply.FlatAppearance.BorderSize = 0;
            this.btnSupply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupply.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSupply.Location = new System.Drawing.Point(0, 393);
            this.btnSupply.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupply.Name = "btnSupply";
            this.btnSupply.Size = new System.Drawing.Size(223, 28);
            this.btnSupply.TabIndex = 12;
            this.btnSupply.Text = "SUPPLY DETAIL";
            this.btnSupply.UseVisualStyleBackColor = true;
            this.btnSupply.Click += new System.EventHandler(this.btnsupply_Click);
            // 
            // btncatagory
            // 
            this.btncatagory.FlatAppearance.BorderSize = 0;
            this.btncatagory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncatagory.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncatagory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btncatagory.Location = new System.Drawing.Point(0, 280);
            this.btncatagory.Margin = new System.Windows.Forms.Padding(2);
            this.btncatagory.Name = "btncatagory";
            this.btncatagory.Size = new System.Drawing.Size(223, 28);
            this.btncatagory.TabIndex = 11;
            this.btncatagory.Text = "CATEGORY DETAIL";
            this.btncatagory.UseVisualStyleBackColor = true;
            this.btncatagory.Click += new System.EventHandler(this.btncatagory_Click);
            // 
            // btnpayment
            // 
            this.btnpayment.FlatAppearance.BorderSize = 0;
            this.btnpayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpayment.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnpayment.Location = new System.Drawing.Point(0, 219);
            this.btnpayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnpayment.Name = "btnpayment";
            this.btnpayment.Size = new System.Drawing.Size(223, 28);
            this.btnpayment.TabIndex = 10;
            this.btnpayment.Text = "PAYEMENT DETAIL";
            this.btnpayment.UseVisualStyleBackColor = true;
            this.btnpayment.Click += new System.EventHandler(this.btnpayment_Click);
            // 
            // btnOrderItem
            // 
            this.btnOrderItem.FlatAppearance.BorderSize = 0;
            this.btnOrderItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderItem.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOrderItem.Location = new System.Drawing.Point(3, 157);
            this.btnOrderItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderItem.Name = "btnOrderItem";
            this.btnOrderItem.Size = new System.Drawing.Size(223, 28);
            this.btnOrderItem.TabIndex = 9;
            this.btnOrderItem.Text = "ORDER ITEM DETAIL";
            this.btnOrderItem.UseVisualStyleBackColor = true;
            this.btnOrderItem.Click += new System.EventHandler(this.btnOrderItem_Click_1);
            // 
            // btnCoustomer
            // 
            this.btnCoustomer.FlatAppearance.BorderSize = 0;
            this.btnCoustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoustomer.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCoustomer.Location = new System.Drawing.Point(3, 55);
            this.btnCoustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnCoustomer.Name = "btnCoustomer";
            this.btnCoustomer.Size = new System.Drawing.Size(224, 28);
            this.btnCoustomer.TabIndex = 8;
            this.btnCoustomer.Text = "CUSTOMER";
            this.btnCoustomer.UseVisualStyleBackColor = true;
            this.btnCoustomer.Click += new System.EventHandler(this.btnCoustomer_Click_1);
            // 
            // btnProduct
            // 
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnProduct.Location = new System.Drawing.Point(-4, 340);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(224, 28);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "PRODUCT";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogout.Location = new System.Drawing.Point(0, 453);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(223, 28);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAdduser
            // 
            this.btnAdduser.FlatAppearance.BorderSize = 0;
            this.btnAdduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdduser.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdduser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdduser.Location = new System.Drawing.Point(-4, 502);
            this.btnAdduser.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdduser.Name = "btnAdduser";
            this.btnAdduser.Size = new System.Drawing.Size(224, 28);
            this.btnAdduser.TabIndex = 5;
            this.btnAdduser.Text = "ADD USER";
            this.btnAdduser.UseVisualStyleBackColor = true;
            this.btnAdduser.Click += new System.EventHandler(this.btnAdduser_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEmployee.Location = new System.Drawing.Point(3, 550);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(217, 28);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "EMPLOYEE";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOrder.Location = new System.Drawing.Point(0, 109);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(224, 28);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "ORDER";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Black;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDashboard.Location = new System.Drawing.Point(1, 2);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(223, 28);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::project_GUI.Properties.Resources.bike1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 653);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAdduser;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnCoustomer;
        private System.Windows.Forms.Button btnSupply;
        private System.Windows.Forms.Button btncatagory;
        private System.Windows.Forms.Button btnpayment;
        private System.Windows.Forms.Button btnOrderItem;
        private System.Windows.Forms.Button btnreport;
    }
}