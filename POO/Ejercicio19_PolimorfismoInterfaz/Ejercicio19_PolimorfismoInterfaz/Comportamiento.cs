using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19_PolimorfismoInterfaz
{
    public interface Sonido{
        void sonido();
    }
    public class Comportamiento:Sonido
    {
        public void sonido()
        {
            Console.WriteLine("Holaaaaaa");
        }
    }
    public class Perro : Sonido
    {
        public void sonido()
        {
            Console.WriteLine("Guau guau");
        }
    }
    public class Carro:Sonido
    {
        public void sonido()
        {
            Console.WriteLine("Sonido de arrancon");
        }

    }
}
