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
    public partial class IssueBook : Form
    {
        int _userID;
        string _username;
        int _bookid;

        public IssueBook(int userID, string username)
        {
            InitializeComponent();
            _userID = userID;
            _username = username;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=Malang123#;database=library;";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("sp_getbooks", con);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "BookName"; // yang kelihatan
                comboBox1.ValueMember = "BookID";     // yang diambil
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=Malang123#;database=library;";
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("ViewStudents", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_KTP", MySqlDbType.VarChar, 60).Value = textBox2.Text;
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = (dr[0].ToString());
                textBox5.Text = (dr[1].ToString());
                textBox4.Text = (dr[2].ToString());
                textBox3.Text = (dr[3].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=Malang123#;database=library;";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_addissuebook", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_Student_Name", MySqlDbType.VarChar, 60).Value = textBox1.Text;
                    cmd.Parameters.Add("p_KTP", MySqlDbType.VarChar, 60).Value = textBox5.Text;
                    cmd.Parameters.Add("p_Address", MySqlDbType.VarChar, 60).Value = textBox4.Text;
                    cmd.Parameters.Add("p_ContactNumber", MySqlDbType.VarChar, 60).Value = textBox3.Text;
                    cmd.Parameters.Add("p_BookName", MySqlDbType.VarChar, 60).Value = comboBox1.Text;
                    cmd.Parameters.Add("p_IssueDate", MySqlDbType.VarChar, 60)
                        .Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("p_ReturnDate", MySqlDbType.VarChar, 60).Value = "";
                    cmd.Parameters.Add("p_BookID", MySqlDbType.Int32).Value = _bookid;
                    cmd.Parameters.Add("p_usernameID", MySqlDbType.Int32).Value = _userID;


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Issue Book added successfully");

                    textBox1.Clear();
                    textBox5.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                }
                catch (MySqlException ex)
                {
                    // Menangkap SIGNAL dari MySQL
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _bookid = Convert.ToInt32(comboBox1.SelectedValue);

        }
    }
}
