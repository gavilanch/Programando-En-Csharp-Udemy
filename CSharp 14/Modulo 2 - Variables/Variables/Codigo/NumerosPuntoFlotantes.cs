using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo
{
    public class NumerosPuntoFlotantes
    {
        public void CodigoDelCurso()
        {
            float altura = 180.123456789f; // Ocupa 4 bytes; Precisión de 6 a 9 dígitos
            double anchura = 45.123456789; // Ocupa 8 bytes; Precisión de 15 a 17 dígitos
            decimal monto = 9.99m; // Ocupa 16 bytes; Precisión de 28 a 29 dígitos (es recomendado temas financieros)

            Console.WriteLine("La altura es:");
            Console.WriteLine(altura);

            Console.WriteLine("La anchura es:");
            Console.WriteLine(anchura);

            Console.WriteLine("El precio es:");
            Console.WriteLine(monto);

        }
    }
}
