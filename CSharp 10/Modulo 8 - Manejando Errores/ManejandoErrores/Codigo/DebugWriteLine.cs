using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejandoErrores.Codigo
{
    internal class DebugWriteLine
    {
        public void CodigoDelCurso()
        {
            var escritorConsola = new TextWriterTraceListener(System.Console.Out);
            var escritorPersonalizado = new TextWriterTraceListener(new EscritorPersonalizado());
            Trace.Listeners.Add(escritorConsola);
            Trace.Listeners.Add(escritorPersonalizado);

            Console.WriteLine("Esta línea se ha ejecutado");

            var cantidad1 = 4;

            Console.WriteLine($"El valor de la variable es: {cantidad1}");

            Debug.WriteLine("Este mensaje solo aparece en modo debug");
        }
    }
}
