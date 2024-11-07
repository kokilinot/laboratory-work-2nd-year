using System.Drawing.Printing;

namespace lab_1_c_
{
    public partial class Form1 : Form
    {
        private Person user;
        public Form1()
        {
            user = new Person();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form dig = new Form();
            dig.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

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