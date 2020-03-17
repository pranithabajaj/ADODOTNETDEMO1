namespace ADODOTNETDEMO
{
    partial class Extract
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
            this.btnGetdata = new System.Windows.Forms.Button();
            this.dGVdata = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnsubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Deptno";
            // 
            // txtDeptno
            // 
            this.txtDeptno.Location = new System.Drawing.Point(603, 146);
            this.txtDeptno.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDeptno.Name = "txtDeptno";
            this.txtDeptno.Size = new System.Drawing.Size(180, 29);
            this.txtDeptno.TabIndex = 1;
            // 
            // btnGetdata
            // 
            this.btnGetdata.Location = new System.Drawing.Point(874, 146);
            this.btnGetdata.Name = "btnGetdata";
            this.btnGetdata.Size = new System.Drawing.Size(96, 37);
            this.btnGetdata.TabIndex = 2;
            this.btnGetdata.Text = "Getdata";
            this.btnGetdata.UseVisualStyleBackColor = true;
            this.btnGetdata.Click += new System.EventHandler(this.btnGetdata_Click);
            // 
            // dGVdata
            // 
            this.dGVdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVdata.Location = new System.Drawing.Point(388, 347);
            this.dGVdata.Name = "dGVdata";
            this.dGVdata.Size = new System.Drawing.Size(592, 167);
            this.dGVdata.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(388, 228);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 29);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(603, 228);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(180, 29);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(874, 228);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(96, 39);
            this.btnsubmit.TabIndex = 6;
            this.btnsubmit.Text = "submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // Extract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dGVdata);
            this.Controls.Add(this.btnGetdata);
            this.Controls.Add(this.txtDeptno);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Extract";
            this.Text = "Extract";
            this.Load += new System.EventHandler(this.Extract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeptno;
        private System.Windows.Forms.Button btnGetdata;
        private System.Windows.Forms.DataGridView dGVdata;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnsubmit;
    }
}