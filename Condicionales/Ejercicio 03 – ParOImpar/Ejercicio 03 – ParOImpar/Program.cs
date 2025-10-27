namespace Ejercicio_03___ParOImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solicita un número entero y determina si es par o impar.
            Console.Write("Ingresa un numero entero :");
            int numero = Convert.ToInt32(Console.ReadLine());
            double numeroProcesado = numero % 2;

            if (numeroProcesado == 0)
            {
                Console.WriteLine("El numero " + numero + " es par");
            }
            else
            {
                Console.WriteLine("El numero "+ numero + " es impar");
            }
        }
    }
}
