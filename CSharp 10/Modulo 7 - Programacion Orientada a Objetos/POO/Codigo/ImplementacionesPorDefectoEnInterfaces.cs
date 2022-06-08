using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Codigo
{
    internal class ImplementacionesPorDefectoEnInterfaces
    {
        internal interface IAlmacenadorArchivos
        {
            string Guardar(string archivo);
            void Borrar(string urlArchivo);
            string Editar(string urlArchivoAnterior, string archivo)
            {
                Borrar(urlArchivoAnterior);
                return Guardar(archivo);
            }
        }

        internal class AlmacenadorArchivosAWS : IAlmacenadorArchivos
        {
            public void Borrar(string urlArchivo)
            {
                Console.WriteLine("Borrando el archivo en aws");
            }

            public string Guardar(string archivo)
            {
                Console.WriteLine("Guardando el archivo en AWS");
                return "URL del archivo en AWS";
            }

            public string Editar(string urlArchivoAnterior, string archivo)
            {
                Console.WriteLine("Nueva implementación de editar");
                return "";
            }
        }

        internal class AlmacenadorArchivosAzure : IAlmacenadorArchivos
        {
            public void Borrar(string urlArchivo)
            {
                Console.WriteLine("Borrando el archivo en Azure");
            }

            public string Guardar(string archivo)
            {
                Console.WriteLine("Guardando el archivo en Azure");
                return "URL del archivo";
            }
        }

        public void CodigoDelCurso(string[] args)
        {
            var hostBuilder = Host.CreateDefaultBuilder(args);
            hostBuilder = hostBuilder.ConfigureServices(ConfigurarServicios);
            using var host = hostBuilder.Build();

            var almacenadorArchivos = host.Services.GetRequiredService<IAlmacenadorArchivos>();
            almacenadorArchivos.Editar("archivo anterior", "archivo nuevo");

            void ConfigurarServicios(IServiceCollection services)
            {
                services.AddTransient<IAlmacenadorArchivos, AlmacenadorArchivosAWS>();
                services.AddTransient<ControladorDePeliculas>();
                services.AddTransient<OtroLugar>();
            }
        }
    }
}
