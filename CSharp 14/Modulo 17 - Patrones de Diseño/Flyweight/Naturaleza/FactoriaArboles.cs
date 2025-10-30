using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.Naturaleza
{
    internal class FactoriaArboles
    {
        private readonly Dictionary<LlaveTipoArbol, ITipoArbol> _cache = new();

        public ITipoArbol ObtenerTipoArbol(string especie, string idTextura, string colorBase)
        {
            var llave = new LlaveTipoArbol(especie, idTextura, colorBase);

            if (_cache.TryGetValue(llave, out var arbolDeCache))
                return arbolDeCache;

            var nuevoArbol = new TipoArbol(especie, idTextura, colorBase);
            _cache[llave] = nuevoArbol;
            return nuevoArbol;
        }

        public int Conteo => _cache.Count;
    }
}
