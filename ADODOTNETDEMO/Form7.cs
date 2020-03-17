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
    public partial class Form7 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Test;Data Source=DESKTOP-583QKG1");
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_cursorex", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(txtdeptno.Text));
                SqlParameter P = new SqlParameter("@Status", SqlDbType.NVarChar, 200);
                P.Direction = ParameterDirection.Output;
                adp.SelectCommand.Parameters.Add(P);
                ds = new DataSet();
                adp.Fill(ds);
                MessageBox.Show(P.Value.ToString());
            }
            catch (FormatException E)
            {
                MessageBox.Show("enter crt dept no");
            }
        }
    }
}
