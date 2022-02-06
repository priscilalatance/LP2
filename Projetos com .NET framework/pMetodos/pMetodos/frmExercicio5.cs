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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSorteio1_Click(object sender, EventArgs e)
        {
 
            System.Random Resultado = new Random();

            int numero1=0, numero2=0;
            double r=0;

            if ((!int.TryParse(txtNumero1.Text, out numero1) || (!int.TryParse(txtNumero2.Text, out numero2))))
            {
                MessageBox.Show("Valores tem que ser numéricos");
            }
            else if (numero1 > numero2)
            {
                MessageBox.Show("Valor do Numero 1 tem que ser menor que o Numero 2");
            }
            else
            {
                r = Resultado.Next(numero1, numero2);
                MessageBox.Show(" O resultado do sorteio é " + r.ToString());
            }
        }
    }
}
