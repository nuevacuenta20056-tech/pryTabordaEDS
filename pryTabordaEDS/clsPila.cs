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
            StreamWriter AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8);
            AD.WriteLine("Lista de personas");
            AD.WriteLine("Codigo\tNombre\tTramite");
            while (aux != null)
            {
               AD.Write(aux.Codigo);
                AD.Write("");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Tramite);
                aux = aux.Siguiente;
            }
            AD.Close();

        }

        internal void Recorrer(DataGridView dgvPila)
        {
       
        }

        internal void Recorrer(ListBox lstPila)
        {
            throw new NotImplementedException();
        }


    }
}
