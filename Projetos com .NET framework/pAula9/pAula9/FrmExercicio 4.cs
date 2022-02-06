using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace pAula9
{
    public partial class FrmExercicio_4 : Form
    {
        public FrmExercicio_4()
        {
            InitializeComponent();
        }

        private void btnListadeAlunos_Click(object sender, EventArgs e)
        {
            ArrayList Lista = new ArrayList();
            Lista.Add("Ana");
            Lista.Add("André");
            Lista.Add("Débora");
            Lista.Add("Fátima");
            Lista.Add("João");
            Lista.Add("Janete");
            Lista.Add("Otávio");
            Lista.Add("Marcelo");
            Lista.Add("Pedro");
            Lista.Add("Thais");

            Lista.Remove("Otávio");

            foreach (string nomes in Lista)
            {
                MessageBox.Show($"Nomes: {nomes}");
            }
        }
    }
}
