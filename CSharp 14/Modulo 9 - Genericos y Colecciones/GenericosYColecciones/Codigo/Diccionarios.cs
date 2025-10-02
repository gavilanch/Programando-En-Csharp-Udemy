using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosYColecciones.Codigo
{
    internal class Diccionarios
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: Introducción a los diccionarios

            // El diccionario usa dos genéricos: TKey y TValue
            Dictionary<string, int> diccionario = new Dictionary<string, int>();
            diccionario.Add("Uno", 1); // Solamente agregar
            diccionario["Dos"] = 2; // Agregar y modificar valores

            // Otra manera de inicializar un diccionario
            var diccionario2 = new Dictionary<string, int>()
            {
                {"Uno", 1 },
                {"Dos", 2 },
                {"Tres", 3 }
            };

            // Leyendo un valor por su llave
            Console.WriteLine(diccionario["Dos"]);

            // Verificando la existencia de una llave
            if (diccionario.ContainsKey("Tres"))
            {
                Console.WriteLine(diccionario["Tres"]);
            }
            else
            {
                Console.WriteLine("La llave no fue encontrada");
            }

            // Error: ya existe la llave 'Uno'
            //diccionario.Add("Uno", 10);
            // No hay error aunque exista la llave
            diccionario["Uno"] = 10;

            Console.WriteLine(diccionario["Uno"]);

            // Iteramos las llaves
            Console.WriteLine("Llaves:");
            foreach (var llave in diccionario.Keys)
            {
                Console.WriteLine(llave);
            }

            Console.WriteLine();

            // Iteramos los valores
            Console.WriteLine("Valores:");
            foreach (var valor in diccionario.Values)
            {
                Console.WriteLine(valor);
            }

            // Ejemplo 2: clasificando con un diccionario

            var diccionarioParImpar = new Dictionary<string, List<int>>();
            diccionarioParImpar.Add("par", new List<int>());
            diccionarioParImpar.Add("impar", new List<int>());

            for (int i = 1; i <= 10; i++)
            {
                var llave = i % 2 == 0 ? "par" : "impar";
                diccionarioParImpar[llave].Add(i);
            }

            foreach (var llaveValores in diccionarioParImpar)
            {
                Console.WriteLine(llaveValores.Key);
                foreach (var valor in llaveValores.Value)
                {
                    Console.WriteLine($"- {valor}");
                }
            }

            // Ahora es sencillo obtener los números pares
            var pares = diccionarioParImpar["par"];
        }
    }
}
