namespace Ejercicio11_ToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SobreEscritura persona1 = new SobreEscritura();
            SobreEscritura persona2 = new SobreEscritura("Gael",23);
            SobreEscritura persona3 = new SobreEscritura(persona2);
            persona1.Mostrar();
            persona2.Mostrar();
            persona3.Mostrar();

        }
    }
}
