using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14_HerenciaMultinivel
{
    public class Animal
    {
        public string Especie { get; set; }
        public int Edad { get; set; }
        public Animal(string especie,int edad) {
            Especie = especie;
            Edad = edad;
        
        }
        public void mostrarinf_animal()
        {
            Console.WriteLine($"Especie {Especie}, Edad{Edad} años");
        }

    }
}
