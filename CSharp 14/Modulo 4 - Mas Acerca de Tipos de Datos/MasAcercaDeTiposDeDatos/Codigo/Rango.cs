using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasAcercaDeTiposDeDatos.Codigo
{
    internal class Rango
    {
        public void CodigoDelCurso()
        {
            var vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };

            Range dosPrimeros = ..2;
            var dosPrimerasVocales = vocales[dosPrimeros]; // 0, 1
            var tresPrimerasVocales = vocales[..3]; // 0, 1, 2

            var dosUltimasVocales = vocales[^2..]; // ^2, ^1
            var dosUltimasVocalesV2 = vocales[3..]; // 3, 4

            var tresEnMedio = vocales[1..4]; // 1,2,3
            Range ignorarPrimeroYUltimo = 1..^1;
            var tresEnMedioV2 = vocales[ignorarPrimeroYUltimo]; // 1,2,3


            foreach (var vocal in tresEnMedioV2)
            {
                Console.WriteLine(vocal);
            }

        }
    }
}
