using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16_SobrescrituraVirtualOverride
{
    public class Español
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Español(string nombre, int edad) {
            Nombre = nombre;
            Edad = edad;
        }
        public virtual void saludar()
        {
            Console.WriteLine($"Holaaa {Nombre} tines {Edad} años" );
        }
    }
}
