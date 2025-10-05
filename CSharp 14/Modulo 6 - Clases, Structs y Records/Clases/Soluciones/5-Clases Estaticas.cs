using System;
using System.Collections.Generic;
using System.Text;

namespace Clases.Soluciones
{
    public static class CalculadoraEjercicio5
    {
        public static double Sumar(double x, double y)
        {
            return x + y;
        }

        public static double Restar(double x, double y)
        {
            return x - y;
        }

        public static double Multiplicar(double x, double y)
        {
            return x * y;
        }

        public static double Dividir(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("No se puede dividir entre cero.");
                return double.NaN;
            }

            return x / y;
        }
    }
}
