using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos.Codigo
{
    internal class ClaseFile
    {
        public void CodigoDelCurso()
        {
            // Nota: las rutas debieran funcionarte en tu máquina tal cual.
            // Si no lo hace, simplemente coloca directamente tus rutas
            
            var ruta = @"..\..\..\ejemplo.txt";
            var rutaDestino = @"..\..\..\ejemplo copiado.txt";

            if (File.Exists(ruta))
            {
                var contenido = File.ReadAllText(ruta);
                Console.WriteLine(contenido);
                File.Copy(ruta, rutaDestino, overwrite: true);
            }
            else
            {
                Console.WriteLine("El archivo no fue encontrado");
            }


            File.Delete(rutaDestino);

            var lineas =
                File.ReadAllLines(@"..\..\..\ejemplo lineas.txt");

            Console.WriteLine();
        }
    }
}
