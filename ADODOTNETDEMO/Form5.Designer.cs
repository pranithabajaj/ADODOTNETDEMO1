namespace ADODOTNETDEMO
{
    partial class Form5
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
            this.btninsert = new System.Windows.Forms.Button();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.txtEname = new System.Windows.Forms.TextBox();
            this.txtEmpno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdno = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(308, 265);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 17;
            this.btninsert.Text = "Submit";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // dtpdob
            // 
            this.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdob.Location = new System.Drawing.Point(372, 176);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(126, 20);
            this.dtpdob.TabIndex = 16;
            // 
            // cbbGender
            // 
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbbGender.Location = new System.Drawing.Point(372, 142);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(121, 21);
            this.cbbGender.TabIndex = 15;
            // 
            // txtEname
            // 
            this.txtEname.Location = new System.Drawing.Point(372, 110);
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(121, 20);
            this.txtEname.TabIndex = 14;
            // 
            // txtEmpno
            // 
            this.txtEmpno.Location = new System.Drawing.Point(372, 75);
            this.txtEmpno.Name = "txtEmpno";
            this.txtEmpno.Size = new System.Drawing.Size(121, 20);
            this.txtEmpno.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dob";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ename";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Empno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Dno";
            // 
            // txtdno
            // 
            this.txtdno.Location = new System.Drawing.Point(372, 216);
            this.txtdno.Name = "txtdno";
            this.txtdno.Size = new System.Drawing.Size(100, 20);
            this.txtdno.TabIndex = 19;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(432, 265);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 20;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(387, 334);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 21;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtdno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.dtpdob);
            this.Controls.Add(this.cbbGender);
            this.Controls.Add(this.txtEname);
            this.Controls.Add(this.txtEmpno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.ComboBox cbbGender;
        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.TextBox txtEmpno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdno;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
    }
}