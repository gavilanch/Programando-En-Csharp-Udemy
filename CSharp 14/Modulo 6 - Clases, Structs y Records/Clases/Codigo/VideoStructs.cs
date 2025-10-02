using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Codigo
{
    internal class VideoStructs
    {
        internal class Carro
        {
            internal Carro() : this("marca por defecto")
            {
                Console.WriteLine("Instanciando un carro");
            }

            internal Carro(string marca)
            {
                Console.WriteLine("Instanciando un carro con una marca");
                _marca = marca;
                ConteoInstancias++;
            }

            internal void Acelerar()
            {
                Acelerar(1);
            }

            public static int ConteoInstancias { get; set; }

            // Por convención, los campos empiezan con guión bajo
            private string _marca;

            internal string Marca
            {
                get { return _marca.ToUpper(); }
                set { _marca = value; }
            }

            internal int Año { get; set; } = 1990;

            internal int Velocidad { get; private set; } = 20;
            private int VelocidadMaxima => 120;
            internal string NombreComercial => $"{Marca} ({Año})";



            internal void Acelerar(int incremento)
            {
                if (Velocidad >= VelocidadMaxima)
                {
                    Console.WriteLine("La velocidad máxima ya ha sido alcanzada");
                    return;
                }
                else if (Velocidad + incremento > VelocidadMaxima)
                {
                    incremento = VelocidadMaxima - Velocidad;
                }

                Velocidad += incremento;
            }

            internal void Detener() => Velocidad = 0;
        }

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

        public void CodigoDelCurso()
        {
            var carro = new Carro();

            carro = null;

            var puntoA = new Punto(3, 4);

            // Error
            //puntoA = null;

            // Esto es válido
            var puntoB = new Punto();

            Console.WriteLine($"La distancia entre el Punto A y el Punto B es: {puntoA.Distancia(puntoB)}");
        }
    }
}
