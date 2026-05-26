using System;
using System.Windows.Forms;

namespace pryTabordaEDS
{
    public partial class FrmGrafo : Form
    {
        private clsGrafo grafo = new clsGrafo();

        public FrmGrafo()
        {
            InitializeComponent();

            button1.Click += button1_Click;
            button2.Click += button2_Click;
            btnListarDestinos.Click += btnListarDestinos_Click;
            btnListarOrigenes.Click += btnListarOrigenes_Click;
            btnVerTodosLosViajes.Click += btnVerTodosLosViajes_Click;
        }

        private void FrmGrafo_Load(object sender, EventArgs e)
        {
            CargarCiudades();
            grafo.MostrarTodo(dgvPila);
        }

        private void CargarCiudades()
        {
            grafo.MostrarCiudades(comboBox1);
            grafo.MostrarCiudades(comboBox2);
            grafo.MostrarCiudades(comboBox3);
            grafo.MostrarCiudades(comboBox4);
            grafo.MostrarCiudades(cmbDesde);
            grafo.MostrarCiudades(cmbHasta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtTramite.Text.Trim(), out decimal precio))
            {
                MessageBox.Show("Ingrese un precio valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTramite.Focus();
                return;
            }

            if (precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTramite.Focus();
                return;
            }

            grafo.Agregar(comboBox1.SelectedIndex, comboBox2.SelectedIndex, precio);
            grafo.MostrarTodo(dgvPila);

            txtTramite.Clear();
            txtTramite.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal precio = grafo.Consultar(comboBox3.SelectedIndex, comboBox4.SelectedIndex);
            textBox3.Text = precio.ToString();

            if (precio == 0)
            {
                MessageBox.Show("No hay precio cargado para ese viaje.", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "Desea borrar todos los viajes cargados?",
                "Borrar todo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                grafo.BorrarTodo();
                grafo.MostrarTodo(dgvPila);
                textBox3.Clear();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            grafo.Eliminar(comboBox3.SelectedIndex, comboBox4.SelectedIndex);
            grafo.MostrarTodo(dgvPila);
            textBox3.Clear();
        }

        private void btnListarDestinos_Click(object sender, EventArgs e)
        {
            grafo.MostrarDestinos(cmbDesde.SelectedIndex, dgvPila);
        }

        private void btnListarOrigenes_Click(object sender, EventArgs e)
        {
            grafo.MostrarOrigenes(cmbHasta.SelectedIndex, dgvPila);
        }

        private void btnVerTodosLosViajes_Click(object sender, EventArgs e)
        {
            grafo.MostrarTodo(dgvPila);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void lblTramite_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvPila_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTramiteEliminar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnVerTodosLosViajes_Click_1(object sender, EventArgs e)
        {

        }
    }
}
