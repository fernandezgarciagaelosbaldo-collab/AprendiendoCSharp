namespace Ejercicio06_Control_de_propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crea una cuenta con un saldo inicial.
              Prueba varias operaciones válidas e inválidas (por ejemplo, retirar más de lo que hay o depositar negativo)
              Muestra el resultado con Console.WriteLine.*/
            CuentaBancaria cuenta = new CuentaBancaria();
            Console.WriteLine("Tienes de saldo "+cuenta.Saldo);
            cuenta.Depositar(1000000);
            if(cuenta.Saldo > 100000)
            {
                Console.WriteLine("Felicidades tu saldo total es de "+cuenta.Saldo);
            }
            cuenta.Retirar(12232121);
            cuenta.Retirar(1223);
            cuenta.Depositar(-23);
            Console.WriteLine("Tu nuevo saldo es de "+cuenta.Saldo);
        }
    }
}
