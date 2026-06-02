using System;
using System.Linq;
using System.Windows.Forms;

namespace pryTabordaEDS
{
    public partial class FrmSQL : Form
    {
        private readonly clsBasedeDatos db = new clsBasedeDatos();
        private DataGridView dgvResultado;

        public FrmSQL()
        {
            InitializeComponent();

            // Crear DataGridView dentro del panel de resultado
            dgvResultado = new DataGridView
            {
                Name = "dgvResultado",
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = System.Drawing.Color.WhiteSmoke
            };

            if (pnlResultado != null)
            {
                pnlResultado.Controls.Clear();
                pnlResultado.Controls.Add(dgvResultado);
            }

            // Registrar manejadores (asegurarse de que los controles existen)
            if (btnListar != null) btnListar.Click += btnListar_Click;
            if (btnCerrar != null) btnCerrar.Click += btnCerrar_Click;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            var sql = txtSQL?.Text.Trim();
            if (string.IsNullOrEmpty(sql))
            {
                MessageBox.Show("Ingrese una consulta SQL o el nombre de la tabla.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSQL?.Focus();
                return;
            }

            try
            {
                // Si el texto no contiene espacios, se trata como nombre de tabla (comportamiento TableDirect)
                if (!sql.Contains(" "))
                {
                    db.Listar(sql, dgvResultado);
                }
                else
                {
                    // Ejecuta la consulta SELECT y vuelca el resultado en el DataGridView
                    db.EjecutarConsulta(sql, dgvResultado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al ejecutar consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
