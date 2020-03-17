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
  
    public partial class Form6 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Test;Data Source=DESKTOP-583QKG1");
        }

        private void txtEmpno_Leave(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_Extract", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@Eno", int.Parse(txtEmpno.Text));
            SqlParameter P = new SqlParameter("@Status", SqlDbType.NVarChar, 100);
            P.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(P);
            ds = new DataSet();
            adp.Fill(ds,"E");
            
            DataRow R = null;

            if (P.Value.ToString().Length == 0)
            {
                R = ds.Tables["E"].Rows[0];
                txtEname.Text = R[1].ToString();
                txtjob.Text = R[2].ToString();
                txtmgr.Text = R[3].ToString();
                dtphiredate.Text = R[4].ToString();
                txtsalary.Text = R[5].ToString();
                txtcomm.Text = R[6].ToString();
                cbbdeptno.Text = R[7].ToString();
            }
            else
                MessageBox.Show("no employee exists");
            
                //    //try
                //    //{
                //    R = ds.Tables["E"].Rows[0];
                //    txtEname.Text = R[1].ToString();
                //    txtjob.Text = R[2].ToString();
                //    txtmgr.Text = R[3].ToString();
                //    dtphiredate.Text = R[4].ToString();
                //    txtsalary.Text = R[5].ToString();
                //    txtcomm.Text = R[6].ToString();
                //    cbbdeptno.Text = R[7].ToString();
                //    //}
                //    //catch (IndexOutOfRangeException E)
                //    //{
                //    //    MessageBox.Show("no emp exists");
                //    //}
            //    if (ds.Tables["E"].Rows.Count != 0)
            //    {
            //      R = ds.Tables["E"].Rows[0];
            //      txtEname.Text = R[1].ToString();
            //      txtjob.Text = R[2].ToString();
            //      txtmgr.Text = R[3].ToString();
            //      dtphiredate.Text = R[4].ToString();
            //      txtsalary.Text = R[5].ToString();
            //      txtcomm.Text = R[6].ToString();
            //      cbbdeptno.Text = R[7].ToString();
            //  }
            //  else
            //  {
            //      MessageBox.Show("no emp exists");
            //  }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_Updatesal", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@Eno", int.Parse(txtEmpno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@NewJob", txtjob.Text);
            adp.SelectCommand.Parameters.AddWithValue("@incPer", int.Parse(txtIncrement.Text));
            SqlParameter P = new SqlParameter("@Status", SqlDbType.NVarChar, 200);
            P.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(P);
            ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show(P.Value.ToString());
        }
    }
}
