namespace ConsoleApp1
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Persona(string nombre,int edad) {
            Nombre= nombre;
            Edad= edad;
        }

    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
            //Crear una clase Persona con nombre y edad, y mostrar los datos.
            Persona persona1 = new Persona("Gael",19);
            Console.WriteLine($"Holaa {persona1.Nombre} tienes {persona1.Edad} años");

        }
    }
}
