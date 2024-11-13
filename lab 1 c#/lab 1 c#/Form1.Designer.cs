namespace lab_1_c_
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(280, 216);
            button1.Name = "button1";
            button1.Size = new Size(173, 29);
            button1.TabIndex = 1;
            button1.Text = "Создать новую запись";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(280, 251);
            button2.Name = "button2";
            button2.Size = new Size(173, 29);
            button2.TabIndex = 2;
            button2.Text = "Изменить выбранную";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(280, 285);
            button3.Name = "button3";
            button3.Size = new Size(173, 29);
            button3.TabIndex = 3;
            button3.Text = "Удалить выбранную";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ActiveCaption;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.ForeColor = Color.Transparent;
            comboBox1.FormattingEnabled = true;
            comboBox1.ImeMode = ImeMode.Off;
            comboBox1.IntegralHeight = false;
            comboBox1.Location = new Point(492, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 28);
            comboBox1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Location = new Point(384, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 104);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Location = new Point(236, 177);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 189);
            panel2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 451);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
        private Panel panel1;
        private Panel panel2;
    }
}