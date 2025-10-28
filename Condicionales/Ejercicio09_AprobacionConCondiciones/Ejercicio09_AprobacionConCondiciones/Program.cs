namespace Ejercicio09_AprobacionConCondiciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aprobado si promedio ≥ 6 y ninguna materia < 5
            Console.WriteLine("Ingresa la calificacion numero uno :");
            double cal1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa la calificacion numero dos :");
            double cal2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa la calificacion numero tres :");
            double cal3 = Convert.ToDouble(Console.ReadLine());
            double promedio = (cal1 + cal2 + cal3) / 3;
            if (promedio >= 6 && cal1 > 5 && cal2 > 5 && cal3 > 5)
            {
                Console.WriteLine("Felicidades , aporbaste con un promedio de " + promedio);
            }
            else {
                Console.WriteLine("Reporbaste :(");
            }
        }


    }
}
