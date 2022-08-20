using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    internal class EsconderAttribute: Attribute
    {
        // Solamente podemos pasar los siguientes tipos de dato como parámetro:
        // Byte, Short, Integer, Long, Single, Double, Char, String, Boolean, System.Type, o una enumeración.

        public EsconderAttribute()
        {

        }

        public EsconderAttribute(int añoInicio, int mesInicio, int díaInicio,
            int añoFin, int mesFin, int díaFin)
        {
            FechaInicio = new DateTime(añoInicio, mesInicio, díaInicio);
            FechaFin = new DateTime(añoFin, mesFin, díaFin);
            usarRangoDeFecha = true;
        }

        public DateTime FechaInicio { get; }
        public DateTime FechaFin { get; }
        private bool usarRangoDeFecha = false;

        public bool Ocultar()
        {
            if (usarRangoDeFecha)
            {
                return DateTime.Now >= FechaInicio && DateTime.Now <= FechaFin;
            }
            else
            {
                return true;
            }
        }
    }
}
