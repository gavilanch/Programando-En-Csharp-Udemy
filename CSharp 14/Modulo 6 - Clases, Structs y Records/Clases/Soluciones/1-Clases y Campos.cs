namespace Clases.Soluciones.Ejercicio1
{
    public class Persona
    {
        public string _nombre;
        public string _apellido;
        public DateTime _fechaNacimiento;
    }

    public class Ejercicio
    {
        public Persona ConstruirPersona(string nombre, string apellido, DateTime fechaNacimiento)
        {
            var persona = new Persona();
            persona._nombre = nombre;
            persona._apellido = apellido;
            persona._fechaNacimiento = fechaNacimiento;
            return persona;
        }
    }
}