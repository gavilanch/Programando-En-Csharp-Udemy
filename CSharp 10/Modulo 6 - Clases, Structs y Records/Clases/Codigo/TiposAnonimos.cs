using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Codigo
{
    internal class TiposAnonimos
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

        public void CodigoDelCurso()
        {
            // Ejemplo: Introducción a los tipos anónimos

            // Clase normal
            var carro = new Carro() { Marca = "Toyota", Año = 2005 };

            // Tipo anónimo (clase sin nombre)
            var persona = new { Nombre = "Felipe", Apellido = "Gavilán", Edad = 999 };

            Console.WriteLine(persona.Nombre);
            Console.WriteLine(persona);

            // Yo no puedo editar las propiedades de un tipo anónimo
            //persona.Nombre = "Roberto";

            // Ejemplo 2: inferir nombres de propiedades

            var miVariable = "Un valor";

            var carroAnonimo = new { carro.Marca, carro.Año, miVariable };

            Console.WriteLine("Carro anonimo: " + carroAnonimo);

            // Ejemplo 3: mutación no destructiva

            var personaMutada = persona with { Edad = 100, Apellido = "Gonzalez" };

            Console.WriteLine(personaMutada);
        }
    }
}
