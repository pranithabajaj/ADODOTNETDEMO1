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
    public partial class Product : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        string pid;
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-583QKG1");
            adp = new SqlDataAdapter("select productid,productdesc from productdetails", con);
            
            DataSet ds = new DataSet();
            adp.Fill(ds,"P");
            pid = ds.Tables["P"].Rows[0][0].ToString();
            dataGridView1.DataSource = ds.Tables["P"];
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Form12 F = new Form12(pid);
            F.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = false;
                }
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value = true;
            }
            for(int i=0;i<dataGridView1.Rows.Count-1;i++)
            {
                //if (dataGridView1.Rows[i].Cells[0].Value != null)
                //{
                    if ((bool)dataGridView1.Rows[i].Cells[0].Value == true)
                    {
                        pid = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    }
                //}
            }
        }
    }
}
