using System;
using System.Collections.Generic;
using System.Text;
using Visitante.Modelos;

namespace Visitante.Servicios
{
    public class ReporteDesempeñoVisitante : IEmpleadoVisitante
    {
        public List<string> Reportes { get; } = new();

        public void Visitar(Gerente g)
        {
            Reportes.Add(
                $"""
            {Descripcion(g)}
            Proyectos: {g.ProyectosLiderados} | Equipo: {g.PersonasACargo} | Desempeño: {g.PuntuacionDesempeño:p0}
            """);
        }

        public void Visitar(Desarrollador d)
        {
            Reportes.Add(
                $"""
            {Descripcion(d)} 
            Historias: {d.HistoriasCompletadas} | Bugs: {d.BugsResueltos} | Desempeño: {d.PuntuacionDesempeño:p0}
            """);
        }

        public void Visitar(Vendedor v)
        {
            Reportes.Add(
                $"""
            {Descripcion(v)}
            Ventas: {v.VentasTrimestrales:C0} | Nuevos: {v.ClientesNuevos} | Desempeño: {v.PuntuacionDesempeño:p0}
            """);
        }

        private static string Descripcion(Empleado e)
            => $"{e.GetType().Name} {e.Nombre} (Salario: {e.SalarioBase:C0})";

    }
}
