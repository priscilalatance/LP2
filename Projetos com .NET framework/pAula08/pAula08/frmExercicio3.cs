using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pAula08
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnPalindromo_Click(object sender, EventArgs e)
        {
            string texto = "";
            string textorevertido = "";


            if (txtFrase.Text.Length > 50)
            {
                MessageBox.Show("O texto tem que ter no máximo 50 caracteres!");
                return;
            }
            char[] palavra = txtFrase.Text.Replace(" ", "").ToUpper().ToArray();
            char[] reverse = palavra.Reverse().ToArray();


            for (int j = 0; j < palavra.Length; j++)
            {
                texto += Convert.ToString(palavra[j]);
            }
            for (int k = 0; k < reverse.Length; k++)
            {
                textorevertido += Convert.ToString(reverse[k]);
            }
            if (texto == textorevertido)
            {
                MessageBox.Show("É um Palíndromo.");
            }
            else
            {
                MessageBox.Show(" Não é um Palíndromo, escreva novamente!");
            }
        }
    }
}
