namespace ADODOTNETDEMO
{
    partial class trgEx
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
            this.txtEmpno = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmpno
            // 
            this.txtEmpno.Location = new System.Drawing.Point(160, 65);
            this.txtEmpno.Name = "txtEmpno";
            this.txtEmpno.Size = new System.Drawing.Size(100, 20);
            this.txtEmpno.TabIndex = 0;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(333, 61);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // trgEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtEmpno);
            this.Name = "trgEx";
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.trgEx_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpno;
        private System.Windows.Forms.Button btndelete;
    }
}