using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Codigo
{
    internal class IgualdadStructs
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

            public static bool operator ==(Punto p1, Punto p2)
            {
                return p1.X == p2.X && p1.Y == p2.Y;
            }

            public static bool operator !=(Punto p1, Punto p2)
            {
                return !(p1 == p2);
            }

            public override bool Equals(object? obj)
            {
                return base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return (X, Y).GetHashCode();
            }
        }

        public void CodigoDelCurso()
        {
            var puntoA = new Punto(1, 2);
            var puntoB = new Punto(1, 2);

            //var sonLosStructsIguales = puntoA == puntoB;
            var sonLosStructsIguales = puntoA.Equals(puntoB);

            Console.WriteLine("Son iguales: " + sonLosStructsIguales);
        }
    }
}
