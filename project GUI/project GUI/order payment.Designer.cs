
namespace project_GUI
{
    partial class order_payment
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.menuStripcoustomer = new System.Windows.Forms.MenuStrip();
            this.dashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.order = new System.Windows.Forms.ToolStripMenuItem();
            this.orderitem = new System.Windows.Forms.ToolStripMenuItem();
            this.customer = new System.Windows.Forms.ToolStripMenuItem();
            this.catagory = new System.Windows.Forms.ToolStripMenuItem();
            this.product = new System.Windows.Forms.ToolStripMenuItem();
            this.supply = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.AddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.report = new System.Windows.Forms.ToolStripMenuItem();
            this.btnview = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dataGridViewPayment = new System.Windows.Forms.DataGridView();
            this.txtpayamo = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblpayamo = new System.Windows.Forms.Label();
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.dateTimePickerpay = new System.Windows.Forms.DateTimePicker();
            this.txtorderid = new System.Windows.Forms.TextBox();
            this.lblorderid = new System.Windows.Forms.Label();
            this.btnonlinePay = new System.Windows.Forms.Button();
            this.menuStripcoustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(478, 477);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 37);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(158, 479);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(93, 37);
            this.btnupdate.TabIndex = 53;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
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
            this.catagory,
            this.product,
            this.supply,
            this.logout,
            this.Employee,
            this.AddUser,
            this.report});
            this.menuStripcoustomer.Location = new System.Drawing.Point(0, 0);
            this.menuStripcoustomer.Name = "menuStripcoustomer";
            this.menuStripcoustomer.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripcoustomer.Size = new System.Drawing.Size(999, 24);
            this.menuStripcoustomer.TabIndex = 52;
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
            // catagory
            // 
            this.catagory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.catagory.Name = "catagory";
            this.catagory.Size = new System.Drawing.Size(121, 20);
            this.catagory.Text = "CATEGORY DETAIL";
            this.catagory.Click += new System.EventHandler(this.catagory_Click);
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
            this.logout.Size = new System.Drawing.Size(68, 20);
            this.logout.Text = "LOGOUT";
            this.logout.Click += new System.EventHandler(this.Logout_Click);
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
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.White;
            this.btnview.Location = new System.Drawing.Point(794, 479);
            this.btnview.Margin = new System.Windows.Forms.Padding(2);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(118, 35);
            this.btnview.TabIndex = 51;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(627, 479);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 35);
            this.btnExit.TabIndex = 50;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(322, 477);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 35);
            this.btnClear.TabIndex = 49;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(9, 479);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(92, 35);
            this.btnadd.TabIndex = 48;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dataGridViewPayment
            // 
            this.dataGridViewPayment.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridViewPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayment.Location = new System.Drawing.Point(431, 87);
            this.dataGridViewPayment.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPayment.Name = "dataGridViewPayment";
            this.dataGridViewPayment.RowHeadersWidth = 51;
            this.dataGridViewPayment.RowTemplate.Height = 24;
            this.dataGridViewPayment.Size = new System.Drawing.Size(501, 273);
            this.dataGridViewPayment.TabIndex = 47;
            // 
            // txtpayamo
            // 
            this.txtpayamo.BackColor = System.Drawing.Color.White;
            this.txtpayamo.Location = new System.Drawing.Point(175, 114);
            this.txtpayamo.Margin = new System.Windows.Forms.Padding(2);
            this.txtpayamo.Name = "txtpayamo";
            this.txtpayamo.Size = new System.Drawing.Size(153, 20);
            this.txtpayamo.TabIndex = 44;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.White;
            this.lblpassword.Location = new System.Drawing.Point(28, 236);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(48, 20);
            this.lblpassword.TabIndex = 43;
            this.lblpassword.Text = "Date";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.ForeColor = System.Drawing.Color.White;
            this.lbltype.Location = new System.Drawing.Point(28, 171);
            this.lbltype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(121, 20);
            this.lbltype.TabIndex = 42;
            this.lbltype.Text = "Payment Type";
            // 
            // lblpayamo
            // 
            this.lblpayamo.AutoSize = true;
            this.lblpayamo.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblpayamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpayamo.ForeColor = System.Drawing.Color.White;
            this.lblpayamo.Location = new System.Drawing.Point(28, 111);
            this.lblpayamo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpayamo.Name = "lblpayamo";
            this.lblpayamo.Size = new System.Drawing.Size(105, 20);
            this.lblpayamo.TabIndex = 41;
            this.lblpayamo.Text = "Pay Amount";
            // 
            // cmbtype
            // 
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Cheque"});
            this.cmbtype.Location = new System.Drawing.Point(175, 175);
            this.cmbtype.Margin = new System.Windows.Forms.Padding(2);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(153, 21);
            this.cmbtype.TabIndex = 55;
            // 
            // dateTimePickerpay
            // 
            this.dateTimePickerpay.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerpay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerpay.Location = new System.Drawing.Point(175, 239);
            this.dateTimePickerpay.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerpay.Name = "dateTimePickerpay";
            this.dateTimePickerpay.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerpay.TabIndex = 56;
            // 
            // txtorderid
            // 
            this.txtorderid.BackColor = System.Drawing.Color.White;
            this.txtorderid.Location = new System.Drawing.Point(175, 311);
            this.txtorderid.Margin = new System.Windows.Forms.Padding(2);
            this.txtorderid.Name = "txtorderid";
            this.txtorderid.Size = new System.Drawing.Size(153, 20);
            this.txtorderid.TabIndex = 58;
            // 
            // lblorderid
            // 
            this.lblorderid.AutoSize = true;
            this.lblorderid.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblorderid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderid.ForeColor = System.Drawing.Color.White;
            this.lblorderid.Location = new System.Drawing.Point(28, 309);
            this.lblorderid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblorderid.Name = "lblorderid";
            this.lblorderid.Size = new System.Drawing.Size(75, 20);
            this.lblorderid.TabIndex = 57;
            this.lblorderid.Text = "order ID";
            // 
            // btnonlinePay
            // 
            this.btnonlinePay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnonlinePay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnonlinePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnonlinePay.ForeColor = System.Drawing.Color.White;
            this.btnonlinePay.Location = new System.Drawing.Point(568, 385);
            this.btnonlinePay.Margin = new System.Windows.Forms.Padding(2);
            this.btnonlinePay.Name = "btnonlinePay";
            this.btnonlinePay.Size = new System.Drawing.Size(291, 35);
            this.btnonlinePay.TabIndex = 59;
            this.btnonlinePay.Text = "View Online Payement Details";
            this.btnonlinePay.UseVisualStyleBackColor = false;
            this.btnonlinePay.Click += new System.EventHandler(this.btnonlinePay_Click);
            // 
            // order_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_GUI.Properties.Resources.payment;
            this.ClientSize = new System.Drawing.Size(999, 547);
            this.Controls.Add(this.btnonlinePay);
            this.Controls.Add(this.txtorderid);
            this.Controls.Add(this.lblorderid);
            this.Controls.Add(this.dateTimePickerpay);
            this.Controls.Add(this.cmbtype);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.menuStripcoustomer);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridViewPayment);
            this.Controls.Add(this.txtpayamo);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.lblpayamo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "order_payment";
            this.Text = " PAYMENT";
            this.Load += new System.EventHandler(this.order_payment_Load);
            this.menuStripcoustomer.ResumeLayout(false);
            this.menuStripcoustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.MenuStrip menuStripcoustomer;
        private System.Windows.Forms.ToolStripMenuItem dashboard;
        private System.Windows.Forms.ToolStripMenuItem order;
        private System.Windows.Forms.ToolStripMenuItem orderitem;
        private System.Windows.Forms.ToolStripMenuItem customer;
        private System.Windows.Forms.ToolStripMenuItem catagory;
        private System.Windows.Forms.ToolStripMenuItem product;
        private System.Windows.Forms.ToolStripMenuItem supply;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dataGridViewPayment;
        private System.Windows.Forms.TextBox txtpayamo;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblpayamo;
        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.DateTimePicker dateTimePickerpay;
        private System.Windows.Forms.TextBox txtorderid;
        private System.Windows.Forms.Label lblorderid;
        private System.Windows.Forms.ToolStripMenuItem Employee;
        private System.Windows.Forms.ToolStripMenuItem AddUser;
        private System.Windows.Forms.ToolStripMenuItem report;
        private System.Windows.Forms.Button btnonlinePay;
    }
}