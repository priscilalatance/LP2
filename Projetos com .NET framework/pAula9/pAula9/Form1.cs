using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pAula9
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio_1 FRM1 = new FrmExercicio_1();
            FRM1.MdiParent = this;
            FRM1.WindowState = FormWindowState.Maximized;
            FRM1.Show();
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio_2 FRM2 = new FrmExercicio_2();
            FRM2.MdiParent = this;
            FRM2.WindowState = FormWindowState.Maximized;
            FRM2.Show();
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio_3 FRM3 = new FrmExercicio_3();
            FRM3.MdiParent = this;
            FRM3.WindowState = FormWindowState.Maximized;
            FRM3.Show();
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio_4 FRM4 = new FrmExercicio_4();
            FRM4.MdiParent = this;
            FRM4.WindowState = FormWindowState.Maximized;
            FRM4.Show();
        }

        private void exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio_5 FRM5 = new FrmExercicio_5();
            FRM5.MdiParent = this;
            FRM5.WindowState = FormWindowState.Maximized;
            FRM5.Show();
        }

        private void exercício6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio_6 FRM6 = new FrmExercicio_6();
            FRM6.MdiParent = this;
            FRM6.WindowState = FormWindowState.Maximized;
            FRM6.Show();
        }

        private void exercício7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* FrmExercicio_7 FRM7 = new FrmExercicio_7();
            FRM7.MdiParent = this;
            FRM7.WindowState = FormWindowState.Maximized;
            FRM7.Show();*/
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
