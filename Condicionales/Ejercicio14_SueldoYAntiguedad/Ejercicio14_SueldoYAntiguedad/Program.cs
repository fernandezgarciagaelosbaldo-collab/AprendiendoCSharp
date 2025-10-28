namespace Ejercicio14_SueldoYAntiguedad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Si el sueldo < 5000 y antigüedad > 10 años, aumento 10%; si no, 5%.
            Console.Write("Ingresa el sueldo :");
            double sueldo=Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa cuantos años cumplidos tienes en la emmpresa :");
            int antiguedad =Convert.ToInt32(Console.ReadLine());
            double nuevoSueldo;
            if (sueldo < 5000 && antiguedad > 10)
            {
                nuevoSueldo = (sueldo * .1) + sueldo;
                Console.WriteLine("Felicidades tienes un aumento de el 10% , tu nuevo sueldo es de " + nuevoSueldo);
            }
            else {
                nuevoSueldo = (sueldo * 0.05) + sueldo;
                Console.WriteLine("Felicidades tienes un aumento de el 5% , tu nuevo sueldo es de " + nuevoSueldo);
            }
        }
    }
}
