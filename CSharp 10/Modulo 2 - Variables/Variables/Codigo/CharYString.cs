using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo
{
    internal class CharYString
    {
        public void CodigoDelCurso()
        {
            char primeraLetraDelABC = 'A';

            string nombre = "Felipe Gavilán";
            string texto = "Mi amigo me dijo una vez: \"Me caes bien\"";
            string caracterDeEscape = "En C# podemos usar \\ para escapar strings";

            Console.WriteLine(primeraLetraDelABC);
            Console.WriteLine(nombre);
            Console.WriteLine(texto);
            Console.WriteLine(caracterDeEscape);
        }
    }
}
