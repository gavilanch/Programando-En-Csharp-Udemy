using Clases.Ejercicios.Ejercicio1;
using System.Reflection;

namespace Pruebas
{
    [TestClass]
    public class ClasesYCamposPruebas
    {
        [TestMethod]
        public void DevuelveLosValoresCorrectos()
        {
            var clase = new Ejercicio();
            var nombre = "Felipe";
            var apellido = "Gavilán";
            var fechaNacimiento = DateTime.Now;
            var tipo = clase.GetType();

            var metodo = tipo.GetMember("ConstruirPersona");

            if (metodo.Length == 0)
            {
                Assert.Fail("Debes implementar el método ConstruirPersona");
            }

            var respuesta = tipo.InvokeMember("ConstruirPersona",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.InvokeMethod,
                null, clase, new object[] { nombre, apellido, fechaNacimiento });

            if (respuesta is null)
            {
                Assert.Fail("El método debe retornar un valor");
            }

            ValidarCampo("_nombre", respuesta, nombre);
            ValidarCampo("_apellido", respuesta, apellido);
            ValidarCampo("_fechaNacimiento", respuesta, fechaNacimiento.ToString());
        }

        private void ValidarCampo(string nombreCampo, object obj, string valorEsperado)
        {
            var campo = obj.GetType().GetField(nombreCampo);

            if (campo is null)
            {
                Assert.Fail("Falta el campo " + nombreCampo);
            }

            var valorObj = campo.GetValue(obj);

            if (valorObj is null)
            {
                Assert.Fail("El valor del campo no puede ser nulo");
            }

            var valorObtenido = valorObj.ToString();

            Assert.AreEqual(valorEsperado, valorObtenido);

        }
    }
}