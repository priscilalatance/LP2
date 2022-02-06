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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            double salario, producao, gratificacao, salariobruto;
            int b, c, d;

            if (!double.TryParse(txtSalario.Text, out salario) || !double.TryParse(txtProducao.Text, out producao) || !double.TryParse(txtGratificacao.Text, out gratificacao))
            {
                MessageBox.Show("Salário, Produção e Gratificação não pode ser vazio!");
            }
            else
            {
                if (producao >= 100)
                {
                    b = 1;
                }
                else
                    b = 0;
                if(producao>=120)
                {
                    c = 1;
                }
                else
                    c = 0;
                if (producao >= 150)
                {
                    d = 1;
                }
                else
                    d = 0;

                salariobruto = salario + salario * (0.05 * b + 0.1 * c + 0.1 * d) + gratificacao;
                txtSalarioBruto.Text = salariobruto.ToString("N2");

                if (salariobruto >= 7000 && producao >= 150 && gratificacao > 0)
                {
                    MessageBox.Show($"Salário Bruto R${salariobruto:N2}");
                }
                else if (salariobruto >= 7000 && producao < 150 && gratificacao > 0)
                {
                    MessageBox.Show("Salário maior que R$7000,00 somente pode ser pago para funcionário que tem produção maior que 150 e tenha Gratificação.");
                }
                else
                    MessageBox.Show($"Salário Bruto R${salariobruto:N2}");

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCargo.Clear();
            txtMatricula.Clear();
            txtProducao.Clear();
            txtSalario.Clear();
            txtGratificacao.Clear();
            txtSalarioBruto.Clear();

            txtNome.Focus();
        }
    }   
}
