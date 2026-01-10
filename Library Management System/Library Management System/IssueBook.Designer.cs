namespace Library_Management_System
{
    partial class IssueBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label5 = new Label();
            button2 = new Button();
            textBox5 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(397, 78);
            label3.Name = "label3";
            label3.Size = new Size(190, 48);
            label3.TabIndex = 29;
            label3.Text = "Issue Book";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(510, 277);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 28;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(510, 234);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(326, 280);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 26;
            label4.Text = "Contact Number :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 237);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 25;
            label2.Text = "Address :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(510, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(410, 149);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 23;
            label1.Text = "Name :";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Location = new Point(510, 423);
            button1.Name = "button1";
            button1.Size = new Size(150, 37);
            button1.TabIndex = 22;
            button1.Text = "Issue Book";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(79, 250);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(358, 186);
            label5.Name = "label5";
            label5.Size = new Size(120, 25);
            label5.TabIndex = 30;
            label5.Text = "KTP Number :";
            label5.Click += label5_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Location = new Point(79, 300);
            button2.Name = "button2";
            button2.Size = new Size(150, 37);
            button2.TabIndex = 32;
            button2.Text = "Search People";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(510, 186);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 219);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 34;
            label6.Text = "KTP Number :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(364, 325);
            label7.Name = "label7";
            label7.Size = new Size(114, 25);
            label7.TabIndex = 35;
            label7.Text = "Book Name :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(510, 322);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 33);
            comboBox1.TabIndex = 36;
           
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(510, 375);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(297, 31);
            dateTimePicker1.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(375, 380);
            label8.Name = "label8";
            label8.Size = new Size(103, 25);
            label8.TabIndex = 38;
            label8.Text = "Issue Date :";
            // 
            // IssueBook
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 492);
            Controls.Add(label8);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "IssueBook";
            Text = "IssueBook";
            Load += IssueBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private Label label5;
        private Button button2;
        private TextBox textBox5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label8;
    }
}