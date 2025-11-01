namespace Ejercicio25_MenuGeneral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Combinar varios de los ejercicios anteriores (calculadora, días, figuras) en un menú principal.
            Console.Write("Quieres acceder al mostrador de dias , a la calculadora o a las figuras? ");
            string menu=Console.ReadLine().ToLower();
            switch(menu){
                case "dias":
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
                    break;
                case "calculadora":
                    Console.Write("Ingresa el primer numero :");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingresa el segundo numero :");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("que operacion quieres hacer con los numeros (+, -, *, /) :");
                    string operacion = Console.ReadLine();
                    double resultado = 0;
                    switch (operacion)
                    {
                        case "+":
                            resultado = num1 + num2;
                            Console.WriteLine("El resultado de la suma es de " + resultado);
                            break;
                        case "-":
                            resultado = num1 - num2;
                            Console.WriteLine("El resultado de la resta es de " + resultado);
                            break;
                        case "*":
                            resultado = num1 * num2;
                            Console.WriteLine("El resultado de la multiplicacion es de " + resultado);
                            break;
                        case "/":
                            resultado = num1 / num2;
                            Console.WriteLine("El resultado de la divicion es de " + resultado);
                            break;
                        default:
                            Console.WriteLine("Simbolo no valido");
                            break;
                    }
                    break;
                case "figuras":
                    Console.Write("Ingresa una figura a la que le quieras calcular el Area , Triangulo,Cuadrado,Circulo :");
                    string figura = Console.ReadLine().ToLower();
                    double area;
                    switch (figura)
                    {
                        case "triangulo":
                            Console.WriteLine();
                            Console.Write("Perfecto, ingresa la altura :");
                            double altura = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingresa la base :");
                            double basee = Convert.ToDouble(Console.ReadLine());
                            area = (basee * altura) / 2;
                            Console.WriteLine("El Area de el triangulo es de " + area);
                            break;
                        case "cuadrado":
                            Console.WriteLine();
                            Console.Write("Ingresa un lado :");
                            double lado = Convert.ToDouble(Console.ReadLine());
                            area = lado * lado;
                            Console.WriteLine("El Area de el cuadrado es de " + area);
                            break;
                        case "circulo":
                            Console.WriteLine("Ingresa el radio de el circulo :");
                            double radio = Convert.ToDouble(Console.ReadLine());
                            area = (radio * radio) * 3.1416;
                            Console.WriteLine("El Area de el circulo es de " + area);
                            break;
                        default:
                            Console.WriteLine("Figura no identificada");
                            break;

                    }
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break ;
            }
        }
    }
}
