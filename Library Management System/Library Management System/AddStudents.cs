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
    public partial class AddStudents : Form
    {
        public AddStudents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=Malang123#;database=library;";
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("sp_addStudents", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_studentname", MySqlDbType.VarChar, 60).Value = textBox1.Text;
            cmd.Parameters.Add("p_ktp", MySqlDbType.VarChar, 60).Value = textBox2.Text;
            cmd.Parameters.Add("p_address", MySqlDbType.VarChar, 60).Value = textBox4.Text;
            cmd.Parameters.Add("p_contactnumber", MySqlDbType.VarChar, 60).Value = textBox3.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Student Details added");
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddStudents_Load(object sender, EventArgs e)
        {

        }
    }
}
