using FactoriaAbstracta.Elementos.Abstracciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoriaAbstracta.Elementos.Windows
{
    public class BotonWindows: IBoton
    {
        public void Presionar()
        {
            Console.WriteLine("[WINDOWS]: Presionaste el botón");
        }
    }
}
