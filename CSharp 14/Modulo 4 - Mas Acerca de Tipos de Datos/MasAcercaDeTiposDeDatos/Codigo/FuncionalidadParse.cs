using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasAcercaDeTiposDeDatos.Codigo
{
    internal class FuncionalidadParse
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: Enteros
            var cantidadString = "5";

            int cantidad = int.Parse(cantidadString);

            cantidad++;

            Console.WriteLine(cantidad); // 6

            // Ejemplo 2: Decimal

            var cantidadDecimalString = "4.9";

            var cantidadDecimal = decimal.Parse(cantidadDecimalString);

            cantidadDecimal++; // 5.9

            // Ejemplo 3: Booleanos

            var booleanoString = "true";

            var booleano = bool.Parse(booleanoString);

            if (booleano)
            {
                Console.WriteLine("Convertimos de string a booleano");
            }

            // Ejemplo 4: Fechas

            var fechaString = "2022-05-09";

            var fecha = DateTime.Parse(fechaString);

            Console.WriteLine(fecha.AddYears(1)); // 2023-05-09

            // Ejemplo 5: Manejando errores

            var supuestoNumero = "Felipe";
            //var supuestoNumero = "9";

            // Lanza un error
            //var numero = int.Parse(supuestoNumero);

            int numero;

            // No lanza error
            var pudoParsear = int.TryParse(supuestoNumero, out numero);

            if (pudoParsear)
            {
                // lugar seguro donde puedo usar la variable numero
                numero++; // 10
                Console.WriteLine(numero);
            }
            else
            {
                Console.WriteLine($"El valor {supuestoNumero} no tiene el formato correcto.");
            }


        }
    }
}
