using FactoriaAbstracta.Elementos.Abstracciones;
using FactoriaAbstracta.Elementos.MacOS;
using FactoriaAbstracta.Elementos.Windows;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoriaAbstracta.Elementos
{
    internal static class FactoriaElementos
    {
        public static IFactoriaElementos CrearFactoria(string sistemaOperativo)
        {
            return sistemaOperativo switch
            {
                "windows" => new FactoriaElementosWindows(),
                "macos" => new FactoriaElementosMacOS(),
                _ => throw new NotImplementedException("tipo de sistema operativo no soportado")
            };

        }
    }
}
