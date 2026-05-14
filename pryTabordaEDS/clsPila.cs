using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTabordaEDS
{
    internal class clsPila
    {
        private clsNodo pri;

        //propiedades de la clase 
        public clsNodo Pri
        {
            get { return pri; }
            set { pri = value; }
        }

        //metodo para agregar un nodo a la pila
        public void Agregar(clsNodo nuevo)
        {
            if (pri == null)
            {
                pri = nuevo;
            }
            else
            {
                nuevo.Siguiente = pri;
                pri = nuevo;
            }
        }

        //Metodo para eliminar un nodo de la pila
        public void Eliminar()
        {
            if (pri != null)
            {
                pri = pri.Siguiente;
            }
        }

        internal void Recorrer(string NombreArchivo)
        {
            clsNodo aux = pri;
            using (StreamWriter AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8))
            {
                AD.WriteLine("Lista de personas");
                AD.WriteLine("Codigo\tNombre\tTramite");
                while (aux != null)
                {
                    AD.Write(aux.Codigo);
                    AD.Write("\t");
                    AD.Write(aux.Nombre);
                    AD.Write(";/");
                    AD.WriteLine(aux.Tramite);
                    aux = aux.Siguiente;
                }
            }
        }

        internal void Recorrer(DataGridView dgvPila)
        {
            // Asegurar que la grilla tenga columnas (si no se definen en el diseñador)
            if (dgvPila.Columns.Count == 0)
            {
                dgvPila.Columns.Add("Codigo", "Codigo");
                dgvPila.Columns.Add("Nombre", "Nombre");
                dgvPila.Columns.Add("Tramite", "Tramite");
            }

            dgvPila.Rows.Clear();
            clsNodo aux = pri;
            while (aux != null)
            {
                dgvPila.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        internal void Recorrer(ListBox lstPila)
        {
            lstPila.Items.Clear();
            clsNodo aux = pri;
            while (aux != null)
            {
                lstPila.Items.Add($"{aux.Codigo} - {aux.Nombre}");
                aux = aux.Siguiente;
            }
        }
    }
}
