namespace Ejercicio08_CuentaBancariaValidaciones
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            cuentaBancaria cuentaBancaria1=new cuentaBancaria();
            Console.WriteLine("Que quieres hacer 1-Depositar,2-Retirar");
            int elegcion =Convert.ToInt32(Console.ReadLine());
            switch (elegcion){
              case 1:
                    Console.Write("Cuanto quieres depositar ?");
                    double deposito = Convert.ToDouble(Console.ReadLine());
                    if (deposito > 0)
                    {
                        cuentaBancaria1.Depositar(deposito);
                    }
                    else {
                        Console.WriteLine("Tines que depositar una cantidad mayo a 0");
                    }
                        break;
                    case 2:
                     Console.Write("Cuanto quieres Retirar :");
                     double retiro = Convert.ToDouble(Console.ReadLine());
                    if (retiro > cuentaBancaria1.MontoTotal)
                    {
                        Console.WriteLine("No se puede retirar mas de lo que tiene ");
                    }
                    else {
                     cuentaBancaria1.Retirar(retiro);

                    }
                    break;


            }

        }
    }
}
