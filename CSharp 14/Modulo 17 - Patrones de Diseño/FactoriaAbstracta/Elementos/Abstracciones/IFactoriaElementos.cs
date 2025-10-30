using System;
using System.Collections.Generic;
using System.Text;

namespace FactoriaAbstracta.Elementos.Abstracciones
{
    internal interface IFactoriaElementos
    {
        IBoton CrearBoton();
        ICuadroDeDialogo CrearCuadroDeDialogo();
    }
}
