using FactoriaAbstracta.Elementos.Abstracciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoriaAbstracta.Elementos.MacOS
{
    internal class FactoriaElementosMacOS : IFactoriaElementos
    {
        public IBoton CrearBoton() => new BotonMacOS();
        public ICuadroDeDialogo CrearCuadroDeDialogo() => new CuadroDeDialogoMacOS();
    }
}
