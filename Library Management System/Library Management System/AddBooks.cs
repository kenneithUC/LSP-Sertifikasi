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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=Malang123#;database=library;";
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SP_addbooks", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_BookName", MySqlDbType.VarChar, 60).Value = textBox1.Text;
            cmd.Parameters.Add("p_BookQuantity", MySqlDbType.VarChar, 60).Value = textBox4.Text;
            cmd.Parameters.Add("p_PurchaseDate", MySqlDbType.VarChar, 60).Value = dateTimePicker1.Value;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Books added");
            con.Close();
            textBox1.Text = "";
            textBox4.Text = "";
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }
    }
}
