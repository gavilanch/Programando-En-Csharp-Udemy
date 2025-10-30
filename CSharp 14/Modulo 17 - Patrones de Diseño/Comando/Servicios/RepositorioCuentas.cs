using Comando.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comando.Servicios
{
    public class RepositorioCuentas : IRepositorioCuentas
    {
        private readonly Dictionary<string, Cuenta> _db = new();

        public Cuenta? ObtenerPorTitular(string titular)
        {
            if (string.IsNullOrWhiteSpace(titular)) return null;
            return _db.TryGetValue(titular, out var cuenta) ? cuenta : null;
        }

        public void Guardar(Cuenta cuenta)
        {
            _db[cuenta.Titular] = cuenta;
        }

        public void EscribirEnConsola()
        {
            Console.WriteLine("-- Saldo de las cuentas --");
            foreach (var cuenta in _db.Values)
            {
                Console.WriteLine($"- Cuenta de {cuenta.Titular} tiene saldo de {cuenta.Saldo:c}");
            }
            Console.WriteLine();
        }


    }
}
