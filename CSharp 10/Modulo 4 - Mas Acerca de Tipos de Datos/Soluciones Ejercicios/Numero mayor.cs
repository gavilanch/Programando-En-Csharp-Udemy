using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public int DeterminarElNumeroMayor(int[] numeros){
            int resultado;
            
             Tu código debajo de esta línea
            if (numeros.Length == 0){
                resultado = null;
            }
            else{
                resultado = numeros[0];
                foreach (var numero in numeros){
                    if (numero  resultado){
                        resultado = numero;
                    }
                }
            }
            
            return resultado;
        }
    }
}
