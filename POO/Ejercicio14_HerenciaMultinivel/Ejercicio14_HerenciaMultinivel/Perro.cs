using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14_HerenciaMultinivel
{
    public class Perro:Animal
    {
        public string Raza {  get; set; }
        public string Color {  get; set; }
        public Perro(string especie,int edad,string raza , string color):base(especie,edad) { 
            Raza = raza;
            Color = color;
        }
        public void mostrarinf_perro()
        {
            Console.WriteLine($"Eres un {Raza} de color {Color} de {Edad} años");
        }
    }
}
