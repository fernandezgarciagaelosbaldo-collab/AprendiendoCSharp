using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15_HerenciaConConstructor_
{
    public class Atleta:Persona
    {
        public string Deporte { get; set; }
        public int FrecuenciaDeEntrenamiento { get; set; }
        public string Meta { get; set; }
        public Atleta(string nombre,int edad,string genero,string deporte,int frecuencia,string meta)
        :base(nombre,edad,genero)
        {
        
            Deporte = deporte;
            FrecuenciaDeEntrenamiento = frecuencia;
            Meta = meta;
        }
        public void mostrar_Atleta() {

            Console.WriteLine($"Hola {Nombre} tienes {Edad} años y eres de el genero {Genero} " +
                $",practicas {Deporte} con una frecuencia de {FrecuenciaDeEntrenamiento}" +
                $" dias a la semana por que tienes la meta de {Meta}");
        }
    }
}
