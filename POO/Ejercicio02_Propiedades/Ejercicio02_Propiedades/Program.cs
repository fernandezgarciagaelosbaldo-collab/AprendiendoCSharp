namespace Ejercicio02_Propiedades
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implementar propiedades con get y set en la clase Persona.
            Persona persona1 = new Persona();
            persona1.Edad = 19;
            persona1.Nombre = "Gael";
            Console.WriteLine($"Hola soy {persona1.Nombre} y tengo {persona1.Edad} años de edad");

        }
    }
}
