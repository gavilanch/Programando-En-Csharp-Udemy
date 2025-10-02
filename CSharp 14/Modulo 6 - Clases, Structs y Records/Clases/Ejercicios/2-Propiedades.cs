namespace Clases.Ejercicios.Ejercicio2
{
    /*
    Debajo tenemos una clase Persona la cual tiene 3 campos p�blicos. Como vimos, no es buena idea exponer 
    la data de nuestras clases usando campos. Esto es lo que debes hacer:

    1) Modifica la clase Persona para que ya no tenga los 3 campos, sino que tenga 3 propiedades p�blicas, 
    llamadas Nombre, Apellido y FechaNacimiento.

    2) Crea una nueva propiedad de solo-lectura, llamada NombreCompleto, la cual debe devolver la 
    concatenaci�n de Nombre y Apellido, separados por un espacio en blanco. Es decir, si Nombre = "Felipe", 
    y Apellido = "Gavil�n", entonces NombreCompleto = "Felipe Gavil�n".

    3) Modifica el m�todo ConstruirPersona de la clase Ejercicio, para que utilice las propiedades que acabas de crear.
     */

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