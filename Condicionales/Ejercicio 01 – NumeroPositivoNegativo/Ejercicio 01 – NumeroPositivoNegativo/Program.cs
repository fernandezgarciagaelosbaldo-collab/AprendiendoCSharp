using System.Runtime.Intrinsics.X86;

namespace Ejercicio_01___NumeroPositivoNegativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Pide al usuario que ingrese un número (puede ser entero o decimal).
            Luego debes mostrar si ese número es positivo, negativo o cero.*/
            Console.Write("Ingresa un numero :");
            
            double numero=Convert.ToDouble(Console.ReadLine());
            if (numero <= 0)
            {
                Console.WriteLine("Es un numero negativo");
            }
            else
            {
                Console.WriteLine("Es un numero postivo");
            }

        }
    }
}
