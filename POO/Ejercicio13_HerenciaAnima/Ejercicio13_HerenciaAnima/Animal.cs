using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13_HerenciaAnima
{
    public class Animal
    {
        public string Especie { get; set; }
        public int Edad { get; set; }
        public double Altura { get; set; }

        public Animal(string especie, int edad, double altura) {
            Especie = especie;
            Edad = edad;
            Altura = altura;
        }
        public void mostrar_caracteristicas()
        {
            Console.WriteLine($"Eres un {Especie}, tienes {Edad} años y tienes una altura de {Altura} metros");
        }

    }
    
}
