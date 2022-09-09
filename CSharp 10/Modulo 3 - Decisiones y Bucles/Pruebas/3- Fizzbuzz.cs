using DecisionesyBucles.Ejercicios;
using System.Text;

namespace Pruebas
{
    [TestClass]
    public class FizzBuzzPruebas
    {
        [TestMethod]
        public void ElMétodoDevuelveElValorCorrecto()
        {
            int n = 30;
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);
                FizzBuzz.Realizar(n);
                Console.SetOut(stdout);
                var esperado = Fizzbuzz(n);
                var respuesta = sw.ToString();
                Assert.IsTrue(respuesta == esperado, "Te recomiendo que hagas una app de consola y verifiques el resultado con tus propios ojos. Ya que al ser muchas líneas es difícil de mostrar por aquí.");
            }
        }

        private string Fizzbuzz(int n)
        {
            var sb = new StringBuilder();
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

                sb.AppendLine(mensaje);
            }

            return sb.ToString();
        }
    }
}
