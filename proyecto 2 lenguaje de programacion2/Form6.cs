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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("rojo");
            comboBox1.Items.Add("verde");
            comboBox1.Items.Add("azul");
            if (comboBox1.SelectedItem == "rojo")
            {
                this.BackColor = Color.Red;
            }
            else if (comboBox1.SelectedItem == "verde")
            {
                this.BackColor = Color.Green;
            }
            else if (comboBox1.SelectedItem == "azul")
            {
                this.BackColor = Color.Blue;
            }
        }
    }
}
