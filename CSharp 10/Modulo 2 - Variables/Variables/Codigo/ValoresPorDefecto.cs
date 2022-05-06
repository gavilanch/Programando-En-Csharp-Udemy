#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo
{
    internal class ValoresPorDefecto
    {
        public void CodigoDelCurso()
        {
            int edad = default;

            Console.WriteLine("Valor por defecto de int: ");
            Console.WriteLine(edad);

            edad = 8;

            bool hoyEsDomingo = default;

            Console.WriteLine("Valor por defecto de bool: ");
            Console.WriteLine(hoyEsDomingo);

            decimal precio = default;

            Console.WriteLine("Valor por defecto de decimal: ");
            Console.WriteLine(precio);

            DateTime fecha = default;

            Console.WriteLine("Valor por defecto de fecha: ");
            Console.WriteLine(fecha);

            string nombre = null;

            Console.WriteLine("Valor por defecto de string: ");
            Console.WriteLine(nombre);
        }
    }
}
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.