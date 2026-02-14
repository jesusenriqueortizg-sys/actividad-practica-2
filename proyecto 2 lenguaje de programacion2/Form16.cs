using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_2_lenguaje_de_programacion2
{
    public partial class Form16 : Form
    {
        public decimal LastValue{ get; set; }
        public string Operator { get; set; }
        public bool IsLastResult { get; set; }
        public Form16()
        {
            InitializeComponent();
            WireEvents();
        }

        private void WireEvents()
        {
            var digitButtons = new Button[] { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            foreach (var b in digitButtons)
                b.Click += btn_Click;

            btnSuma.Click += btnOperator_Click;
            btnResta.Click += btnOperator_Click;
            btnMultiplicacion.Click += btnOperator_Click;
            btnDivision.Click += btnOperator_Click;

            btnIgual.Click += btnIgual_Click;

            txtResultado.TextChanged += txtResultado_TextChanged;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (IsLastResult)
            {
                txtResultado.Clear();
                IsLastResult = false;
            }
            txtResultado.Text += ((Button)sender).Text;
        }
        private void btnOperator_Click(object sender, EventArgs e)
        {
            var current_operator = (Button)sender;
            this.Operator = current_operator.Text;

            if (!decimal.TryParse(txtResultado.Text, out decimal parsed))
            {
                return;
            }

            this.LastValue = parsed;
            txtResultado.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (IsLastResult)
                return;

            if (string.IsNullOrEmpty(Operator) || string.IsNullOrEmpty(txtResultado.Text))
                return;

            if (!decimal.TryParse(txtResultado.Text, out decimal currentValue))
                return;

            switch (this.Operator)
            {
                case "+":
                    txtResultado.Text = (this.LastValue + currentValue).ToString();
                    break;
                case "-":
                    txtResultado.Text = (this.LastValue - currentValue).ToString();
                    break;
                case "*":
                    txtResultado.Text = (this.LastValue * currentValue).ToString();
                    break;
                case "/":
                    if (currentValue == 0)
                        txtResultado.Text = "Error";
                    else
                        txtResultado.Text = (this.LastValue / currentValue).ToString();
                    break;
            }
            IsLastResult = true;
        }
        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

