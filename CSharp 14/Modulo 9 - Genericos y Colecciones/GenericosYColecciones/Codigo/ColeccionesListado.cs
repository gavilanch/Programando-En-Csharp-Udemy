using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosYColecciones.Codigo
{
    internal class ColeccionesListado
    {
        internal void CodigoDelCurso()
        {
            int[] enteros = { 1, 2, 3 };

            // No es tan sencillo agregar elementos nuevos a un arreglo
            //enteros.Add(4);

            List<int> enterosLista = new List<int>();
            // Al listado sí es sencillo agregarle nuevos elementos
            enterosLista.Add(1);
            enterosLista.Add(5);
            enterosLista.Add(15);

            // Otra manera de inicializar un listado
            List<int> enterosLista2 = new() { 45, 1, -2, 100, -50 };

            enterosLista2.Add(-8);

            // Error: solamente podemos agregar enteros
            //enterosLista2.Add("Felipe");

            // Cantidad de elementos de la lista
            var cantidad = enterosLista2.Count;

            // Puedo modificar un elemento por su indice
            //enterosLista2[1] = 75;

            // Puedo remover un elemento por su valor
            //enterosLista2.Remove(15);

            // Puedo remover un elemento por su posición
            //enterosLista2.RemoveAt(0);

            // Puedo ordenar los elementos
            enterosLista2.Sort();

            // Puedo iterar los elementos
            foreach (var elemento in enterosLista2)
            {
                Console.WriteLine(elemento);
            }

            // Puedo borrar todos los elementos de la lista
            enterosLista2.Clear();
        }
    }
}
