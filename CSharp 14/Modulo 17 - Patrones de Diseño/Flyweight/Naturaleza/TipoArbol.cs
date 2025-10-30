using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.Naturaleza
{
    internal class TipoArbol : ITipoArbol
    {
        public string Especie { get; }
        public string IdTextura { get; }
        public string ColorBase { get; }

        public TipoArbol(string especie, string idTextura, string colorBase)
        {
            Especie = especie;
            IdTextura = idTextura;
            ColorBase = colorBase;
        }

        public void Dibujar(int x, int y, float altura, float rotacionGrados)
        {
            Console.WriteLine($"{Especie} Ubicación ({x},{y}), altura:{altura} rot:{rotacionGrados}° (textura:{IdTextura}, color:{ColorBase})");
        }



    }
}
