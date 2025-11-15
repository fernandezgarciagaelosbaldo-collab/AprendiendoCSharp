using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20_MenuPOO
{
    public class Materias
    {
        public string Nombre {  get; set; }
        public int Horas { get; set; }
        public Materias(string nombre,int horas) {
         Nombre = nombre;
            Horas = horas;
        }
        public void mostrar_Inf()
        {
            Console.WriteLine($"La materia {Nombre} les tocara {Horas} a la semana ");
        }
    }
}
