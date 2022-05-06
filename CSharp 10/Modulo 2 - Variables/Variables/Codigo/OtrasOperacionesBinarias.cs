using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo
{
    internal class OtrasOperacionesBinarias
    {
        public void CodigoDelCurso()
        {
            var cantidad1 = 7;
            var cantidad2 = 3;
            var resultadoSuma = cantidad1 + cantidad2;
            var resultadoResta = cantidad1 - cantidad2;
            var resultadoMultiplicacion = cantidad1 * cantidad2;
            // Aquí hicimos un casteo. Lo veremos más adelante en detalle.
            var resultadoDivision = (double)cantidad1 / cantidad2;
            var resultadoResiduo = cantidad1 % cantidad2;

            Console.WriteLine("La suma es " + resultadoSuma);
            Console.WriteLine("La resta es " + resultadoResta);
            Console.WriteLine("La multiplicación es " + resultadoMultiplicacion);
            Console.WriteLine("La división es " + resultadoDivision);
            Console.WriteLine("El residuo es " + resultadoResiduo);
        }
    }
}
