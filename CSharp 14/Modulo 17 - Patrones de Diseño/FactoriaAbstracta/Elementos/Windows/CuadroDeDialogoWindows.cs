using FactoriaAbstracta.Elementos.Abstracciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoriaAbstracta.Elementos.Windows
{
    public class CuadroDeDialogoWindows: ICuadroDeDialogo
    {
        public void Desplegar()
        {
            Console.WriteLine("[WINDOWS]: Desplegando el cuadro de diálogo");
        }
    }
}
