using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrencia.Codigo
{
    internal class EjemploInterlocked
    {
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Inicio");

            var valorSinInterlocked = 0;

            Parallel.For(0, 1_000_000, numero => valorSinInterlocked++);

            Console.WriteLine($"Sumatoria sin interlocked: {valorSinInterlocked}");

            var valorConInterlocked = 0;

            Parallel.For(0, 1_000_000, numero => Interlocked.Increment(ref valorConInterlocked));

            Console.WriteLine($"Sumatoria con interlocked: {valorConInterlocked}");

            Console.WriteLine("Fin");
        }
    }
}
