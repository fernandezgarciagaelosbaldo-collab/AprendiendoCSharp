namespace Ejercicio10_ContadorObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario persona1 = new Usuario("Gael",19);
            Usuario persona2 = new Usuario("Alan", 19);
            Usuario persona3 = new Usuario("Alejandro", 19);
            Usuario persona4 = new Usuario("Karol", 19);
            Usuario persona5 = new Usuario("Mayte", 19);
            persona5.mostrarcontador();
            persona3.mostrarcontador();
        }
    }
}
