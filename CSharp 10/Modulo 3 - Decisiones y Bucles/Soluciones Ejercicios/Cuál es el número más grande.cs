using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public int DeterminarElNumeroMayor(int a, int b){
            int resultado;
            
            // Tu código debajo de esta línea
            if (a > b)
            {
                resultado = a;
            } else{
                resultado = b;
            }
            
            return resultado;
        }
    }
}
