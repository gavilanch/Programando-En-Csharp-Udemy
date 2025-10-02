using Funciones.Ejercicios;
using System.Reflection;

namespace Pruebas
{
    [TestClass]
    public class DeclarandoFuncionesPruebas
    {
        [TestMethod]
        public void ObtieneElDiaActual()
        {
            var clase = new DeclarandoFunciones();

            MethodInfo? metodo = clase.GetType().GetMethod("ObtenerDiaActual",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);

            if (metodo is null)
            {
                Assert.Fail("La clase debe contener el método 'ObtenerDiaActual'");
            }

            var respuestaObj = metodo.Invoke(clase, null);

            if (respuestaObj is null)
            {
                Assert.Fail("El método debe devolver un valor");
            }

            var respuestaStr = respuestaObj.ToString()!;
            var respuesta = int.Parse(respuestaStr);
            var esperado = DateTime.Today.Day;
            Assert.IsTrue(respuesta == esperado, "Respuesta esperada: " + esperado + ". Respuesta obtenida: " + respuesta);
        }
    }
}