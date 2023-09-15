using Clases.Ejercicios.Ejercicio3;
using System.Reflection;

namespace Pruebas
{
    [TestClass]
    public class EsMayorDeEdadPruebas
    {
        [TestMethod]
        public void DiaAntesDelCumple()
        {
            DateTime fechaNacimiento = DateTime.Today.AddYears(-18).AddDays(-1);
            bool respuestaEsperada = true;
            EjecutarPrueba(fechaNacimiento, respuestaEsperada);
        }

        [TestMethod]
        public void DiaADelCumple()
        {
            DateTime fechaNacimiento = DateTime.Today.AddYears(-18);
            bool respuestaEsperada = true;
            EjecutarPrueba(fechaNacimiento, respuestaEsperada);
        }

        [TestMethod]
        public void DiaDspuesDelCumple()
        {
            DateTime fechaNacimiento = DateTime.Today.AddYears(-18).AddDays(1);
            bool respuestaEsperada = false;
            EjecutarPrueba(fechaNacimiento, respuestaEsperada);
        }

        private void EjecutarPrueba(DateTime fechaNacimiento, bool respuestaEsperada)
        {
            var persona = new Persona();
            persona.FechaNacimiento = fechaNacimiento;

            MethodInfo? metodo = persona.GetType().GetMethod("EsMayorDeEdad",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);

            if (metodo is null)
            {
                Assert.Fail("La clase debe contener el método 'EsMayorDeEdad'");
            }

            var respuestaObj = metodo.Invoke(persona, null);

            if (respuestaObj is null)
            {
                Assert.Fail("El método debe devolver un valor");
            }

            var respuestaStr = respuestaObj.ToString()!;
            var esMayor = bool.Parse(respuestaStr);

            var esONoEs = "Sí";

            if (!respuestaEsperada)
            {
                esONoEs = "No";
            }

            Assert.IsTrue(esMayor == respuestaEsperada, "Si la fecha de nacimiento es " + fechaNacimiento.ToString("yyyy-MM-dd") + " la persona " + esONoEs + " mayor de edad");
        }
    }
}
