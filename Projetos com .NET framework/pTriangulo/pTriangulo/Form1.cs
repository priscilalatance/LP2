using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pTriangulo
{
    public partial class pnlTriangulo : Form
    {
        public pnlTriangulo()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValordeA.Clear();
            txtValordeB.Clear();
            txtValordeC.Clear();

            txtValordeA.Focus();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            double LadoA, LadoB, LadoC;

            if(!double.TryParse(txtValordeA.Text, out LadoA) || !double.TryParse(txtValordeB.Text, out LadoB) || !double.TryParse(txtValordeC.Text, out LadoC))
            {
                MessageBox.Show("Valores tem que ser numéricos");
            }
            else
            {
                if(LadoA<(LadoB+LadoC) && LadoA>Math.Abs(LadoB-LadoC) && LadoB<(LadoA+LadoC)&&LadoB>Math.Abs(LadoA-LadoC) &&LadoC<(LadoA+LadoB) && LadoC>Math.Abs(LadoA-LadoB))
                {
                    if (LadoA==LadoB && LadoB==LadoC)
                    {
                        MessageBox.Show("Triângulo Equilátero!");
                    }
                    else
                    {
                        if(LadoA==LadoB || LadoA==LadoC || LadoC==LadoB)
                        {
                            MessageBox.Show("Triângulo Isósceles!");
                        }
                        else
                        {
                            MessageBox.Show("Triângulo Escaleno!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Valores não formaram um Triângulo");
                }
            }
        }
    }
}
