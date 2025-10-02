using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetApp.Codigo
{
    internal class ConectandonosConSQLServer
    {
        internal void CodigoDelCurso()
        {
            var cadenaConexión = "Data Source=.;Database=AdoNetDemo;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection conexión = new SqlConnection(cadenaConexión))
                {
                    // Abrimos la conexión
                    conexión.Open();

                    Console.WriteLine("Conexión abierta");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No pudimos abrir la conexión");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Fin");
        }
    }
}
