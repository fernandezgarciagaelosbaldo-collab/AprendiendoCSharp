namespace Ejercicio11_MenuOpciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mostrar un menú con 3 opciones (sumar, restar, salir) y actuar según elección.
            Console.WriteLine("Ingresa el primer numero :");
            double  num1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero :");
            double num2=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Que quieres hacer con esos numeros ,1-sumar,2-restar,3-salir");
            int eleccion = Convert.ToInt32(Console.ReadLine());
            double suma, resta;
            switch (eleccion)
            {
                case 1:
                    suma = num1 + num2;
                    Console.WriteLine("Okey la suma de el numero " + num1 +" y el numero "+num2+" es de "+ suma);
                    break;
                case 2:
                    resta = num1 - num2;
                    Console.WriteLine("okey elegiste resta , la resta es " + resta);
                    break;
                case 3:
                    Console.WriteLine("Okey byee");
                    break;
                default:
                    Console.WriteLine("opcion no valida");
                    break;

            }
        }
    }
}
