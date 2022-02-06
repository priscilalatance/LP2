﻿using System;
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
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void btnInstanciarMensalista_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();


            // set
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntradaEmpresa.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalarioMensal.Text);

            //get
            MessageBox.Show("Matrícula : " + objMensalista.Matricula + "\n" +
            "Nome : " + objMensalista.NomeEmpregado + "\n" +
            "Data Entrada : " + objMensalista.DataEntradaEmpresa.ToShortDateString() +
            "\n" +
            "Salário Bruto : " + objMensalista.SalarioBruto().ToString("N2") + "\n" +
            "Tempo Empresa (dias): " + objMensalista.TempoTrabalho());

        }

        private void btnInstanciarMensalistaparametros_Click(object sender, EventArgs e)
        {
            Mensalista mensalista = new Mensalista(
            Convert.ToInt32(txtMatricula.Text),
            txtNome.Text,
            Convert.ToDateTime(txtDataEntradaEmpresa.Text),
            Convert.ToDouble(txtSalarioMensal.Text));

            MessageBox.Show("Nome =" + mensalista.NomeEmpregado + "\n" +
            "Matrícula =" + mensalista.Matricula + "\n" +
            "Salário Final =" +
            mensalista.SalarioBruto().ToString("N2")
            + "\n" +
            "Tempo Empresa =" +
            mensalista.TempoTrabalho().ToString());

        }
    }
 }

