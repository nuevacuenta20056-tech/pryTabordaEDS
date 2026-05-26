using System;

namespace pryTabordaEDS
{
    internal class clsGrafo
    {
        // Campos de la clase

        // Vector
        private String[] Ciudades = new String[] { "Cordoba", "Mendoza", "Santa Fe", "Buenos Aires", "Salta" };

        // Matriz
        private Decimal[,] Precio = new Decimal[5, 5];

        // Metodos de la matriz
        public void Agregar(Int32 f, Int32 c, Decimal p)
        {
            Precio[f, c] = p;
        }

        public void Eliminar(Int32 f, Int32 c)
        {
            Precio[f, c] = 0;
        }

        public Decimal Consultar(Int32 f, Int32 c)
        {
            return Precio[f, c];
        }
    }
}
