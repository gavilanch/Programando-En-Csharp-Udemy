using System;
using System.Collections.Generic;
using System.Text;

namespace GenericosYColecciones.Codigo
{
    internal class ColeccionesComoParametros
    {
        public void CodigoDelCurso()
        {
            Console.WriteLine(Promedio(1, 5, 7, 2));

            double Promedio(params List<int> numeros)
            {
                var suma = 0.0;
                for (int i = 0; i < numeros.Count; i++)
                {
                    suma += numeros[i];
                }

                return suma / numeros.Count;
            }

        }
    }
}
