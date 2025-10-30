namespace Ejercicio18_CalculadoraSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedir dos números y una operación(+, -, *, /) y mostrar el resultado.
            Console.Write("Ingresa el primer numero :");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresa el segundo numero :");
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.Write("que operacion quieres hacer con los numeros (+, -, *, /) :");
            string operacion=Console.ReadLine();
            double resultado = 0;
            switch (operacion) {
                case "+":
                    resultado=num1 + num2;
                    Console.WriteLine("El resultado de la suma es de "+resultado);
                    break;
                    case "-":
                    resultado=num1 - num2;
                    Console.WriteLine("El resultado de la resta es de " + resultado);
                    break;
                    case "*":
                    resultado=num1 * num2;
                    Console.WriteLine("El resultado de la multiplicacion es de " + resultado);
                    break;
                    case "/":
                    resultado=num1 / num2;
                    Console.WriteLine("El resultado de la divicion es de " + resultado);
                    break;
                default:
                    Console.WriteLine("Simbolo no valido");
                    break;
            }
        }
    }
}
