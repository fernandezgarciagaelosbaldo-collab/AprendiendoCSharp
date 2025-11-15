using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11_ToString
{
    public class SobreEscritura
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public SobreEscritura() {
            Nombre = "";
            Edad = 0;
        }
        public SobreEscritura(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
        public SobreEscritura(SobreEscritura copia)
        {
            Nombre = copia.Nombre;
            Edad = copia.Edad;
        }
        public void Mostrar() {
            Console.WriteLine($"Holaaa {Nombre} tienes {Edad} años");
        }

    }
}
