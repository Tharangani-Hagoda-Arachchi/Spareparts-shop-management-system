
namespace project_GUI
{
    partial class Add_user
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
            this.lblemployeeiod = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtEId = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.dataGridViewAdduser = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.menuStripcoustomer = new System.Windows.Forms.MenuStrip();
            this.dashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.order = new System.Windows.Forms.ToolStripMenuItem();
            this.orderitem = new System.Windows.Forms.ToolStripMenuItem();
            this.payment = new System.Windows.Forms.ToolStripMenuItem();
            this.category = new System.Windows.Forms.ToolStripMenuItem();
            this.product = new System.Windows.Forms.ToolStripMenuItem();
            this.supply = new System.Windows.Forms.ToolStripMenuItem();
            this.customer = new System.Windows.Forms.ToolStripMenuItem();
            this.employee = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.report = new System.Windows.Forms.ToolStripMenuItem();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdduser)).BeginInit();
            this.menuStripcoustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblemployeeiod
            // 
            this.lblemployeeiod.AutoSize = true;
            this.lblemployeeiod.BackColor = System.Drawing.Color.Black;
            this.lblemployeeiod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemployeeiod.ForeColor = System.Drawing.Color.Yellow;
            this.lblemployeeiod.Location = new System.Drawing.Point(28, 124);
            this.lblemployeeiod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblemployeeiod.Name = "lblemployeeiod";
            this.lblemployeeiod.Size = new System.Drawing.Size(111, 20);
            this.lblemployeeiod.TabIndex = 0;
            this.lblemployeeiod.Text = "Employee ID";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Black;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.Yellow;
            this.lblusername.Location = new System.Drawing.Point(28, 184);
            this.lblusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(98, 20);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "User Name";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Black;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.Yellow;
            this.lblpassword.Location = new System.Drawing.Point(28, 249);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(86, 20);
            this.lblpassword.TabIndex = 2;
            this.lblpassword.Text = "Password";
            // 
            // txtEId
            // 
            this.txtEId.BackColor = System.Drawing.Color.White;
            this.txtEId.Location = new System.Drawing.Point(175, 126);
            this.txtEId.Margin = new System.Windows.Forms.Padding(2);
            this.txtEId.Name = "txtEId";
            this.txtEId.Size = new System.Drawing.Size(153, 20);
            this.txtEId.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(175, 184);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(153, 20);
            this.txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(175, 252);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(153, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // dataGridViewAdduser
            // 
            this.dataGridViewAdduser.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridViewAdduser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdduser.Location = new System.Drawing.Point(424, 76);
            this.dataGridViewAdduser.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAdduser.Name = "dataGridViewAdduser";
            this.dataGridViewAdduser.RowHeadersWidth = 51;
            this.dataGridViewAdduser.RowTemplate.Height = 24;
            this.dataGridViewAdduser.Size = new System.Drawing.Size(566, 273);
            this.dataGridViewAdduser.TabIndex = 6;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Black;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.Yellow;
            this.btnadd.Location = new System.Drawing.Point(9, 448);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(92, 35);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Yellow;
            this.btnClear.Location = new System.Drawing.Point(400, 447);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 35);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Yellow;
            this.btnExit.Location = new System.Drawing.Point(705, 448);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 35);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.Black;
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.Yellow;
            this.btnview.Location = new System.Drawing.Point(872, 448);
            this.btnview.Margin = new System.Windows.Forms.Padding(2);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(118, 35);
            this.btnview.TabIndex = 10;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // menuStripcoustomer
            // 
            this.menuStripcoustomer.BackColor = System.Drawing.Color.Black;
            this.menuStripcoustomer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripcoustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboard,
            this.order,
            this.orderitem,
            this.payment,
            this.category,
            this.product,
            this.supply,
            this.customer,
            this.employee,
            this.logout,
            this.report});
            this.menuStripcoustomer.Location = new System.Drawing.Point(0, 0);
            this.menuStripcoustomer.Name = "menuStripcoustomer";
            this.menuStripcoustomer.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripcoustomer.Size = new System.Drawing.Size(1127, 24);
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
            // payment
            // 
            this.payment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(114, 20);
            this.payment.Text = "PAYMENT DETAIL";
            this.payment.Click += new System.EventHandler(this.payment_Click);
            // 
            // category
            // 
            this.category.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(121, 20);
            this.category.Text = "CATEGORY DETAIL";
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
            // customer
            // 
            this.customer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(132, 20);
            this.customer.Text = "CUSTOMER DETAILS";
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // employee
            // 
            this.employee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(77, 20);
            this.employee.Text = "EMPLOYEE";
            this.employee.Click += new System.EventHandler(this.employee_Click);
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
            // report
            // 
            this.report.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(64, 20);
            this.report.Text = "REPORT";
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Black;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Yellow;
            this.btnupdate.Location = new System.Drawing.Point(236, 448);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(93, 37);
            this.btnupdate.TabIndex = 28;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Yellow;
            this.btnDelete.Location = new System.Drawing.Point(556, 447);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 37);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = global::project_GUI.Properties.Resources.add;
            this.ClientSize = new System.Drawing.Size(1127, 547);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.menuStripcoustomer);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridViewAdduser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtEId);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblemployeeiod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Add_user";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.Add_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdduser)).EndInit();
            this.menuStripcoustomer.ResumeLayout(false);
            this.menuStripcoustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblemployeeiod;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtEId;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DataGridView dataGridViewAdduser;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.MenuStrip menuStripcoustomer;
        private System.Windows.Forms.ToolStripMenuItem dashboard;
        private System.Windows.Forms.ToolStripMenuItem order;
        private System.Windows.Forms.ToolStripMenuItem orderitem;
        private System.Windows.Forms.ToolStripMenuItem payment;
        private System.Windows.Forms.ToolStripMenuItem category;
        private System.Windows.Forms.ToolStripMenuItem product;
        private System.Windows.Forms.ToolStripMenuItem supply;
        private System.Windows.Forms.ToolStripMenuItem employee;
        private System.Windows.Forms.ToolStripMenuItem customer;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripMenuItem report;
    }
}