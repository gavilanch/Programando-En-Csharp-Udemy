using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.Naturaleza
{
    internal class Arbol(int x, int y, float altura, float rotacionGrados, ITipoArbol tipoArbol)
    {
        public int X { get; } = x;
        public int Y { get; } = y;
        public float Altura { get; } = altura;
        public float RotacionGrados { get; } = rotacionGrados;
        private readonly ITipoArbol _tipoArbol = tipoArbol;
        public void Dibujar() => _tipoArbol.Dibujar(X, Y, Altura, RotacionGrados);

    }
}
