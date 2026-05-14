using System;
using System.Windows.Forms;

namespace pryTabordaEDS
{
    public partial class FrmListaSimple : Form
    {
        public FrmListaSimple()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigoNuevo.Text.Trim(), out int codigo))
            {
                MessageBox.Show("Ingrese un código numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = txtNombreNuevo.Text.Trim();
            string tramite = txtTramiteNuevo.Text.Trim();

            // Añadir a la grilla y a la lista
            dgvListaSimple.Rows.Add(codigo, nombre, tramite);
            lstListaSimple.Items.Add($"{codigo} - {nombre}");

            // Limpiar entradas
            txtCodigoNuevo.Clear();
            txtNombreNuevo.Clear();
            txtTramiteNuevo.Clear();
            txtCodigoNuevo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Eliminar el primer elemento (comportamiento similar a cola) o el seleccionado de la grilla
            if (dgvListaSimple.Rows.Count > 0)
            {
                int rowIndex = 0;
                // Si hay fila seleccionada, usarla
                if (dgvListaSimple.SelectedRows.Count > 0)
                {
                    rowIndex = dgvListaSimple.SelectedRows[0].Index;
                }

                var codigo = dgvListaSimple.Rows[rowIndex].Cells[0].Value?.ToString() ?? "";
                var nombre = dgvListaSimple.Rows[rowIndex].Cells[1].Value?.ToString() ?? "";
                var tramite = dgvListaSimple.Rows[rowIndex].Cells[2].Value?.ToString() ?? "";

                // Mostrar en campos de eliminado
                txtCodigoElim.Text = codigo;
                txtNombreElim.Text = nombre;
                txtTramiteElim.Text = tramite;

                // Quitar de la grilla
                dgvListaSimple.Rows.RemoveAt(rowIndex);

                // Reconstruir lista
                lstListaSimple.Items.Clear();
                foreach (DataGridViewRow r in dgvListaSimple.Rows)
                {
                    var c = r.Cells[0].Value?.ToString() ?? "";
                    var n = r.Cells[1].Value?.ToString() ?? "";
                    lstListaSimple.Items.Add($"{c} - {n}");
                }
            }
            else
            {
                MessageBox.Show("La lista está vacía.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigoElim.Clear();
                txtNombreElim.Clear();
                txtTramiteElim.Clear();
            }
        }
    }
}
