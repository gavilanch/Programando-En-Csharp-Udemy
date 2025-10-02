using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal struct Punto
    {
        public Punto(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; }
        public int Y { get; }
        public double Distancia(Punto b) => Math.Sqrt(Math.Pow(b.X - X, 2) + Math.Pow(b.Y - Y, 2));
    }
}
