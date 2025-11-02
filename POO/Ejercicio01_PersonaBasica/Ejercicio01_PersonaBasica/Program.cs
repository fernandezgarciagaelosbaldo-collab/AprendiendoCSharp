namespace Ejercicio01_PersonaBasica
{
    public class Persona {
       public string Nombre;
        public int Edad;
    
    }
    internal class Program
       
    {
        static void Main(string[] args)
        {
            //	Crear una clase Persona con nombre y edad, y mostrar los datos.
            Persona persona1 = new Persona();
            persona1.Nombre = "Gael";
            persona1.Edad = 19;
            Console.WriteLine($"Hola soy {persona1.Nombre} y tengo {persona1.Edad} años");

        }
    }
}
