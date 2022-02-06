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

namespace P0030482113037
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int qtdLinhas = 7;
            int qtdColunas = 4;
            double[,] mes = new double[qtdLinhas, qtdColunas];
            double soma = 0;
            int linha = 0, coluna = 0;
            string valormes = string.Empty;
            double resultado=0;


            for (linha = 0; linha < qtdLinhas; linha++)
            {
                soma = 0;
                for (coluna = 0; coluna < qtdColunas; coluna++)
                {
                    do
                    {
                        valormes = Interaction.InputBox($"Total do mês: { linha + 1} Semana: {coluna + 1}\n\n *Lembrete: Não pode deixar em branco e somente pode valores numéricos.", "Entrada de Dados");

                    } while ((!double.TryParse(valormes, out mes[linha, coluna])));

                    lstbxMeses.Items.Add($"Total do mês:{linha + 1} Semana: {coluna + 1} {(mes[linha, coluna]).ToString("C2")}");
                    
                    soma += mes[linha, coluna];
                    resultado = resultado + mes[linha, coluna];
                }
                lstbxMeses.Items.Add($">>Total Mês: {soma.ToString("c2")}");

                lstbxMeses.Items.Add($"______________________");
            }
            lstbxMeses.Items.Add($">>Total Geral: {resultado.ToString("c2")}");
        }

    }
}
