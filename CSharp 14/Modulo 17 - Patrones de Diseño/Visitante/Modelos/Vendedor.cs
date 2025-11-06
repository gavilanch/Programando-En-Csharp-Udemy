using System;
using System.Collections.Generic;
using System.Text;
using Visitante.Servicios;

namespace Visitante.Modelos
{
    public class Vendedor(string nombre, decimal salarioBase, int años, double puntuacion,
                     decimal ventasTrimestrales, int clientesNuevos) : Empleado(nombre, salarioBase, años, puntuacion)
    {
        public decimal VentasTrimestrales { get; } = ventasTrimestrales;
        public int ClientesNuevos { get; } = clientesNuevos;
        public override void Aceptar(IEmpleadoVisitante visitante) => visitante.Visitar(this);
    }

}
