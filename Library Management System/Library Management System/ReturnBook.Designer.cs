namespace Library_Management_System
{
    partial class ReturnBook
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
            label6 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(127, 175);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 39;
            label6.Text = "KTP Number :";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Location = new Point(110, 256);
            button2.Name = "button2";
            button2.Size = new Size(150, 37);
            button2.TabIndex = 38;
            button2.Text = "Search People";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 206);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(428, 34);
            label3.Name = "label3";
            label3.Size = new Size(216, 48);
            label3.TabIndex = 36;
            label3.Text = "Return Book";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Location = new Point(599, 429);
            button1.Name = "button1";
            button1.Size = new Size(150, 37);
            button1.TabIndex = 35;
            button1.Text = "Return Book";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(317, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(471, 211);
            dataGridView1.TabIndex = 40;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(185, 365);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 368);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 41;
            label1.Text = "Book ID :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(356, 367);
            label8.Name = "label8";
            label8.Size = new Size(114, 25);
            label8.TabIndex = 44;
            label8.Text = "Return Date :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(491, 362);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(297, 31);
            dateTimePicker1.TabIndex = 43;
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 499);
            Controls.Add(label8);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button1);
            Name = "ReturnBook";
            Text = "ReturnBook";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Button button2;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Label label8;
        private DateTimePicker dateTimePicker1;
    }
}