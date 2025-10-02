using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo
{
    internal class Tuplas
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: Una simple tupla

            (int edadFelipe, int edadClaudia, string nombreGato) tupla = (99, 45, "Fluffy");

            Console.WriteLine(tupla);

            Console.WriteLine(tupla.edadFelipe);
            Console.WriteLine(tupla.edadClaudia);
            Console.WriteLine(tupla.nombreGato);

            // Ejemplo 2: Devolviendo varios valores de una función

            (int duplo, int triplo) DuplicarYTriplicar(int valor)
            {
                return (valor * 2, valor * 3);
            }

            var cantidad = 10;
            var resultado = DuplicarYTriplicar(cantidad);

            Console.WriteLine("La cantidad es " + cantidad);
            Console.WriteLine("Su duplo es " + resultado.duplo);
            Console.WriteLine("Su triplo es " + resultado.triplo);


        }
    }
}
