using Clases.Ejercicios;
using System.Reflection;

namespace Pruebas
{
    [TestClass]
    public class ClasesEstaticasTests
    {
        private const double Delta = 1e-9;

        [TestMethod]
        public void ExisteLaClaseEstaticaCalculadora()
        {
            var tipo = typeof(CalculadoraEjercicio5);

            bool esEstatica = tipo.IsAbstract && tipo.IsSealed;

            Assert.IsTrue(esEstatica, "La clase CalculadoraEjercicio5 debe ser estática");
        }

        [TestMethod]
        public void Metodos_De_Calculadora_DebenSerEstaticos()
        {
            var tipo = typeof(CalculadoraEjercicio5);
            var metodos = new[] { "Sumar", "Restar", "Multiplicar", "Dividir" };

            foreach (var nombre in metodos)
            {
                var metodo = tipo.GetMethod(nombre, BindingFlags.Public | BindingFlags.Static);
                Assert.IsNotNull(metodo, $"No se encontró método público estático '{nombre}'.");
                Assert.IsTrue(metodo!.IsStatic, $"El método '{nombre}' debe ser estático.");
            }
        }

        [TestMethod]
        [DataRow(10, 5, 15)]
        public void Sumar_RegresaResultadoCorrecto(double x, double y, double esperado)
        {
            ProbarMetodoMatematico("Sumar", x, y, esperado);
        }

        [TestMethod]
        [DataRow(10, 5, 5)]
        public void Restar_RegresaResultadoCorrecto(double x, double y, double esperado)
        {
            ProbarMetodoMatematico("Restar", x, y, esperado);
        }

        [TestMethod]
        [DataRow(10, 5, 50)]
        public void Multiplicar_RegresaResultadoCorrecto(double x, double y, double esperado)
        {
            ProbarMetodoMatematico("Multiplicar", x, y, esperado);
        }

        [TestMethod]
        [DataRow(10, 5, 2)]
        public void Dividir_RegresaResultadoCorrecto(double x, double y, double esperado)
        {
            ProbarMetodoMatematico("Dividir", x, y, esperado);
        }

        [TestMethod]
        public void Dividir_EntreCero_RegresaNaN()
        {
            ProbarMetodoMatematico("Dividir", 1, 0, double.NaN);
        }


        private void ProbarMetodoMatematico(string nombre, double x, double y, double esperado)
        {
            var tipo = typeof(CalculadoraEjercicio5);
            var metodo = tipo.GetMethod(nombre, BindingFlags.Public | BindingFlags.Static);

            Assert.IsNotNull(metodo, $"No se encontró método público estático '{nombre}'.");
            Assert.IsTrue(metodo!.IsStatic, $"El método '{nombre}' debe ser estático.");

            var respuesta = metodo.Invoke(null, new object[] { x, y });

            if (respuesta is not double)
            {
                Assert.Fail("El tipo de dato de retorno debe ser un double");
            }

            var respuestaDouble = (double)respuesta;

            Assert.AreEqual(esperado, respuestaDouble, Delta);
        }


        [TestMethod]
        public void FirmaDeMetodos_DebeSerDoubleDoubleADouble()
        {
            var tipo = typeof(CalculadoraEjercicio5);
            var metodos = new[] { "Sumar", "Restar", "Multiplicar", "Dividir" };

            foreach (var nombreMetodo in metodos)
            {
                var metodo = tipo.GetMethod(nombreMetodo, BindingFlags.Public | BindingFlags.Static);
                Assert.IsNotNull(metodo, $"No se encontró el método '{nombreMetodo}'.");
                var parametros = metodo!.GetParameters();

                Assert.AreEqual(typeof(double), metodo.ReturnType, $"'{nombreMetodo}' debe retornar double.");
                Assert.AreEqual(2, parametros.Length, $"'{nombreMetodo}' debe recibir exactamente 2 parámetros.");
                Assert.IsTrue(parametros.All(p => p.ParameterType == typeof(double)),
                    $"Los parámetros de '{nombreMetodo}' deben ser de tipo double.");
            }
        }
    }
}
