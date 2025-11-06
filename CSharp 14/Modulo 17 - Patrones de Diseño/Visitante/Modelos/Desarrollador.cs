using System;
using System.Collections.Generic;
using System.Text;
using Visitante.Servicios;

namespace Visitante.Modelos
{
    public class Desarrollador(string nombre, decimal salarioBase, int años, double puntuacion,
                         int historiasCompletadas, int bugsResueltos) : Empleado(nombre, salarioBase, años, puntuacion)
    {
        public int HistoriasCompletadas { get; } = historiasCompletadas;
        public int BugsResueltos { get; } = bugsResueltos;
        public override void Aceptar(IEmpleadoVisitante visitante) => visitante.Visitar(this);
    }
}
