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
    public partial class Form2 : Form
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Test;Data Source=DESKTOP-583QKG1");
            Adp = new SqlDataAdapter("Select * from Empdata", Con);
            DataSet DS = new DataSet();
            SqlCommandBuilder Cmb = new SqlCommandBuilder(Adp);
            SqlCommand Cmd = Cmb.GetInsertCommand();
            //Cmd = Cmb.GetUpdateCommand();
            //Cmd = Cmb.GetDeleteCommand();
            MessageBox.Show(Cmd.CommandText);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
