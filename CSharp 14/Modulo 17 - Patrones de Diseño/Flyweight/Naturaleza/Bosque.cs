using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.Naturaleza
{
    internal class Bosque
    {
        private readonly List<Arbol> _arboles = new();
        private readonly FactoriaArboles _factoria;

        public Bosque(FactoriaArboles factoria) => _factoria = factoria;

        public void PlantarArbol(int x, int y, float altura, float rotacionGrados,
                          string especie, string idTextura, string colorBase)
        {
            var tipoArbol = _factoria.ObtenerTipoArbol(especie, idTextura, colorBase);
            _arboles.Add(new Arbol(x, y, altura, rotacionGrados, tipoArbol));
        }

        public void Dibujar()
        {
            foreach (var arbol in _arboles)
            {
                arbol.Dibujar();
            }
        }

        public int Conteo => _arboles.Count;
    }
}
