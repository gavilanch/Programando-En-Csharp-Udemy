namespace DecisionesyBucles.Soluciones
{
    public class FizzBuzz
    {
        public static void Realizar(int n)
        {
            // Tu c�digo debajo de esta l�nea
            for (int i = 1; i <= n; i++)
            {
                var mensaje = i.ToString();

                if (i % 3 == 0 && i % 5 == 0)
                {
                    mensaje = "fizzbuzz";
                }
                else if (i % 3 == 0)
                {
                    mensaje = "fizz";
                }
                else if (i % 5 == 0)
                {
                    mensaje = "buzz";
                }

                Console.WriteLine(mensaje);
            }
        }
    }
}