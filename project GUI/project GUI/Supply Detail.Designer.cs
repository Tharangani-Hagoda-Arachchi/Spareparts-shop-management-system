
namespace project_GUI
{
    partial class Supply_Detail
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
            this.payment = new System.Windows.Forms.ToolStripMenuItem();
            this.category = new System.Windows.Forms.ToolStripMenuItem();
            this.product = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.AddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.report = new System.Windows.Forms.ToolStripMenuItem();
            this.btnview = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dataGridViewSupplier = new System.Windows.Forms.DataGridView();
            this.txtSuoTp = new System.Windows.Forms.TextBox();
            this.txtSupname = new System.Windows.Forms.TextBox();
            this.lblTp = new System.Windows.Forms.Label();
            this.lblsupname = new System.Windows.Forms.Label();
            this.menuStripcoustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Yellow;
            this.btnDelete.Location = new System.Drawing.Point(451, 437);
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
            this.btnupdate.BackColor = System.Drawing.Color.Black;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Yellow;
            this.btnupdate.Location = new System.Drawing.Point(139, 435);
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
            this.payment,
            this.category,
            this.product,
            this.logout,
            this.Employee,
            this.AddUser,
            this.report});
            this.menuStripcoustomer.Location = new System.Drawing.Point(0, 0);
            this.menuStripcoustomer.Name = "menuStripcoustomer";
            this.menuStripcoustomer.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripcoustomer.Size = new System.Drawing.Size(926, 24);
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
            this.category.Size = new System.Drawing.Size(79, 20);
            this.category.Text = "CATEGORY";
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
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(71, 20);
            this.logout.Text = "LOG OUT";
            this.logout.Click += new System.EventHandler(this.logout_Click);
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
            this.btnview.BackColor = System.Drawing.Color.Black;
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.Yellow;
            this.btnview.Location = new System.Drawing.Point(761, 440);
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
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Yellow;
            this.btnExit.Location = new System.Drawing.Point(598, 439);
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
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Yellow;
            this.btnClear.Location = new System.Drawing.Point(290, 437);
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
            this.btnadd.BackColor = System.Drawing.Color.Black;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.Yellow;
            this.btnadd.Location = new System.Drawing.Point(4, 435);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(92, 35);
            this.btnadd.TabIndex = 48;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dataGridViewSupplier
            // 
            this.dataGridViewSupplier.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridViewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplier.Location = new System.Drawing.Point(384, 86);
            this.dataGridViewSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSupplier.Name = "dataGridViewSupplier";
            this.dataGridViewSupplier.RowHeadersWidth = 51;
            this.dataGridViewSupplier.RowTemplate.Height = 24;
            this.dataGridViewSupplier.Size = new System.Drawing.Size(517, 273);
            this.dataGridViewSupplier.TabIndex = 47;
            // 
            // txtSuoTp
            // 
            this.txtSuoTp.BackColor = System.Drawing.Color.White;
            this.txtSuoTp.Location = new System.Drawing.Point(175, 254);
            this.txtSuoTp.Margin = new System.Windows.Forms.Padding(2);
            this.txtSuoTp.Name = "txtSuoTp";
            this.txtSuoTp.Size = new System.Drawing.Size(153, 20);
            this.txtSuoTp.TabIndex = 46;
            // 
            // txtSupname
            // 
            this.txtSupname.BackColor = System.Drawing.Color.White;
            this.txtSupname.Location = new System.Drawing.Point(175, 186);
            this.txtSupname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupname.Name = "txtSupname";
            this.txtSupname.Size = new System.Drawing.Size(153, 20);
            this.txtSupname.TabIndex = 45;
            // 
            // lblTp
            // 
            this.lblTp.AutoSize = true;
            this.lblTp.BackColor = System.Drawing.Color.Black;
            this.lblTp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTp.ForeColor = System.Drawing.Color.Yellow;
            this.lblTp.Location = new System.Drawing.Point(28, 251);
            this.lblTp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTp.Name = "lblTp";
            this.lblTp.Size = new System.Drawing.Size(120, 20);
            this.lblTp.TabIndex = 43;
            this.lblTp.Text = "Telephone No";
            this.lblTp.Click += new System.EventHandler(this.lblpassword_Click);
            // 
            // lblsupname
            // 
            this.lblsupname.AutoSize = true;
            this.lblsupname.BackColor = System.Drawing.Color.Black;
            this.lblsupname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsupname.ForeColor = System.Drawing.Color.Yellow;
            this.lblsupname.Location = new System.Drawing.Point(28, 186);
            this.lblsupname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsupname.Name = "lblsupname";
            this.lblsupname.Size = new System.Drawing.Size(126, 20);
            this.lblsupname.TabIndex = 42;
            this.lblsupname.Text = "Supplier Name";
            // 
            // Supply_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_GUI.Properties.Resources.supply;
            this.ClientSize = new System.Drawing.Size(926, 526);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.menuStripcoustomer);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridViewSupplier);
            this.Controls.Add(this.txtSuoTp);
            this.Controls.Add(this.txtSupname);
            this.Controls.Add(this.lblTp);
            this.Controls.Add(this.lblsupname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Supply_Detail";
            this.Text = "Supply Detail";
            this.Load += new System.EventHandler(this.Supply_Detail_Load);
            this.menuStripcoustomer.ResumeLayout(false);
            this.menuStripcoustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem payment;
        private System.Windows.Forms.ToolStripMenuItem category;
        private System.Windows.Forms.ToolStripMenuItem product;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dataGridViewSupplier;
        private System.Windows.Forms.TextBox txtSuoTp;
        private System.Windows.Forms.TextBox txtSupname;
        private System.Windows.Forms.Label lblTp;
        private System.Windows.Forms.Label lblsupname;
        private System.Windows.Forms.ToolStripMenuItem Employee;
        private System.Windows.Forms.ToolStripMenuItem AddUser;
        private System.Windows.Forms.ToolStripMenuItem report;
    }
}