using System;
using System.Collections.Generic;
using System.Text;

namespace Concurrencia.Codigo
{
    internal class LockNuevoObjeto
    {
        public void CodigoDelCurso()
        {
            Console.WriteLine("Inicio");


            var valorIncrementado = 0;
            var valorSumado = 0;

            var mutex = new Lock();

            Parallel.For(0, 10_000, numero =>
            {
                // realizar las operaciones necesarias en paralelo...

                // esta parte la necesitamos secuencial
                //lock (mutex)
                //{
                //    valorIncrementado++;
                //    valorSumado += valorIncrementado;
                //}

                if (mutex.TryEnter(TimeSpan.FromMicroseconds(5)))
                {
                    try
                    {
                        valorIncrementado++;
                        valorSumado += valorIncrementado;
                    }
                    finally
                    {
                        mutex.Exit();
                    }
                }
                else
                {
                    Console.WriteLine("Timeout: esperamos demasiado tiempo para entrar");
                }
            });

            Console.WriteLine("--Usando lock--");
            Console.WriteLine($"Valor Incrementado: {valorIncrementado}");
            Console.WriteLine($"Valor Sumado: {valorSumado}");


            Console.WriteLine("Fin");
        }
    }

}
