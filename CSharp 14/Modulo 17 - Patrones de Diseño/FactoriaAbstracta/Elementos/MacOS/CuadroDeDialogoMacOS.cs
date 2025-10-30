using FactoriaAbstracta.Elementos.Abstracciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoriaAbstracta.Elementos.MacOS
{
    public class CuadroDeDialogoMacOS: ICuadroDeDialogo
    {
        public void Desplegar()
        {
            Console.WriteLine("[MacOS]: Desplegando el cuadro de diálogo");
        }
    }
}
