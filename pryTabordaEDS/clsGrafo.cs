using System;
using System.Windows.Forms;

namespace pryTabordaEDS
{
    internal class clsGrafo
    {
        // Campos de la clase

        // Vector
        private String[] Ciudades = new String[] { "Cordoba", "Mendoza", "Santa Fe", "Buenos Aires", "Salta" };

        // Matriz
        private Decimal[,] Precio = new Decimal[5, 5];

        // Metodos de la matriz
        public void Agregar(Int32 f, Int32 c, Decimal p)
        {
            Precio[f, c] = p;
        }

        public void Eliminar(Int32 f, Int32 c)
        {
            Precio[f, c] = 0;
        }

        public Decimal Consultar(Int32 f, Int32 c)
        {
            return Precio[f, c];
        }

        // Procedimiento que borra todos los datos cargados
        public void BorrarTodo()
        {
            for (Int32 f = 0; f < 5; f++)
            {
                for (Int32 c = 0; c < 5; c++)
                {
                    Precio[f, c] = 0;
                }
            }
        }

        // Metodos del vector
        public void MostrarCiudades(ComboBox cmb)
        {
            cmb.Items.Clear();
            for (Int32 i = 0; i < 5; i++)
            {
                cmb.Items.Add(Ciudades[i]);
            }
            cmb.SelectedIndex = 0;
        }

        public void MostrarDestinos(Int32 f, DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();
            // Agregar columnas manualmente
            Grilla.Columns.Add("Col1", "Destino");
            Grilla.Columns.Add("Col2", "Precio");
            Grilla.Columns[0].Width = 200;
            Grilla.Columns[1].Width = 200;
            Grilla.Rows.Clear();
            for (Int32 c = 0; c < 5; c++)
            {
                if (Precio[f, c] > 0)
                {
                    Grilla.Rows.Add(Ciudades[c], Precio[f, c]);
                }
            }
        }

        public void MostrarOrigenes(Int32 c, DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();
            // Agregar columnas manualmente
            Grilla.Columns.Add("Col1", "Origen");
            Grilla.Columns.Add("Col2", "Precio");
            Grilla.Columns[0].Width = 200;
            Grilla.Columns[1].Width = 200;
            for (Int32 f = 0; f < 5; f++)
            {
                if (Precio[f, c] > 0)
                {
                    Grilla.Rows.Add(Ciudades[f], Precio[f, c]);
                }
            }
        }

        public void MostrarTodo(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();
            // Agregar columnas manualmente
            Grilla.Columns.Add("NomOrigen", "Origen");
            for (Int32 i = 0; i < 5; i++)
            {
                Grilla.Columns.Add("Destino" + i.ToString(), Ciudades[i]);
            }
            for (Int32 f = 0; f < 5; f++)
            {
                Grilla.Rows.Add(Ciudades[f]);
                for (Int32 c = 0; c < 5; c++)
                {
                    Grilla.Rows[f].Cells[c + 1].Value = Precio[f, c];
                }
            }
        }
    }
}
