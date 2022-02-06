using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pIMC
{
    public partial class pnlCalculadoraIMC : Form
    {
        public pnlCalculadoraIMC()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskbxPesoAtual.Clear();
            mskbxAltura.Clear();
            mskbxIMC.Clear();

            mskbxPesoAtual.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double pesoAtual;
            double altura;
            double imc;

            if (Double.TryParse(mskbxPesoAtual.Text, out pesoAtual) && Double.TryParse(mskbxAltura.Text, out altura))
            {
                imc = pesoAtual / (Math.Pow(altura, 2));
                imc = Math.Round(imc, 1);
                mskbxIMC.Text = imc.ToString("N1");

                if (imc < 18.5) 
                    MessageBox.Show("Magreza");
                else if ((imc >= 18.5) && (imc <= 24.9))
                    MessageBox.Show("Normal");
                else if ((imc >= 25.0) && (imc <= 29.9))
                    MessageBox.Show("Sobrepeso");
                else if ((imc >= 30.0) && (imc <= 39.9))
                    MessageBox.Show("Obesidade");
                else
                    MessageBox.Show("Obesidade Grave");
                
            }
        }

        private void btnCalcular_Validated(object sender, EventArgs e)
        {

            double altura = 0;
            double peso = 0;

            if (!double.TryParse(mskbxAltura.Text, out altura) || !double.TryParse(mskbxPesoAtual.Text, out peso))
            {
                MessageBox.Show("Falta um valor");
            }
        }
    }
}
