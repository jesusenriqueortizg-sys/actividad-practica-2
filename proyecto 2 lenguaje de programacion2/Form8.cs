using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_2_lenguaje_de_programacion2
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        int num = 0;
        private void button1_Click(object sender, EventArgs e)
        {      
            num += 1;
            label1.Text = num.ToString();
        }
    }
}
