using System;
using System.Collections.Generic;
using System.Text;

namespace Comando.Servicios
{
    public class ServicioCuentas : IServicioCuentas
    {
        private readonly IRepositorioCuentas _repo;
        public ServicioCuentas(IRepositorioCuentas repo)
        {
            _repo = repo;
        }

        public void Depositar(string titular, decimal monto)
        {
            if (string.IsNullOrWhiteSpace(titular)) throw new ArgumentException("Cuenta inválida", nameof(titular));
            if (monto <= 0) throw new ArgumentOutOfRangeException(nameof(monto), "El monto debe ser mayor que cero.");

            var cuenta = _repo.ObtenerPorTitular(titular);

            if (cuenta is null)
            {
                throw new InvalidOperationException($"No existe la cuenta '{titular}'.");
            }

            cuenta.Saldo += monto;
            _repo.Guardar(cuenta);
        }

        public void Retirar(string titular, decimal monto)
        {
            if (string.IsNullOrWhiteSpace(titular)) throw new ArgumentException("Cuenta inválida", nameof(titular));
            if (monto <= 0) throw new ArgumentOutOfRangeException(nameof(monto), "El monto debe ser mayor que cero.");

            var cuenta = _repo.ObtenerPorTitular(titular);

            if (cuenta is null)
            {
                throw new InvalidOperationException($"No existe la cuenta '{titular}'.");
            }

            cuenta.Saldo -= monto;
            _repo.Guardar(cuenta);
        }
    }
}
