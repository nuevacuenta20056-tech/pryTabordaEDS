using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pryTabordaEDS
{
    internal class clsCola
    {
        private clsNodo pri;
        private clsNodo ult;

        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(clsNodo nuevo)
        {
            if (pri == null)
            {
                pri = nuevo;
                ult = nuevo;
            }
            else
            {
                ult.Siguiente = nuevo;
                ult = nuevo;
            }
        }

        public void Eliminar()
        {
            if (pri == ult)
            {
                pri = null;
                ult = null;
            }
            else
            {
                Primero = Primero.Siguiente;
            }
        }

        public void Recorrer()
        {
            clsNodo actual = Primero;
            while (actual != null)
            {
                Console.WriteLine($"Codigo: {actual.Codigo}, Nombre: {actual.Nombre}, Tramite: {actual.Tramite}");
                actual = actual.Siguiente;
            }
        }
    }
}
