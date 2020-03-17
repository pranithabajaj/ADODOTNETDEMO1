﻿using System;
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
    public partial class Insert : Form
    {
        SqlConnection Con = null;
        SqlCommand Cmd = null;
        public Insert()
        {
            InitializeComponent();
        }

        private void Insert_Load(object sender, EventArgs e)
        {
            //step1
            Con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ADODB;Data Source=DESKTOP-583QKG1");

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            //step2
            Con.Open();
            //step3
            Cmd = new SqlCommand("insert into Emp values(@Eno,@En,@G,@D)",Con);
            Cmd.Parameters.AddWithValue("@Eno",int.Parse(txtEmpno.Text));
            Cmd.Parameters.AddWithValue("@En", txtEname.Text);
            Cmd.Parameters.AddWithValue("@G", cbbGender.Text);
            Cmd.Parameters.AddWithValue("@D", DateTime.Parse(dtpdob.Text));
            //step4
            int R=Cmd.ExecuteNonQuery();
            MessageBox.Show(R + " Row inserted");
            //step5
            Con.Close();

        }
    }
}
