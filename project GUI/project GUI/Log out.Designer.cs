
namespace project_GUI
{
    partial class Log_out
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
            this.lblThank = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuStripcoustomer = new System.Windows.Forms.MenuStrip();
            this.dashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.order = new System.Windows.Forms.ToolStripMenuItem();
            this.orderitem = new System.Windows.Forms.ToolStripMenuItem();
            this.customer = new System.Windows.Forms.ToolStripMenuItem();
            this.payment = new System.Windows.Forms.ToolStripMenuItem();
            this.category = new System.Windows.Forms.ToolStripMenuItem();
            this.product = new System.Windows.Forms.ToolStripMenuItem();
            this.supply = new System.Windows.Forms.ToolStripMenuItem();
            this.Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.AddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.report = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripcoustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThank
            // 
            this.lblThank.AutoSize = true;
            this.lblThank.BackColor = System.Drawing.Color.Transparent;
            this.lblThank.Font = new System.Drawing.Font("Monotype Corsiva", 73.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblThank.Location = new System.Drawing.Point(103, 55);
            this.lblThank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThank.Name = "lblThank";
            this.lblThank.Size = new System.Drawing.Size(578, 120);
            this.lblThank.TabIndex = 0;
            this.lblThank.Text = "THANK YOU";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Maroon;
            this.btnLogout.Location = new System.Drawing.Point(201, 417);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(190, 45);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // menuStripcoustomer
            // 
            this.menuStripcoustomer.BackColor = System.Drawing.Color.Black;
            this.menuStripcoustomer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripcoustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboard,
            this.order,
            this.orderitem,
            this.customer,
            this.payment,
            this.category,
            this.product,
            this.supply,
            this.Employee,
            this.AddUser,
            this.report});
            this.menuStripcoustomer.Location = new System.Drawing.Point(0, 0);
            this.menuStripcoustomer.Name = "menuStripcoustomer";
            this.menuStripcoustomer.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripcoustomer.Size = new System.Drawing.Size(953, 24);
            this.menuStripcoustomer.TabIndex = 27;
           //
            // dashboard
            // 
            this.dashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(94, 20);
            this.dashboard.Text = "DASHBOARD";
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // order
            // 
            this.order.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(59, 20);
            this.order.Text = "ORDER";
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // orderitem
            // 
            this.orderitem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderitem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.orderitem.Name = "orderitem";
            this.orderitem.Size = new System.Drawing.Size(90, 20);
            this.orderitem.Text = "ORDER ITEM";
            this.orderitem.Click += new System.EventHandler(this.orderitem_Click);
            // 
            // customer
            // 
            this.customer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(83, 20);
            this.customer.Text = "CUSTOMER";
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // payment
            // 
            this.payment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(72, 20);
            this.payment.Text = "PAYMENT";
            this.payment.Click += new System.EventHandler(this.payment_Click);
            // 
            // category
            // 
            this.category.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(72, 20);
            this.category.Text = "CATEGOR";
            this.category.Click += new System.EventHandler(this.category_Click);
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(75, 20);
            this.product.Text = "PRODUCT";
            this.product.Click += new System.EventHandler(this.product_Click);
            // 
            // supply
            // 
            this.supply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.supply.Name = "supply";
            this.supply.Size = new System.Drawing.Size(103, 20);
            this.supply.Text = "SUPPLY DETAIL";
            this.supply.Click += new System.EventHandler(this.supply_Click);
            // 
            // Employee
            // 
            this.Employee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(77, 20);
            this.Employee.Text = "EMPLOYEE";
            this.Employee.Click += new System.EventHandler(this.Employee_Click);
            // 
            // AddUser
            // 
            this.AddUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(78, 20);
            this.AddUser.Text = "ADD USER";
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // report
            // 
            this.report.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(64, 20);
            this.report.Text = "REPORT";
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // Log_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_GUI.Properties.Resources.B111;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(953, 621);
            this.Controls.Add(this.menuStripcoustomer);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblThank);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Log_out";
            this.Text = "LOG OUT";
            this.Load += new System.EventHandler(this.Log_out_Load);
            this.menuStripcoustomer.ResumeLayout(false);
            this.menuStripcoustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThank;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.MenuStrip menuStripcoustomer;
        private System.Windows.Forms.ToolStripMenuItem dashboard;
        private System.Windows.Forms.ToolStripMenuItem order;
        private System.Windows.Forms.ToolStripMenuItem orderitem;
        private System.Windows.Forms.ToolStripMenuItem customer;
        private System.Windows.Forms.ToolStripMenuItem payment;
        private System.Windows.Forms.ToolStripMenuItem category;
        private System.Windows.Forms.ToolStripMenuItem product;
        private System.Windows.Forms.ToolStripMenuItem supply;
        private System.Windows.Forms.ToolStripMenuItem Employee;
        private System.Windows.Forms.ToolStripMenuItem AddUser;
        private System.Windows.Forms.ToolStripMenuItem report;
    }
}