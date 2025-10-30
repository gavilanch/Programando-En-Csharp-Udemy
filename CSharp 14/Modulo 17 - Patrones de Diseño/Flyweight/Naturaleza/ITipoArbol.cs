using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.Naturaleza
{
    internal interface ITipoArbol
    {
        string ColorBase { get; }
        string Especie { get; }
        string IdTextura { get; }

        void Dibujar(int x, int y, float altura, float rotacionGrados);

    }
}
