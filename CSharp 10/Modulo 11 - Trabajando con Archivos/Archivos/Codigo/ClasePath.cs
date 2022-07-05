using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos.Codigo
{
    internal class ClasePath
    {
        public void CodigoDelCurso()
        {
            var rutaEjemplo = @"..\..\..\";

            var rutas = Directory.EnumerateFiles(rutaEjemplo, "*", SearchOption.AllDirectories);

            foreach (var ruta in rutas)
            {
                //Console.WriteLine(ruta);
                var nombreArchivo = Path.GetFileName(ruta);
                var extensión = Path.GetExtension(ruta);
                Console.WriteLine($"{nombreArchivo} - extensión: {extensión}");
            }

            var ruta1 = @"C:\Users\ASUS\source";
            var ruta2 = @"repos\Archivos";
            var rutaCombinada = Path.Combine(ruta1, ruta2);
            Console.WriteLine(rutaCombinada);
        }
    }
}
