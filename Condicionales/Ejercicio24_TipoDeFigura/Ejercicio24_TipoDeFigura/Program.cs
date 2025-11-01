namespace Ejercicio24_TipoDeFigura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar una figura (cuadro, triángulo, círculo) y calcular su área según datos.
            Console.Write("Ingresa una figura a la que le quieras calcular el Area , Triangulo,Cuadrado,Circulo :");
            string figura=Console.ReadLine().ToLower();
            double area;
            switch (figura) {
                case "triangulo":
                    Console.WriteLine();
                    Console.Write("Perfecto, ingresa la altura :");
                    double altura=Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingresa la base :");
                    double basee=Convert.ToDouble(Console.ReadLine());
                    area = (basee * altura) / 2;
                    Console.WriteLine("El Area de el triangulo es de "+ area);
                    break;
                case "cuadrado":
                    Console.WriteLine();
                    Console.Write("Ingresa un lado :");
                    double lado =Convert.ToDouble(Console.ReadLine());
                    area = lado * lado;
                    Console.WriteLine("El Area de el cuadrado es de "+ area);
                    break;
                case "circulo":
                    Console.WriteLine("Ingresa el radio de el circulo :");
                    double radio = Convert.ToDouble(Console.ReadLine());
                    area=(radio * radio)*3.1416;
                    Console.WriteLine("El Area de el circulo es de "+area);
                    break;
                default:
                    Console.WriteLine("Figura no identificada");
                    break;

            }
        }
    }
}
