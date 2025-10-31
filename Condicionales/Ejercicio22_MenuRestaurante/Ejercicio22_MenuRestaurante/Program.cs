namespace Ejercicio22_MenuRestaurante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Menú con opciones (Hamburguesa, Pizza, Ensalada) y mostrar precio total.
            Console.Write("Que quieres comer una Hamburguesa , Pizza o Ensalada :");
            string comida =Console.ReadLine().ToLower();
            double precio = 0;
            switch (comida)
            {
                case "hamburguesa":
                    precio = 132.23;
                    Console.WriteLine("El precio de la Hamburguesa es de "+ precio);
                    break;
                case "pizza":
                    precio = 23;
                    Console.WriteLine("El precio de la pizza esta en "+precio);
                    break;
                case "ensalada":
                    precio = 90;
                    Console.WriteLine("El precio de la ensalada es de "+precio);
                    break;
                    default:
                    Console.WriteLine("Comida no valida");
                    break;

            }

        }
    }
}
