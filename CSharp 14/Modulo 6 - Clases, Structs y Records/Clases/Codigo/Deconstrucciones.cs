using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Codigo
{
    internal class Deconstrucciones
    {
        internal class ResultadoDT
        {
            internal int Valor { get; set; }
            public int Duplo { get; set; }
            public int Triplo { get; set; }

            public void Deconstruct(out int valor, out int duplo, out int triplo)
            {
                valor = Valor;
                duplo = Duplo;
                triplo = Triplo;
            }
        }

        internal class Calculadora
        {
            internal ResultadoDT CalcularDuploTriplo(int valor)
            {
                var resultado = new ResultadoDT();
                resultado.Valor = valor;
                resultado.Duplo = valor * 2;
                resultado.Triplo = valor * 3;
                return resultado;
            }
        }

        public void CodigoDelCurso()
        {
            var calculadora = new Calculadora();

            var resultadoDT = calculadora.CalcularDuploTriplo(5);

            // Ejemplo 0: sin deconstructor

            //var valor = resultadoDT.Valor;
            //var duplo = resultadoDT.Duplo;
            //var triplo = resultadoDT.Triplo;

            // Ejemplo 1: Explícita

            //int valor, duplo, triplo;
            //resultadoDT.Deconstruct(out valor, out duplo, out triplo);

            // Ejemplo 2: Forma resumida con Deconstruct

            //resultadoDT.Deconstruct(out var valor, out var duplo, out var triplo);

            // Ejemplo 3: Sin usar Deconstruct direcamente

            //(var valor, var duplo, var triplo) = resultadoDT;

            // Ejemplo 4: Lo más resumido posible

            var (valor, duplo, triplo) = resultadoDT;
            // Podemos descartar una variable si queremos con _
            //var (valor, _, triplo) = resultadoDT;

            Console.WriteLine("El valor es " + valor);
            Console.WriteLine("El duplo es " + duplo);
            Console.WriteLine("El triplo es " + triplo);
        }
    }
}
