using System;

namespace Variables.Soluciones
{
    public class NumeroMayor
    {
        public int? DeterminarElNumeroMayor(int[] numeros)
        {
            int? resultado = 0;

            // Tu código debajo de esta línea
            if (numeros.Length == 0)
            {
                return null;
            }

            resultado = numeros[0];
            foreach (var numero in numeros)
            {
                if (numero > resultado)
                {
                    resultado = numero;
                }
            }

            return resultado;
        }
    }
}
