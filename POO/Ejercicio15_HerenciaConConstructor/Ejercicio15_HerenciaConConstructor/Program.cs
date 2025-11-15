namespace Ejercicio15_HerenciaConConstructor_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta Gael = new Atleta("Gael",19,"Masculino","MMA",5,"Ser campeon");
            Gael.mostrar_persona();
            Console.WriteLine();
            Gael.mostrar_Atleta();

        }
    }
}
