namespace Clases.Soluciones.Ejercicio3
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public bool EsMayorDeEdad()
        {
            var fechaActual = DateTime.Today;
            var edad = fechaActual.Year - FechaNacimiento.Year;

            var fechaCumplea�osEsteA�o = new DateTime(fechaActual.Year,
                FechaNacimiento.Month, FechaNacimiento.Day);

            var yaCumpli�A�os = fechaCumplea�osEsteA�o <= fechaActual;

            if (!yaCumpli�A�os)
            {
                edad--;
            }

            var esMayorDe18 = edad >= 18;
            return esMayorDe18;
        }
    }
}