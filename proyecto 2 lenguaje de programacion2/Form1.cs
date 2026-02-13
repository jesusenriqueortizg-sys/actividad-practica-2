using System.Runtime.ExceptionServices;

namespace proyecto_2_lenguaje_de_programacion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 First = new Form2();
            First.Show();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form3 second = new Form3();
            second.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form4 third = new Form4();
            third.Show();
        }

        private void toolStripMenuItem5_Click_Custom(object sender, EventArgs e)
        {
            Form5 four = new Form5();
            four.Show();
        }

        private void toolStripMenuItem6_Click_1(object sender, EventArgs e)
        {
            Form6 five = new Form6();
            five.Show();
        }
    }
}

