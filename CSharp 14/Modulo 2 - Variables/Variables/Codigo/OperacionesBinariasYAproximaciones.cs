using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo
{
    internal class OperacionesBinariasYAproximaciones
    {
        public void CodigoDelCurso()
        {
            // Si usamos double o float, no tenemos representaciones suficientemente precisas
            // de algunos números. Cuando sea necesario, es mejor usar decimal.
            var cantidad1 = 7.1; // double
            var cantidad2 = 3.5; // double
            var resultadoSuma = cantidad1 + cantidad2;
            var resultadoResta = cantidad1 - cantidad2;
            var resultadoMultiplicacion = cantidad1 * cantidad2;
            var resultadoDivision = cantidad1 / cantidad2;
            var resultadoResiduo = cantidad1 % cantidad2;

            Console.WriteLine("La suma es " + resultadoSuma);
            Console.WriteLine("La resta es " + resultadoResta);
            Console.WriteLine("La multiplicación es " + resultadoMultiplicacion);
            Console.WriteLine("La división es " + resultadoDivision);
            Console.WriteLine("El residuo es " + resultadoResiduo);
        }
    }
}
