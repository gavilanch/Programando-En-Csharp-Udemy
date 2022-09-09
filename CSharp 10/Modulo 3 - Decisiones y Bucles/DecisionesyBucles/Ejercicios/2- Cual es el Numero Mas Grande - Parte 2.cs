namespace DecisionesyBucles.Ejercicios
{
    /*
    Borra el código del if-else y sustitúyelo por uno que use el operador ternario.

    Tu solución debe quedar por debajo del comentario y por encima del return.
     */

    public class NumeroMayorParte2
    {
        public int DeterminarElNumeroMayor(int a, int b)
        {
            int resultado;

            // Tu código debajo de esta línea
            if (a > b)
            {
                resultado = a;
            }
            else
            {
                resultado = b;
            }

            return resultado;
        }
    }
}