using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace pryTabordaEDS
{
    internal class clsBasedeDatos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        // Mantengo las cadenas originales como plantilla, pero se construye la ruta absoluta
        private string CadenaDeConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";
        private string CadenaDeConexion2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";

        public void Listar(string tabla, DataGridView Grilla)
        {
            try
            {
                // Usar ruta de la aplicación si existe el MDB allí
                var dbPath = Path.Combine(Application.StartupPath, "Libreria.mdb");
                if (File.Exists(dbPath))
                {
                    conexion.ConnectionString = CadenaDeConexion.Replace("Libreria.mdb", dbPath);
                }
                else
                {
                    conexion.ConnectionString = CadenaDeConexion;
                }

                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;

                DataSet ds = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(ds, tabla);

                Grilla.DataSource = null;
                Grilla.DataSource = ds.Tables[tabla];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                try { conexion.Close(); } catch { }
            }
        }

        // Nuevo: ejecutar consultas SELECT y volcar resultados en un DataGridView
        public void EjecutarConsulta(string sql, DataGridView Grilla)
        {
            if (string.IsNullOrWhiteSpace(sql)) return;

            // Construir rutas/connection strings usando la MDB en la carpeta de la aplicación si existe
            var dbPath = Path.Combine(Application.StartupPath, "Libreria.mdb");
            var connAce = CadenaDeConexion2.Replace("Libreria.mdb", dbPath);
            var connJet = CadenaDeConexion.Replace("Libreria.mdb", dbPath);

            // Intentar ACE primero (más moderno), si falla intentar JET
            Exception lastEx = null;

            try
            {
                conexion.ConnectionString = connAce;
                comando = new OleDbCommand(sql, conexion);
                comando.CommandType = CommandType.Text;

                adaptador = new OleDbDataAdapter(comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                Grilla.DataSource = null;
                Grilla.DataSource = dt;
                return;
            }
            catch (Exception ex)
            {
                lastEx = ex;
                try { conexion.Close(); } catch { }
            }

            try
            {
                conexion.ConnectionString = connJet;
                comando = new OleDbCommand(sql, conexion);
                comando.CommandType = CommandType.Text;

                adaptador = new OleDbDataAdapter(comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                Grilla.DataSource = null;
                Grilla.DataSource = dt;
                return;
            }
            catch (Exception ex2)
            {
                lastEx = ex2;
                try { conexion.Close(); } catch { }
            }

            // Si llegamos acá, ambas intentos fallaron
            MessageBox.Show(lastEx?.Message ?? "Error ejecutando consulta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

