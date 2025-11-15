using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20_MenuPOO
{
    
    public class Alumnos
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Calificacion { get; set; }
        public Alumnos(string name, int edad, double calificacion)
        {
            Nombre = name;
            Edad = edad;
            Calificacion = calificacion;
        }
        public void mostrar_inf()
        {
            Console.WriteLine($"{Nombre} tiene {Edad} años y tiene un promedio de {Calificacion}");
        }
    }
}
