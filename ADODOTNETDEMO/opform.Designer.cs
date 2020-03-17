namespace ADODOTNETDEMO
{
    partial class opform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtoid = new System.Windows.Forms.TextBox();
            this.txtodesc = new System.Windows.Forms.TextBox();
            this.dtpodate = new System.Windows.Forms.DateTimePicker();
            this.txtdisc = new System.Windows.Forms.TextBox();
            this.cbbcid = new System.Windows.Forms.ComboBox();
            this.cbbsid = new System.Windows.Forms.ComboBox();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.Productid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ProductDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "orderid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "orderdesc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "orderdate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "discount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "customer name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "salesman name";
            // 
            // txtoid
            // 
            this.txtoid.Enabled = false;
            this.txtoid.Location = new System.Drawing.Point(246, 34);
            this.txtoid.Name = "txtoid";
            this.txtoid.Size = new System.Drawing.Size(121, 20);
            this.txtoid.TabIndex = 6;
            // 
            // txtodesc
            // 
            this.txtodesc.Location = new System.Drawing.Point(246, 72);
            this.txtodesc.Name = "txtodesc";
            this.txtodesc.Size = new System.Drawing.Size(121, 20);
            this.txtodesc.TabIndex = 7;
            // 
            // dtpodate
            // 
            this.dtpodate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpodate.Location = new System.Drawing.Point(246, 113);
            this.dtpodate.Name = "dtpodate";
            this.dtpodate.Size = new System.Drawing.Size(121, 20);
            this.dtpodate.TabIndex = 8;
            // 
            // txtdisc
            // 
            this.txtdisc.Location = new System.Drawing.Point(246, 150);
            this.txtdisc.Name = "txtdisc";
            this.txtdisc.Size = new System.Drawing.Size(121, 20);
            this.txtdisc.TabIndex = 9;
            // 
            // cbbcid
            // 
            this.cbbcid.FormattingEnabled = true;
            this.cbbcid.Location = new System.Drawing.Point(246, 187);
            this.cbbcid.Name = "cbbcid";
            this.cbbcid.Size = new System.Drawing.Size(121, 21);
            this.cbbcid.TabIndex = 10;
            // 
            // cbbsid
            // 
            this.cbbsid.FormattingEnabled = true;
            this.cbbsid.Location = new System.Drawing.Point(246, 232);
            this.cbbsid.Name = "cbbsid";
            this.cbbsid.Size = new System.Drawing.Size(121, 21);
            this.cbbsid.TabIndex = 11;
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Productid,
            this.ProductDesc,
            this.Qty,
            this.UnitPrice,
            this.TotalCost});
            this.dgvdata.Location = new System.Drawing.Point(43, 259);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(540, 131);
            this.dgvdata.TabIndex = 12;
            this.dgvdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellClick);
            this.dgvdata.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellLeave);
            this.dgvdata.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_RowLeave);
            this.dgvdata.SelectionChanged += new System.EventHandler(this.dgvdata_SelectionChanged);
            // 
            // Productid
            // 
            this.Productid.HeaderText = "Product ID";
            this.Productid.Name = "Productid";
            this.Productid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Productid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ProductDesc
            // 
            this.ProductDesc.HeaderText = "Description";
            this.ProductDesc.Name = "ProductDesc";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Quantity";
            this.Qty.Name = "Qty";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // TotalCost
            // 
            this.TotalCost.HeaderText = "Total Cost";
            this.TotalCost.Name = "TotalCost";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(274, 403);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 13;
            this.btnsubmit.Text = "submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnsubmit);
            this.panel1.Controls.Add(this.dgvdata);
            this.panel1.Controls.Add(this.cbbsid);
            this.panel1.Controls.Add(this.cbbcid);
            this.panel1.Controls.Add(this.txtdisc);
            this.panel1.Controls.Add(this.dtpodate);
            this.panel1.Controls.Add(this.txtodesc);
            this.panel1.Controls.Add(this.txtoid);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 429);
            this.panel1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add Bill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // opform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "opform";
            this.Text = "opform";
            this.Load += new System.EventHandler(this.opform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtoid;
        private System.Windows.Forms.TextBox txtodesc;
        private System.Windows.Forms.DateTimePicker dtpodate;
        private System.Windows.Forms.TextBox txtdisc;
        private System.Windows.Forms.ComboBox cbbcid;
        private System.Windows.Forms.ComboBox cbbsid;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
    }
}