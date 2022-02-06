using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pClasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void btnInstanciarHorista_Click(object sender, EventArgs e)
        {
            Horista ObjHorista = new Horista();

            ObjHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            ObjHorista.NomeEmpregado = txtNome.Text;
            ObjHorista.SalarioHora = Convert.ToDouble(txtSalarioHora.Text);
            ObjHorista.NumeroHora = Convert.ToDouble(txtNumeroHoras.Text);
            ObjHorista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntrada.Text);
            ObjHorista.DiasFalta = Convert.ToInt32(txtDiasFaltas.Text);

            MessageBox.Show("Nome:" + ObjHorista.NomeEmpregado +
            "\n" + "Matrícula:" + ObjHorista.Matricula + "\n" +
            "Tempo Trabalho:" + ObjHorista.TempoTrabalho().ToString()
            + "\n" + "Salário:" + ObjHorista.SalarioBruto().ToString("N2"));
        }
    }
 }

