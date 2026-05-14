using System;
using System.Windows.Forms;

namespace pryTabordaEDS
{
    public partial class FrmListaDoble : Form
    {
        private clsListaDoble lista = new clsListaDoble();

        public FrmListaDoble()
        {
            InitializeComponent();

            // Registrar manejadores (el diseñador tiene algunas asociaciones, reforzamos aquí)
            btnAgregar.Click += btnAgregar_Click;
            btnEliminar.Click += btnEliminar_Click;
            // El diseñador asoció la ListBox a `lstListaSimple_SelectedIndexChanged`; dejarlo para compatibilidad.
            lstListaDoble.SelectedIndexChanged += lstListaSimple_SelectedIndexChanged;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigoNuevo.Text.Trim(), out int codigo))
            {
                MessageBox.Show("Ingrese un código numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsNodo nuevo = new clsNodo
            {
                Codigo = codigo,
                Nombre = txtNombreNuevo.Text.Trim(),
                Tramite = txtTramiteNuevo.Text.Trim()
            };

            lista.Agregar(nuevo);

            RefrescarVistas();

            // Limpiar entradas
            txtCodigoNuevo.Clear();
            txtNombreNuevo.Clear();
            txtTramiteNuevo.Clear();
            txtCodigoNuevo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsNodo eliminado = lista.Eliminar();
            if (eliminado != null)
            {
                txtCodigoElim.Text = eliminado.Codigo.ToString();
                txtNombreElim.Text = eliminado.Nombre;
                txtTramiteElim.Text = eliminado.Tramite;
            }
            else
            {
                txtCodigoElim.Clear();
                txtNombreElim.Clear();
                txtTramiteElim.Clear();
                MessageBox.Show("La lista está vacía.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            RefrescarVistas();
        }

        // Sincroniza la selección de la ListBox con la grilla
        private void lstListaSimple_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = lstListaDoble.SelectedIndex;
            if (idx >= 0 && idx < dgvListaSimple.Rows.Count)
            {
                dgvListaSimple.ClearSelection();
                dgvListaSimple.Rows[idx].Selected = true;
                dgvListaSimple.FirstDisplayedScrollingRowIndex = idx;
            }
        }

        // Recorre la lista doble y actualiza ListBox y DataGridView
        private void RefrescarVistas()
        {
            dgvListaSimple.Rows.Clear();
            lstListaDoble.Items.Clear();

            clsNodo aux = lista.Primero;
            while (aux != null)
            {
                dgvListaSimple.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                lstListaDoble.Items.Add($"{aux.Codigo} - {aux.Nombre}");
                aux = aux.Siguiente;
            }
        }
    }
}
