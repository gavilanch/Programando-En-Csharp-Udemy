using System;

namespace Coding.Exercise
{
    // Aquí puedes crear la clase (Nota: colócala como public)
    
    public class Persona{
        public string _nombre;
        public string _apellido;
        public DateTime _fechaNacimiento;
    }
    
    
    public class Ejercicio
    {
        public Persona ConstruirPersona (string nombre, string apellido, DateTime fechaNacimiento)
        {
            var persona = new Persona();
            persona._nombre = nombre;
            persona._apellido = apellido;
            persona._fechaNacimiento = fechaNacimiento;
            return persona;
        }
    }
}
