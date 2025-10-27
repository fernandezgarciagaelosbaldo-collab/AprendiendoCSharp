namespace Ejercicio_04___MayorDeEdad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pide al usuario su edad (entero) y muestra si es mayor de edad (≥18) o menor de edad.
            Console.Write("Ingresa tu edad :");
            int edad =Convert.ToInt32(Console.ReadLine());
            if (edad >= 18)
            {

                Console.WriteLine("Eres mayor de edad");
            }
            else {

                Console.WriteLine("Es menor de edad");
            }

        }
    }
}
