using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADODOTNETDEMO
{
    public partial class Form4 : Form
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        DataSet DS = null;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Test;Data Source=DESKTOP-583QKG1");
            Adp = new SqlDataAdapter("Select * from deptdata", Con);
            DS = new DataSet();
            Adp.Fill(DS, "D");
            cbbdeptno.DataSource = DS.Tables["D"];
            cbbdeptno.ValueMember = "deptno";
            cbbdeptno.DisplayMember = "dname";
        }
        private void txtEmpno_Leave(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("select * from empdata where empno=@E",Con);
            Adp.SelectCommand.Parameters.AddWithValue("@E", int.Parse(txtEmpno.Text));
            DS = new DataSet();
            Adp.Fill(DS, "E");
            DataRow R = DS.Tables["E"].Rows[0];
            txtEname.Text = R[1].ToString();
            //txtEname.Text = DS.Tables["E"].Rows[0][1].ToString();
            txtjob.Text = R[2].ToString();
            txtmgr.Text = R[3].ToString();
            dtphiredate.Text = R[4].ToString();
            txtsalary.Text = R[5].ToString();
            txtcomm.Text = R[6].ToString();
            cbbdeptno.Text = R[7].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("select * from empdata where empno=@E", Con);
            Adp.SelectCommand.Parameters.AddWithValue("@E", int.Parse(txtEmpno.Text));
            DS = new DataSet();
            Adp.Fill(DS, "E");
            DataRow R = DS.Tables["E"].Rows[0];
            R[2] = txtjob.Text;
            R[3] = txtmgr.Text;
            R[5] = int.Parse(txtsalary.Text);
            if(txtcomm.Text.Length!=0)
                R[6] = int.Parse(txtcomm.Text);
            R[7] = int.Parse(cbbdeptno.Text);
            SqlCommandBuilder Cmb = new SqlCommandBuilder(Adp);
            Adp.UpdateCommand = Cmb.GetUpdateCommand();
            Adp.Update(DS, "E");
            MessageBox.Show("1 row updated");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adp = new SqlDataAdapter("select * from empdata where empno=@E", Con);
            Adp.SelectCommand.Parameters.AddWithValue("@E", int.Parse(txtEmpno.Text));
            DS = new DataSet();
            Adp.Fill(DS, "E");
            DataRow R = DS.Tables["E"].Rows[0];
            DS.Tables["E"].Rows[0].Delete();
            SqlCommandBuilder Cmb = new SqlCommandBuilder(Adp);
            Adp.DeleteCommand = Cmb.GetDeleteCommand();
            Adp.Update(DS, "E");
            MessageBox.Show("1 row deleted");
        }
    }
}
