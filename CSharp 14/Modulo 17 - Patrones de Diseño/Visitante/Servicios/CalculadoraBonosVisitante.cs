using System;
using System.Collections.Generic;
using System.Text;
using Visitante.Modelos;

namespace Visitante.Servicios
{
    public class CalculadoraBonosVisitante : IEmpleadoVisitante
    {
        public Dictionary<string, decimal> Bonos { get; } = new();

        public void Visitar(Gerente gerente)
        {
            var porcentaje = 0.15m
            + 0.02m * gerente.ProyectosLiderados
            + 0.001m * gerente.PersonasACargo;

            var bono = gerente.SalarioBase * porcentaje * (decimal)gerente.PuntuacionDesempeño;
            Bonos[LlaveBono(gerente)] = decimal.Round(bono, 2);
        }

        public void Visitar(Desarrollador dev)
        {
            var porcentaje = 0.10m
                + 0.003m * dev.HistoriasCompletadas
                + 0.001m * dev.BugsResueltos;

            var bono = dev.SalarioBase * porcentaje * (decimal)dev.PuntuacionDesempeño;
            Bonos[LlaveBono(dev)] = decimal.Round(bono, 2);
        }

        public void Visitar(Vendedor vendedor)
        {
            var bono = vendedor.VentasTrimestrales * 0.02m + (100m * vendedor.ClientesNuevos);
            Bonos[LlaveBono(vendedor)] = decimal.Round(bono, 2);
        }

        private static string LlaveBono(Empleado e) => $"{e.GetType().Name}:{e.Nombre}";
    }
}
