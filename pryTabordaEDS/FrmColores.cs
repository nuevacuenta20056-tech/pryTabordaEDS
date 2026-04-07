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
    public partial class FrmColores : Form
    {
        public FrmColores()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NomArchiv = "Colores.txt";
            x.Grabar(lblColor.Text);

            MessageBox.Show("Color grabado correctamente");
        }
    }
}
