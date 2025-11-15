namespace Ejercicio12_ConstructoresEncadenados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Casa casa1 = new Casa();
            casa1.Mostrar(); 
            Casa casa2 = new Casa("Lucía");
            casa2.Mostrar(); 
            Casa casa3 = new Casa("Pedro", "Azul");
            casa3.Mostrar();
            Casa casa4 = new Casa("Ana", "Verde", 456);
            casa4.Mostrar(); 
            Casa casa5 = new Casa("Carlos", "Blanco", 789, 2500000);
            casa5.Mostrar();
        }
    }
}
