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
    public partial class FrmPila : Form
    {
        public FrmPila()
        {
            InitializeComponent();
        }
        clsPila pila = new clsPila();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text.Trim(), out int codigo))
            {
                MessageBox.Show("Ingrese un código numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsNodo nuevo = new clsNodo();
            nuevo.Codigo = codigo;
            nuevo.Nombre = txtNombre.Text.Trim();
            nuevo.Tramite = txtTramite.Text.Trim();

            pila.Agregar(nuevo);

            // Actualizar vistas y archivo
            pila.Recorrer(dgvPila);
            pila.Recorrer(lstPila);
            pila.Recorrer("ArchivoPila.txt");

            // Limpiar entradas
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            txtCodigo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (pila.Pri != null)
            {
                // Guardar valores antes de eliminar
                int codigo = pila.Pri.Codigo;
                string nombre = pila.Pri.Nombre;
                string tramite = pila.Pri.Tramite;

                pila.Eliminar();

                // Mostrar el elemento eliminado en los TextBox del grupo "Elemento Eliminado"
                textBox1.Text = codigo.ToString();
                textBox2.Text = nombre;
                textBox3.Text = tramite;

                // Actualizar vistas
                pila.Recorrer(dgvPila);
                pila.Recorrer(lstPila);
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }
    }
}
