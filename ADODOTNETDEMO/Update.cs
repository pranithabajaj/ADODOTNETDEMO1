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
    public partial class Update : Form
    {
        SqlConnection Con = null;
        SqlCommand Cmd = null;
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=ADODB;Data Source=DESKTOP-583QKG1");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                Cmd = new SqlCommand("Update Emp set Ename=@En,Deptno=@Dn where Empno=@Eno", Con);
                Cmd.Parameters.AddWithValue("@En", txtEname.Text);
                Cmd.Parameters.AddWithValue("@Dn", int.Parse(txtDeptno.Text));
                Cmd.Parameters.AddWithValue("@Eno", int.Parse(txtEmpno.Text));
                int E = Cmd.ExecuteNonQuery();
                if (E != 0)
                    MessageBox.Show(E + " rows updated");
                else
                    MessageBox.Show(" no employee exists");
            }
            catch (SqlException E)
            {
                MessageBox.Show("Ename must be given in specified char");
            }
            catch (FormatException E)
            {
                MessageBox.Show("Enter the details in Deptno");
            }
            catch (InvalidOperationException E)
            {
                MessageBox.Show("no Emp exists");
            }
            finally
            {
                Con.Close();
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                Cmd = new SqlCommand("Select * from Emp where Empno=@Eno", Con);
                Cmd.Parameters.AddWithValue("@Eno", int.Parse(txtEmpno.Text));
                SqlDataReader R = Cmd.ExecuteReader();
                R.Read();
                txtEname.Text = R[1].ToString();
                cbbGender.Text = R[2].ToString();
                dtpdob.Text = R[3].ToString();
                txtDeptno.Text = R[4].ToString();
            }
            catch (InvalidOperationException E)
            {
                MessageBox.Show("no employee exists with this number ");
                txtEname.Text = "";
                txtDeptno.Text = "";
                cbbGender.Text = "";
                dtpdob.Text = "";
            }
            catch(FormatException E)
            {
                MessageBox.Show("enter only no's in empno");
            }
            
            finally
            {
                Con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                Cmd = new SqlCommand("Delete from Emp where Empno=@Eno", Con);
                Cmd.Parameters.AddWithValue("@Eno", int.Parse(txtEmpno.Text));
                int R = Cmd.ExecuteNonQuery();
                if (R != 0)
                    MessageBox.Show(R + " rows deleted");
                else
                    MessageBox.Show(" no employee exits with this number");
            }
            catch (FormatException E)
            {
                MessageBox.Show("enter only no's in empno");
            }
            finally
            {
                Con.Close();
            }
        }
    }
}
