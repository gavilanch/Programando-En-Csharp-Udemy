using Clases.Ejercicios.Ejercicio4;
using System.Reflection;

namespace Pruebas
{
    [TestClass]
    public class ConstructoresPruebas
    {
        [TestMethod]
        public void Constructor2Params()
        {
            var nombre = "Felipe";
            var apellido = "Gavil�n";

            try
            {
                var personaObj = Activator.CreateInstance(typeof(Persona), new object[] { nombre, apellido });
                var persona = (Persona)personaObj!;

                Assert.AreEqual(nombre, persona.Nombre);
                Assert.AreEqual(apellido, persona.Apellido);
                Assert.AreEqual(default(DateTime), persona.FechaNacimiento);
            }
            catch (MissingMethodException)
            {
                Assert.Fail("No existe un constructor con dos par�metros string");
            }
        }

        [TestMethod]
        public void Constructor3Params()
        {
            var nombre = "Felipe";
            var apellido = "Gavil�n";
            var fechaNacimiento = DateTime.Today;
            try
            {
                var personaObj = Activator.CreateInstance(typeof(Persona), new object[] { nombre, apellido, fechaNacimiento });
                var persona = (Persona)personaObj!;

                Assert.AreEqual(nombre, persona.Nombre);
                Assert.AreEqual(apellido, persona.Apellido);
                Assert.AreEqual(fechaNacimiento, persona.FechaNacimiento);
            }
            catch (MissingMethodException)
            {
                Assert.Fail("No existe un constructor con dos par�metros string y uno DateTime");
            }
        }
    }
}