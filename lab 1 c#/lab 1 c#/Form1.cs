using System.CodeDom.Compiler;
using System.Drawing.Printing;

namespace lab_1_c_
{

    public partial class Form1 : Form
    {
        private List<Person> user;
        public Person temp;
        public Form1()
        {
            user = new List<Person>();
            temp = new Person();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.ShowDialog();
            if (Date.exam == true)
            {
                temp.load(Date.Cardnumber, Date.name, Date.dr);
                user.Add(temp);
                comboBox1.Items.Add(temp.trans());
                comboBox1.SelectedIndex = 0;
                Date.exam = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1) 
            {
                Date.examforchoice = true;
                Date.Cardnumber = user[comboBox1.SelectedIndex].CardNumber;
                Date.name = user[comboBox1.SelectedIndex].Name;
                Date.dr = user[comboBox1.SelectedIndex].Bithday;
                Form2 ff = new Form2();
                ff.ShowDialog();
                if (Date.exam == true)
                {
                    temp.load(Date.Cardnumber, Date.name, Date.dr);
                    user[comboBox1.SelectedIndex] = temp;
                    comboBox1.Items[comboBox1.SelectedIndex] = temp.trans();
                    Date.exam = false;
                }
                Date.examforchoice = false;
                Date.Cardnumber = 00000;
                Date.name = "name";
                Date.dr = DateTime.Now;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ( comboBox1.SelectedIndex != -1)
            { 
                DialogResult resultat = MessageBox.Show
                ("вы уверены?", "сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
                );
                if (resultat == DialogResult.Yes)
                {
                    user.RemoveAt(comboBox1.SelectedIndex);
                    comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                }
            }
        }
    }
}