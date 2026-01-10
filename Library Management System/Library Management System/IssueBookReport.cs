using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class IssueBookReport : Form
    {
        public IssueBookReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IssueBookReport_Load(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=Malang123#;database=library;";
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("ViewBookReport", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_BookName", MySqlDbType.VarChar, 60).Value = "";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=Malang123#;database=library;";
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("ViewBookReport", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_BookName", MySqlDbType.VarChar, 60).Value = textBox1.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
