using System.Security.Cryptography;

namespace Ejercicio21_SemanaLaboral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar un día y decir si es laboral o fin de semana.
            Console.WriteLine("Ingresa un dia que quieras saber si es laboral o no , ejemplo lunes - dia laboral");
            string dia=Console.ReadLine();
            switch (dia) {
                case "lunes":
                    Console.WriteLine("Dia laboral");
                    break;
                case "martes":
                    Console.WriteLine("Dia laboral");
                    break;
                case "miercoles":
                    Console.WriteLine("Dia laboral");
                    break;
                case "jueves":
                    Console.WriteLine("Dia laboral");
                    break;
                case "viernes":
                    Console.WriteLine("Dia laboral");
                        break;
                case "sabado":
                    Console.WriteLine("Fin de semana");
                    break;
                case "domingo":
                    Console.WriteLine("Fin de semana");
                    break;
                default:
                    Console.WriteLine("dia no valido");
                    break;



            }
        }
    }
}
