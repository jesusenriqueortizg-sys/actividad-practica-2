using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace proyecto_2_lenguaje_de_programacion2
{
    public partial class Form15 : Form
    {
        string archivo = "";
     
 
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            ofd.Title = "Abrir archivo de texto";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                archivo = ofd.FileName;
                textBox1.Text = File.ReadAllText(archivo);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (archivo == "")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Archivos de texto (*.txt)|*.txt";
                sfd.Title = "Guardar archivo";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    archivo = sfd.FileName;
                }
                else
                {
                    return;
                }
            }
            File.WriteAllText(archivo, textBox1.Text);
            MessageBox.Show("archivo guardado exitosamente");
        }
    }
}
