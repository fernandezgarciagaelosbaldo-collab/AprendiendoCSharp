using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14_HerenciaMultinivel
{
    public class Rotwailert:Perro
    {
        public string Nombre {  get; set; }
        public string Comportamiento {  get; set; }
        public Rotwailert(string especie,int edad,string raza,string color,string nombre ,string comportamiento)
            :base(especie,edad,raza,color) {
            Nombre = nombre;
            Comportamiento = comportamiento;
        
        }
        public void mostrar_inf()
        {
            Console.WriteLine($"Holaa {Nombre} eres un {Raza}, eres de color {Color} , tienes{Edad} y eres {Comportamiento}");
        }
    }
}
