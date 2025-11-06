using System;
using System.Collections.Generic;
using System.Text;
using Visitante.Servicios;

namespace Visitante.Modelos
{
    public abstract class Empleado(string nombre, decimal salarioBase, int añosAntiguedad, 
        double puntuacionDesempeño)
    {
        public string Nombre { get; } = nombre;
        public decimal SalarioBase { get; set; } = salarioBase;
        public int AñosAntiguedad { get; } = añosAntiguedad;
        public double PuntuacionDesempeño { get; } = puntuacionDesempeño;
        public abstract void Aceptar(IEmpleadoVisitante visitante);
    }
}
