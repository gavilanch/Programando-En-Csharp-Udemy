using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosYColecciones.Codigo
{
    internal class Introduccion_a_los_genericos
    {
        internal interface IUtilidadesArreglos<T>
        {
            int CalcularLongitudDeArreglo(T[] arreglo);
            T? PrimerElementoOValorPorDefecto(T[] arreglo);
        }

        internal class UtilidadesArreglos<T> : IUtilidadesArreglos<T>
        {
            public int CalcularLongitudDeArreglo(T[] arreglo)
            {
                return arreglo.Length;
            }

            public T? PrimerElementoOValorPorDefecto(T[] arreglo)
            {
                if (arreglo.Length == 0)
                {
                    return default;
                }

                return arreglo[0];
            }
        }

        internal void CodigoDelCurso()
        {

            int[] enteros = { 1, 2, 3 };

            string[] nombres = { "Felipe", "Claudia", "Pedro", "Juana" };

            DateTime[] fechas = { DateTime.Today, DateTime.Today.AddDays(1) };

            Console.WriteLine($"Longitud de arreglo de enteros " +
                $"{CalcularLongitudDeArreglo(enteros)}");

            Console.WriteLine($"Longitud de arreglo de strings " +
                $"{CalcularLongitudDeArreglo(nombres)}");

            Console.WriteLine($"Longitud de arreglo de fechas " +
                $"{CalcularLongitudDeArreglo(fechas)}");


            Console.WriteLine();

            Console.WriteLine($"Primer elemento del arreglo de enteros {PrimerElementoOValorPorDefecto(enteros)}");
            Console.WriteLine($"Primer elemento del arreglo de strings {PrimerElementoOValorPorDefecto(nombres)}");
            Console.WriteLine($"Primer elemento del arreglo de fechas {PrimerElementoOValorPorDefecto(fechas)}");


            int CalcularLongitudDeArreglo<T>(T[] arreglo)
            {
                return arreglo.Length;
            }

            T? PrimerElementoOValorPorDefecto<T>(T[] arreglo)
            {
                if (arreglo.Length == 0)
                {
                    return default;
                }

                return arreglo[0];
            }


            var utilidadesArregloStrings = new UtilidadesArreglos<string>();

        }
    }
}
