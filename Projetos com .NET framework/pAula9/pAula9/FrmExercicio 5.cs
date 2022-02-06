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
    public partial class FrmExercicio_5 : Form
    {
        public FrmExercicio_5()
        {
            InitializeComponent();
        }

        private void btnMedias_Click(object sender, EventArgs e)
        {
            int qtdLinhas = 20;
            int qtdColunas = 3;
            double[,] notas = new double[qtdLinhas, qtdColunas];
            double media = 0;
            string resultado = string.Empty;
            int linha = 0, coluna = 0;
            string nota= string.Empty;

            for (linha = 0; linha < qtdLinhas; linha++)
            {
                media = 0;

                for (coluna = 0; coluna < qtdColunas; coluna++)
                {
                    do
                    {
                         nota = Interaction.InputBox($"Digite a Nota: { coluna + 1} do aluno { linha + 1}\n\n *Lembrete: Não pode deixar em branco, não Digitar nota abaixo de 0 e maior que 10.", "Entrada de Dados");

                    } while ((!double.TryParse(nota, out notas[linha, coluna])) || notas[linha, coluna] < 0 || notas[linha, coluna] > 10);

                   
                    media += notas[linha, coluna];
                }

                resultado += $"Aluno {linha + 1}: média: {(media / qtdColunas):N2}\n";
            }

            MessageBox.Show(resultado);
        }
    }
}
