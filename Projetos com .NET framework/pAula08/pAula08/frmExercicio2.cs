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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnNumeroH_Click(object sender, EventArgs e)
        {
            int numeroN, x = 1; 
            double numeroH = 0;

            //var numN = Convert.ToInt32(txtNumeroN.Text);

            if ((!int.TryParse(txtNumeroN.Text, out numeroN)))
            {
                MessageBox.Show("Valores tem que ser numéricos!");
                return;
            }

            if (numeroN <= 0)
            {
                MessageBox.Show("O número N tem que ser maior que Zero!");
                return;
            }

            do
            {
                numeroH = numeroH + 1 / (double)x;
                x++;
            } while (x <= numeroN);

            MessageBox.Show($"Calculo do Número H é {numeroH:N2}");
        }
    }
}
