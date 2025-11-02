namespace Ejercicio03_Constructor
{
    public class Persona {
        public string Nombre {  get; set; }
        public int Edad { get; set; }
        public Persona(string nombre,int edad) { 
        Nombre = nombre;
            Edad = edad;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //añade un constructor con parámetros para inicializar Nombre y Edad al crear el objeto.
            Persona persona1 =new Persona("Gael",19);
            Persona persona2 = new Persona("Alejandro",20);
            Console.WriteLine($"Hola soy {persona1.Nombre} y tengo {persona1.Edad}");
            Console.WriteLine($"Mi amigo se llama {persona2.Nombre} y tiene {persona2.Edad} años ");
        }
    }
}
