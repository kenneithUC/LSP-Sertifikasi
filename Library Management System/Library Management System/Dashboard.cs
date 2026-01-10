using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_Management_System
{
    public partial class Dashboard : Form
    {
        int _userID;
        string _username;

        public Dashboard(int userID, string username)
        {
            InitializeComponent();
            _userID = userID;
            _username = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBooks AB = new AddBooks();
            AB.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View_Books VB = new View_Books();
            VB.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ViewStudents VS = new ViewStudents();
            VS.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IssueBook IS = new IssueBook(_userID, _username);
            IS.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReturnBook RB = new ReturnBook();
            RB.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            IssueBookReport IBR = new IssueBookReport();
            IBR.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReturnBookReport RBR = new ReturnBookReport();
            RBR.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AddStudents AS = new AddStudents();
            AS.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
