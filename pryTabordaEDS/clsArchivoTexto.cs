using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pryTabordaEDS
{
    internal class clsArchivoTexto
    {

        //Variable para almacenar
        public string NomArchiv = "Colores.txt";

        //Procedimiento para guardar 
        public void Grabar()
        {
           StreamWriter AD = new StreamWriter(NomArchiv);
            AD.WriteLine("Hola"); //Escribe en el archivo
            AD.Close(); //Cierra el archivo
        }

        public void Grabar(string Dato)
        {
            StreamWriter AD = new StreamWriter(NomArchiv, true);
            AD.WriteLine(Dato); //Escribe en el archivo
            AD.Close(); //Cerrar AD
        }

        public void Grabar(string codigo, string Nombre)
            
        {
            StreamWriter AD = new StreamWriter(NomArchiv, true);
            AD.Write(codigo); //Escribe en el archivo sin el ENTER
            AD.Write(";"); //Escribe ";" en el archivo
            AD.WriteLine(Nombre); //Escribe el contenido de la variable + ENTER
            AD.Close(); //Cierra el archivo
        }

        //Procedimiento para recorrer
        public void Recorrer()
        {
            string DatoLeido;
        }

}
}
