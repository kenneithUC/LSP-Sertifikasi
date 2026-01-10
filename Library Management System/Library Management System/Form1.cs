using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;

namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=Malang123#;database=library;";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();

                string sql = "SELECT usernameID, username FROM login WHERE username=@user AND password=@pass";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@user", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int usernameID = reader.GetInt32("usernameID");
                    string username = reader.GetString("username");

                    Dashboard d = new Dashboard(usernameID, username);
                    d.Show();
                    this.Hide();

                    MessageBox.Show("Login berhasil.");
                }
                else
                {
                    MessageBox.Show("Username atau password salah");
                }
            }
        }

    }
}
