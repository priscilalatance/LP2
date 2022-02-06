using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace pAula9
{
    public partial class FrmExercicio_2 : Form
    {
        public FrmExercicio_2()
        {
            InitializeComponent();
        }

        private void btnMercadorias_Click(object sender, EventArgs e)
        {
            int[] Quantidade = new int[10];
            double[] Preco = new double[10];
            double faturamento = 0;

            string auxiliar = "", auxiliar1 = "";


            for (var i = 0; i < 10; i++)
            {
                auxiliar = Interaction.InputBox("Digite a quantidade das Mercadorias " + (i + 1).ToString(),
                      "Entrada de Quantidade de Mercadorias");

                if (!int.TryParse(auxiliar, out Quantidade[i]))
                    MessageBox.Show("Quantidade inválida!");
                else
                {
                    if (Quantidade[i] <= 0)
                        MessageBox.Show("Quantidade não pode ser <= 0");
                }

                while (true)
                {
                    auxiliar1 = Interaction.InputBox("Digite o preço " + (i + 1),
                    "Entrada dos Preços");

                    if (!double.TryParse(auxiliar1, out Preco[i]))
                        MessageBox.Show("Preço inválido!");
                    else
                    {
                        if (Preco[i] <= 0)
                            MessageBox.Show("Preço não pode ser <=0");
                        else
                        {
                            faturamento += Quantidade[i] * Preco[i];
                            break;
                        }
                    }                         
                }                
            }
            MessageBox.Show($"Total de Faturamento R${faturamento} no mês");
        }
    }
}
