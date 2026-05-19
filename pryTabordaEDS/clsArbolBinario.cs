using pryTabordaEDS;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryTabordaEDS
{
    internal class clsArbolBinario
    {
        private clsNodo PrimerNodo;

        public clsNodo Raiz
            {
                get { return PrimerNodo; }
                set { PrimerNodo = value; }
        }
    }
}
public void Agregar(clsNodo Nvo)

    if (Raiz == null)
    {
       Raiz = Nvo;
    }
else
    {
        clsNodo Ant = Raiz;
        clsNodo Aux = Raiz;
        while (Aux != null)
        {
            Ant = Aux;
            if (Nvo.Codigo < Aux.Codigo)
            else
            {
                Aux = Aux.Derecho;
            }

          if (Nvo.Codigo < Ant.Codigo)
            {
                Ant.Izquierdo = Nvo;
            }
            else
            {
                Ant.Derecho = Nvo;
            }