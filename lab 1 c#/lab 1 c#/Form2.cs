using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1_c_
{
    public partial class Form2 : Form
    {
        private Random random = new Random();
        public Form2()
        {
            KeyPreview = true;
            InitializeComponent();
            dateTimePicker1.Value = Date.dr;
            textBox1.Text = Date.name;
            textBox2.Text = Convert.ToString(Date.Cardnumber);
            if (Date.examforchoice == true)
            {
                textBox2.Enabled = false;
                dateTimePicker1.Enabled = false;
                button1.MouseEnter += new EventHandler(button1_MouseEnter);
            }

        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (Date.examforchoice == true & Convert.ToString(Date.Cardnumber) != textBox2.Text)
            { int X = random.Next(0, this.ClientSize.Width - button1.Width);
              int Y = random.Next(0, this.ClientSize.Height - button1.Height);

              button1.Location = new Point(X, Y);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 5)
            {
                Date.Cardnumber = Convert.ToInt32(textBox2.Text);
                Date.dr = dateTimePicker1.Value;
                Date.name = textBox1.Text;
                Date.exam = true;// проверка на закрытие
                this.Close();
            }
            else
            {
                MessageBox.Show("карта не подходит", "сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1) ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.L && Date.examforchoice == true)
            {
                Form3 fe = new Form3(this);
                fe.ShowDialog();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
