using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class PuntoClase
    {
        public PuntoClase(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; }
        public int Y { get; }

        public static bool operator ==(PuntoClase p1, PuntoClase p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        public static bool operator !=(PuntoClase p1, PuntoClase p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object? obj)
        {
            if (obj is PuntoClase pc2)
            {
                return this == pc2;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return (X, Y).GetHashCode();
        }
    }
}
