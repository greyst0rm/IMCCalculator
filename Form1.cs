using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btbCalcular_Click(object sender, EventArgs e)
        {
            double n1 = 0;
            double n2 = 0;
            double resultado = 0;
            if (txtNumero1.Text != "" && txtNumero2.Text != "")
            {
                n1 = double.Parse(txtNumero1.Text);
                n2 = double.Parse(txtNumero2.Text);
            }

            // Verificar qual está marcado:
            if (rbSomar.Checked)
            {
                resultado = n1 + n2;
            }
            else if (rbSubtrair.Checked)
            {
                resultado = n1 - n2;
            }
            else if (rbMultiplicacao.Checked)
            {
                resultado = n1 * n2;
            }
            else if (rbDividir.Checked)
            {
                if (n2 == 0)
                {
                    MessageBox.Show("Impossível dividir por zero");
                }
                else
                {
                    resultado = n1 / n2;
                }


            }
            else
            {
                MessageBox.Show("Escolha uma opção, dude!");
            }

            // Mostrar o valor no lblResultado:
            lblResultado.Text = resultado.ToString();
        }
    }
}
