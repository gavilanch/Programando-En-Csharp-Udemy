using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos.Codigo
{
    internal class UtilizandoElStreamReader
    {
        string rutaEjemplo = @"..\..\..\personas grande.csv";

        public void CodigoDelCurso()
        {
            // Creando el archivo grande
            //using (var sw = new StreamWriter(rutaEjemplo, append: false))
            //{
            //    for (int i = 1; i <= 10_000_000; i++)
            //    {
            //        sw.WriteLine($"{i},Persona {i},{i}.00");
            //    }
            //}

            // Prueba 1: ¿Qué tiempo toma File.ReadAllLines? 2.9 segundos (en mi máquina)
            UsandoFileReadAllLines();

            // Prueba 2: ¿Qué tiempo toma el StreamReader? 0.001 segundos (en mi máquina)
            UsandoStreamReader();
        }

        private void UsandoFileReadAllLines()
        {
            var reloj = new Stopwatch();

            reloj.Start();

            var primeraLinea = File.ReadAllLines(rutaEjemplo)[0];

            reloj.Stop();

            Console.WriteLine(primeraLinea);
            Console.WriteLine($"Duración de File.ReadAllLines: {reloj.ElapsedMilliseconds / 1000.0} segundos");

        }

        private void UsandoStreamReader()
        {
            var reloj = new Stopwatch();

            reloj.Start();

            string primeraLinea_v2;

            // Opción 1: Usar el StreamReader directamente
            //using (var sr = new StreamReader(rutaEjemplo))
            //{
            //    primeraLinea_v2 = sr.ReadLine()!;
            //}

            // Opción 2: usando File.ReadLines (la cual usa el StreamReader internamente)
            primeraLinea_v2 = File.ReadLines(rutaEjemplo).First();

            reloj.Stop();

            Console.WriteLine(primeraLinea_v2);
            Console.WriteLine($"Duración del StreamReader: {reloj.ElapsedMilliseconds / 1000.0} segundos");
        }
    }
}
