using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace pryTabordaEDS
{
    internal class clsNodo
    {
        private Int32 cod;
        private string nom;
        private String tra;
        private clsNodo sig;
        private clsNodo ant;

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

        public clsNodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }
        public clsNodo Anterior
        {
            get { return ant; }
            set { ant = value; }
        }
    }
}   

public clsNodo Izquierdo
{
    get { return izq; }
    set { izq = value; }
} 
public clsNodo Derecho
{
    get { return der; }
    set { der = value; }
}
