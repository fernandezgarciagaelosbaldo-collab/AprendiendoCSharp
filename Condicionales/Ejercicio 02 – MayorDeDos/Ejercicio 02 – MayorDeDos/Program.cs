using System.Timers;

namespace Ejercicio_02___MayorDeDos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Pide dos números y muestra cuál de los dos es mayor o si son iguales.
             */
            Console.Write("Ingresa el primer numero: ");
            double num1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Ingresa el segundo numero :");
            double num2=Convert.ToDouble(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("El numero: " + num1 + " es igual a el numero: " + num2);
            }
            else if (num1 > num2)
            {
                Console.WriteLine("El numero: " + num1 + " es mayor que el numero: " + num2);
            }
            else {
                Console.WriteLine("El numero: "+num2+" es mayor que el numero: "+num1);
            }
        }
    }
}
