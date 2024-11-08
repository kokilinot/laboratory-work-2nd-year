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
        public Person temp2;
        public Form2(ref Person temp)
        {
            temp2 = temp;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {/*            temp2.load(Convert.ToInt32(textBox2.Text), Convert.ToString(textBox1.Text), dateTimePicker1.Value);
            temp = temp2;*/
            this.Close();
        }
    }
}
