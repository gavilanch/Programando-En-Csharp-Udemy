using Interprete.Expresiones;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interprete.Parseadores
{
    // 1 + 2*3 => [1, +, 2, *, 3]
    // ( 1+2)*3 => [(, 1, +, 2, ), *, 3]
    public class Parseador
    {
        private readonly Queue<string> _simbolos;

        public Parseador(string operacionMatematica)
        {
            _simbolos = new Queue<string>(
                operacionMatematica.Replace("(", " ( ")
                .Replace(")", " ) ")
                .Replace("+", " + ")
                .Replace("*", " * ")
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                );
        }

        public IExpresion Parsear()
        {
            var expresion = ParsearSuma();
            if (_simbolos.Count > 0)
            {
                throw new Exception("Existen símbolos que no pudieron ser evaluados.");
            }
            return expresion;
        }

        private IExpresion ParsearSuma()
        {
            var expresion = ParsearMultiplicacion();

            while (_simbolos.Count > 0 && _simbolos.Peek() == "+")
            {
                _simbolos.Dequeue();
                var derecha = ParsearMultiplicacion();
                expresion = new SumaExpresion(expresion, derecha);
            }

            return expresion;
        }

        private IExpresion ParsearMultiplicacion()
        {
            var expresion = ParsearNumeroOParentesis();
            while (_simbolos.Count > 0 && _simbolos.Peek() == "*")
            {
                _simbolos.Dequeue();
                var derecha = ParsearNumeroOParentesis();
                expresion = new MultiplicacionExpresion(expresion, derecha);
            }

            return expresion;
        }

        private IExpresion ParsearNumeroOParentesis()
        {
            var simbolo = _simbolos.Dequeue();

            if (int.TryParse(simbolo, out var numero))
            {
                return new NumeroExpresion(numero);
            }

            if (simbolo == "(")
            {
                var expresion = ParsearSuma();
                if (_simbolos.Dequeue() != ")")
                {
                    throw new Exception("Falta cierre de paréntesis.");
                }

                return expresion;
            }

            throw new Exception($"Símbolo inesperado: {simbolo}");
        }

    }
}
