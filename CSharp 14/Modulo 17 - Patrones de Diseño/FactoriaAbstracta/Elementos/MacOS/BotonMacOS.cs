using FactoriaAbstracta.Elementos.Abstracciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoriaAbstracta.Elementos.MacOS
{
    public class BotonMacOS: IBoton
    {
        public void Presionar()
        {
            Console.WriteLine("[MacOS]: Presionaste el botón");
        }
    }
}
