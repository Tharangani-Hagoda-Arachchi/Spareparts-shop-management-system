
namespace project_GUI
{
    partial class Order
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
            this.btnview = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgorder = new System.Windows.Forms.DataGridView();
            this.dateorder = new System.Windows.Forms.DateTimePicker();
            this.lblorderdate = new System.Windows.Forms.Label();
            this.cbotype = new System.Windows.Forms.ComboBox();
            this.lbltype = new System.Windows.Forms.Label();
            this.txtqun = new System.Windows.Forms.TextBox();
            this.lblno = new System.Windows.Forms.Label();
            this.menuStriplogout = new System.Windows.Forms.MenuStrip();
            this.dashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.customer = new System.Windows.Forms.ToolStripMenuItem();
            this.orderitem = new System.Windows.Forms.ToolStripMenuItem();
            this.payment = new System.Windows.Forms.ToolStripMenuItem();
            this.catagory = new System.Windows.Forms.ToolStripMenuItem();
            this.product = new System.Windows.Forms.ToolStripMenuItem();
            this.supply = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.AddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.report = new System.Windows.Forms.ToolStripMenuItem();
            this.txtcusid = new System.Windows.Forms.TextBox();
            this.lblCusid = new System.Windows.Forms.Label();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgorder)).BeginInit();
            this.menuStriplogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.White;
            this.btnview.Location = new System.Drawing.Point(838, 519);
            this.btnview.Margin = new System.Windows.Forms.Padding(2);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(110, 28);
            this.btnview.TabIndex = 33;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(690, 519);
            this.btnexit.Margin = new System.Windows.Forms.Padding(2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(112, 28);
            this.btnexit.TabIndex = 30;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(509, 519);
            this.btnclear.Margin = new System.Windows.Forms.Padding(2);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(113, 28);
            this.btnclear.TabIndex = 29;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(22, 519);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(112, 28);
            this.btnadd.TabIndex = 28;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgorder
            // 
            this.dgorder.BackgroundColor = System.Drawing.Color.Gray;
            this.dgorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgorder.Location = new System.Drawing.Point(378, 84);
            this.dgorder.Margin = new System.Windows.Forms.Padding(2);
            this.dgorder.Name = "dgorder";
            this.dgorder.RowHeadersWidth = 51;
            this.dgorder.RowTemplate.Height = 24;
            this.dgorder.Size = new System.Drawing.Size(570, 299);
            this.dgorder.TabIndex = 27;
            // 
            // dateorder
            // 
            this.dateorder.CalendarTitleForeColor = System.Drawing.Color.IndianRed;
            this.dateorder.CustomFormat = "dd-MM-yyyy";
            this.dateorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateorder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateorder.Location = new System.Drawing.Point(174, 186);
            this.dateorder.Margin = new System.Windows.Forms.Padding(2);
            this.dateorder.Name = "dateorder";
            this.dateorder.Size = new System.Drawing.Size(151, 23);
            this.dateorder.TabIndex = 26;
            // 
            // lblorderdate
            // 
            this.lblorderdate.AutoSize = true;
            this.lblorderdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblorderdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderdate.ForeColor = System.Drawing.Color.White;
            this.lblorderdate.Location = new System.Drawing.Point(16, 190);
            this.lblorderdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblorderdate.Name = "lblorderdate";
            this.lblorderdate.Size = new System.Drawing.Size(115, 20);
            this.lblorderdate.TabIndex = 25;
            this.lblorderdate.Text = "Ordered date";
            // 
            // cbotype
            // 
            this.cbotype.BackColor = System.Drawing.Color.White;
            this.cbotype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotype.FormattingEnabled = true;
            this.cbotype.Items.AddRange(new object[] {
            "offline"});
            this.cbotype.Location = new System.Drawing.Point(174, 123);
            this.cbotype.Margin = new System.Windows.Forms.Padding(2);
            this.cbotype.Name = "cbotype";
            this.cbotype.Size = new System.Drawing.Size(151, 25);
            this.cbotype.TabIndex = 24;
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.ForeColor = System.Drawing.Color.White;
            this.lbltype.Location = new System.Drawing.Point(16, 125);
            this.lbltype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(93, 20);
            this.lbltype.TabIndex = 23;
            this.lbltype.Text = "Order type";
            // 
            // txtqun
            // 
            this.txtqun.BackColor = System.Drawing.Color.White;
            this.txtqun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqun.Location = new System.Drawing.Point(174, 245);
            this.txtqun.Margin = new System.Windows.Forms.Padding(2);
            this.txtqun.Name = "txtqun";
            this.txtqun.Size = new System.Drawing.Size(151, 23);
            this.txtqun.TabIndex = 18;
            // 
            // lblno
            // 
            this.lblno.AutoSize = true;
            this.lblno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblno.ForeColor = System.Drawing.Color.White;
            this.lblno.Location = new System.Drawing.Point(16, 247);
            this.lblno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblno.Name = "lblno";
            this.lblno.Size = new System.Drawing.Size(121, 20);
            this.lblno.TabIndex = 17;
            this.lblno.Text = "Total Quantity";
            // 
            // menuStriplogout
            // 
            this.menuStriplogout.BackColor = System.Drawing.Color.Black;
            this.menuStriplogout.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStriplogout.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboard,
            this.customer,
            this.orderitem,
            this.payment,
            this.catagory,
            this.product,
            this.supply,
            this.logout,
            this.Employee,
            this.AddUser,
            this.report});
            this.menuStriplogout.Location = new System.Drawing.Point(0, 0);
            this.menuStriplogout.Name = "menuStriplogout";
            this.menuStriplogout.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStriplogout.Size = new System.Drawing.Size(976, 24);
            this.menuStriplogout.TabIndex = 36;
            this.menuStriplogout.Text = "LOG OUT MENU STRIP";
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.Black;
            this.dashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(94, 20);
            this.dashboard.Text = "DASHBOARD";
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click_1);
            // 
            // customer
            // 
            this.customer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(92, 20);
            this.customer.Text = "COUSTOMER";
            this.customer.Click += new System.EventHandler(this.customer_Click_1);
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
            // payment
            // 
            this.payment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(72, 20);
            this.payment.Text = "PAYMENT";
            this.payment.Click += new System.EventHandler(this.payment_Click);
            // 
            // catagory
            // 
            this.catagory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.catagory.Name = "catagory";
            this.catagory.Size = new System.Drawing.Size(79, 20);
            this.catagory.Text = "CATEGORY";
            this.catagory.Click += new System.EventHandler(this.catagory_Click_1);
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
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(71, 20);
            this.logout.Text = "LOG OUT";
            this.logout.Click += new System.EventHandler(this.logout_Click_1);
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
            // txtcusid
            // 
            this.txtcusid.BackColor = System.Drawing.Color.White;
            this.txtcusid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusid.Location = new System.Drawing.Point(174, 305);
            this.txtcusid.Margin = new System.Windows.Forms.Padding(2);
            this.txtcusid.Name = "txtcusid";
            this.txtcusid.Size = new System.Drawing.Size(151, 23);
            this.txtcusid.TabIndex = 38;
            // 
            // lblCusid
            // 
            this.lblCusid.AutoSize = true;
            this.lblCusid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCusid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusid.ForeColor = System.Drawing.Color.White;
            this.lblCusid.Location = new System.Drawing.Point(16, 307);
            this.lblCusid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCusid.Name = "lblCusid";
            this.lblCusid.Size = new System.Drawing.Size(110, 20);
            this.lblCusid.TabIndex = 37;
            this.lblCusid.Text = "Customer ID";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(34, 20);
            this.toolStripMenuItem2.Text = "BIl";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(334, 519);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(112, 28);
            this.btnupdate.TabIndex = 39;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(181, 519);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(112, 28);
            this.btndelete.TabIndex = 40;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = global::project_GUI.Properties.Resources.order;
            this.ClientSize = new System.Drawing.Size(976, 582);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtcusid);
            this.Controls.Add(this.lblCusid);
            this.Controls.Add(this.menuStriplogout);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgorder);
            this.Controls.Add(this.dateorder);
            this.Controls.Add(this.lblorderdate);
            this.Controls.Add(this.cbotype);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.txtqun);
            this.Controls.Add(this.lblno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgorder)).EndInit();
            this.menuStriplogout.ResumeLayout(false);
            this.menuStriplogout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgorder;
        private System.Windows.Forms.DateTimePicker dateorder;
        private System.Windows.Forms.Label lblorderdate;
        private System.Windows.Forms.ComboBox cbotype;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.TextBox txtqun;
        private System.Windows.Forms.Label lblno;
        private System.Windows.Forms.MenuStrip menuStriplogout;
        private System.Windows.Forms.TextBox txtcusid;
        private System.Windows.Forms.Label lblCusid;
        private System.Windows.Forms.ToolStripMenuItem dashboard;
        private System.Windows.Forms.ToolStripMenuItem customer;
        private System.Windows.Forms.ToolStripMenuItem orderitem;
        private System.Windows.Forms.ToolStripMenuItem payment;
        private System.Windows.Forms.ToolStripMenuItem catagory;
        private System.Windows.Forms.ToolStripMenuItem product;
        private System.Windows.Forms.ToolStripMenuItem supply;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.ToolStripMenuItem Employee;
        private System.Windows.Forms.ToolStripMenuItem AddUser;
        private System.Windows.Forms.ToolStripMenuItem report;
    }
}