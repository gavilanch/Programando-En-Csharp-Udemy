using System;
using System.Collections.Generic;
using System.Text;

namespace Interprete.Expresiones
{
    public class NumeroExpresion(int valor) : IExpresion
    {
        public int Interpretar() => valor;
    }
}
