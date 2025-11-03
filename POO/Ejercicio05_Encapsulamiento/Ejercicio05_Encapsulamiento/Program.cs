namespace Ejercicio05_Encapsulamiento
{
    public class Persona {
    
        private string nombre;
        public string Nombre { get { return nombre; } 
            set { if (value != "Gael")
                {
                    nombre = "Tiger";
                }
                else {
                    nombre = "Gael";
                }
            } }
        public int Edad {  get; set; }
        private double saldo;
        public double Saldo { get { return saldo; } private set { if (value > 0) { saldo = value; }
                else { 
                 saldo= 0;
                }
            } }
        public Persona(string name,double dinero,int edad) { 
         Nombre = name;
            Saldo = dinero;
            Edad = edad;
        }
        public void info()
        {
            Console.WriteLine($"Hola {Nombre}, tienes {Edad} y tu cuenta de banco tiene {Saldo}");
        }
    }
    internal class Program
       
    {
        static void Main(string[] args)
        {
            //Crear atributo privado salario y controlarlo con una propiedad Salario.
            Persona p1 = new Persona("Gael",1000000,20);
            Persona p2 = new Persona("Alan", 2323, 21);
            Persona p3 = new Persona("Alejandro", 34231, 34);
            p1.info();
            p2.info();
            p3.info();
        }
    }
}
