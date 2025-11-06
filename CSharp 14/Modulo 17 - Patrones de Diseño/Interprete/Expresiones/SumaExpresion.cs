using System;
using System.Collections.Generic;
using System.Text;

namespace Interprete.Expresiones
{
    // A + B
    public class SumaExpresion(IExpresion izquierda, IExpresion derecha) : IExpresion
    {
        public int Interpretar() => izquierda.Interpretar() + derecha.Interpretar();
    }
}
