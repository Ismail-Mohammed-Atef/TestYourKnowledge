namespace TestYourKnowledge
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            button3 = new Button();
            textBox2 = new TextBox();
            button4 = new Button();
            label1 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.Firebrick;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(169, 312);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(231, 28);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(49, 227);
            button1.Name = "button1";
            button1.Size = new Size(700, 47);
            button1.TabIndex = 2;
            button1.Text = "Add New Exam";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(550, 40);
            button2.Name = "button2";
            button2.Size = new Size(199, 29);
            button2.TabIndex = 3;
            button2.Text = "Update Existing Exams";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.White;
            comboBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox2.ForeColor = Color.Firebrick;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(244, 41);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(275, 28);
            comboBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Firebrick;
            textBox1.Location = new Point(244, 137);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Category name";
            textBox1.Size = new Size(275, 27);
            textBox1.TabIndex = 6;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(224, 224, 224);
            button3.Location = new Point(550, 136);
            button3.Name = "button3";
            button3.Size = new Size(199, 29);
            button3.TabIndex = 7;
            button3.Text = "Add New Category";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Firebrick;
            textBox2.Location = new Point(426, 313);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Exam Name";
            textBox2.Size = new Size(323, 27);
            textBox2.TabIndex = 8;
            // 
            // button4
            // 
            button4.BackColor = Color.Firebrick;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(49, 41);
            button4.Name = "button4";
            button4.Size = new Size(162, 29);
            button4.TabIndex = 9;
            button4.Text = "Delete Exam";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 316);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 11;
            label1.Text = "Exam category";
            // 
            // button5
            // 
            button5.BackColor = Color.DarkGoldenrod;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(560, 365);
            button5.Name = "button5";
            button5.Size = new Size(199, 59);
            button5.TabIndex = 12;
            button5.Text = "Back To Login Page";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Name = "AdminPanel";
            Text = "AdminPanel";
            Load += AdminPanel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Button button3;
        private TextBox textBox2;
        private Button button4;
        private Label label1;
        private Button button5;
    }
}