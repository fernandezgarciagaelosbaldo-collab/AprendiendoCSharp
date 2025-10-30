namespace Ejercicio16_DiaDeLaSemana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedir un número del 1 al 7 y mostrar el día de la semana.
            Console.Write("Ingresa el dia de la semana , ejemplo 1=Lunes: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                    case 2:
                     Console.WriteLine("Martes");
                     break;
                    case 3:
                    Console.WriteLine("Miercoles");
                    break;
                    case 4:
                    Console.WriteLine("Jueves");
                    break;
                    case 5:
                    Console.WriteLine("Viernes");
                    break;
                    case 6:
                    Console.WriteLine("Sabado");
                    break;
                    case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Numero no valido");
                    break;

            }
        }

    }
}
