
using System.Reflection;
using Variables.Ejercicios;

namespace Pruebas
{
    [TestClass]
    public class IntroduccionADateTimePruebas
    {
        [TestMethod]
        public void ElMétodoDevuelveElDateTimeCorrecto()
        {
            var clase = new IntroduccionADateTime();
            var tipo = clase.GetType();

            var metodo = tipo.GetMember("Ejercicio");

            if (metodo.Length == 0)
            {
                Assert.Fail("Debes implementar el método Ejercicio");
            }

            var respuesta = tipo.InvokeMember("Ejercicio", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.InvokeMethod, 
                null, clase, new object[] { });

            if (respuesta is null)
            {
                Assert.Fail("El método no debe retornar null");
            }

            if (respuesta is not DateTime)
            {
                Assert.Fail("El tipo de dato de retorno debe ser un datetime");
            }

            var respuestaDT = (DateTime)respuesta;
            var esperado = new DateTime(2022, 5, 12, 10, 0, 0);
            Assert.AreEqual(esperado.Month, respuestaDT.Month, "El mes es incorrecto. Debió ser el mes 5");
            Assert.AreEqual(esperado.Day, respuestaDT.Day, "El día es incorrecto. Debió ser el día 12");
            Assert.AreEqual(esperado.Hour, respuestaDT.Hour, "La hora es incorrecta. Debió ser las 10 AM");
        }
    }
}