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
    public partial class Form12 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        string pid;
        public Form12(string pid)
        {
            this.pid = pid;
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-583QKG1");
            adp = new SqlDataAdapter("select * from productdetails where productid=@pid", con);
            adp.SelectCommand.Parameters.AddWithValue("@pid", pid);
            DataSet ds = new DataSet();
            adp.Fill(ds,"P");
            label4.Text = ds.Tables["P"].Rows[0][0].ToString();
            label5.Text = ds.Tables["P"].Rows[0][1].ToString();
            label6.Text = ds.Tables["P"].Rows[0][2].ToString();
        }
    }
}
