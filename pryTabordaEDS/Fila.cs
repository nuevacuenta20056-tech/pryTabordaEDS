using System;
using System.Windows.Forms;

namespace pryTabordaEDS
{
    public class Fila
    {
        public Nodo Primero { get; set; }

        public void Eliminar()
        {
            
        }

        public void Recorrer(DataGridView dtgv)
        {
            
        }

        public void Recorrer(ListBox lst)
        {
            // Implementación para recorrer y mostrar en ListBox
        }

        public void Recorrer()
        {
            // Implementación para recorrer la fila (sin parámetros)
        }
    }

    public class Nodo
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Tramite { get; set; }
        public Nodo Siguiente { get; set; }
    }
}