using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Codigo
{
    internal class SobrecargaDeOperadores
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

        public void CodigoDelCurso()
        {
            int cantidad1 = 3;
            int cantidad2 = 4;
            int suma = cantidad1 + cantidad2;

            string nombre = "Felipe";
            string apellido = " Gavilán";
            string nombreCompleto = nombre + apellido;

            var v1 = new Vector2D { X = 1, Y = 2 };
            var v2 = new Vector2D { X = 3, Y = 4 };
            //var v3 = v1 + v2;
            var v3 = v1.Sumar(v2);


            Console.WriteLine($"Coordenadas resultante: ({v3.X}, {v3.Y})");
        }
    }
}
