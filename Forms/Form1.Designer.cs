namespace Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            listBoxResults = new ListBox();
            query8comboBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            query10comboBox = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            query11comboBox = new ComboBox();
            label7 = new Label();
            query12comboBox = new ComboBox();
            label8 = new Label();
            textBox3 = new TextBox();
            label9 = new Label();
            textBox4 = new TextBox();
            label10 = new Label();
            textBox5 = new TextBox();
            label11 = new Label();
            textBox6 = new TextBox();
            label12 = new Label();
            textBox7 = new TextBox();
            label13 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Избери команда:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1 ", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            comboBox1.Location = new Point(172, 27);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(36, 144);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(144, 27);
            button1.TabIndex = 2;
            button1.Text = "Покажи резултат";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(35, 219);
            listBoxResults.Margin = new Padding(2);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(145, 104);
            listBoxResults.TabIndex = 3;
            // 
            // query8comboBox
            // 
            query8comboBox.FormattingEnabled = true;
            query8comboBox.Items.AddRange(new object[] { "available", "unavailable", "in-preorder" });
            query8comboBox.Location = new Point(395, 81);
            query8comboBox.Margin = new Padding(2);
            query8comboBox.Name = "query8comboBox";
            query8comboBox.Size = new Size(146, 28);
            query8comboBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(395, 44);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 5;
            label2.Text = "Изберете статус:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 181);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 6;
            label3.Text = "Въведете заплата:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(378, 181);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 27);
            textBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(228, 226);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 8;
            label4.Text = "Въведете години опит:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(411, 226);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 27);
            textBox2.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.Snow;
            button2.Location = new Point(38, 80);
            button2.Name = "button2";
            button2.Size = new Size(142, 29);
            button2.TabIndex = 11;
            button2.Text = "Insert initial data";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // query10comboBox
            // 
            query10comboBox.FormattingEnabled = true;
            query10comboBox.Items.AddRange(new object[] { "Ciela", "Egmont", "Orange", "Robertino" });
            query10comboBox.Location = new Point(438, 303);
            query10comboBox.Name = "query10comboBox";
            query10comboBox.Size = new Size(151, 28);
            query10comboBox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(228, 303);
            label5.Name = "label5";
            label5.Size = new Size(189, 20);
            label5.TabIndex = 13;
            label5.Text = "Изберете име на издател:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(236, 363);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 14;
            label6.Text = "Изберете жанр:";
            // 
            // query11comboBox
            // 
            query11comboBox.FormattingEnabled = true;
            query11comboBox.Items.AddRange(new object[] { "Fantasy", "Classics", "Romance", "Non-Fiction", "Sci-Fi" });
            query11comboBox.Location = new Point(395, 355);
            query11comboBox.Name = "query11comboBox";
            query11comboBox.Size = new Size(151, 28);
            query11comboBox.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(236, 407);
            label7.Name = "label7";
            label7.Size = new Size(201, 20);
            label7.TabIndex = 16;
            label7.Text = "Изберете име на работник:";
            label7.Click += label7_Click;
            // 
            // query12comboBox
            // 
            query12comboBox.FormattingEnabled = true;
            query12comboBox.Items.AddRange(new object[] { "Ivana Vasileva", "Elena Dimitrovа", "Ana Asenova", "Maria Nenova" });
            query12comboBox.Location = new Point(473, 411);
            query12comboBox.Name = "query12comboBox";
            query12comboBox.Size = new Size(151, 28);
            query12comboBox.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(236, 465);
            label8.Name = "label8";
            label8.Size = new Size(133, 20);
            label8.TabIndex = 18;
            label8.Text = "Въведете id (1-5): ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(405, 465);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(236, 515);
            label9.Name = "label9";
            label9.Size = new Size(152, 20);
            label9.TabIndex = 20;
            label9.Text = "Въведете нова цена:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(420, 513);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(646, 80);
            label10.Name = "label10";
            label10.Size = new Size(125, 20);
            label10.TabIndex = 22;
            label10.Text = "Въведете id(1-3):";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(807, 73);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(653, 129);
            label11.Name = "label11";
            label11.Size = new Size(150, 20);
            label11.TabIndex = 24;
            label11.Text = "Въведете нов адрес:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(822, 129);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(655, 190);
            label12.Name = "label12";
            label12.Size = new Size(125, 20);
            label12.TabIndex = 26;
            label12.Text = "Въведете id(1-5):";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(810, 194);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(874, 559);
            label13.Name = "label13";
            label13.Size = new Size(49, 20);
            label13.TabIndex = 28;
            label13.Text = "Done!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(981, 614);
            Controls.Add(label13);
            Controls.Add(textBox7);
            Controls.Add(label12);
            Controls.Add(textBox6);
            Controls.Add(label11);
            Controls.Add(textBox5);
            Controls.Add(label10);
            Controls.Add(textBox4);
            Controls.Add(label9);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(query12comboBox);
            Controls.Add(label7);
            Controls.Add(query11comboBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(query10comboBox);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(query8comboBox);
            Controls.Add(listBoxResults);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private ListBox listBoxResults;
        private ComboBox query8comboBox;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Button button2;
        private ComboBox query10comboBox;
        private Label label5;
        private Label label6;
        private ComboBox query11comboBox;
        private Label label7;
        private ComboBox query12comboBox;
        private Label label8;
        private TextBox textBox3;
        private Label label9;
        private TextBox textBox4;
        private Label label10;
        private TextBox textBox5;
        private Label label11;
        private TextBox textBox6;
        private Label label12;
        private TextBox textBox7;
        private Label label13;
    }
}
