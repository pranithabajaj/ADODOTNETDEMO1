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
    public partial class Extract : Form
    {
        SqlConnection Con = null;
        SqlCommand Cmd = null;
        public Extract()
        {
            InitializeComponent();
        }

        private void Extract_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-583QKG1");

        }

        private void btnGetdata_Click(object sender, EventArgs e)
        {
            Con.Open();
            Cmd = new SqlCommand("Select * from Empdata where deptno=@D", Con);
            Cmd.Parameters.AddWithValue("@D", int.Parse(txtDeptno.Text));
            SqlDataReader R=Cmd.ExecuteReader();
            DataSet DS = new DataSet();//empty database
            DS.Tables.Add("Deptdata");//creating table but table is empty
            DS.Tables["Deptdata"].Load(R);//table is loaded
            dGVdata.DataSource = DS.Tables["Deptdata"];//we are showing data in grid view
            Con.Close();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            Con.Open();
            //Cmd = new SqlCommand("Select * from Empdata where hiredate between @S and @E", Con);
            Cmd = new SqlCommand("Select * from Emp_view", Con);
            //Cmd.Parameters.AddWithValue("@S", DateTime.Parse(dateTimePicker1.Text));
            //Cmd.Parameters.AddWithValue("@E", DateTime.Parse(dateTimePicker2.Text));
            SqlDataReader R = Cmd.ExecuteReader();
            DataSet DS = new DataSet();
            DS.Tables.Add("Deptdata");
            DS.Tables["Deptdata"].Load(R);
            dGVdata.DataSource = DS.Tables["Deptdata"];
            Con.Close();
        }
    }
}
