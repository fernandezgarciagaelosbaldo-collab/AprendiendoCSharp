namespace Ejercicio18_ClaseAbstracta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Area> Figuras=new List<Area>();
            Figuras.Add(new Tringulo(23,34));
            Figuras.Add(new Reactangulo(23, 34));
            Figuras.Add(new Cuadrado(23));
            foreach (Area area in Figuras) {
                Console.WriteLine(area.CalcularArea());
            }
        }
    }
}
