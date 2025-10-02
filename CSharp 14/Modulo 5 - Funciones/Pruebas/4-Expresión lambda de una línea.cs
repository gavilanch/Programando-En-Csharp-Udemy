using Funciones.Ejercicios;
using System.Reflection;

namespace Pruebas
{
    [TestClass]
    public class ExpresiónLambdaDeUnaLíneaPruebas
    {
        [DataRow(1, 2, 2)]
        [DataRow(10, 20, 200)]
        [DataTestMethod]
        public void RetornaElValorCorrecto(int a, int b, int esperado)
        {
            var clase = new ExpresiónLambdaDeUnaLínea();

            MethodInfo? metodo = clase.GetType().GetMethod("Multiplicar",
         BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);

            if (metodo is null)
            {
                Assert.Fail("Falta el método 'Multiplicar'");
            }

            var respuesta = metodo.Invoke(clase, new object[] { a, b })!.ToString()!;

            var respuestaInt = int.Parse(respuesta);

            Assert.IsTrue(respuestaInt == esperado, "Respuesta esperada: " + esperado + ". Respuesta obtenida: " + respuestaInt);
        }
    }
}