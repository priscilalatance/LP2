using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pCalculadora
{
    public partial class pnlCalculadora : Form
    {
        public pnlCalculadora()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();

            txtNumero1.Focus();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            double numero1, numero2;

            if ((double.TryParse(txtNumero1.Text, out numero1)) && (double.TryParse(txtNumero2.Text, out numero2)))
            {
                double resultado;
                resultado = numero1+numero2;

                if ((int)(resultado * 10.0) % 10 == 0)
                    txtResultado.Text = resultado.ToString("N0");
                else
                    txtResultado.Text = resultado.ToString("N2");
            }

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            double numero1, numero2;

            if ((double.TryParse(txtNumero1.Text, out numero1)) && (double.TryParse(txtNumero2.Text, out numero2)))
            {
                double resultado;
                resultado = numero1 - numero2;

                if ((int)(resultado * 10.0) % 10 == 0)
                    txtResultado.Text = resultado.ToString("N0");
                else
                    txtResultado.Text = resultado.ToString("N2");
            }
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            double numero1, numero2;

            if ((double.TryParse(txtNumero1.Text, out numero1)) && (double.TryParse(txtNumero2.Text, out numero2)))
            {
                double resultado;
                resultado = numero1 * numero2;

                if ((int)(resultado * 10.0) % 10 == 0)
                    txtResultado.Text = resultado.ToString("N0");
                else
                    txtResultado.Text = resultado.ToString("N2");
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double numero1, numero2;

            if ((double.TryParse(txtNumero1.Text, out numero1)) && (double.TryParse(txtNumero2.Text, out numero2)))
            {
                double resultado;
                resultado = numero1 / numero2;

                if ((int)(resultado * 10.0) % 10 == 0)
                    txtResultado.Text = resultado.ToString("N0");
                else
                    txtResultado.Text = resultado.ToString("N2");



            }
        }

        private void btnDividir_Validated(object sender, EventArgs e)
        {

        }

        private void btnDividir_Validating(object sender, CancelEventArgs e)
        {
            if(txtNumero2.Text=="0")
            {
                MessageBox.Show("Digite novamente, não admitido valor 0 no numero2");
            }
        }

        private void txtNumero1_Validated(object sender, EventArgs e)
        {
            if (txtNumero1.Text == "")
            {
                MessageBox.Show("Digite um número válido");
            }
        }

        private void txtNumero2_Validated(object sender, EventArgs e)
        {
            if (txtNumero2.Text == "0")
            {
                MessageBox.Show("Digite um número válido, não admitido valor 0");
            }
        }

        private void txtResultado_Validated(object sender, EventArgs e)
        {
            //double resultado;


            //if ((int)(resultado * 10.0) % 10 == 0)
            //    txtResultado.Text = resultado.ToString("N0");
            //else
            //    txtResultado.Text = resultado.ToString("N2");



        }
    }
}
