namespace lab_1_c_
{
    partial class Form2
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 200, 200);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(66, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 47);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 13);
            label1.Name = "label1";
            label1.Size = new Size(180, 20);
            label1.TabIndex = 0;
            label1.Text = "введите значение";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(252, 200, 205);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(160, 39);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(160, 39);
            label2.TabIndex = 0;
            label2.Text = "имя";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(252, 200, 205);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(12, 198);
            panel4.Name = "panel4";
            panel4.Size = new Size(160, 39);
            panel4.TabIndex = 2;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(160, 39);
            label3.TabIndex = 1;
            label3.Text = "дата рождения";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(252, 200, 205);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(12, 263);
            panel3.Name = "panel3";
            panel3.Size = new Size(160, 39);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(160, 39);
            label4.TabIndex = 3;
            label4.Text = "номер карты";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(203, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(203, 269);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 27);
            textBox2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(203, 202);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(160, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(139, 338);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "ввести";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 190, 190);
            ClientSize = new Size(399, 379);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "ввод значения";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel4;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
    }
}