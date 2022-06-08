using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Codigo
{
    internal class IgualdadClases
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

        public void CodigoDelCurso()
        {
            var puntoA = new PuntoClase(1, 2);
            var puntoB = new PuntoClase(1, 3);

            var sonLosStructsIguales = puntoA == puntoB;
            var sonLosStructsIgualesv2 = puntoA.Equals(puntoB);

            Console.WriteLine("Son iguales con ==: " + sonLosStructsIguales);

            Console.WriteLine("Son iguales con equals: " + sonLosStructsIgualesv2);
        }
    }
}
