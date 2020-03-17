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
    public partial class Form9 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Test;Data Source=DESKTOP-583QKG1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //adp = new SqlDataAdapter("select * from dbo.fn_First(@dno)", con);
            adp = new SqlDataAdapter("select * from dbo.fn_Second()", con);
          // adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(txtdeptno.Text));
           DataSet ds = new DataSet();
           adp.Fill(ds, "E");
            dataGridView1.DataSource = ds.Tables["E"];
        }
        private void button2_Click(object sender, EventArgs e)  //stored procedure for fn_Second()
        {
            adp = new SqlDataAdapter("sp_gross", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            adp.Fill(ds, "E");
            dataGridView1.DataSource = ds.Tables["E"];
        }
        private void button3_Click(object sender, EventArgs e)  //stored procedure for fn_First(@dno)
        {
            adp = new SqlDataAdapter("sp_gross", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(txtdeptno.Text));
            DataSet ds = new DataSet();
            adp.Fill(ds, "E");
            dataGridView1.DataSource = ds.Tables["E"];
        }

        private void button4_Click(object sender, EventArgs e)  //stored procedure for fn_emplist()
        {
            adp = new SqlDataAdapter("sp_gross", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            
            DataSet ds = new DataSet();
            adp.Fill(ds, "E");
            dataGridView1.DataSource = ds.Tables["E"];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select Empno,Ename,Location,Sal,dbo.fn_HRA1(Empno),dbo.fn_DA1(Empno),dbo.fn_GrossSal(Empno) from emploc", con);
            DataSet ds = new DataSet();
            adp.Fill(ds, "E");
            dataGridView1.DataSource = ds.Tables["E"];
        }
    }
}
