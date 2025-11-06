using System;
using System.Collections.Generic;
using System.Text;
using Visitante.Modelos;

namespace Visitante.Servicios
{
    public interface IEmpleadoVisitante
    {
        void Visitar(Gerente gerente);
        void Visitar(Desarrollador desarrollador);
        void Visitar(Vendedor vendedor);
    }
}
