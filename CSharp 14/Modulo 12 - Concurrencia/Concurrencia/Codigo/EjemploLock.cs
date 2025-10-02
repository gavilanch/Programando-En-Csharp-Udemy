using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrencia.Codigo
{
    internal class EjemploLock
    {
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Inicio");

            var valorConInterlocked = 0;
            var valorConInterlocked2 = 0;

            Parallel.For(0, 10_000, numero =>
            {
                Interlocked.Increment(ref valorConInterlocked);
                Interlocked.Add(ref valorConInterlocked2, valorConInterlocked);
            });

            Console.WriteLine("--Usando dos interlockeds--");
            Console.WriteLine("Valor incrementado: " + valorConInterlocked);
            Console.WriteLine("Valor sumado: " + valorConInterlocked2);

            var valorIncrementado = 0;
            var valorSumado = 0;

            var mutex = new object();

            Parallel.For(0, 10_000, numero =>
            {
                // realizar las operaciones necesarias en paralelo...

                // esta parte la necesitamos secuencial
                lock (mutex)
                {
                    valorIncrementado++;
                    valorSumado += valorIncrementado;
                }
            });

            Console.WriteLine("--Usando lock--");
            Console.WriteLine($"Valor Incrementado: {valorIncrementado}");
            Console.WriteLine($"Valor Sumado: {valorSumado}");


            Console.WriteLine("Fin");
        }
    }
}
