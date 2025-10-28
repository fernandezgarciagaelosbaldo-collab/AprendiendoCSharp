namespace Ejercicio12_TipoDeTriang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedir lados y decir si es equilátero, isósceles o escaleno.
            Console.WriteLine("Ingresa el primer lado de el triangulo :");
            double lado1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo lado de el triangulo :");
            double lado2=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el tercer lado de el triangulo :");
            double lado3=Convert.ToDouble(Console.ReadLine());
            if (lado1 == lado2 && lado1 == lado3)
            {
                Console.WriteLine("Es un triangulo Equilátero");
            }
            else
            {
                if (lado1 == lado2 && lado1 != lado3)
                {
                    Console.WriteLine("Es un triangulo Isósceles");
                }
                else {
                    if (lado1 != lado2 && lado1 == lado3)
                    {
                        Console.WriteLine("Es un triangulo Isósceles");
                    }
                    else {
                        Console.WriteLine("Es un triangulo Escaleno");
                    }

                
                }
            }
        }
    }
}
