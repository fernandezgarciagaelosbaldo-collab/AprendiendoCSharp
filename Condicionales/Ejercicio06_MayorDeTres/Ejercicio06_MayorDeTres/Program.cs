namespace Ejercicio06_MayorDeTres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedir tres números y mostrar cuál es el mayor.
            Console.WriteLine("Ingresa el primer numero :");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero :");
            int numero2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el tercer numero :");
            int numero3= Convert.ToInt32(Console.ReadLine());
            if (numero1 > numero2 && numero1 > numero3)
            {
                Console.WriteLine("El numero mayor es el " + numero1);
            }
            else if (numero2 > numero1 && numero2 > numero3)
            {
                Console.WriteLine("El numero mayor es " + numero2);
            }
            else {
                Console.WriteLine("El numero mayor es "+numero3);
            }
        }
    }
}
