using System;
using System.Collections.Generic;
using System.Text;
using Visitante.Servicios;

namespace Visitante.Modelos
{
    public class Gerente(string nombre, decimal salarioBase, int años, double puntuacion,
                   int proyectosLiderados, int personasACargo) : Empleado(nombre, salarioBase, años, puntuacion)
    {

        public int ProyectosLiderados { get; } = proyectosLiderados;
        public int PersonasACargo { get; } = personasACargo;
        public override void Aceptar(IEmpleadoVisitante visitante) => visitante.Visitar(this);
    }

}
