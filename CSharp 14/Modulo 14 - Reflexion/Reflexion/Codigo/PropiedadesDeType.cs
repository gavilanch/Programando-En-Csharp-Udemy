using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion.Codigo
{
    internal class PropiedadesDeType
    {
        public void CodigoDelCurso()
        {
            Type tipo = typeof(int);

            int edad = 999;
            Type tipoDeDatoDeEdad = edad.GetType();

            Type tipoDeDatoSystemInt32 = Type.GetType("System.Int32")!;

            Console.WriteLine($"¿Es {tipo.Name} un arreglo? {tipo.IsArray}");

            Console.WriteLine($"El valor máximo de un entero es (sin reflexión): {int.MaxValue}");

            var valor = tipo.GetField("MaxValue")!.GetValue(default(int));

            Console.WriteLine($"El valor máximo de un entero es (con reflexión): {valor}");
        }
    }
}
