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
    public partial class Form3 : Form
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        DataSet DS = null;
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Test;Data Source=DESKTOP-583QKG1");
            Adp = new SqlDataAdapter("Select * from deptdata",Con);
            DS = new DataSet();
            Adp.Fill(DS, "D");
            cbbdeptno.DataSource = DS.Tables["D"];
            cbbdeptno.ValueMember = "deptno";
            cbbdeptno.DisplayMember = "dname";
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Adp = new SqlDataAdapter("select * from empdata", Con);
                DS = new DataSet();
                Adp.Fill(DS, "E");
                DataRow R = DS.Tables["E"].NewRow();
                R[0] = int.Parse(txtEmpno.Text);
                R[1] = txtEname.Text;
                R[2] = txtjob.Text;
                R[3] = int.Parse(txtmgr.Text);
                R[4] = DateTime.Parse(dtphiredate.Text);
                R[5] = int.Parse(txtsalary.Text);
                R[6] = int.Parse(txtcomm.Text);
                R[7] = cbbdeptno.SelectedValue;
                DS.Tables["E"].Rows.Add(R);
                SqlCommandBuilder Cmb = new SqlCommandBuilder(Adp);
                Adp.InsertCommand = Cmb.GetInsertCommand();
                Adp.Update(DS, "E");
                MessageBox.Show("1 row inserted");
               
                
                Clear();
            }
            catch(SqlException E)
            {
                MessageBox.Show(E.Message);
            }
        }
        private void Clear()
        {
            txtEmpno.Text = "";
            txtEname.Text = "";
            txtjob.Text = "";
            txtsalary.Text = "";
            txtmgr.Text = "";
            dtphiredate.Text = "";
            txtcomm.Text = "";
            cbbdeptno.Text = "";
        }
    }
}
