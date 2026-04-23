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
            clsNodo nuevo = new clsNodo();
            nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nuevo.Nombre = txtNombre.Text;
            nuevo.Tramite = txtTramite.Text;

            pila.Agregar(nuevo);
            pila.Recorrer(dgvPila);
            pila.Recorrer("ArchivoPila.txt");

            txtCodigo.Text = "";    
            txtNombre.Text = "";
            txtTramite.Text = "";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (pila.Pri != null)
            {
                lblCodigo.Text = pila.Pri.Codigo.ToString();
                lblNombre.Text = pila.Pri.Nombre;
                lblTramite.Text = pila.Pri.Tramite;
                pila.Eliminar();
                pila.Recorrer(dgvPila);
                pila.Recorrer(lstPila);
            }   
            else
            {
                lblCodigo.Text = "";
                lblNombre.Text = "";    
                lblTramite.Text = "";   
            }
        }
    }
}
