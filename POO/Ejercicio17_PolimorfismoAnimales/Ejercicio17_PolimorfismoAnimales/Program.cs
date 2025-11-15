namespace Ejercicio17_PolimorfismoAnimales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> Animales = new List<Animal>();
            Animales.Add(new Tigre());
            Animales.Add(new Perro());
            Animales.Add(new Gato());
            foreach(Animal i in Animales)
            {
                i.Sonido();
            }
           
        }
    }
}
