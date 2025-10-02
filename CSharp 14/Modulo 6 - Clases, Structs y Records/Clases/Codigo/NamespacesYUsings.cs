using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Codigo
{
    namespace Clases.Codigo.Matematicas
    {
        internal class Calculadora
        {
            public double CalcularPi()
            {
                return Math.PI;
            }
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


    internal class NamespacesYUsings
    {
        public void CodigoDelCurso()
        {
            var calculadora = new Calculadora();

            var calculadora2 = new Clases.Codigo.Matematicas.Calculadora();
        }
    }
}
