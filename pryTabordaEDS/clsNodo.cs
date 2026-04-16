using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryTabordaEDS
{
    internal class clsNodo
    {
        private Int32 cod;
        private string nom;
        private String tra;

        //Propiedades del nodoo
        public Int32 Codigo
        {
            get { return cod; }
            set { cod = value; }
        }
        public string Nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public String Tramite
        {
            get { return tra; }
            set { tra = value; }
        }
    }
}
