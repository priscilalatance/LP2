using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pDescontos
{
    public partial class pnlDesconto : Form
    {
        public pnlDesconto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificarDescontos_Click(object sender, EventArgs e)
        {
            lblDados.Visible = true;

            double salarioBruto = 0, descontoINSS = 0, descontoIRPF = 0, filhos = 0, salarioFamilia = 0, salarioLiquido = 0;

            if (txtNome.Text==String.Empty)
            {
                MessageBox.Show("Não digitou o nome, digite novamente.");
            }
            else
            {
                if (!double.TryParse(mskbxSalario.Text, out salarioBruto) || !double.TryParse(cbxNumeroFilhos.Text, out filhos))
                {
                    MessageBox.Show("Salário Bruto e números de filhos não pode ser vazio");
                }
                else
                {
                    if(salarioBruto<=0)
                    {
                        MessageBox.Show("Salário Bruto deve ser maior que 0");
                    }
                    else
                    {
                        if(salarioBruto <= 800.47)
                        {
                            txtAliquotaINSS.Text = "7,65%";
                            descontoINSS = 0.0765 * salarioBruto;
                        }
                        else if(salarioBruto<=1050)
                        {
                            txtAliquotaINSS.Text = "8,65%";
                            descontoINSS = 0.0865 * salarioBruto;
                        }
                        else if(salarioBruto<=1400.77)
                        {
                            txtAliquotaINSS.Text = "9%";
                            descontoINSS = 0.09 * salarioBruto;
                        }
                        else if(salarioBruto<=2801.56)
                        {
                            txtAliquotaINSS.Text = "11%";
                            descontoINSS = 0.11 * salarioBruto;
                        }
                        else
                        {
                            txtAliquotaINSS.Text = "Teto";
                            descontoINSS = 308.17;
                        }

                        txtDescontoINSS.Text = descontoINSS.ToString("N2");

                        if(salarioBruto<=1257.12)
                        {
                            txtAliquotaIRPF.Text = "0";
                        }
                        else if(salarioBruto<=2512.08)
                        {
                            txtAliquotaIRPF.Text = "15%";
                            descontoIRPF = salarioBruto * 0.15;
                        }
                        else
                        {
                            txtAliquotaIRPF.Text = "27,5%";
                            descontoIRPF = salarioBruto * 0.275;
                        }

                        txtDescontoIRPF.Text = descontoIRPF.ToString("N2");

                        if(filhos>0)
                        {
                            if (salarioBruto <= 432.52)
                            {
                                salarioFamilia = filhos * 22.33;
                            }
                            else if(salarioBruto<=654.61)
                            {
                                salarioFamilia = filhos * 15.74;
                            }
                            else
                            {
                                salarioFamilia = 0;
                            }
                        }

                        txtSalarioFamilia.Text = salarioFamilia.ToString("N2");

                        salarioLiquido = (salarioBruto + salarioFamilia) - descontoINSS - descontoIRPF;

                        txtSalarioLiquido.Text = salarioLiquido.ToString("N2");

                        lblDados.Text = "Os descontos do salário " + (rbtnF.Checked ? "da Sra." : "do Sr.") + txtNome.Text + "\n" + " que é " + (ckbxCasado.Checked ? "Casado(a)" : "Solteiro(a)") + "\n" + " e que tem " + Convert.ToString(filhos) + " filho(s) são:";

                        lblDados.Text = "Os descontos do salário ";

                        if(rbtnF.Checked)
                        {
                            lblDados.Text = lblDados.Text + "da Sra. ";
                        }
                        else
                        {
                            lblDados.Text = lblDados.Text + "do Sr. ";
                        }

                        lblDados.Text = lblDados.Text + txtNome.Text;

                        if(ckbxCasado.Checked)
                        {
                            lblDados.Text = lblDados.Text + " que é casado(a) ";
                        }
                        else
                        {
                            lblDados.Text = lblDados.Text + " que é solteiro(a) ";
                        }

                        lblDados.Text = lblDados.Text + "e que tem: ";

                        lblDados.Text = lblDados.Text + filhos + " filho(s) são: ";
                    }
                }
            }
        }
    }
}
