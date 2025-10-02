using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrencia.Codigo
{
    internal class QueEsParallelFor
    {
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("--Contemos del 1 al 10 de manera secuencial--");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--Contemos del 1 al 10 en paralelo --");

            Parallel.For(1, 11, i => Console.WriteLine(i));
        }
    }
}
