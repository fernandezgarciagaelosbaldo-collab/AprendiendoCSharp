using System.ComponentModel.Design;

namespace Ejercicio13_EdadYGener
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedir edad y género y dar un mensaje personalizado (ej. "Eres mayor de edad, Sr.").
            Console.Write("holaa, ingresa tu edad :");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresa tu genero ,masculino o femenino?");
            string genero = Console.ReadLine();
            if (edad >= 60 && genero == "masculino")
            {
                Console.WriteLine("Eres mayor de edad, Sr.");
            }
            else if (genero == "masculino")
            {
                Console.WriteLine("Hola Sr");

            }
            else if (edad >= 60 && genero == "femenino")
            {
                Console.WriteLine("Eres mayor de edad, Sra.");
            }
            else {
                Console.WriteLine( "holaaa , Sra");
            }
        

        }
    }
}
