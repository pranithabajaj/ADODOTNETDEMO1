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
    public partial class trgEx : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public trgEx()
        {
            InitializeComponent();
        }

        private void trgEx_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Test;Data Source=DESKTOP-583QKG1");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_delete",con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@empno", int.Parse(txtEmpno.Text));
            SqlParameter p = new SqlParameter("@status", SqlDbType.NVarChar, 200);
            p.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(p);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show(p.Value.ToString());
        }
    }
}
