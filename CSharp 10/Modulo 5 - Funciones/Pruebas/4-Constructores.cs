namespace Clases.Soluciones.Ejercicio4
{
    public class Persona
    {
        public Persona(string nombre, string apellido) : this(nombre, apellido, default)
        {
        }

        public Persona(string nombre, string apellido, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}