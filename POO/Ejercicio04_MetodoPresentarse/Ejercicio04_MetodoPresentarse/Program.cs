namespace Ejercicio04_MetodoPresentarse
{
    public class Persona {
        public string Nombre {  get; set; }
        public int Edad {  get; set; }
        public Persona(string nombre, int edad) {
            Nombre= nombre;
            Edad= edad;

        }
        public void presentarse()
        {
            Console.WriteLine($"Hola {Nombre} tienes {Edad} años");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*agrega al Persona un método Presentarse() 
             * que imprime un mensaje usando sus propiedades;
             * crea varias instancias y llama al método.*/
            Persona persona1 = new Persona("Gael",23);
            Persona persona2 = new Persona("Pepe", 34);
            Persona persona3 = new Persona("osbaldo",34);
            persona1.presentarse();
            persona2.presentarse();
            persona3.presentarse();
        }
    }
}
