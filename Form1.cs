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
            double peso = 0;
            double altura = 0;
            double imc = 0;
            if (txtPeso.Text != "" && txtAltura.Text != "")
            {
                peso = double.Parse(txtPeso.Text);
                altura = double.Parse(txtAltura.Text);
                imc = peso / (altura * altura);


            }
            imc = peso / Math.Pow(altura, 2);

            if (imc <= 18.5)
            {
                txtIMC.Text = imc.ToString();
                lblResultado.Text = "Abaixo do peso.";

            }
            else if (imc > 18.5 && imc <= 24.9)
            {
                txtIMC.Text = imc.ToString();
                lblResultado.Text = "Peso ideal.";
            }
            else if (imc > 25 && imc <= 29.9)
            {
                txtIMC.Text = imc.ToString();
                lblResultado.Text = "Levemente acima do peso.";
            }
            else if (imc > 30 && imc <= 34.9)
            {
                txtIMC.Text = imc.ToString();
                lblResultado.Text = "Obesidade primeiro grau.";
            }
            else if (imc < 35 && imc <= 39.9)
            {
                txtIMC.Text = imc.ToString();
                lblResultado.Text = "Obesidade segundo grau ou severa.";
            }
            else
            {
                txtIMC.Text = imc.ToString();
                lblResultado.Text = "Obesidade terceiro grau ou mórbida.";
            }
        }
    }
}
