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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnEspaços_Click(object sender, EventArgs e)
        {

            int x = 0;

            foreach (char texto in rchtxtFrase.Text)
            {
                if (char.IsWhiteSpace(texto))
                {
                    x++;
                }
            }

            MessageBox.Show($"Temos {x} no total de Caracteres em Brancos.");
        }

        private void btnLetraR_Click(object sender, EventArgs e)
        {

                var total = rchtxtFrase.Text.ToUpper().Count(x => x.Equals('R'));

           //MessageBox.Show("Temos " + total.ToString() + " Caracteres R na frase");
            MessageBox.Show($"Temos {total} Caracteres R na frase.");
          //  MessageBox.Show("Temos {0} Caracteres R na frase", total.ToString());
        }

        private void btnParesLetras_Click(object sender, EventArgs e)
        {
            int x , iguais = 0;

            for (x = 1; x < rchtxtFrase.Text.Length; x++)
            {
                if (rchtxtFrase.Text[x] == rchtxtFrase.Text[x - 1])
                {
                    iguais++;
                }
            }

            MessageBox.Show($"Temos {iguais} conjuntos de Caracteres Iguais na frase.");
        }
    }
}
