using System;
using System.Collections.Generic;
using System.Text;

namespace Interprete.Expresiones
{
    // A * B
    public class MultiplicacionExpresion(IExpresion izquierda, IExpresion derecha) : IExpresion
    {
        public int Interpretar() => izquierda.Interpretar() * derecha.Interpretar();
    }
}
