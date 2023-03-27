namespace project_GUI
{
    partial class Payment_Detail_Form
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
            this.txtcusid = new System.Windows.Forms.TextBox();
            this.lblCusid = new System.Windows.Forms.Label();
            this.btnview = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgcustomer = new System.Windows.Forms.DataGridView();
            this.dateorder = new System.Windows.Forms.DateTimePicker();
            this.lblorderdate = new System.Windows.Forms.Label();
            this.cbotype = new System.Windows.Forms.ComboBox();
            this.lbltype = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtordrno = new System.Windows.Forms.TextBox();
            this.lblno = new System.Windows.Forms.Label();
            this.menuStripcoustomer = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDUSERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgcustomer)).BeginInit();
            this.menuStripcoustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcusid
            // 
            this.txtcusid.BackColor = System.Drawing.Color.White;
            this.txtcusid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusid.Location = new System.Drawing.Point(169, 202);
            this.txtcusid.Margin = new System.Windows.Forms.Padding(2);
            this.txtcusid.Name = "txtcusid";
            this.txtcusid.Size = new System.Drawing.Size(151, 23);
            this.txtcusid.TabIndex = 75;
            // 
            // lblCusid
            // 
            this.lblCusid.AutoSize = true;
            this.lblCusid.BackColor = System.Drawing.Color.Black;
            this.lblCusid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusid.ForeColor = System.Drawing.Color.Yellow;
            this.lblCusid.Location = new System.Drawing.Point(16, 203);
            this.lblCusid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCusid.Name = "lblCusid";
            this.lblCusid.Size = new System.Drawing.Size(71, 20);
            this.lblCusid.TabIndex = 74;
            this.lblCusid.Text = "Amount";
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.Black;
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.Yellow;
            this.btnview.Location = new System.Drawing.Point(760, 400);
            this.btnview.Margin = new System.Windows.Forms.Padding(2);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(110, 28);
            this.btnview.TabIndex = 73;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Black;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Yellow;
            this.btnexit.Location = new System.Drawing.Point(534, 400);
            this.btnexit.Margin = new System.Windows.Forms.Padding(2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(112, 28);
            this.btnexit.TabIndex = 70;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Black;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.Yellow;
            this.btnclear.Location = new System.Drawing.Point(321, 400);
            this.btnclear.Margin = new System.Windows.Forms.Padding(2);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(113, 28);
            this.btnclear.TabIndex = 69;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Black;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.Yellow;
            this.btnadd.Location = new System.Drawing.Point(68, 400);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(112, 28);
            this.btnadd.TabIndex = 68;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            // 
            // dgcustomer
            // 
            this.dgcustomer.BackgroundColor = System.Drawing.Color.Gray;
            this.dgcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcustomer.Location = new System.Drawing.Point(333, 72);
            this.dgcustomer.Margin = new System.Windows.Forms.Padding(2);
            this.dgcustomer.Name = "dgcustomer";
            this.dgcustomer.RowHeadersWidth = 51;
            this.dgcustomer.RowTemplate.Height = 24;
            this.dgcustomer.Size = new System.Drawing.Size(570, 299);
            this.dgcustomer.TabIndex = 67;
            // 
            // dateorder
            // 
            this.dateorder.CalendarTitleForeColor = System.Drawing.Color.IndianRed;
            this.dateorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateorder.Location = new System.Drawing.Point(169, 254);
            this.dateorder.Margin = new System.Windows.Forms.Padding(2);
            this.dateorder.Name = "dateorder";
            this.dateorder.Size = new System.Drawing.Size(151, 23);
            this.dateorder.TabIndex = 66;
            // 
            // lblorderdate
            // 
            this.lblorderdate.AutoSize = true;
            this.lblorderdate.BackColor = System.Drawing.Color.Black;
            this.lblorderdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderdate.ForeColor = System.Drawing.Color.Yellow;
            this.lblorderdate.Location = new System.Drawing.Point(12, 254);
            this.lblorderdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblorderdate.Name = "lblorderdate";
            this.lblorderdate.Size = new System.Drawing.Size(122, 20);
            this.lblorderdate.TabIndex = 65;
            this.lblorderdate.Text = "Payment Date";
            // 
            // cbotype
            // 
            this.cbotype.BackColor = System.Drawing.Color.White;
            this.cbotype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotype.FormattingEnabled = true;
            this.cbotype.Items.AddRange(new object[] {
            "Butter Cake",
            "Chocolate Cake",
            "Design Cake",
            "Chocolate Design Cake",
            "Cup Cake",
            "Royal Wedding Cake"});
            this.cbotype.Location = new System.Drawing.Point(169, 150);
            this.cbotype.Margin = new System.Windows.Forms.Padding(2);
            this.cbotype.Name = "cbotype";
            this.cbotype.Size = new System.Drawing.Size(151, 25);
            this.cbotype.TabIndex = 64;
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.BackColor = System.Drawing.Color.Black;
            this.lbltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.ForeColor = System.Drawing.Color.Yellow;
            this.lbltype.Location = new System.Drawing.Point(16, 150);
            this.lbltype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(80, 20);
            this.lbltype.TabIndex = 63;
            this.lbltype.Text = "Discount";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(169, 101);
            this.txtname.Margin = new System.Windows.Forms.Padding(2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(151, 23);
            this.txtname.TabIndex = 62;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Black;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Yellow;
            this.lblname.Location = new System.Drawing.Point(16, 101);
            this.lblname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(121, 20);
            this.lblname.TabIndex = 61;
            this.lblname.Text = "Payment Type";
            // 
            // txtordrno
            // 
            this.txtordrno.BackColor = System.Drawing.Color.White;
            this.txtordrno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtordrno.Location = new System.Drawing.Point(169, 55);
            this.txtordrno.Margin = new System.Windows.Forms.Padding(2);
            this.txtordrno.Name = "txtordrno";
            this.txtordrno.Size = new System.Drawing.Size(151, 23);
            this.txtordrno.TabIndex = 60;
            // 
            // lblno
            // 
            this.lblno.AutoSize = true;
            this.lblno.BackColor = System.Drawing.Color.Black;
            this.lblno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblno.ForeColor = System.Drawing.Color.Yellow;
            this.lblno.Location = new System.Drawing.Point(18, 55);
            this.lblno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblno.Name = "lblno";
            this.lblno.Size = new System.Drawing.Size(102, 20);
            this.lblno.TabIndex = 59;
            this.lblno.Text = "Payment ID";
            // 
            // menuStripcoustomer
            // 
            this.menuStripcoustomer.BackColor = System.Drawing.Color.Black;
            this.menuStripcoustomer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripcoustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.aDDUSERToolStripMenuItem,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11});
            this.menuStripcoustomer.Location = new System.Drawing.Point(0, 0);
            this.menuStripcoustomer.Name = "menuStripcoustomer";
            this.menuStripcoustomer.Size = new System.Drawing.Size(926, 24);
            this.menuStripcoustomer.TabIndex = 58;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 20);
            this.toolStripMenuItem1.Text = "DASHBOARD";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItem2.Text = "ORDER";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(90, 20);
            this.toolStripMenuItem3.Text = "ORDER ITEM";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(34, 20);
            this.toolStripMenuItem4.Text = "BIl";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(114, 20);
            this.toolStripMenuItem5.Text = "PAYMENT DETAIL";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(121, 20);
            this.toolStripMenuItem6.Text = "CATEGORY DETAIL";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(75, 20);
            this.toolStripMenuItem7.Text = "PRODUCT";
            // 
            // aDDUSERToolStripMenuItem
            // 
            this.aDDUSERToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aDDUSERToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.aDDUSERToolStripMenuItem.Name = "aDDUSERToolStripMenuItem";
            this.aDDUSERToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.aDDUSERToolStripMenuItem.Text = "SUPPLY DETAIL";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(77, 20);
            this.toolStripMenuItem8.Text = "EMPLOYEE";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem9.Text = "REPORTS";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(56, 20);
            this.toolStripMenuItem10.Text = "LOGIN";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem11.Text = "LOG OUT";
            // 
            // Payment_Detail_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_GUI.Properties.Resources.B74;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.txtcusid);
            this.Controls.Add(this.lblCusid);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgcustomer);
            this.Controls.Add(this.dateorder);
            this.Controls.Add(this.lblorderdate);
            this.Controls.Add(this.cbotype);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtordrno);
            this.Controls.Add(this.lblno);
            this.Controls.Add(this.menuStripcoustomer);
            this.Name = "Payment_Detail_Form";
            this.Text = "Payment_Detail_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgcustomer)).EndInit();
            this.menuStripcoustomer.ResumeLayout(false);
            this.menuStripcoustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtcusid;
        private System.Windows.Forms.Label lblCusid;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgcustomer;
        private System.Windows.Forms.DateTimePicker dateorder;
        private System.Windows.Forms.Label lblorderdate;
        private System.Windows.Forms.ComboBox cbotype;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtordrno;
        private System.Windows.Forms.Label lblno;
        private System.Windows.Forms.MenuStrip menuStripcoustomer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem aDDUSERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
    }
}