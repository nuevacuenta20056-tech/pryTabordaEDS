using System;
using System.Windows.Forms;

namespace pryTabordaEDS
{
    public partial class FrmArbolBinario : Form
    {
        private clsArbolBinario arbol = new clsArbolBinario();

        public FrmArbolBinario()
        {
            InitializeComponent();

            btnAgregar.Click += btnAgregar_Click;
            btnEliminar.Click += btnEliminar_Click;
            rbtnOrden.CheckedChanged += rbtnOrden_CheckedChanged;
        }

        private void FrmArbolBinario_Load(object sender, EventArgs e)
        {
            rbtnOrden.Checked = true;
            RefrescarGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text.Trim(), out int codigo))
            {
                MessageBox.Show("Ingrese un codigo numerico valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return;
            }

            clsNodo nuevo = new clsNodo();
            nuevo.Codigo = codigo;
            nuevo.Nombre = txtNombre.Text.Trim();
            nuevo.Tramite = txtTramite.Text.Trim();

            arbol.Agregar(nuevo);
            RefrescarGrilla();

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            txtCodigo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (arbol.Raiz == null)
            {
                LimpiarEliminado();
                MessageBox.Show("El arbol esta vacio.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int codigo = ObtenerCodigoSeleccionado();
            clsNodo eliminado = arbol.Eliminar(codigo);

            if (eliminado != null)
            {
                textBox1.Text = eliminado.Codigo.ToString();
                textBox2.Text = eliminado.Nombre;
                textBox3.Text = eliminado.Tramite;
            }
            else
            {
                LimpiarEliminado();
                MessageBox.Show("No se encontro el elemento seleccionado.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            RefrescarGrilla();
        }

        private int ObtenerCodigoSeleccionado()
        {
            if (dgvPila.CurrentRow != null && !dgvPila.CurrentRow.IsNewRow)
            {
                object valor = dgvPila.CurrentRow.Cells[0].Value;

                if (valor != null && int.TryParse(valor.ToString(), out int codigo))
                {
                    return codigo;
                }
            }

            return arbol.Raiz.Codigo;
        }

        private void RefrescarGrilla()
        {
            if (rbtnPreOrden.Checked)
            {
                arbol.RecorrerPreOrden(dgvPila);
            }
            else if (rbtnPostOrden.Checked)
            {
                arbol.RecorrerPostOrden(dgvPila);
            }
            else
            {
                arbol.RecorrerInOrden(dgvPila);
            }
        }

        private void LimpiarEliminado()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void rbtnOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnOrden.Checked)
            {
                RefrescarGrilla();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPreOrden.Checked)
            {
                RefrescarGrilla();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPostOrden.Checked)
            {
                RefrescarGrilla();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lstPila_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
