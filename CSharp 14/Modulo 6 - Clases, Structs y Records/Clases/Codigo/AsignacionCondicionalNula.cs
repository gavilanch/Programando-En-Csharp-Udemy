using System;
using System.Collections.Generic;
using System.Text;

namespace Clases.Codigo
{
    internal class AsignacionCondicionalNula
    {
        public void CodigoDelCurso()
        {
            Carro? carro = null;

            carro?.Marca = "Honda";

            Console.WriteLine($"La marca del carro es: {carro?.Marca}");
        }
    }
}
