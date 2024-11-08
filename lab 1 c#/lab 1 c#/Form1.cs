using System.CodeDom.Compiler;
using System.Drawing.Printing;

namespace lab_1_c_
{

    public partial class Form1 : Form
    {
        private List<Person> user;
        private List<string> roles;
        public Person temp;
        public Form1()
        {
            user = new List<Person>();
            roles = new List<string>();
            Person temp = new Person(55555, "костя", DateTime.Now);
            user.Add(temp);
            roles.Add(temp.trans());
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2(ref temp);
            user.Add(temp);
            ff.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2(ref temp);
            ff.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show
                ("вы уверены?", "сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (resultat == DialogResult.Yes)
            {

            }
            if (resultat == DialogResult.No)
            {

            }
        }
    }
}