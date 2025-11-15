using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21_Tiendita
{
    public class Curso
    {    
      public string Nombre { get; set; }
        public Profesor Profesor { get; set; }
        public List<Estudiante> Estudiantes { get; set; }
        public Curso(string nombre,Profesor profe,List<Estudiante> estudiantes) {
         
            Nombre = nombre;
            Profesor = profe;
            Estudiantes = estudiantes;

        }
        public void mostrar()
        {
            Console.WriteLine($"Curso: {Nombre}");
        }



    }
}
