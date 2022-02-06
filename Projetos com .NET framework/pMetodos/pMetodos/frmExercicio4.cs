using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pMetodos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            char[] vetor = rtbTexto.Text.ToCharArray();
            int x, l=0;
            


                for ( x = 0; x < rtbTexto.Text.Length; x++)
                {
                if (Char.IsNumber(vetor[x]))
                    l++;
                }
            MessageBox.Show("Temos o total de " + l.ToString() + " números");
        }

        private void btnCaracter_Click(object sender, EventArgs e)
        {
           
            int x = 0;

            while (x < rtbTexto.Text.Length) 
            {
                if (char.IsWhiteSpace(rtbTexto.Text[x])) 
                {
                    break;
                }
                x++; 
            }
            MessageBox.Show("A posição do primeiro espaço em branco encontrado é " + x.ToString());

        }

        private void btnLetras_Click(object sender, EventArgs e)
        {

            int x = 0;

            foreach (char texto in rtbTexto.Text)
            {
                if (char.IsLetter(texto))
                {
                    x++;
                }
            }

            MessageBox.Show("Temos " + x.ToString() + " Caracteres alfabéticos");
        }
    }
}
