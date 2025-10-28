using System.ComponentModel.DataAnnotations;

namespace Ejercicio15_FechaValida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedir día y mes, y validar si la fecha existe(simplificada).
            Console.WriteLine("Te pediere el dia , mes y año , uno por uno , me tienes que escibir ejemplo 22/11/2003");
            Console.WriteLine();
            Console.Write("perfecto , ingresa el dia :");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("perfecto , ingresa el mes :");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el año");
            int anio= Convert.ToInt32(Console.ReadLine());
            if (dia > 0 && dia < 31 && mes > 0 && mes < 13 && anio > 0 && anio < 2027)
            {
                Console.WriteLine("Perfecto la fecha seleccionada fue " + dia + "/" + mes + "/" + anio + "/");
            }
            else {
                Console.WriteLine("Fecha invalida");
            }
        }
    }
}
