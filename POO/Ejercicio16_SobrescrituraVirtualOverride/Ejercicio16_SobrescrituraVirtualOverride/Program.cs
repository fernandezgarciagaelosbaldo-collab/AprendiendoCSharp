using System.Security.Cryptography.X509Certificates;

namespace Ejercicio16_SobrescrituraVirtualOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ingles persona1 = new Ingles("Gael",19);
            persona1.saludar();
            Console.WriteLine();
            Español persona2 = new Español("Erick",20);
            persona2.saludar();

        }
    }
}
