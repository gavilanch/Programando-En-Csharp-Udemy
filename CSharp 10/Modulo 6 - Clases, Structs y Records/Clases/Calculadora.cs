using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases;

internal partial class Calculadora
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

