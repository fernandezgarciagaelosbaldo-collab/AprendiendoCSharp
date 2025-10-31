namespace Ejercicio19_MenuOpciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un menú (1. Sumar, 2. Restar, 3. Salir). Según opción, ejecutar acción
            Console.Write("Ingresa el primer numero :");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresa el segundo numero :");
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresa que quieres hacer 1-suma,2-Restar,3-Salir :");
            int decicion=Convert.ToInt32(Console.ReadLine());
            int suma = 0, resta = 0;
            switch(decicion){
                case 1:
                    suma = num1 + num2;
                    Console.WriteLine("La suma total es de "+suma);
                    break;
                    case 2:
                    resta = num2;
                    Console.WriteLine("La resta es de "+resta);
                    break;
                    case 3:
                    Console.WriteLine("Byeeee ");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
                    
            }
           
        }
    }
}
