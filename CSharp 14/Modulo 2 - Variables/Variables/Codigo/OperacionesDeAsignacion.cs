using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo
{
    internal class OperacionesDeAsignacion
    {
        public void CodigoDelCurso()
        {
            var cantidad1 = 7m;
            var cantidad2 = 5m;

            var suma = cantidad1 + cantidad2; // yo no altero cantidad1

            // aquí yo altero cantidad1
            //cantidad1 += cantidad2; // cantidad1 = cantidad1 + cantidad2

            //Console.WriteLine("Cantidad1 es " + cantidad1);

            //cantidad1 -= cantidad2; // cantidad1 = cantidad1 - cantidad2

            //cantidad1 *= cantidad2; // cantidad1 = cantidad1*cantidad2

            //cantidad1 /= cantidad2; // cantidad1 = cantidad1 / cantidad2

            //cantidad1 %= cantidad2; // cantidad1 = cantidad1 % cantidad2
            //Console.WriteLine("Cantidad1 es " + cantidad1);

            var nombre = "Felipe";
            var apellido = " Gavilán";

            nombre += apellido; // nombre = nombre + apellido

            Console.WriteLine(nombre);

        }
    }
}
