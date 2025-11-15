using System.Security.Cryptography.X509Certificates;

namespace Ejercicio21_Tiendita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Profesor profesor1 = new Profesor("Oscar","C#");
            List<Estudiante> estudiantes = new List<Estudiante>();
            estudiantes.Add(new Estudiante("Gael",19));
            estudiantes.Add(new Estudiante("Alejandro",19));
            estudiantes.Add(new Estudiante("Alan",20));
            Curso curso1 = new Curso("POO",profesor1,estudiantes);
            curso1.mostrar();
            profesor1.mostrarinf();
            Console.WriteLine("Estudiantes:");
            foreach(Estudiante e in estudiantes)
            {
                e.mostrae_inf();
            }
            
        }
    }
}
