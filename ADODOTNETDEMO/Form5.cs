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
    public partial class Form5 : Form
    {
        SqlConnection Con = null;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=ADODB;Data Source=DESKTOP-583QKG1");
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            SqlDataAdapter Adp = new SqlDataAdapter("sp_InsertEmp", Con);
            Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adp.SelectCommand.Parameters.AddWithValue("@Eno", int.Parse(txtEmpno.Text));
            Adp.SelectCommand.Parameters.AddWithValue("@En", txtEname.Text);
            Adp.SelectCommand.Parameters.AddWithValue("@G", cbbGender.Text);
            Adp.SelectCommand.Parameters.AddWithValue("@Db", DateTime.Parse(dtpdob.Text));
            Adp.SelectCommand.Parameters.AddWithValue("@Dno", int.Parse(txtdno.Text));
            SqlParameter P = new SqlParameter("@Result", SqlDbType.NVarChar,100);
            P.Direction = ParameterDirection.Output;
            Adp.SelectCommand.Parameters.Add(P);
            DataSet DS = new DataSet();
            Adp.Fill(DS);
            MessageBox.Show(P.Value.ToString());
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlDataAdapter Adp = new SqlDataAdapter("sp_UpdateEmp", Con);
            Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adp.SelectCommand.Parameters.AddWithValue("@Eno", int.Parse(txtEmpno.Text));
            Adp.SelectCommand.Parameters.AddWithValue("@En", txtEname.Text);
            Adp.SelectCommand.Parameters.AddWithValue("@Dno", int.Parse(txtdno.Text));
            Adp.SelectCommand.Parameters.AddWithValue("@Db", DateTime.Parse(dtpdob.Text));
            SqlParameter P = new SqlParameter("@Result", SqlDbType.NVarChar, 100);
            P.Direction = ParameterDirection.Output;
            Adp.SelectCommand.Parameters.Add(P);
            DataSet DS = new DataSet();
            Adp.Fill(DS);
            MessageBox.Show(P.Value.ToString());
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlDataAdapter Adp = new SqlDataAdapter("sp_DeleteEmp", Con);
            Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adp.SelectCommand.Parameters.AddWithValue("@Eno", int.Parse(txtEmpno.Text));
            SqlParameter P = new SqlParameter("@Result", SqlDbType.NVarChar, 100);
            P.Direction = ParameterDirection.Output;
            Adp.SelectCommand.Parameters.Add(P);
            DataSet DS = new DataSet();
            Adp.Fill(DS);
            MessageBox.Show(P.Value.ToString());
        }
    }
}
