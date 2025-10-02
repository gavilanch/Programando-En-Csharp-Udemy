using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosYColecciones.Codigo
{
    internal class RestriccionesEnGenericos
    {

        internal class Vehículo
        {

        }

        internal class Carro : Vehículo
        {
            public Carro(string marca)
            {
                Marca = marca;
            }

            public string Marca { get; }
        }

        internal class Camión : Vehículo
        {

        }

        public void CodigoDelCurso()
        {
            int[] enteros = { 1, 2, 3 };

            int numero = new int();
            DateTime fecha = new DateTime();
            // Error: string no tiene un constructor sin parámetros
            //string nombre = new string();

            string[] nombres = { "Felipe", "Claudia", "Pedro", "Juana" };

            DateTime[] fechas = { DateTime.Today, DateTime.Today.AddDays(1) };

            //Console.WriteLine($"Longitud de arreglo de enteros {CalcularLongitudDeArreglo(enteros)}");
            //Console.WriteLine($"Longitud de arreglo de strings {CalcularLongitudDeArreglo(nombres)}");
            //Console.WriteLine($"Longitud de arreglo de fechas {CalcularLongitudDeArreglo(fechas)}");

            //Carro[] carros = { new Carro() };
            //Console.WriteLine($"Longitud del arreglo de carros {CalcularLongitudDeArreglo(carros)}");

            // Solamente camión cumple con las dos restricciones del tipo T
            Camión[] camiones = { new Camión() };
            Console.WriteLine($"Longitud del arreglo de carros {CalcularLongitudDeArreglo(camiones)}");


            int CalcularLongitudDeArreglo<T>(T[] arreglo) where T : Vehículo, new()
            {
                return arreglo.Length;
            }
        }
    }
}
