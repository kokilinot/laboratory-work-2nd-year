using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1_c_
{
    public partial class Form3 : Form
    {

            Form2 form2;
        public Form3(Form2 owner)
        {
            form2 = owner;
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

        }

        private void Test_click(object? sender, int e)
        {
            throw new NotImplementedException();
        }

        public string GetHash(string Ai)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(Ai));

            return Convert.ToBase64String(hash);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox2.Enabled = false;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                textBox2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(GetHash(textBox2.Text)== hash.password)
            {
                form2.textBox2.Enabled = true;
                form2.dateTimePicker1.Enabled = true;
                form2.BackColor = Color.FromArgb(100, 100, 100);
                this.Close();
            }
        }
    }

}
