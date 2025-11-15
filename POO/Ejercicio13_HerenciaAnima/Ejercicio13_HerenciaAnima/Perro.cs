using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13_HerenciaAnima
{
    public class Perro : Animal
    {
        public string Raza { get; set; }
        public string Color { get; set; }
        public string Sonido = "GUAAF";
        public Perro(string especie, int edad, double altura, string raza, string color) : base(especie, edad, altura)
        {
            Raza = raza;
            Color = color;

        }
        public void caracteristicas()
        {
            Console.WriteLine($"Holaaaa , eres perrito, tienes {Edad} años y mides {Altura} metros, eres de raza {Raza} y de color {Color}");
            Console.WriteLine(Sonido);
        }
    }
}
