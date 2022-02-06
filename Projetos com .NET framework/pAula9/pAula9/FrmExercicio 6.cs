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
    public partial class FrmExercicio_6 : Form
    {
        public FrmExercicio_6()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            char[] vetor = new char[7];

            string nome = "";

            for(var i = 0; i < 7; i++)
            {
                nome = Interaction.InputBox("Digite o Nome:" + (i + 1).ToString(), "Entrada dos Dados");
                var espaco = nome.Replace(" ", "");
                var caracter = espaco.Length;
                lstbxNomes.Items.Add($"O nome: {nome} tem {caracter} caracteres.");
            }

        }
    }
}
