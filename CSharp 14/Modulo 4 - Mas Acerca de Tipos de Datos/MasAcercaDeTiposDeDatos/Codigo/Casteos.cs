using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasAcercaDeTiposDeDatos.Codigo
{
    internal class Casteos
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: Casteo explícito, de entero a double

            var cantidad1 = 7;
            var cantidad2 = 4;

            var division = (double)cantidad1 / cantidad2;

            Console.WriteLine("La división es " + division);

            // Ejemplo 2: Otro casteo explícito

            byte byte1; // 0 hasta 255
            int int1 = 7; // -2 mil millones hasta 2 mil millones

            checked
            {
                byte1 = (byte)int1;
            }

            Console.WriteLine(byte1);

            // Ejemplo 3: Casteo implícito

            byte byte2 = 11;
            int int2;

            int2 = byte2;

            Console.WriteLine(int2);
        }
    }
}
