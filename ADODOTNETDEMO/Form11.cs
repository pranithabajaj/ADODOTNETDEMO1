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
    public partial class Form11 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Test;Data Source=DESKTOP-583QKG1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select dbo.fn_Date1(@hd)", con);
            adp.SelectCommand.Parameters.AddWithValue("@hd", DateTime.Parse(dateTimePicker1.Text));
            DataSet ds = new DataSet();
            adp.Fill(ds, "E");
            dataGridView1.DataSource = ds.Tables["E"];
        }
    }
}
