using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ADODOTNETDEMO
{
    public partial class ConnectionlessEx1 : Form
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        public ConnectionlessEx1()
        {
            InitializeComponent();
        }

        private void ConnectionlessEx1_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Test;Data Source=DESKTOP-583QKG1");
            Adp = new SqlDataAdapter("Select * from deptdata", Con);
            DataSet DS = new DataSet();
            Adp.Fill(DS, "Dept");
            cbbDeptno.DataSource = DS.Tables["Dept"];
            cbbDeptno.DisplayMember = "dname";
           
            cbbDeptno.ValueMember = "deptno ";

        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
                Adp = new SqlDataAdapter("Select * from Empdata where deptno=@D", Con);
                Adp.SelectCommand.Parameters.AddWithValue("@D", cbbDeptno.SelectedValue);
                DataSet DS = new DataSet();
                Adp.Fill(DS, "Emp");
                dGVdata.DataSource = DS.Tables["Emp"];
        }
            

       
       
    }
}
