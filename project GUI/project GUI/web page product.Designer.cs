
namespace project_GUI
{
    partial class web_page_product
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
            this.rbtnbike = new System.Windows.Forms.RadioButton();
            this.rbtnthreewheel = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgWebPro = new System.Windows.Forms.DataGridView();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtIname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgWebPro)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnbike
            // 
            this.rbtnbike.AutoSize = true;
            this.rbtnbike.BackColor = System.Drawing.Color.Blue;
            this.rbtnbike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbtnbike.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnbike.ForeColor = System.Drawing.Color.White;
            this.rbtnbike.Location = new System.Drawing.Point(34, 28);
            this.rbtnbike.Name = "rbtnbike";
            this.rbtnbike.Size = new System.Drawing.Size(72, 29);
            this.rbtnbike.TabIndex = 0;
            this.rbtnbike.TabStop = true;
            this.rbtnbike.Text = "BIKE";
            this.rbtnbike.UseVisualStyleBackColor = false;
            // 
            // rbtnthreewheel
            // 
            this.rbtnthreewheel.AutoSize = true;
            this.rbtnthreewheel.BackColor = System.Drawing.Color.Blue;
            this.rbtnthreewheel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbtnthreewheel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnthreewheel.ForeColor = System.Drawing.Color.White;
            this.rbtnthreewheel.Location = new System.Drawing.Point(164, 28);
            this.rbtnthreewheel.Name = "rbtnthreewheel";
            this.rbtnthreewheel.Size = new System.Drawing.Size(157, 29);
            this.rbtnthreewheel.TabIndex = 1;
            this.rbtnthreewheel.TabStop = true;
            this.rbtnthreewheel.Text = "THREE WHEEL";
            this.rbtnthreewheel.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(29, 128);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Name";
            // 
            // lblIName
            // 
            this.lblIName.AutoSize = true;
            this.lblIName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblIName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIName.ForeColor = System.Drawing.Color.White;
            this.lblIName.Location = new System.Drawing.Point(29, 181);
            this.lblIName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIName.Name = "lblIName";
            this.lblIName.Size = new System.Drawing.Size(110, 20);
            this.lblIName.TabIndex = 26;
            this.lblIName.Text = "Image Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(29, 245);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 20);
            this.lblPrice.TabIndex = 27;
            this.lblPrice.Text = "Price";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(186, 393);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(112, 28);
            this.btndelete.TabIndex = 46;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(339, 393);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(112, 28);
            this.btnupdate.TabIndex = 45;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.White;
            this.btnview.Location = new System.Drawing.Point(504, 393);
            this.btnview.Margin = new System.Windows.Forms.Padding(2);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(110, 28);
            this.btnview.TabIndex = 44;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(668, 393);
            this.btnclear.Margin = new System.Windows.Forms.Padding(2);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(113, 28);
            this.btnclear.TabIndex = 42;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(27, 393);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(112, 28);
            this.btnadd.TabIndex = 41;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgWebPro
            // 
            this.dgWebPro.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgWebPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWebPro.Location = new System.Drawing.Point(353, 96);
            this.dgWebPro.Margin = new System.Windows.Forms.Padding(2);
            this.dgWebPro.Name = "dgWebPro";
            this.dgWebPro.RowHeadersWidth = 51;
            this.dgWebPro.RowTemplate.Height = 24;
            this.dgWebPro.Size = new System.Drawing.Size(428, 220);
            this.dgWebPro.TabIndex = 47;
            // 
            // txtPName
            // 
            this.txtPName.BackColor = System.Drawing.Color.White;
            this.txtPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.Location = new System.Drawing.Point(164, 127);
            this.txtPName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(151, 23);
            this.txtPName.TabIndex = 49;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(164, 241);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(151, 23);
            this.txtPrice.TabIndex = 51;
            // 
            // txtIname
            // 
            this.txtIname.BackColor = System.Drawing.Color.White;
            this.txtIname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIname.Location = new System.Drawing.Point(164, 181);
            this.txtIname.Margin = new System.Windows.Forms.Padding(2);
            this.txtIname.Name = "txtIname";
            this.txtIname.Size = new System.Drawing.Size(151, 23);
            this.txtIname.TabIndex = 50;
            // 
            // web_page_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = global::project_GUI.Properties.Resources.B91;
            this.ClientSize = new System.Drawing.Size(823, 494);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtIname);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.dgWebPro);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblIName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.rbtnthreewheel);
            this.Controls.Add(this.rbtnbike);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "web_page_product";
            this.Text = "web page product";
            this.Load += new System.EventHandler(this.web_page_product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgWebPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnbike;
        private System.Windows.Forms.RadioButton rbtnthreewheel;
        private System.Windows.Forms.Label lblIName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgWebPro;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtIname;
        private System.Windows.Forms.Label lblName;
    }
}