using System;
using System.Collections.Generic;
using System.Text;

namespace Comando.Comandos
{
    public interface IComando
    {
        void Ejecutar();
        void Deshacer();
    }

}
