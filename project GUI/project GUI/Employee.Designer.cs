
namespace project_GUI
{
    partial class Empoyee
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
            this.dgemployee = new System.Windows.Forms.DataGridView();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtemname = new System.Windows.Forms.TextBox();
            this.lblsalary = new System.Windows.Forms.Label();
            this.lblwrkday = new System.Windows.Forms.Label();
            this.lblemname = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.menuStriplogout = new System.Windows.Forms.MenuStrip();
            this.dashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.customer = new System.Windows.Forms.ToolStripMenuItem();
            this.order = new System.Windows.Forms.ToolStripMenuItem();
            this.orderitem = new System.Windows.Forms.ToolStripMenuItem();
            this.payment = new System.Windows.Forms.ToolStripMenuItem();
            this.category = new System.Windows.Forms.ToolStripMenuItem();
            this.product = new System.Windows.Forms.ToolStripMenuItem();
            this.supply = new System.Windows.Forms.ToolStripMenuItem();
            this.adduser = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.report = new System.Windows.Forms.ToolStripMenuItem();
            this.txtemid = new System.Windows.Forms.TextBox();
            this.lblemid = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgemployee)).BeginInit();
            this.menuStriplogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.Blue;
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.White;
            this.btnview.Location = new System.Drawing.Point(605, 505);
            this.btnview.Margin = new System.Windows.Forms.Padding(2);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(95, 37);
            this.btnview.TabIndex = 25;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // dgemployee
            // 
            this.dgemployee.BackgroundColor = System.Drawing.Color.Silver;
            this.dgemployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgemployee.Location = new System.Drawing.Point(412, 93);
            this.dgemployee.Margin = new System.Windows.Forms.Padding(2);
            this.dgemployee.Name = "dgemployee";
            this.dgemployee.RowHeadersWidth = 51;
            this.dgemployee.RowTemplate.Height = 24;
            this.dgemployee.Size = new System.Drawing.Size(556, 302);
            this.dgemployee.TabIndex = 24;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Blue;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(752, 505);
            this.btnexit.Margin = new System.Windows.Forms.Padding(2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(97, 37);
            this.btnexit.TabIndex = 23;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Blue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(307, 505);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 37);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Blue;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(168, 505);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(93, 37);
            this.btnupdate.TabIndex = 21;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btncal_Click);
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.White;
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(188, 194);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(156, 23);
            this.txtaddress.TabIndex = 19;
            // 
            // txtemname
            // 
            this.txtemname.BackColor = System.Drawing.Color.White;
            this.txtemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemname.Location = new System.Drawing.Point(188, 139);
            this.txtemname.Margin = new System.Windows.Forms.Padding(2);
            this.txtemname.Name = "txtemname";
            this.txtemname.Size = new System.Drawing.Size(156, 23);
            this.txtemname.TabIndex = 17;
            // 
            // lblsalary
            // 
            this.lblsalary.AutoSize = true;
            this.lblsalary.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalary.ForeColor = System.Drawing.Color.White;
            this.lblsalary.Location = new System.Drawing.Point(37, 318);
            this.lblsalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsalary.Name = "lblsalary";
            this.lblsalary.Size = new System.Drawing.Size(0, 18);
            this.lblsalary.TabIndex = 16;
            // 
            // lblwrkday
            // 
            this.lblwrkday.AutoSize = true;
            this.lblwrkday.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblwrkday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwrkday.ForeColor = System.Drawing.Color.White;
            this.lblwrkday.Location = new System.Drawing.Point(18, 197);
            this.lblwrkday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblwrkday.Name = "lblwrkday";
            this.lblwrkday.Size = new System.Drawing.Size(148, 18);
            this.lblwrkday.TabIndex = 15;
            this.lblwrkday.Text = "Employee Address";
            // 
            // lblemname
            // 
            this.lblemname.AutoSize = true;
            this.lblemname.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemname.ForeColor = System.Drawing.Color.White;
            this.lblemname.Location = new System.Drawing.Point(18, 144);
            this.lblemname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblemname.Name = "lblemname";
            this.lblemname.Size = new System.Drawing.Size(131, 18);
            this.lblemname.TabIndex = 13;
            this.lblemname.Text = "Employee Name";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Blue;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(21, 505);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(98, 37);
            this.btnadd.TabIndex = 26;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // menuStriplogout
            // 
            this.menuStriplogout.BackColor = System.Drawing.Color.Black;
            this.menuStriplogout.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStriplogout.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboard,
            this.customer,
            this.order,
            this.orderitem,
            this.payment,
            this.category,
            this.product,
            this.supply,
            this.adduser,
            this.logout,
            this.report});
            this.menuStriplogout.Location = new System.Drawing.Point(0, 0);
            this.menuStriplogout.Name = "menuStriplogout";
            this.menuStriplogout.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStriplogout.Size = new System.Drawing.Size(1017, 24);
            this.menuStriplogout.TabIndex = 28;
            this.menuStriplogout.Text = "LOG OUT MENU STRIP";
            // 
            // dashboard
            // 
            this.dashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.Green;
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(94, 20);
            this.dashboard.Text = "DASHBOARD";
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click_1);
            // 
            // customer
            // 
            this.customer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.ForeColor = System.Drawing.Color.Green;
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(92, 20);
            this.customer.Text = "COUSTOMER";
            this.customer.Click += new System.EventHandler(this.customer_Click_1);
            // 
            // order
            // 
            this.order.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.ForeColor = System.Drawing.Color.Green;
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(59, 20);
            this.order.Text = "ORDER";
            this.order.Click += new System.EventHandler(this.order_Click_1);
            // 
            // orderitem
            // 
            this.orderitem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderitem.ForeColor = System.Drawing.Color.Green;
            this.orderitem.Name = "orderitem";
            this.orderitem.Size = new System.Drawing.Size(90, 20);
            this.orderitem.Text = "ORDER ITEM";
            this.orderitem.Click += new System.EventHandler(this.orderitem_Click);
            // 
            // payment
            // 
            this.payment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.ForeColor = System.Drawing.Color.Green;
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(72, 20);
            this.payment.Text = "PAYMENT";
            this.payment.Click += new System.EventHandler(this.payment_Click);
            // 
            // category
            // 
            this.category.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.ForeColor = System.Drawing.Color.Green;
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(79, 20);
            this.category.Text = "CATEGORY";
            this.category.Click += new System.EventHandler(this.category_Click);
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.ForeColor = System.Drawing.Color.Green;
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(75, 20);
            this.product.Text = "PRODUCT";
            this.product.Click += new System.EventHandler(this.product_Click_1);
            // 
            // supply
            // 
            this.supply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supply.ForeColor = System.Drawing.Color.Green;
            this.supply.Name = "supply";
            this.supply.Size = new System.Drawing.Size(103, 20);
            this.supply.Text = "SUPPLY DETAIL";
            this.supply.Click += new System.EventHandler(this.supply_Click_1);
            // 
            // adduser
            // 
            this.adduser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adduser.ForeColor = System.Drawing.Color.Green;
            this.adduser.Name = "adduser";
            this.adduser.Size = new System.Drawing.Size(78, 20);
            this.adduser.Text = "ADD USER";
            this.adduser.Click += new System.EventHandler(this.adduser_Click);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Green;
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(71, 20);
            this.logout.Text = "LOG OUT";
            this.logout.Click += new System.EventHandler(this.logout_Click_1);
            // 
            // report
            // 
            this.report.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.ForeColor = System.Drawing.Color.Green;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(64, 20);
            this.report.Text = "REPORT";
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // txtemid
            // 
            this.txtemid.BackColor = System.Drawing.Color.White;
            this.txtemid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemid.Location = new System.Drawing.Point(188, 84);
            this.txtemid.Margin = new System.Windows.Forms.Padding(2);
            this.txtemid.Name = "txtemid";
            this.txtemid.Size = new System.Drawing.Size(156, 23);
            this.txtemid.TabIndex = 30;
            // 
            // lblemid
            // 
            this.lblemid.AutoSize = true;
            this.lblemid.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblemid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemid.ForeColor = System.Drawing.Color.White;
            this.lblemid.Location = new System.Drawing.Point(18, 84);
            this.lblemid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblemid.Name = "lblemid";
            this.lblemid.Size = new System.Drawing.Size(103, 18);
            this.lblemid.TabIndex = 29;
            this.lblemid.Text = "Employee ID";
            // 
            // txtcontact
            // 
            this.txtcontact.BackColor = System.Drawing.Color.White;
            this.txtcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontact.Location = new System.Drawing.Point(188, 280);
            this.txtcontact.Margin = new System.Windows.Forms.Padding(2);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(156, 23);
            this.txtcontact.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 283);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Contact Number";
            // 
            // txtrole
            // 
            this.txtrole.BackColor = System.Drawing.Color.White;
            this.txtrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrole.Location = new System.Drawing.Point(188, 336);
            this.txtrole.Margin = new System.Windows.Forms.Padding(2);
            this.txtrole.Name = "txtrole";
            this.txtrole.Size = new System.Drawing.Size(156, 23);
            this.txtrole.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 336);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Employee Role";
            // 
            // txtdes
            // 
            this.txtdes.BackColor = System.Drawing.Color.White;
            this.txtdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdes.Location = new System.Drawing.Point(188, 392);
            this.txtdes.Margin = new System.Windows.Forms.Padding(2);
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(156, 23);
            this.txtdes.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 396);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Discription";
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.White;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(188, 236);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(156, 23);
            this.txtemail.TabIndex = 38;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.White;
            this.lblemail.Location = new System.Drawing.Point(18, 240);
            this.lblemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(129, 18);
            this.lblemail.TabIndex = 37;
            this.lblemail.Text = "Employee Email";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Blue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(457, 505);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 37);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Empoyee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = global::project_GUI.Properties.Resources.employee;
            this.ClientSize = new System.Drawing.Size(1017, 600);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtrole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtemid);
            this.Controls.Add(this.lblemid);
            this.Controls.Add(this.menuStriplogout);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.dgemployee);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtemname);
            this.Controls.Add(this.lblsalary);
            this.Controls.Add(this.lblwrkday);
            this.Controls.Add(this.lblemname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Empoyee";
            this.Text = "EMPLOYEE";
            this.Load += new System.EventHandler(this.Empoyee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgemployee)).EndInit();
            this.menuStriplogout.ResumeLayout(false);
            this.menuStriplogout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.DataGridView dgemployee;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtemname;
        private System.Windows.Forms.Label lblsalary;
        private System.Windows.Forms.Label lblwrkday;
        private System.Windows.Forms.Label lblemname;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.MenuStrip menuStriplogout;
        private System.Windows.Forms.ToolStripMenuItem dashboard;
        private System.Windows.Forms.ToolStripMenuItem customer;
        private System.Windows.Forms.ToolStripMenuItem order;
        private System.Windows.Forms.ToolStripMenuItem orderitem;
        private System.Windows.Forms.ToolStripMenuItem payment;
        private System.Windows.Forms.ToolStripMenuItem category;
        private System.Windows.Forms.ToolStripMenuItem product;
        private System.Windows.Forms.ToolStripMenuItem supply;
        private System.Windows.Forms.ToolStripMenuItem adduser;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.TextBox txtemid;
        private System.Windows.Forms.Label lblemid;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripMenuItem report;
    }
}