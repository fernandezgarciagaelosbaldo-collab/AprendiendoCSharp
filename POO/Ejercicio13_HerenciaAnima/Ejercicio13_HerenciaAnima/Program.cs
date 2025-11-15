namespace Ejercicio13_HerenciaAnima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal tigre =new Animal("Felino",19,2.23);
            tigre.mostrar_caracteristicas();
            Perro chihuhua=new Perro("Canino",20,.50,"chihuahua","negro");
            chihuhua.caracteristicas();
        }
    }
}
