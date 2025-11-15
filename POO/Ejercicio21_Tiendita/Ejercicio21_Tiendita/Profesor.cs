using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21_Tiendita
{
    public class Profesor
    {
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public Profesor(string nombre,string especialidad) {
            Nombre = nombre;
            Especialidad = especialidad;
        }
        public void mostrarinf()
        {
            Console.WriteLine($"Profesor: {Nombre} (Especialidad: {Especialidad})");
        }
    }
}
