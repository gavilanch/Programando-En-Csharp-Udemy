using Clases.Ejercicios.Ejercicio2;
using System.Reflection;

namespace Pruebas
{
    [TestClass]
    public class PropiedadesPruebas
    {
        [TestMethod]
        public void DevuelveLosValoresCorrectos()
        {
            var clase = new Ejercicio();
            var nombre = "Felipe";
            var apellido = "Gavilán";
            
            var fechaNacimiento = DateTime.Now;

            var persona = clase.ConstruirPersona(nombre, apellido, fechaNacimiento);

            ValidarPropiedad("Nombre", persona, nombre);
            ValidarPropiedad("Apellido", persona, apellido);
            ValidarPropiedad("FechaNacimiento", persona, fechaNacimiento.ToString());
            var nombreCompleto = $"{nombre} {apellido}";
            ValidarPropiedad("NombreCompleto", persona, nombreCompleto);
        }

        private void ValidarPropiedad(string nombrePropiedad, object obj, string valorEsperado)
        {
            var campo = obj.GetType().GetProperty(nombrePropiedad);

            if (campo is null)
            {
                Assert.Fail("Falta la propiedad " + nombrePropiedad);
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