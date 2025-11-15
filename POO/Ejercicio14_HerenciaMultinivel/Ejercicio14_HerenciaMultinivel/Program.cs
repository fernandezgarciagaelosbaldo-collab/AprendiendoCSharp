namespace Ejercicio14_HerenciaMultinivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1= new Animal("Canino",2);
            animal1.mostrarinf_animal();
            Perro perro1=new Perro("Canino", 2, "Rotwailer","Negro");
            perro1.mostrarinf_perro();
            Rotwailert rot = new Rotwailert("Canino", 2, "Rotwailer", "Negro","Max","Loco");
            rot.mostrar_inf();

        }
    }
}
