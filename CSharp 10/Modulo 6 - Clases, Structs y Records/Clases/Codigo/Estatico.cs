using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Codigo
{
    internal class Estatico
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

        internal static class Calculadora
        {
            internal static ResultadoDT CalcularDuploTriplo(int valor)
            {
                var resultado = new ResultadoDT();
                resultado.Valor = valor;
                resultado.Duplo = valor * 2;
                resultado.Triplo = valor * 3;
                return resultado;
            }
        }

        public void CodigoDelCurso()
        {
            var carro1 = new Carro();
            var carro2 = new Carro();
            var carro3 = new Carro();
            var carro4 = new Carro();

            Console.WriteLine();

            Console.WriteLine($"Han sido instanciados {Carro.ConteoInstancias} carros");

            // Error: No podemos acceder al miembro estático desde una instancia
            //var conteo = carro1.ConteoInstancias;

            // Error: No podemos instanciar una clase estática
            //var calculadora = new Calculadora();

            // Sí podemos usar la clase estática de esta manera
            var (valor, duplo, triplo) = Calculadora.CalcularDuploTriplo(10);

            Console.WriteLine("El duplo es: " + duplo);
        }
    }
}
