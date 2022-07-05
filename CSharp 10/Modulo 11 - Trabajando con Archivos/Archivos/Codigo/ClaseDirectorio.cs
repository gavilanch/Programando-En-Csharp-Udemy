using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos.Codigo
{
    internal class ClaseDirectorio
    {
        public void CodigoDelCurso()
        {
            var rutaEjemplo = @"..\..\..\Mi Directorio";

            Directory.CreateDirectory(rutaEjemplo);

            var rutasDirectorios = Directory.EnumerateDirectories(rutaEjemplo, "*", SearchOption.AllDirectories);

            foreach (var ruta in rutasDirectorios)
            {
                Console.WriteLine(ruta);
            }

            var rutasArchivos = Directory.EnumerateFiles(rutaEjemplo, "*.json", SearchOption.AllDirectories);

            foreach (var ruta in rutasArchivos)
            {
                Console.WriteLine(ruta);
            }

            //Directory.Delete(rutaEjemplo);
        }
    }
}
