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

        public Form2()
        {
            KeyPreview = true;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Date.Cardnumber = Convert.ToInt32(textBox2.Text);
            Date.dr = dateTimePicker1.Value;
            Date.name = textBox1.Text;
            Date.exam = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.L && Date.examforchoice == true) 
            {
                Form3 fe = new Form3();
                fe.ShowDialog();
            }
        }
    }
}
