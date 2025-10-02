using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosYColecciones
{
    internal interface IUtilidadesArreglos<T>
    {
        int CalcularLongitudDeArreglo(T[] arreglo);
        T? PrimerElementoOValorPorDefecto(T[] arreglo);
    }

    internal class UtilidadesArreglos<T>: IUtilidadesArreglos<T>
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
}
