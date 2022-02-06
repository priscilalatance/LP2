using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pVolume2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtAltura.Clear();
            TxtRaio.Clear();
            TxtVolume.Clear();

            TxtRaio.Focus();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double altura, raio;

            if ((double.TryParse(TxtAltura.Text, out altura)) && (double.TryParse(TxtRaio.Text, out raio)))
            {
                double volume;
                volume = Math.PI * Math.Pow(raio, 2) * altura;

                TxtVolume.Text = volume.ToString("N2");
            }
            else
                MessageBox.Show("Valores inválidos, digite novamente");
        }

        private void TxtRaio_TextChanged(object sender, EventArgs e)
        {
            //if (e.KeyChar == (Char)13)
            //{
            //    SendKeys.Send("{TAB}");
            //    e.Handled = true; 
            //}  
        }
    }
}
