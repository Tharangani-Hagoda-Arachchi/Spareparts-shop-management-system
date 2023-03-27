
namespace project_GUI
{
    partial class order_item_detail
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
            this.txtproid = new System.Windows.Forms.TextBox();
            this.lblproid = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.menuStripcoustomer = new System.Windows.Forms.MenuStrip();
            this.dashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.order = new System.Windows.Forms.ToolStripMenuItem();
            this.customer = new System.Windows.Forms.ToolStripMenuItem();
            this.payment = new System.Windows.Forms.ToolStripMenuItem();
            this.catageory = new System.Windows.Forms.ToolStripMenuItem();
            this.product = new System.Windows.Forms.ToolStripMenuItem();
            this.supply = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.AddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.report = new System.Windows.Forms.ToolStripMenuItem();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.btnview = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dataGridVieworderitem = new System.Windows.Forms.DataGridView();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtproname = new System.Windows.Forms.TextBox();
            this.txtordid = new System.Windows.Forms.TextBox();
            this.lblquantity = new System.Windows.Forms.Label();
            this.lblproname = new System.Windows.Forms.Label();
            this.lblorderid = new System.Windows.Forms.Label();
            this.menuStripcoustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieworderitem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtproid
            // 
            this.txtproid.BackColor = System.Drawing.Color.PowderBlue;
            this.txtproid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproid.Location = new System.Drawing.Point(167, 380);
            this.txtproid.Margin = new System.Windows.Forms.Padding(2);
            this.txtproid.Name = "txtproid";
            this.txtproid.Size = new System.Drawing.Size(148, 23);
            this.txtproid.TabIndex = 50;
            // 
            // lblproid
            // 
            this.lblproid.AutoSize = true;
            this.lblproid.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblproid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproid.ForeColor = System.Drawing.Color.Black;
            this.lblproid.Location = new System.Drawing.Point(20, 382);
            this.lblproid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblproid.Name = "lblproid";
            this.lblproid.Size = new System.Drawing.Size(92, 20);
            this.lblproid.TabIndex = 49;
            this.lblproid.Text = "Product Id";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Blue;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(463, 512);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(92, 35);
            this.btndelete.TabIndex = 48;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Blue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(323, 512);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 35);
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // menuStripcoustomer
            // 
            this.menuStripcoustomer.BackColor = System.Drawing.Color.Black;
            this.menuStripcoustomer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripcoustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboard,
            this.order,
            this.customer,
            this.payment,
            this.catageory,
            this.product,
            this.supply,
            this.logout,
            this.Employee,
            this.AddUser,
            this.report});
            this.menuStripcoustomer.Location = new System.Drawing.Point(0, 0);
            this.menuStripcoustomer.Name = "menuStripcoustomer";
            this.menuStripcoustomer.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripcoustomer.Size = new System.Drawing.Size(1018, 24);
            this.menuStripcoustomer.TabIndex = 46;
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
            this.payment.Size = new System.Drawing.Size(114, 20);
            this.payment.Text = "PAYMENT DETAIL";
            this.payment.Click += new System.EventHandler(this.payment_Click);
            // 
            // catageory
            // 
            this.catageory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catageory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.catageory.Name = "catageory";
            this.catageory.Size = new System.Drawing.Size(121, 20);
            this.catageory.Text = "CATEGORY DETAIL";
            this.catageory.Click += new System.EventHandler(this.catageory_Click);
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
            // txtdiscount
            // 
            this.txtdiscount.BackColor = System.Drawing.Color.PowderBlue;
            this.txtdiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscount.Location = new System.Drawing.Point(167, 258);
            this.txtdiscount.Margin = new System.Windows.Forms.Padding(2);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(148, 23);
            this.txtdiscount.TabIndex = 45;
            // 
            // lbldiscount
            // 
            this.lbldiscount.AutoSize = true;
            this.lbldiscount.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbldiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscount.ForeColor = System.Drawing.Color.Black;
            this.lbldiscount.Location = new System.Drawing.Point(20, 260);
            this.lbldiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(80, 20);
            this.lbldiscount.TabIndex = 44;
            this.lbldiscount.Text = "Discount";
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.Blue;
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.White;
            this.btnview.Location = new System.Drawing.Point(761, 512);
            this.btnview.Margin = new System.Windows.Forms.Padding(2);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(86, 35);
            this.btnview.TabIndex = 43;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Blue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(611, 512);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 35);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Blue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(174, 512);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 35);
            this.btnClear.TabIndex = 41;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Blue;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(29, 512);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(85, 35);
            this.btnadd.TabIndex = 40;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dataGridVieworderitem
            // 
            this.dataGridVieworderitem.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridVieworderitem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridVieworderitem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridVieworderitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVieworderitem.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridVieworderitem.Location = new System.Drawing.Point(359, 106);
            this.dataGridVieworderitem.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridVieworderitem.Name = "dataGridVieworderitem";
            this.dataGridVieworderitem.RowHeadersWidth = 51;
            this.dataGridVieworderitem.RowTemplate.Height = 24;
            this.dataGridVieworderitem.Size = new System.Drawing.Size(514, 296);
            this.dataGridVieworderitem.TabIndex = 39;
            // 
            // txtquantity
            // 
            this.txtquantity.BackColor = System.Drawing.Color.PowderBlue;
            this.txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(167, 190);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(148, 23);
            this.txtquantity.TabIndex = 38;
            // 
            // txtproname
            // 
            this.txtproname.BackColor = System.Drawing.Color.PowderBlue;
            this.txtproname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproname.Location = new System.Drawing.Point(167, 121);
            this.txtproname.Margin = new System.Windows.Forms.Padding(2);
            this.txtproname.Name = "txtproname";
            this.txtproname.Size = new System.Drawing.Size(148, 23);
            this.txtproname.TabIndex = 37;
            // 
            // txtordid
            // 
            this.txtordid.BackColor = System.Drawing.Color.PowderBlue;
            this.txtordid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtordid.Location = new System.Drawing.Point(167, 317);
            this.txtordid.Margin = new System.Windows.Forms.Padding(2);
            this.txtordid.Name = "txtordid";
            this.txtordid.Size = new System.Drawing.Size(148, 23);
            this.txtordid.TabIndex = 36;
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantity.ForeColor = System.Drawing.Color.Black;
            this.lblquantity.Location = new System.Drawing.Point(20, 192);
            this.lblquantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(76, 20);
            this.lblquantity.TabIndex = 35;
            this.lblquantity.Text = "Quantity";
            // 
            // lblproname
            // 
            this.lblproname.AutoSize = true;
            this.lblproname.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblproname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproname.ForeColor = System.Drawing.Color.Black;
            this.lblproname.Location = new System.Drawing.Point(20, 123);
            this.lblproname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblproname.Name = "lblproname";
            this.lblproname.Size = new System.Drawing.Size(122, 20);
            this.lblproname.TabIndex = 34;
            this.lblproname.Text = "Product Name";
            // 
            // lblorderid
            // 
            this.lblorderid.AutoSize = true;
            this.lblorderid.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblorderid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderid.ForeColor = System.Drawing.Color.Black;
            this.lblorderid.Location = new System.Drawing.Point(20, 318);
            this.lblorderid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblorderid.Name = "lblorderid";
            this.lblorderid.Size = new System.Drawing.Size(78, 20);
            this.lblorderid.TabIndex = 33;
            this.lblorderid.Text = "Order ID";
            // 
            // order_item_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_GUI.Properties.Resources.abc1__3_;
            this.ClientSize = new System.Drawing.Size(1018, 592);
            this.Controls.Add(this.txtproid);
            this.Controls.Add(this.lblproid);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.menuStripcoustomer);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.lbldiscount);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridVieworderitem);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtproname);
            this.Controls.Add(this.txtordid);
            this.Controls.Add(this.lblquantity);
            this.Controls.Add(this.lblproname);
            this.Controls.Add(this.lblorderid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "order_item_detail";
            this.Text = "  ORDER ITEM";
            this.Load += new System.EventHandler(this.order_item_detail_Load);
            this.menuStripcoustomer.ResumeLayout(false);
            this.menuStripcoustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieworderitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtproid;
        private System.Windows.Forms.Label lblproid;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.MenuStrip menuStripcoustomer;
        private System.Windows.Forms.ToolStripMenuItem dashboard;
        private System.Windows.Forms.ToolStripMenuItem order;
        private System.Windows.Forms.ToolStripMenuItem customer;
        private System.Windows.Forms.ToolStripMenuItem payment;
        private System.Windows.Forms.ToolStripMenuItem catageory;
        private System.Windows.Forms.ToolStripMenuItem product;
        private System.Windows.Forms.ToolStripMenuItem supply;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label lbldiscount;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dataGridVieworderitem;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtproname;
        private System.Windows.Forms.TextBox txtordid;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.Label lblproname;
        private System.Windows.Forms.Label lblorderid;
        private System.Windows.Forms.ToolStripMenuItem Employee;
        private System.Windows.Forms.ToolStripMenuItem AddUser;
        private System.Windows.Forms.ToolStripMenuItem report;
    }
}