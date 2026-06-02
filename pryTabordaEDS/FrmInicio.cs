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

            // Registrar manejadores para los items del menú que no tenían evento en el diseñador
            listaSimpleToolStripMenuItem.Click += listaSimpleToolStripMenuItem_Click;
            toolStripMenuItem4.Click += listaDobleToolStripMenuItem_Click;

            // Registrar manejadores para la sección "Base de datos"
            grafoToolStripMenuItem.Click += grafoToolStripMenuItem_Click;
            arbolToolStripMenuItem.Click += arbolBinarioToolStripMenuItem_Click;
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

        // Maneador para abrir Lista Simple
        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaSimple f = new FrmListaSimple();
            f.ShowDialog();
        }

        // Maneador para abrir Lista Doble
        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaDoble f = new FrmListaDoble();
            f.ShowDialog();
        }

        private void grafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGrafo f = new FrmGrafo();
            f.ShowDialog();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArbolBinario f = new FrmArbolBinario();
            f.ShowDialog();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCarreras f = new FrmCarreras();
            f.ShowDialog();
        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSQL f = new FrmSQL();
            f.ShowDialog();
        }
    }
}
