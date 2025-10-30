using FactoriaAbstracta.Elementos.Abstracciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoriaAbstracta.Elementos.Windows
{
    internal class FactoriaElementosWindows : IFactoriaElementos
    {
        public IBoton CrearBoton() => new BotonWindows();
        public ICuadroDeDialogo CrearCuadroDeDialogo() => new CuadroDeDialogoWindows();
    }
}
