using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo
{
    internal class FuncionMain
    {
        public int CodigoDelCurso(string[] args)
        {
            Console.WriteLine($"Recibiendo {args.Length} argumentos de la consola");

            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }

            return 20;
        }
    }
}
