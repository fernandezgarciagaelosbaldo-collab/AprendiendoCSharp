namespace Ejercicio20_CalificacionLetra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedir una nota (0–100) y mostrar su equivalente (A, B, C, D, F).
            Console.WriteLine("Ingresa tu calificacion de el o al 100 ");
            int calificacion = Convert.ToInt32(Console.ReadLine());
            string letra="";
            if (calificacion >= 90 && calificacion <= 100)
            {
                letra = "A";
            }
            else if (calificacion >= 80)
            {
                letra = "B";
            }
            else if (calificacion >= 70)
            {
                letra = "C";
            }
            else if (calificacion >= 60)
            {
                letra = "D";
            }
            else if (calificacion >= 0)
            {
                letra = "F";

            }
            else {
                Console.WriteLine("Calificacion no valida");
            }

            switch (letra)
            {
                case "A":
                    Console.WriteLine("Felicidades eres un genio");
                    break;
                    case "B":
                    Console.WriteLine("Felicidades tu calificacion es buena");
                    break;
                    case "C":
                    Console.WriteLine("Tu calificacion no es mala pero necesitas mejorar");
                    break;
                    case "D":
                    Console.WriteLine("Necesitas mejorar tu calificacion , estuviste cerca de reprobar");
                    break;
                    case "F":
                    Console.WriteLine("Reprobaste");
                        break;
                default:
                    Console.WriteLine("No tuvo calificacion");
                    break;

            }
        }
    }
}
