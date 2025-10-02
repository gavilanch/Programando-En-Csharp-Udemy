using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemasAdicionales.Codigo
{
    internal class EventosYTimers
    {
        public void CodigoDelCurso()
        {
            var miTimer = new System.Timers.Timer(1000);
            miTimer.Elapsed += ImprimirHoraActual;
            miTimer.Start();
            Console.ReadLine();
            Console.WriteLine("Ahora, vamos a imprimir mi nombre también: ");
            miTimer.Elapsed += ImprimirMiNombre;
            Console.ReadLine();
            Console.WriteLine("Ya no vamos a imprimir mi nombre: ");
            miTimer.Elapsed -= ImprimirMiNombre;
            Console.ReadLine();
            Console.WriteLine("Fin");
        }

        void ImprimirMiNombre(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Felipe");
        }

        void ImprimirHoraActual(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
