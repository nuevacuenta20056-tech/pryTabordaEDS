using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTabordaEDS
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmColores x = new FrmColores();
            x.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPila x = new FrmPila();
            x.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void mesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes x = new FrmClientes();
            x.ShowDialog();
        }

        private void mesesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmClientes x = new FrmClientes();
            x.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlumnos x = new FrmAlumnos();
            x.ShowDialog();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCola x = new FrmCola();
            x.ShowDialog();

        }
    }
}
