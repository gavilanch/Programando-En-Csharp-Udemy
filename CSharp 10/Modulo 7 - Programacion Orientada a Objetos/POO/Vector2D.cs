using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Vector2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Vector2D operator +(Vector2D v1, Vector2D v2)
        {
            return new Vector2D { X = v1.X + v2.X, Y = v1.Y + v2.Y };
        }

        public Vector2D Sumar(Vector2D v2)
        {
            return this + v2;
        }
    }
}
