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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace ADODOTNETDEMO
{
    public partial class EMPDATA : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public EMPDATA()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EMPDATA_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Test;Data Source=DESKTOP-583QKG1");
            adp = new SqlDataAdapter("select * from empdata", con);
            DataSet ds = new DataSet();
            adp.Fill(ds, "E");
            dataGridView1.DataSource = ds.Tables["E"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("d:\\Test.pdf", FileMode.Create));
            doc.Open();
           
            
            DataTable Emp = new DataTable();
            Emp.Columns.Add("empno", typeof(Int32));
            Emp.Columns.Add("ename", typeof(string));
            Emp.Columns.Add("job", typeof(string));
            Emp.Columns.Add("mgr", typeof(string));
            Emp.Columns.Add("hiredate", typeof(DateTime));
            Emp.Columns.Add("sal", typeof(Int32));
            Emp.Columns.Add("comm", typeof(Int32));
            Emp.Columns.Add("deptno", typeof(Int32));
            for(int i=0;i<dataGridView1.Rows.Count-1;i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null)
                {
                    if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value))
                    {
                        DataRow r = Emp.NewRow();
                        r["empno"] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        r["ename"] = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        r["job"] = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        r["mgr"] = dataGridView1.Rows[i].Cells[4].Value.ToString();
                        r["hiredate"] = dataGridView1.Rows[i].Cells[5].Value.ToString();
                        r["sal"] = dataGridView1.Rows[i].Cells[6].Value.ToString();
                        r["comm"] = dataGridView1.Rows[i].Cells[7].Value;
                        r["deptno"] = dataGridView1.Rows[i].Cells[8].Value.ToString();
                        Emp.Rows.Add(r);

                    }
                    dataGridView2.DataSource = Emp;
                }

            }
            //dataGridView2.DataSource = Emp;
            
            PdfPTable table = new PdfPTable(Emp.Columns.Count);
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));

                cell.BackgroundColor = new iTextSharp.text.BaseColor(255,100,200);
                table.AddCell(cell);
            }
            
            for(int i=0;i<Emp.Rows.Count;i++)
            {
                for(int j=0;j<Emp.Columns.Count;j++)
                {
                    table.AddCell(Emp.Rows[i][j].ToString());
                }
            }
            doc.Add(table);
            doc.Close();
           
        }
    }
}
