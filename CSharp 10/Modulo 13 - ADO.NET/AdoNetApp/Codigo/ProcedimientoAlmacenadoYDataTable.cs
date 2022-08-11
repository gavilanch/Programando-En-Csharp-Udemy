using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetApp.Codigo
{
    internal class ProcedimientoAlmacenadoYDataTable
    {
        public void CodigoDelCurso(string[] args)
        {
            using IHost host = Host.CreateDefaultBuilder(args).Build();

            var configuración = host.Services.GetService<IConfiguration>();

            var cadenaConexión = configuración.GetConnectionString("cadenaDeConexion");

            try
            {
                using (SqlConnection conexión = new SqlConnection(cadenaConexión))
                {
                    // Abrimos la conexión
                    conexión.Open();
                    Console.WriteLine("Conexión abierta");
                    var query = "Personas_Leer";

                    using (SqlCommand comando = new SqlCommand(query, conexión))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            var dt = new DataTable();
                            adaptador.Fill(dt);

                            foreach (DataRow fila in dt.Rows)
                            {
                                Console.WriteLine($"{fila["Id"]} | {fila["Nombre"]}");
                            }
                        }
                    }
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
