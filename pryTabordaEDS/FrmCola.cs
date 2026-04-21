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
    public partial class FrmCola : Form
    {
        // Declarar la variable fila al nivel de clase
        private Fila fila = new Fila();

        public FrmCola()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmCola_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fila.Primero != null)
            {
                lblCodigo.Text = fila.Primero.Codigo.ToString();
                lblNombre.Text = fila.Primero.Nombre;
                lblTramite.Text = fila.Primero.Tramite;

                fila.Eliminar();
                fila.Recorrer(dtgvItems);
                fila.Recorrer(lstCola);
                fila.Recorrer();
            }
            else
            {
                lblCodigo.Text = "";
                lblNombre.Text = "";
                lblTramite.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clsCola fila = new clsCola();

private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo n = new clsNodo();
            n.Codigo = Convert.ToInt32(txtCodigo.Text);
            n.Nombre = txtNombre.Text;
            n.Tramite = txtTramite.Text;

            fila.Agregar(n);
            fila.Recorrer(dgvCola);
            fila.Recorrer(lstCola);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
