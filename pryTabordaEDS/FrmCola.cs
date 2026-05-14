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
        private clsListaDoble lista = new clsListaDoble();

        public FrmCola()
        {
            InitializeComponent();

            // Asociar handlers (si no están asignados en el diseñador)
            this.btnAgregar.Click += btnAgregar_Click;
            // btnEliminar ya está asignado en el diseñador a btnEliminar_Click
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text.Trim(), out int codigo))
            {
                MessageBox.Show("Ingrese un código numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsNodo nuevo = new clsNodo
            {
                Codigo = codigo,
                Nombre = txtNombre.Text.Trim(),
                Tramite = txtTramite.Text.Trim()
            };

            lista.Agregar(nuevo);
            LimpiarEntradas();
            RefrescarVista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsNodo eliminado = lista.Eliminar();
            if (eliminado == null)
            {
                MessageBox.Show("La cola está vacía.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostrar el elemento eliminado en los TextBox del grupo "Elemento eliminado"
            textBox4.Text = eliminado.Codigo.ToString();
            textBox5.Text = eliminado.Nombre;
            textBox6.Text = eliminado.Tramite;

            RefrescarVista();
        }

        // Actualiza DataGridView y ListBox con el contenido de la lista
        private void RefrescarVista()
        {
            dgvCola.Rows.Clear();
            lstCola.Items.Clear();

            clsNodo aux = lista.Primero;
            while (aux != null)
            {
                dgvCola.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                lstCola.Items.Add($"{aux.Codigo} - {aux.Nombre}");
                aux = aux.Siguiente;
            }
        }

        private void LimpiarEntradas()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            txtCodigo.Focus();
        }
    }
}
