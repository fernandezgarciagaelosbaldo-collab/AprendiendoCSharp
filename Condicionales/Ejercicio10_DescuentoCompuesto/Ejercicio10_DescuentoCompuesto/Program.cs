using System;

namespace Ejercicio10_DescuentoCompuesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Si compra > $100 y es cliente frecuente, aplica 20%; si solo una condición se cumple, 10%
            Console.Write("Eres cliente frecuente? , responde con si o no :");
            string cliente=(Console.ReadLine().ToLower());
            Console.Write("Ingrese el monto de la compra :");
            double monto=Convert.ToDouble(Console.ReadLine());
            double Total;
            if (monto > 100 && cliente == "si")
            {
                Total = monto - (monto * 0.2);
                Console.WriteLine("Perfecto tienes un descuento de el 20%, el total de tu compra es de " + Total);
            }
            else if (monto > 100 || cliente == "si")
            {
                Total = monto - (monto * 0.2);
                Console.WriteLine("Perfecto tienes un descuento de %10 , el total de tu compra es de " + Total);

            }
            else {
                Console.WriteLine("No tienes ningun descuento , el total de tu compra sera de "+monto);
            }
        }
    }
}
