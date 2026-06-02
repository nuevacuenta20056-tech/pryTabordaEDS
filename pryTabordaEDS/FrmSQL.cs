using System;
using System.Linq;
using System.Windows.Forms;

namespace pryTabordaEDS
{
    public partial class FrmSQL : Form
    {
        public FrmSQL()
        {
            InitializeComponent();

            // Registrar manejadores (asegurarse de que los controles existen)
            if (btnListar != null) btnListar.Click += btnListar_Click;
            if (btnCerrar != null) btnCerrar.Click += btnCerrar_Click;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            var sql = txtSQL?.Text.Trim();
            if (string.IsNullOrEmpty(sql))
            {
                MessageBox.Show("Ingrese una consulta SQL.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSQL?.Focus();
                return;
            }

            pnlResultado.Controls.Clear();
            var lbl = new Label
            {
                AutoSize = false,
                Text = "Aquí se mostrará el resultado de la consulta (implementar conexión y llenado).",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                ForeColor = System.Drawing.Color.FromArgb(30, 30, 60),
                Font = new System.Drawing.Font("Segoe UI", 9.5F)
            };
            pnlResultado.Controls.Add(lbl);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
