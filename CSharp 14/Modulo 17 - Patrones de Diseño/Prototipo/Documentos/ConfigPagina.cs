using Prototipo.Utilidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipo.Documentos
{
    public class ConfigPagina: IPrototipo<ConfigPagina>
    {
        public string Tamaño { get; set; } = "A4";
        public double MargenSuperior { get; set; } = 2.5;
        public double MargenInferior { get; set; } = 2.5;
        public double MargenIzquierdo { get; set; } = 2.5;
        public double MargenDerecho { get; set; } = 2.5;

        public ConfigPagina Clonar()
        {
            return new ConfigPagina
            {
                MargenDerecho = MargenDerecho,
                MargenInferior = MargenInferior,
                MargenIzquierdo = MargenIzquierdo,
                MargenSuperior = MargenSuperior,
                Tamaño = Tamaño
            };

        }
    }
}
