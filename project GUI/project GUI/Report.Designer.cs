
namespace project_GUI
{
    partial class Report
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
            this.dataGridViewreport = new System.Windows.Forms.DataGridView();
            this.btnreport = new System.Windows.Forms.Button();
            this.menuStripreports = new System.Windows.Forms.MenuStrip();
            this.dashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.customer = new System.Windows.Forms.ToolStripMenuItem();
            this.order = new System.Windows.Forms.ToolStripMenuItem();
            this.orderitem = new System.Windows.Forms.ToolStripMenuItem();
            this.payment = new System.Windows.Forms.ToolStripMenuItem();
            this.category = new System.Windows.Forms.ToolStripMenuItem();
            this.product = new System.Windows.Forms.ToolStripMenuItem();
            this.supply = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.employee = new System.Windows.Forms.ToolStripMenuItem();
            this.adduser = new System.Windows.Forms.ToolStripMenuItem();
            this.export = new System.Windows.Forms.Button();
            this.lblsupname = new System.Windows.Forms.Label();
            this.dateTimePickerreport = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewreport)).BeginInit();
            this.menuStripreports.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewreport
            // 
            this.dataGridViewreport.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridViewreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewreport.Location = new System.Drawing.Point(38, 164);
            this.dataGridViewreport.Name = "dataGridViewreport";
            this.dataGridViewreport.RowHeadersWidth = 51;
            this.dataGridViewreport.RowTemplate.Height = 24;
            this.dataGridViewreport.Size = new System.Drawing.Size(899, 377);
            this.dataGridViewreport.TabIndex = 0;
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.Color.Navy;
            this.btnreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.ForeColor = System.Drawing.Color.Transparent;
            this.btnreport.Location = new System.Drawing.Point(461, 73);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(146, 39);
            this.btnreport.TabIndex = 1;
            this.btnreport.Text = "VIEW REPORT";
            this.btnreport.UseVisualStyleBackColor = false;
            this.btnreport.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStripreports
            // 
            this.menuStripreports.BackColor = System.Drawing.Color.Black;
            this.menuStripreports.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripreports.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboard,
            this.customer,
            this.order,
            this.orderitem,
            this.payment,
            this.category,
            this.product,
            this.supply,
            this.logout,
            this.employee,
            this.adduser});
            this.menuStripreports.Location = new System.Drawing.Point(0, 0);
            this.menuStripreports.Name = "menuStripreports";
            this.menuStripreports.Size = new System.Drawing.Size(988, 24);
            this.menuStripreports.TabIndex = 8;
            this.menuStripreports.Text = "Reports MENU STRIP";
            // 
            // dashboard
            // 
            this.dashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.Green;
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(94, 20);
            this.dashboard.Text = "DASHBOARD";
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // customer
            // 
            this.customer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.ForeColor = System.Drawing.Color.Green;
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(92, 20);
            this.customer.Text = "COUSTOMER";
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // order
            // 
            this.order.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.ForeColor = System.Drawing.Color.Green;
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(59, 20);
            this.order.Text = "ORDER";
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // orderitem
            // 
            this.orderitem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderitem.ForeColor = System.Drawing.Color.Green;
            this.orderitem.Name = "orderitem";
            this.orderitem.Size = new System.Drawing.Size(93, 20);
            this.orderitem.Text = "ORDER  ITEM";
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
            this.product.Click += new System.EventHandler(this.product_Click);
            // 
            // supply
            // 
            this.supply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supply.ForeColor = System.Drawing.Color.Green;
            this.supply.Name = "supply";
            this.supply.Size = new System.Drawing.Size(61, 20);
            this.supply.Text = "SUPPLY";
            this.supply.Click += new System.EventHandler(this.supply_Click);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Green;
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(71, 20);
            this.logout.Text = "LOG OUT";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // employee
            // 
            this.employee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee.ForeColor = System.Drawing.Color.Green;
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(77, 20);
            this.employee.Text = "EMPLOYEE";
            this.employee.Click += new System.EventHandler(this.employee_Click);
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
            // export
            // 
            this.export.BackColor = System.Drawing.Color.Navy;
            this.export.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export.ForeColor = System.Drawing.Color.White;
            this.export.Location = new System.Drawing.Point(713, 73);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(109, 39);
            this.export.TabIndex = 10;
            this.export.Text = "Export";
            this.export.UseVisualStyleBackColor = false;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // lblsupname
            // 
            this.lblsupname.AutoSize = true;
            this.lblsupname.BackColor = System.Drawing.Color.Black;
            this.lblsupname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsupname.ForeColor = System.Drawing.Color.Yellow;
            this.lblsupname.Location = new System.Drawing.Point(45, 82);
            this.lblsupname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsupname.Name = "lblsupname";
            this.lblsupname.Size = new System.Drawing.Size(56, 20);
            this.lblsupname.TabIndex = 43;
            this.lblsupname.Text = "DATE";
            // 
            // dateTimePickerreport
            // 
            this.dateTimePickerreport.CustomFormat = " ";
            this.dateTimePickerreport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerreport.Location = new System.Drawing.Point(146, 82);
            this.dateTimePickerreport.Name = "dateTimePickerreport";
            this.dateTimePickerreport.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerreport.TabIndex = 44;
            this.dateTimePickerreport.ValueChanged += new System.EventHandler(this.dateTimePickerreport_ValueChanged);
            this.dateTimePickerreport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerreport_KeyDown);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = global::project_GUI.Properties.Resources.Report_Writing;
            this.ClientSize = new System.Drawing.Size(988, 593);
            this.Controls.Add(this.dateTimePickerreport);
            this.Controls.Add(this.lblsupname);
            this.Controls.Add(this.export);
            this.Controls.Add(this.menuStripreports);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.dataGridViewreport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewreport)).EndInit();
            this.menuStripreports.ResumeLayout(false);
            this.menuStripreports.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewreport;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.MenuStrip menuStripreports;
        private System.Windows.Forms.ToolStripMenuItem dashboard;
        private System.Windows.Forms.ToolStripMenuItem customer;
        private System.Windows.Forms.ToolStripMenuItem order;
        private System.Windows.Forms.ToolStripMenuItem orderitem;
        private System.Windows.Forms.ToolStripMenuItem payment;
        private System.Windows.Forms.ToolStripMenuItem category;
        private System.Windows.Forms.ToolStripMenuItem product;
        private System.Windows.Forms.ToolStripMenuItem supply;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.ToolStripMenuItem employee;
        private System.Windows.Forms.ToolStripMenuItem adduser;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Label lblsupname;
        private System.Windows.Forms.DateTimePicker dateTimePickerreport;
    }
}