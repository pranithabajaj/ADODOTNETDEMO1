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
    public partial class Form8 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            con=new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Test;Data Source=DESKTOP-583QKG1");
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_cursorex1", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(txtdeptno.Text));
            DataSet DS = new DataSet();
            adp.Fill(DS, "dept");
            dgvdata.DataSource = DS.Tables["dept"];
        }
    }
}
