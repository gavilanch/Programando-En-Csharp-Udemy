namespace DecisionesyBucles.Ejercicios
{
    /*
    Borra el c�digo del if-else y sustit�yelo por uno que use el operador ternario.

    Tu soluci�n debe quedar por debajo del comentario y por encima del return.
     */

    public class NumeroMayorParte2
    {
        public int DeterminarElNumeroMayor(int a, int b)
        {
            int resultado;

            // Tu c�digo debajo de esta l�nea
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