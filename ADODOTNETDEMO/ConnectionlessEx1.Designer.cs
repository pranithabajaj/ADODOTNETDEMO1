namespace ADODOTNETDEMO
{
    partial class ConnectionlessEx1
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
            this.txtDeptno = new System.Windows.Forms.TextBox();
            this.btnExtract = new System.Windows.Forms.Button();
            this.dGVdata = new System.Windows.Forms.DataGridView();
            this.cbbDeptno = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter deptno";
            // 
            // txtDeptno
            // 
            this.txtDeptno.Location = new System.Drawing.Point(452, 76);
            this.txtDeptno.Name = "txtDeptno";
            this.txtDeptno.Size = new System.Drawing.Size(100, 20);
            this.txtDeptno.TabIndex = 1;
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(569, 77);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 23);
            this.btnExtract.TabIndex = 2;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // dGVdata
            // 
            this.dGVdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVdata.Location = new System.Drawing.Point(224, 196);
            this.dGVdata.Name = "dGVdata";
            this.dGVdata.Size = new System.Drawing.Size(420, 150);
            this.dGVdata.TabIndex = 3;
            // 
            // cbbDeptno
            // 
            this.cbbDeptno.FormattingEnabled = true;
            this.cbbDeptno.Location = new System.Drawing.Point(310, 76);
            this.cbbDeptno.Name = "cbbDeptno";
            this.cbbDeptno.Size = new System.Drawing.Size(121, 21);
            this.cbbDeptno.TabIndex = 4;
            //this.cbbDeptno.SelectedIndexChanged += new System.EventHandler(this.cbbDeptno_SelectedIndexChanged);
            // 
            // ConnectionlessEx1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbDeptno);
            this.Controls.Add(this.dGVdata);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.txtDeptno);
            this.Controls.Add(this.label1);
            this.Name = "ConnectionlessEx1";
            this.Text = "ConnectionlessEx1";
            this.Load += new System.EventHandler(this.ConnectionlessEx1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeptno;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.DataGridView dGVdata;
        private System.Windows.Forms.ComboBox cbbDeptno;
    }
}