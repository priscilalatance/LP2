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
    public partial class FrmExercicio_1 : Form
    {
        public FrmExercicio_1()
        {
            InitializeComponent();
        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];

            string auxiliar = "";
            string invertido = "";

            for (var i = 0; i < 20; i++)
            {
                auxiliar = Interaction.InputBox("Digite o número da posição " + (i + 1).ToString(),
                      "Entrada de Dados");

                if (!int.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("Número inválido");
                    i--;
                }
                else
                    invertido = vetor[i] + "\n" + invertido;
            }

            MessageBox.Show(invertido);

            // 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20

            // usando o reverse
            /*
            Array.Reverse(vetor);

            auxiliar = "";

            foreach (int i in vetor)
                auxiliar += i + "\n";
            */

            // usando o for ao contrário
            /*
            auxiliar = "";
            for (var i = 19; i >= 0; i--)
                auxiliar += vetor[i] + "\n";

            MessageBox.Show(auxiliar);
            */
        }
    }
}
