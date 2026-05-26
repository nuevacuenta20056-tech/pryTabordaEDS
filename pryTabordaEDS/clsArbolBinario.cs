using System;
using System.Windows.Forms;

namespace pryTabordaEDS
{
    internal class clsArbolBinario
    {
        private clsNodo primerNodo;

        public clsNodo Raiz
        {
            get { return primerNodo; }
            set { primerNodo = value; }
        }

        public void Agregar(clsNodo nuevo)
        {
            if (nuevo == null)
            {
                return;
            }

            nuevo.Izquierdo = null;
            nuevo.Derecho = null;

            if (Raiz == null)
            {
                Raiz = nuevo;
                return;
            }

            clsNodo actual = Raiz;
            clsNodo anterior = null;

            while (actual != null)
            {
                anterior = actual;

                if (nuevo.Codigo < actual.Codigo)
                {
                    actual = actual.Izquierdo;
                }
                else
                {
                    actual = actual.Derecho;
                }
            }

            if (nuevo.Codigo < anterior.Codigo)
            {
                anterior.Izquierdo = nuevo;
            }
            else
            {
                anterior.Derecho = nuevo;
            }
        }

        public clsNodo Buscar(Int32 codigo)
        {
            clsNodo actual = Raiz;

            while (actual != null)
            {
                if (codigo == actual.Codigo)
                {
                    return actual;
                }

                actual = codigo < actual.Codigo ? actual.Izquierdo : actual.Derecho;
            }

            return null;
        }

        public clsNodo Eliminar(Int32 codigo)
        {
            clsNodo eliminado = Buscar(codigo);
            Raiz = EliminarNodo(Raiz, codigo);
            return eliminado;
        }

        public void RecorrerInOrden(DataGridView grilla)
        {
            PrepararGrilla(grilla);
            RecorrerInOrden(Raiz, grilla);
        }

        public void RecorrerPreOrden(DataGridView grilla)
        {
            PrepararGrilla(grilla);
            RecorrerPreOrden(Raiz, grilla);
        }

        public void RecorrerPostOrden(DataGridView grilla)
        {
            PrepararGrilla(grilla);
            RecorrerPostOrden(Raiz, grilla);
        }

        private clsNodo EliminarNodo(clsNodo nodo, Int32 codigo)
        {
            if (nodo == null)
            {
                return null;
            }

            if (codigo < nodo.Codigo)
            {
                nodo.Izquierdo = EliminarNodo(nodo.Izquierdo, codigo);
            }
            else if (codigo > nodo.Codigo)
            {
                nodo.Derecho = EliminarNodo(nodo.Derecho, codigo);
            }
            else
            {
                if (nodo.Izquierdo == null)
                {
                    return nodo.Derecho;
                }

                if (nodo.Derecho == null)
                {
                    return nodo.Izquierdo;
                }

                clsNodo reemplazo = ObtenerMenor(nodo.Derecho);
                nodo.Codigo = reemplazo.Codigo;
                nodo.Nombre = reemplazo.Nombre;
                nodo.Tramite = reemplazo.Tramite;
                nodo.Derecho = EliminarNodo(nodo.Derecho, reemplazo.Codigo);
            }

            return nodo;
        }

        private clsNodo ObtenerMenor(clsNodo nodo)
        {
            while (nodo.Izquierdo != null)
            {
                nodo = nodo.Izquierdo;
            }

            return nodo;
        }

        private void PrepararGrilla(DataGridView grilla)
        {
            if (grilla == null)
            {
                return;
            }

            if (grilla.Columns.Count == 0)
            {
                grilla.Columns.Add("Codigo", "Codigo");
                grilla.Columns.Add("Nombre", "Nombre");
                grilla.Columns.Add("Tramite", "Tramite");
            }

            grilla.Rows.Clear();
        }

        private void AgregarFila(DataGridView grilla, clsNodo nodo)
        {
            if (grilla != null && nodo != null)
            {
                grilla.Rows.Add(nodo.Codigo, nodo.Nombre, nodo.Tramite);
            }
        }

        private void RecorrerInOrden(clsNodo nodo, DataGridView grilla)
        {
            if (nodo == null)
            {
                return;
            }

            RecorrerInOrden(nodo.Izquierdo, grilla);
            AgregarFila(grilla, nodo);
            RecorrerInOrden(nodo.Derecho, grilla);
        }

        private void RecorrerPreOrden(clsNodo nodo, DataGridView grilla)
        {
            if (nodo == null)
            {
                return;
            }

            AgregarFila(grilla, nodo);
            RecorrerPreOrden(nodo.Izquierdo, grilla);
            RecorrerPreOrden(nodo.Derecho, grilla);
        }

        private void RecorrerPostOrden(clsNodo nodo, DataGridView grilla)
        {
            if (nodo == null)
            {
                return;
            }

            RecorrerPostOrden(nodo.Izquierdo, grilla);
            RecorrerPostOrden(nodo.Derecho, grilla);
            AgregarFila(grilla, nodo);
        }
    }
}
