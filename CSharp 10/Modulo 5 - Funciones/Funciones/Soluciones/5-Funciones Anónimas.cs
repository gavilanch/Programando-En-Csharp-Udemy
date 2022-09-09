namespace Funciones.Soluciones
{
    public class FuncionesAnonimas
    {

        public void ImprimirSumaYMultiplicacion(int a, int b, int veces)
        {
            // Tú codigo va debajo de aquí

            Func<int, int, int> sumar = (x, y) => x + y;

            Func<int, int, int> multiplicar = (x, y) => x * y;

            Action<int, int, int> imprimir = (resultadoSuma, resultadoMultiplicacion, n) => {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"{resultadoSuma} - {resultadoMultiplicacion}");
                }
            };

            // Tú codigo va encima de aquí

            int suma = sumar(a, b);
            int multiplicacion = multiplicar(a, b);
            imprimir(suma, multiplicacion, veces);
        }

    }
}