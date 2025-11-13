using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09_PropiedadesCalculadas
{
    //Clase Rectangulo con Base y Altura, y una propiedad calculada Area (solo lectura).
    public class Area
    {
        public double Base {  get; set; } 
        public double Altura { get; set; }
        public Area (double basee,double altura)
        {
            Base = basee;
            Altura = altura;
        }
        public double Areaa
        {
            get { return Base * Altura; }
        }

        public void mostrar()
        {
            Console.WriteLine("El area es de "+ Areaa);
        }
    }
}
