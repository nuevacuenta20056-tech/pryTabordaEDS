using System;

namespace pryTabordaEDS
{
    public class clsListaDoble
    {
        private class Nodo
        {
            public int valor;
            public Nodo anterior;
            public Nodo siguiente;
            public Nodo(int v) { valor = v; anterior = null; siguiente = null; }
        }

        private Nodo cabeza;
        private Nodo cola;

        public clsListaDoble()
        {
            cabeza = null;
            cola = null;
        }

        public void InsertarAlFinal(int v)
        {
            Nodo n = new Nodo(v);
            if (cabeza == null)
            {
                cabeza = cola = n;
                return;
            }
            cola.siguiente = n;
            n.anterior = cola;
            cola = n;
        }

        // Añadir aquí el resto de métodos...
    } // <- asegurarse que la clase se cierra
} // <- y que el namespace se cierra