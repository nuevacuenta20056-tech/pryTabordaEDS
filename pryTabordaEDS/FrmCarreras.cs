using System;
using System.Windows.Forms;

namespace pryTabordaEDS
{
    public partial class FrmCarreras : Form
    {
        public FrmCarreras()
        {
            InitializeComponent();

            // Registrar manejadores de eventos para los controles del formulario
            btnAgregar.Click += btnAgregar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnCerrar.Click += btnCerrar_Click;
            txtCarrera.KeyDown += txtCarrera_KeyDown;
            lstCarreras.DoubleClick += lstCarreras_DoubleClick;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AddCarrera();
        }

        private void txtCarrera_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                AddCarrera();
            }
        }

        private void AddCarrera()
        {
            var carrera = txtCarrera.Text.Trim();
            if (string.IsNullOrEmpty(carrera))
            {
                MessageBox.Show("Ingrese una carrera.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCarrera.Focus();
                return;
            }

            // Evitar duplicados simples
            if (!lstCarreras.Items.Contains(carrera))
            {
                lstCarreras.Items.Add(carrera);
            }
            else
            {
                MessageBox.Show("La carrera ya está en la lista.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtCarrera.Clear();
            txtCarrera.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCarrera.Clear();
            txtCarrera.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstCarreras_DoubleClick(object sender, EventArgs e)
        {
            if (lstCarreras.SelectedIndex >= 0)
            {
                var item = lstCarreras.SelectedItem.ToString();
                var confirm = MessageBox.Show($"¿Eliminar \"{item}\" de la lista?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    lstCarreras.Items.RemoveAt(lstCarreras.SelectedIndex);
                }
            }
        }
    }
}
