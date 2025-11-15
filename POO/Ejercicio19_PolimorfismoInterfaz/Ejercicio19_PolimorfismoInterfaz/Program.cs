namespace Ejercicio19_PolimorfismoInterfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sonido> Sonidos=new List<Sonido>();
            Sonidos.Add(new Comportamiento());
            Sonidos.Add(new Perro());
            Sonidos.Add(new Carro());

            foreach(Sonido i in Sonidos)
            {
                i.sonido();
            }
        }
    }
}
