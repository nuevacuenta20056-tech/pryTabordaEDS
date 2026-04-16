using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
