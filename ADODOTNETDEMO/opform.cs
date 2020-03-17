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
    public partial class opform : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public opform()
        {
            InitializeComponent();
        }

        private void opform_Load(object sender, EventArgs e)
        {
            
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-583QKG1");
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select count(*) from orderdetails", con);
            DataSet ds = new DataSet();
            adp.Fill(ds,"c");
            txtoid.Text = (int.Parse(ds.Tables["c"].Rows[0][0].ToString()) + 1).ToString();

            adp = new SqlDataAdapter("select salesmanid,salesmanname from salesmandetails ", con);
            adp.Fill(ds,"s");
            cbbsid.DataSource = ds.Tables["s"];
            cbbsid.DisplayMember = "salesmanname";
            cbbsid.ValueMember = "salesmanid";

            adp = new SqlDataAdapter("select customerid,customername from customerdetails ", con);
            adp.Fill(ds, "cus");
            cbbcid.DataSource = ds.Tables["cus"];
            cbbcid.DisplayMember = "customername";
            cbbcid.ValueMember = "customerid";

            panel1.Visible = true;
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_orderproducts1", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@oid", txtoid.Text);
            adp.SelectCommand.Parameters.AddWithValue("@orderdesc", txtodesc.Text);
            adp.SelectCommand.Parameters.AddWithValue("@orderdate", DateTime.Parse(dtpodate.Text));
            adp.SelectCommand.Parameters.AddWithValue("@discount", int.Parse(txtdisc.Text));
            adp.SelectCommand.Parameters.AddWithValue("@custid", cbbcid.SelectedValue);
            adp.SelectCommand.Parameters.AddWithValue("@salesid", cbbsid.SelectedValue);

            DataTable MyTable = new DataTable();
            MyTable.Columns.Add("orderid", typeof(string));
            MyTable.Columns.Add("productid", typeof(string));
            MyTable.Columns.Add("Qty", typeof(Int32));
            MessageBox.Show(dgvdata.Rows.Count.ToString());
            for(int i=0;i<dgvdata.Rows.Count-1;i++)
            {
                MyTable.Rows.Add(txtoid.Text, dgvdata.Rows[i].Cells[0].Value.ToString(),dgvdata.Rows[i].Cells[2].Value.ToString());
            }
            SqlParameter p = new SqlParameter("@ord_pro", MyTable);
            DataSet ds = new DataSet();
            p.SqlDbType = SqlDbType.Structured;
            adp.SelectCommand.Parameters.Add(p);
            adp.Fill(ds);
            MessageBox.Show("order placed");
            panel1.Visible = false;
        }

        private void dgvdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(dgvdata.CurrentCell.ColumnIndex.Equals(0))
            {
                adp = new SqlDataAdapter("select productid from productdetails", con);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Pid");
                foreach(DataGridViewRow row in dgvdata.Rows)
                {
                    (row.Cells[0] as DataGridViewComboBoxCell).DataSource = ds.Tables["Pid"];
                    (row.Cells[0] as DataGridViewComboBoxCell).DisplayMember = "productid";
                }
            }
        }
        private void dgvdata_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvdata.CurrentRow.Cells[0].Value != null)
            {
                if (!dgvdata.CurrentCell.ColumnIndex.Equals(0))
                {
                    adp = new SqlDataAdapter("select * from productdetails where productid=@P", con);
                    adp.SelectCommand.Parameters.AddWithValue("@P", dgvdata.CurrentRow.Cells[0].Value);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "P");
                    dgvdata.CurrentRow.Cells[1].Value = ds.Tables["P"].Rows[0][1];
                    dgvdata.CurrentRow.Cells[3].Value = ds.Tables["P"].Rows[0][2];
                }
            }
        }

        private void dgvdata_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvdata.CurrentRow.Cells[2].Value != null)
            //{
            //    int Q = int.Parse(dgvdata.CurrentRow.Cells[2].Value.ToString());
            //    int P = int.Parse(dgvdata.CurrentRow.Cells[3].Value.ToString());
            //    dgvdata.CurrentRow.Cells[4].Value = Q * P;
            //}
        }

        private void dgvdata_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (!dgvdata.CurrentCell.ColumnIndex.Equals(0) && dgvdata.CurrentRow.Cells[2].Value != null)
            {
                int Q = int.Parse(dgvdata.CurrentRow.Cells[2].Value.ToString());
                int P = int.Parse(dgvdata.CurrentRow.Cells[3].Value.ToString());
                dgvdata.CurrentRow.Cells[4].Value = Q * P;
            }
        }
    }
}
