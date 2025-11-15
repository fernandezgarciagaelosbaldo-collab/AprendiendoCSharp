using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21_Tiendita
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Estudiante(string nombre,int edad) {
         Nombre = nombre;
            Edad = edad;
        }
        public void mostrae_inf()
        {
            Console.WriteLine($"- {Nombre} ({Edad} años)\r\n");
        }
    }
}
