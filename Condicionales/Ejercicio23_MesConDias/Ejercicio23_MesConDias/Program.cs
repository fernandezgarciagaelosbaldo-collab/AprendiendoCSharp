namespace Ejercicio23_MesConDias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ingresar el nombre de un mes y mostrar cuántos días tiene.
            Console.Write("Ingresa el nombre del mes para saber cuántos días tiene: ");
            string mes = Console.ReadLine().ToLower();

            switch (mes)
            {
                case "enero":
                    Console.WriteLine("Enero tiene 31 días.");
                    break;
                case "febrero":
                    Console.WriteLine("Febrero tiene 28 días y 29 en años bisiestos.");
                    break;
                case "marzo":
                    Console.WriteLine("Marzo tiene 31 días.");
                    break;
                case "abril":
                    Console.WriteLine("Abril tiene 30 días.");
                    break;
                case "mayo":
                    Console.WriteLine("Mayo tiene 31 días.");
                    break;
                case "junio":
                    Console.WriteLine("Junio tiene 30 días.");
                    break;
                case "julio":
                    Console.WriteLine("Julio tiene 31 días.");
                    break;
                case "agosto":
                    Console.WriteLine("Agosto tiene 31 días.");
                    break;
                case "septiembre":
                    Console.WriteLine("Septiembre tiene 30 días.");
                    break;
                case "octubre":
                    Console.WriteLine("Octubre tiene 31 días.");
                    break;
                case "noviembre":
                    Console.WriteLine("Noviembre tiene 30 días.");
                    break;
                case "diciembre":
                    Console.WriteLine("Diciembre tiene 31 días.");
                    break;
                default:
                    Console.WriteLine("Mes no valido ");
                    break;
            }
        }
    }
}
