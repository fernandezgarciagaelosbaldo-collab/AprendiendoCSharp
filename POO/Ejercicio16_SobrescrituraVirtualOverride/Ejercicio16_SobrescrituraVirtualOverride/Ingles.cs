using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16_SobrescrituraVirtualOverride
{
    public class Ingles:Español
    {
        public Ingles(string nombre,int edad):base(nombre,edad) { 
        
        }
        public override void saludar()
        {
            Console.WriteLine($"Hello , I am {Nombre} and i am {Edad} years old");


        }
    }
}
