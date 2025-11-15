using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17_PolimorfismoAnimales
{
    public class Animal
    {
        public virtual void Sonido()
        {
            Console.WriteLine("..");
        }
    }
    public class Tigre : Animal
    {
        public override void Sonido()
        {
            Console.WriteLine("GRRRR");
        }
    }
    public class Perro : Animal {
        public override void Sonido() {
            Console.WriteLine("Guau guau");
        }
    }
    public class Gato : Animal
    {
        public override void Sonido()
        {
            Console.WriteLine("Miau miau ");
        }
    }
}
