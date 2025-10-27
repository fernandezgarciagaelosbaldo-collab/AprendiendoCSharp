namespace Ejercicio08_PromedioAprobado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedir tres calificaciones, sacar promedio y decir si aprobó (>=6).
            Console.Write("Ingresa la primer calificacion :");
            double cal1=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa la segunda calificacion :");
            double cal2=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa la tercer calificacion :");
            double cal3=Convert.ToDouble(Console.ReadLine());   
            double promedio=(cal1+cal2+cal3)/3;
            if (promedio >= 6)
            {
                Console.WriteLine("Felicidades pasate la materia , con un promedio de " + promedio);
            }
            else {
                Console.WriteLine("No aprobaste :( , tu promedio fue de "+promedio);
            }
        }
    }
}
